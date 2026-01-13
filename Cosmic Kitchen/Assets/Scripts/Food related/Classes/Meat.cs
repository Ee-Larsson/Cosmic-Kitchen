using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Meat : Food
    {
        string animal;

        public Meat(string name, bool meal, string animal, int spriteIndex) : base(name, meal, spriteIndex)
        {
            this.name = name;
            this.meal = meal;
            this.animal = animal;
            this.spriteIndex = spriteIndex;
        }
    }
}
