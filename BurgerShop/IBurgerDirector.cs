using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop
{
    interface IBurgerDirector
    {
        void Return();
        void AddBread();
        void AddSauce();
        void AddMainElement();
        void AddSalad();
        Burger GetBurger();
    }
}
