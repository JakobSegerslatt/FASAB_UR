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
        public string Name { get; set; }
        [Required]
        
        public int SSN { get; set; }
        [Required]
        public int Phone { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]

        public int ZipCode { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public string Email { get; set; }

        #endregion

        #region Övriga uppgifter
        [Required]

        public string Month { get; set; }
        [Required]

        public string Region { get; set; }
        [Required]

        public List<Uppdrag> Uppdrag { get; set; }
        [Required]

        public DateTime DateSignedByUser { get; set; }

        public string SignatureUser { get; set; }
        [Required]

        public DateTime DateSignedByAttester { get; set; }
        public string SignatureAttester { get; set; }
        #endregion
    }
}
