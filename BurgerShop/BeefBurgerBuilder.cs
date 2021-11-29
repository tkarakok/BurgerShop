using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop
{
    class BeefBurgerBuilder : IBurgerDirector
    {
        private Burger burger;


        public void AddBread()
        {
            burger.SetBread("Beef Burger Bread");
        }

        public void AddMainElement()
        {
            burger.SetMainElement("Beef");
        }

        public void AddSalad()
        {
            burger.SetSalad("Green Salad");
        }

        public void AddSauce()
        {
            burger.SetSauce("Barbeque");
        }

        public Burger GetBurger()
        {
            Console.WriteLine(burger.bread);
            Console.WriteLine(burger.sauce);
            Console.WriteLine(burger.salad);
            Console.WriteLine(burger.mainElement);
            return burger;
        }

        public void Return()
        {
            burger = new Burger();
        }
    }
}
