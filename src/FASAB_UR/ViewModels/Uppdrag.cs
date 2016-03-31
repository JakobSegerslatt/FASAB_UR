using System;
using System.ComponentModel.DataAnnotations;

namespace FASAB_UR.ViewModels
{
    public class Uppdrag
    {
        [Required(ErrorMessage = "Du har glömt att ange ett datum.")]
        [Display(Name = "Datum")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Du har glömt att ange uppdragets art.")]
        [Display(Name = "Uppdragsart")]
        public string Uppdragsart { get; set; }

        [Required(ErrorMessage = "Du har glömt att ange hur många timmar du arbetat.")]
        [Display(Name = "Arbetade timmar")]
        public int WorkedHours { get; set; }

        [Required(ErrorMessage = "Du måste ange semesterersättning i procent. Ange 0 om semesterersättning ej är applicerbar")]
        [Display(Name = "Semesterersättning (%)")]
        public int VacationCompPercent { get; set; }

        [Required]
        [Display(Name = "Avresetid")]
        public DateTime StartTime { get; set; }
        [Required]
        [Display(Name = "Ankomsttid")]
        public DateTime EndTime { get; set; }

        [Required]
        [Display(Name = "Researvode")]
        public int TravelFee { get; set; }
        [Required]
        [Display(Name = "Kostavdrag, antal")]
        public int Kostavdrag_antal { get; set; }
        [Required]
        [Display(Name = "Bilersättning skattefri (km)")]
        public float CarCompKMTaxfree { get; set; }
        [Required]
        [Display(Name = "Bilersätting skattepliktig (km)")]
        public float CarCompKMTax { get; set; }
        [Required]
        [Display(Name = "Egna utlägg")]
        public int OwnExpenses { get; set; }
        [Required]
        [Display(Name = "Verksamhetsgren")]
        public string Vgren { get; set; }
        [Required]
        [Display(Name = "Kostnadsställe")]
        public string Kställe { get; set; }
        [Required]
        [Display(Name = "Projekt")]
        public string Project { get; set; }


    }
}