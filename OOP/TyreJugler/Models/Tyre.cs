using System;
using System.Globalization;

namespace TyreJugler
{
    class Tyre
    {
        public Tyre()
        {

        }

        public Tyre(Manufacturer man,bool isWorn,string season,string mat,double maxP)
        {
            Manufacturer = man;
            Season = season;
            Material = mat;
            IsWorn = isWorn;
            MaxPressureBars = maxP;
        }

        public Tyre(string mat, string season, bool isWorn, double maxPressureBars)
        {
            Season = season;
            Material = mat;
            IsWorn = isWorn;
            MaxPressureBars = maxPressureBars;
        }


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

        public DateTime YearOfMake { get; set; } = DateTime.ParseExact("16-2-2021 | 15:23", "d-M-yyyy | H:m", CultureInfo.InvariantCulture);
        public Manufacturer Manufacturer { get; set; }
        public bool IsWorn { get; set; }
        public string Season { get; set; }
        public double MaxPressureBars { get; set; }
    }
}
