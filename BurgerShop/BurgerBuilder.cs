using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShop
{
    class BurgerBuilder
    {
       
        public void MakeBurger(IBurgerDirector burgerDirector)
        {
            burgerDirector.Return();
            burgerDirector.AddBread();
            burgerDirector.AddSauce();
            burgerDirector.AddSalad();
            burgerDirector.AddMainElement();
        }
    }
}
