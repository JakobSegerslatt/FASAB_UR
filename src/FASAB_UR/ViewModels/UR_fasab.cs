using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FASAB_UR.ViewModels
{
    public class UR_fasab
    { // Basformuläret, framtaget av FASAB
        #region Personuppgifter
        [Required(ErrorMessage = "Du måste skriva in ditt namn")]
        [Display(Name = "Förnamn och efternamn")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ange personnummer i formatet ÅÅÅÅMMDDXXXX")]
        [Display(Name = "Personnummer")]
        [Range(12,12, ErrorMessage = "Ange personnummer i formatet ÅÅÅÅMMDDXXXX")]
        public int SSN { get; set; }
        [Required(ErrorMessage = "Ange mobiltelefonnummer. Om du saknar mobiltelefon kan du ange ett fast nummmer.")]
        [Display(Name = "Mobiltelefon")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Du måste ange din adress")]
        [Display(Name = "Gatuadress")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Du måste ange ditt postnummer")]
        [Display(Name = "Postnummer")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Du måste ange din postort")]
        [Display(Name = "Postort")]
        public string City { get; set; }
        [Required(ErrorMessage = "Du måste ange din e-postadress")]
        [Display(Name = "E-postadress")]
        public string Email { get; set; }

        #endregion

        #region Övriga uppgifter
        [Required]
        //[Display(Name = "Månad")]
        public string Month { get; set; }
        [Required]
        //[Display(Name = "Region")]
        public string Region { get; set; }
        [Required]
        //[Display(Name = "Uppdrag")]
        public List<Uppdrag> Uppdrag { get; set; }
        [Required]
        //[Display(Name = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")]
        public DateTime DateSignedByUser { get; set; }

        public string SignatureUser { get; set; }
        [Required]
        //[Display(Name = "Datum för signatur")]
        public DateTime DateSignedByAttester { get; set; }
        public string SignatureAttester { get; set; }
        #endregion
    }
}
