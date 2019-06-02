using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Korisnik : /*TODO: IdentityUser,*/ IIsDeleted
    {
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public virtual string AvatarId { get; set; }
        public virtual Avatar Avatar { get; set; }

        public string Adresa { get; set; }
        public string GradId { get; set; }
        public virtual Grad Grad { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public bool IsDeleted { get; set; }
    }
}
