using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Food
    {
        protected string name;
        protected bool meal;
        protected int spriteIndex;

        public Food(string name, bool meal, int spriteIndex)
        {
            this.name = name;
            this.meal = meal;
            this.spriteIndex = spriteIndex;
        }

        public string GetName()
        {
            return (name);
        }
        public int GetSpriteIndex()
        {
            return (spriteIndex);
        }
    }

