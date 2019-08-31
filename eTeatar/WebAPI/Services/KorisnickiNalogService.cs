using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Hosting.Internal;
using Repository;
using WebAPI.Errors;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public class KorisnickiNalogService : BaseService<DataTransferObjects.KorisnickiNalog, KorisnickiNalogSearchRequest, Models.KorisnickiNalog>, IKorisnickiNalogService
    {
        private readonly IKorisnickiNalogRepository _nalogRepository;
        readonly IBaseService<KorisnickaUloga, KorisnickaUlogaSearchRequest> _korisnickaUlogaService;
        public KorisnickiNalogService(IMapper mapper, IKorisnickiNalogRepository nalogRepository, IBaseService<KorisnickaUloga, KorisnickaUlogaSearchRequest> korisnickaUlogaService) : base(mapper, nalogRepository)
        {
            _nalogRepository = nalogRepository;
            _korisnickaUlogaService = korisnickaUlogaService;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public override List<KorisnickiNalog> Get(KorisnickiNalogSearchRequest search)
        {
            var list = Repository.Get(search);
            return Mapper.Map<List<KorisnickiNalog>>(list);
        }

        public KorisnickiNalog Update(string id, KorisnickiNalogUpsertRequest request)
        {
            var entity = Repository.GetById(id);
            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            if (!string.IsNullOrEmpty(request.Password))
            {
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            Mapper.Map(request, entity);

            return Mapper.Map<KorisnickiNalog>(Repository.Update(entity));
        }

        public void Delete(string id)
        {
            Repository.Remove(id);
        }

        public Models.KorisnickiNalog Autentificiraj(string username, string pass)
        {
            var user = _nalogRepository.Autentificiraj(username);

            if (user == null) return null;

            return GenerateHash(user.LozinkaSalt, pass) == user.LozinkaHash ? Mapper.Map<Models.KorisnickiNalog>(user) : null;
        }

        public KorisnickiNalog Insert(KorisnickiNalogUpsertRequest request, DataTransferObjects.Enums.KorisnickeUloge uloga)
        {
            var entity = Mapper.Map<Models.KorisnickiNalog>(request);

            if (!_nalogRepository.ValidacijaKorisnickogImena(request.KorisnickoIme))
                throw new UserException("Korisničko ime je zauzeto");

            if (request.Password != request.PasswordPotvrda)
                throw new UserException("Passwordi se ne slažu");

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            entity.KorisnickaUlogaId = _korisnickaUlogaService
                .Get(new KorisnickaUlogaSearchRequest { Naziv = uloga.ToString() })
                .First().Id;

            return Mapper.Map<KorisnickiNalog>(Repository.Add(entity));
        }

        public KorisnickiNalog Insert(KorisnickiNalogUpsertRequest request)
        {
            var entity = Mapper.Map<Models.KorisnickiNalog>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            return Mapper.Map<KorisnickiNalog>(Repository.Add(entity));
        }
    }
}
