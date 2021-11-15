using System.Collections.Generic;

namespace Greshki.Model
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            Offices = new List<string>();
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public List<string> Offices { get; set; }
    }



}