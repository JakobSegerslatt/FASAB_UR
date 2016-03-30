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
        [Required]
        public string Name { get; set; }

        public int SSN { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }
        #endregion
        #region Övriga uppgifter
        public string Month { get; set; }
        public string Region { get; set; }

        public List<Uppdrag> Uppdrag { get; set; }

        public DateTime DateSignedByUser { get; set; }
        public string SignatureUser { get; set; }

        public DateTime DateSignedByAttester { get; set; }
        public string SignatureAttester { get; set; }
        #endregion
    }
}
