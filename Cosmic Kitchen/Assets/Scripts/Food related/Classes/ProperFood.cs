using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    public class ProperFood : Food
    {

        public ProperFood(string name, bool meal, int spriteIndex, Food ingridient1, Food ingridient2, Food ingridient3, Food ingridient4) : base(name, meal, spriteIndex)
        {
            this.name = name;
            this.spriteIndex = spriteIndex;
        }

    }
}
