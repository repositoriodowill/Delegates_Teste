using System;
using DelegatesTeste.Classes;

namespace DelegatesTeste.Items
{
    public sealed class Sword : Item
    {
        public Sword(string name, string description, double price) : base(name, description, price)
        {
            AddCallback(new Action(UsarEspada));
            AddCallback(new Action(TesteMaroto));
            AddCallback(new Action(Abc));
        }
        private void UsarEspada()
        {
            Console.WriteLine("Usar Espada");
        }

        private void TesteMaroto()
        {
            Console.WriteLine("TesteMaroto");
        }

        private void Abc()
        {
            Console.WriteLine("Abc");
        }




    }


}