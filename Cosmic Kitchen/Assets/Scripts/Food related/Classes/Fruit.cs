using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    public class Fruit : Food
    {
        public Fruit(string name, bool meal, int spriteIndex) : base(name, meal, spriteIndex)
        {
            this.name = name;
            this.meal = meal;
            this.spriteIndex = spriteIndex;
        }
    }
}
