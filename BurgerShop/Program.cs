using System;

namespace BurgerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BeefBurgerBuilder beefBurgerBuilder = new();
            VeggieBurgerBuilder veggieBurgerBuilder = new();
            BurgerBuilder burgerBuilder = new();

            burgerBuilder.MakeBurger(beefBurgerBuilder);
            burgerBuilder.MakeBurger(veggieBurgerBuilder);

            var beefBurger = beefBurgerBuilder.GetBurger();
            var veggieBurger = veggieBurgerBuilder.GetBurger();
            Console.WriteLine(" burger make complated ");
        }
    }
}
