using HeroGuild.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroGuild.Models.Entities
{
    public class Hero
    {
        private double attackCoef = 15;
        private double defenceCoef = 20;

        public Hero(string name, Fraction fraction)
        {
            Name = name;
            Fraction = fraction;
            ItemSet = new List<Item>();
        }

        public string Name { get; }
        public Fraction Fraction { get; set; }
        public int Level { get; private set; } = 0;
        public double Health { get; private set; } = 100;
        public double Mana { get; private set; } = 100;
        public double Stamina { get; private set; } = 100;
        public List<Item> ItemSet { get; private set; }
        public int LevelUp()
        {
            Health = 100;
            Stamina = 100;
            Mana = 100;
            Level += 1;
            return Level;
        }

        public double GetAttack()
        {
            return Level * attackCoef + ItemSet.Sum(x => x.Attack);
        }

        public double GetDefence()
        {
            return Level * defenceCoef + ItemSet.Sum(x => x.Defence);
        }
    }

}
