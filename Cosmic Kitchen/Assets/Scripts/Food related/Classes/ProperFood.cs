using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    public class ProperFood : Ingridents
    {
        string name;
        int spriteIndex;
        public ProperFood(string name, int spriteIndex, Food ingridient1, Food ingridient2, Food ingridient3, Food ingridient4) : base()
        {
            this.name = name;
            this.spriteIndex = spriteIndex;
        }

        public string GetName()
        {
            return(name);
        }

        public int GetSpriteIndex()
        {
            return (spriteIndex);
        }

    }
}
