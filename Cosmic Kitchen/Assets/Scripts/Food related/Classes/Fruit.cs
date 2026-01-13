using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    public class Fruit : Food
    {
        public Fruit(string name, bool meal) : base(name, meal)
        {
            this.name = name;
            this.meal = meal;
        }
    }
}
