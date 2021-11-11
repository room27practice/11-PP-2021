using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroGuild.Models.Entities
{
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
}