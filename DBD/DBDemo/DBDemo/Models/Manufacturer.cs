using System.Collections.Generic;

namespace DBDemo
{
  public  class Manufacturer
    {        
        public Manufacturer()
        {
            Tyres = new HashSet<Tyre>();
        }

        public Manufacturer( string name, string email):this()
        {
           
            Name = name;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Tyre> Tyres { get; set; }
    }
}
