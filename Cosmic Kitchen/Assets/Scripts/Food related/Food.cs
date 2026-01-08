using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal class Food
    {
        protected string name;
        protected bool meal;

        public Food(string name, bool meal)
        {
            this.name = name;
            this.meal = meal;
        }
    }
}
