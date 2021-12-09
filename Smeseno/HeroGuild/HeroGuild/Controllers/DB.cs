using HeroGuild.Models.Entities;
using System.Collections.Generic;

namespace HeroGuild.Controllers
{
    public static class DB
    {
        public static List<Hero> Heroes { get; set; } = new List<Hero>();
    }
}
