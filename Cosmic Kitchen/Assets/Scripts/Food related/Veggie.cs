using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    internal class Veggie : Food
    {
        public Veggie(string name, bool meal) : base(name, meal)
        {
            this.name = name;
            this.meal = meal;
        }
    }
}
