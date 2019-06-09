using ImageMagick;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebAPI.Helpers
{
    public class ImageUpload
    {
        /// <summary>
        /// Dohvaćanje ekstenzije fajla
        /// </summary>
        /// <param name="avatar">Avatar klijenta unijet preko inputa</param>
        /// <returns></returns>
        public string Ekstenzija(IFormFile avatar)
        {
            return avatar == null || avatar.Length <= 0 ? null : Path.GetExtension(avatar.FileName);
        }

        /// <summary>
        /// Promjena veličine i kompresovanje slike preko NuGet paketa 'Magick.NET-Q16-AnyCPU'
        /// </summary>
        /// <param name="filePath">Putanja do slike</param>
        private static void OptimizacijaSlike(string filePath)
        {
            using (MagickImage image = new MagickImage(filePath))
            {
                image.Resize(500, 0);
                image.Write(filePath);
            }

            FileInfo picture = new FileInfo(filePath);

            ImageOptimizer optimizer = new ImageOptimizer();
            optimizer.Compress(picture);
            picture.Refresh();
        }

        /// <summary>
        /// Pretvaranje u format Base64 avatara kojeg je klijent unio u inputu
        /// </summary>
        /// <param name="avatar">Avatar klijenta unijet preko inputa</param>
        /// <returns></returns>
        public async Task<byte[]> Base64(IFormFile avatar)
        {

            if (avatar == null || avatar.Length <= 0) return null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                await avatar.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }

        }

        /// <summary>
        /// Kreiranje klijentovog avatara i spašavanje u folder slikeKlijenata na serveru 
        /// </summary>
        /// <param name="avatar">Avatar klijenta unijet preko inputa</param>
        /// <param name="stariAvatar">Naziv starog avatara</param>
        /// <param name="folder">Naziv foldera za pohranu slike</param>
        /// <returns>Vraća naziv fajla</returns>
        public async Task<string> PictureToFolder(IFormFile avatar, string stariAvatar, string folder)
        {
            //Ako je nije ništa uplodovano, vratiti stariAvatar, u slučaju da je prvi put kreirana pa nema stari avatar, vratit će se defaultni avatar
            if (avatar == null || avatar.Length <= 0)
            {
                return stariAvatar ?? "default.png";
            }

            //Brisanje postojećeg avatara ako nije defaultni avatar
            if (stariAvatar != null && stariAvatar != "default.png")
            {
                var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img\" + folder, stariAvatar);
                File.Delete(oldFilePath);
            }

            var fileName = $"{Guid.NewGuid()}{Ekstenzija(avatar)}";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img\" + folder, fileName);

            //Kreiranje slike
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                await avatar.CopyToAsync(fileStream);
            }

            //Optimizacija slike
            OptimizacijaSlike(filePath);

            return fileName;
        }

    }
}
