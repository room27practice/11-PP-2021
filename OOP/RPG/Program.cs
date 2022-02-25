using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    class Program
    {
        static void Main()
        {
            Hero h1 = new Hero("Terminatora_04", Fraction.Priest);
         //   Console.WriteLine(h1.ItemSet[2]);

            h1.ItemSet.Add(new Item("sword", 8, 0));
            h1.ItemSet.Add(new Item("cap",0, 6));
            h1.LevelUp();
            double heroAtk=  h1.GetAttack();
            double heroDef=  h1.GetDefence();
            h1.ItemSet.Add(new Item("sword", 8, 0));
            h1.ItemSet.Add(new Item("cap", 0, 6));
            h1.LevelUp();
            double heroAtk2 = h1.GetAttack();
            double heroDef2 = h1.GetDefence();

                   
        }
    }

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
            return Level * attackCoef + ItemSet.Sum(x=>x.Attack);
        }

        public double GetDefence()
        {
            return Level * defenceCoef + ItemSet.Sum(x => x.Defence);
        }
    }

    public class Item
    {
        public Item(string name, double atk, double def)
        {
            if (atk < 0 || atk > 10)
            {
                Console.WriteLine("Invalid Attack item value");
                Attack = 9;
            }
            else
            {
                Attack = atk;
            }

            if (def < 0 || def > 10)
            {
                Console.WriteLine("Invalid Defence item value");
                Defence = 9;
            }
            else
            {
                Defence = def;
            }

            Name = name;
        }

        public string Name { get; }
        public double Attack { get; private set; }
        public double Defence { get; private set; }

        public void UpgradeAttack(double up)
        {
            if (up < 0 || up > 50)
            {
                Console.WriteLine("Invalid Attack improvement value");
            }
            else
            {
                Attack += up;
                //Attack = Attack + up; равнозначно.
            }
        }

        public void UpgradeDefence(double up)
        {
            if (up < 0 || up > 50)
            {
                Console.WriteLine("Invalid Defence improvement value");
            }
            else
            {
                Defence += up;
                //Defence = Defence + up; равнозначно.
            }
        }
    }

    public enum Fraction
    {
        Mage,
        Knight,
        Priest,
        Ranged,
        Rogue
    }
}