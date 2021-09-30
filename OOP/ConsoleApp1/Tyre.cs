using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Tyre
    {
        string material;
        public double Size { get; set; }
        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }

        public DateTime YearOfMake { get; set; } = DateTime.ParseExact("16-2-2021 | 15:23","d-M-yyyy | H:m", CultureInfo.InvariantCulture);
        public Manufacturer Manufacturer { get; set; }
        public bool IsWorn { get; set; }
        public string Season { get; set; }
        public double MaxPressurePSI { get; set; }
    }
}
