using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    internal class ProperFood : Ingridents
    {

        
        
        public ProperFood(Fruit fruit, Veggie veggie, Food meat, Misc misc) : base()
        {
            if(fruit == null)
            {

            }
            
            if (veggie == null)
            {

            }
            if (meat == null)
            {

            }
            if (misc == null)
            {

            }
        }

        public void GetFoodItems()
        {
            Debug.Print("ProperFood");
        }

    }
}
