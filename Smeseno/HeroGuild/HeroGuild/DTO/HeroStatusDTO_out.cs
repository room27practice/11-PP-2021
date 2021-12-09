using HeroGuild.Models.Enumerations;

namespace HeroGuild.DTO
{
    public class HeroStatusDTO_out
    {
        public HeroStatusDTO_out()
        { }

        public string Name { get; }
        public Fraction Fraction { get; set; }
        public double Health { get; set; }
    }
}
