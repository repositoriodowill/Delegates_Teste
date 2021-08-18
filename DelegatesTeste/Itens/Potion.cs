using System;
using DelegatesTeste.Classes;

namespace DelegatesTeste.Itens
{
    public class Potion : Item
    {
        public Potion(string name, string description, double price) : base(name, description, price)
        {
            AddCallback(new Action(LifeRecover));
        }

        private void LifeRecover()
        {
            Console.WriteLine("Recuperando a vida...");
        }
    }
}