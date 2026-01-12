using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    public class Misc : Food
    {
        bool vegan;
        public Misc(string name, bool meal, bool vegan) : base(name, meal)
        {
            this.name = name;
            this.meal = meal;
            this.vegan = vegan;
        }
    }
}
