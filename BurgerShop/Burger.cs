using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop
{
    class Burger
    {
        public string bread;
        public string sauce;
        public string salad;
        public string mainElement;

        public void SetBread(string bread) 
        {
            this.bread = bread;
        }
        public void SetSauce(string sauce)
        {
            this.sauce = sauce;
        }
        public void SetSalad(string salad)
        {
            this.salad = salad;
        }
        public void SetMainElement(string mainElement)
        {
            this.mainElement = mainElement;
        }
    }
}
