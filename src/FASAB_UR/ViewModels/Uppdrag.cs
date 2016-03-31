using System;
using System.ComponentModel.DataAnnotations;

namespace FASAB_UR.ViewModels
{
    public class Uppdrag
    {
        [Required(ErrorMessage = "Du har glömt att ange ett datum.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Du har glömt att ange uppdragets art.")]
        public string Uppdragsart { get; set; }

        [Required(ErrorMessage = "Du har glömt att ange hur många timmar du arbetat.")]
        public int WorkedHours { get; set; }

        [Required]        
        public int VacationCompPercent { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
        [Required]

        public DateTime EndTime { get; set; }
        [Required]

        public int TravelFee { get; set; }
        [Required]

        public int Kostavdrag_antal { get; set; }
        [Required]

        public float CarCompKMTaxfree { get; set; }
        [Required]

        public float CarCompKMTax { get; set; }
        [Required]

        public int OwnExpenses { get; set; }
        [Required]

        public string Vgren { get; set; }
        [Required]

        public string Kställe { get; set; }
        [Required]

        public string Project { get; set; }


    }
}