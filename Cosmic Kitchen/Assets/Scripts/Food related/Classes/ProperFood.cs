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
        public ProperFood(string name, Food ingridient1, Food ingridient2, Food ingridient3, Food ingridient4) : base()
        {
            this.name = name;
        }

        public string GetName()
        {
            return(name);
        }

    }
}
