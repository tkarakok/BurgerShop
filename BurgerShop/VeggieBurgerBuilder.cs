using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop
{
    class VeggieBurgerBuilder : IBurgerDirector
    {
        private Burger burger;

        public void AddBread()
        {
            burger.SetBread(" Veggie Burger Bread");
        }

        public void AddMainElement()
        {
            burger.SetMainElement(" Veggie Beef"); 
        }

        public void AddSalad()
        {
            burger.SetSalad(" Corn Salad");
        }

        public void AddSauce()
        {
            burger.SetSauce(" Just Ketchup");
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
