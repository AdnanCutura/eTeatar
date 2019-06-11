using System;
using System.ComponentModel.DataAnnotations;

namespace DataTransferObjects.Requests
{
    public class TeatarUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string Naziv { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string Adresa { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string BrojTelefona { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime VrijemeOtvaranja { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime VrijemeZatvaranja { get; set; }

        [Required]
        public string GradId { get; set; }
    }
}
