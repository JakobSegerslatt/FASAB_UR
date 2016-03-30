using System;

namespace FASAB_UR.ViewModels
{
    public class Uppdrag
    {
        public DateTime Date { get; set; }

        public string Uppdragsart { get; set; }

        public int WorkedHours { get; set; }

        public int VacationCompPercent { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int TravelFee { get; set; }

        public int Kostavdrag_antal { get; set; }

        public float CarCompKMTaxfree { get; set; }

        public float CarCompKMTax { get; set; }

        public int OwnExpenses { get; set; }

        public string Vgren { get; set; }

        public string Kställe { get; set; }

        public string Project { get; set; }


    }
}