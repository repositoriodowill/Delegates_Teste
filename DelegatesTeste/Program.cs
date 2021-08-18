using System;
using DelegatesTeste.Classes;
using DelegatesTeste.Items;
using DelegatesTeste.Itens;

namespace DelegatesTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sword espada = new Sword("espada", "descrição dahora", 15.63d);
            // espada.UseItem();
            Console.WriteLine(">>> Criando Personagem...");
            Character will = new Character("William");

            Console.WriteLine(">>> Criando Item Elixir...");
            Potion elixir = new Potion("Radiance", "Elixir que recupera sua vida", 50d);
            Potion elixir2 = new Potion("Radiance", "Elixir que recupera sua vida", 50d);
            will.Inventory.AddItem(elixir);
            will.Inventory.AddItem(elixir2);

            Sword espada = new Sword("Espada Maluca","Espada bem lhouca e que tem coisa que brilha", 645.29);
            will.Inventory.AddItem(espada);
            Console.WriteLine(will.PrintInventory());


            Console.WriteLine(">>> USANDO Item Elixir...");
            will.UseItem(elixir);
            Console.WriteLine(will.PrintInventory());

            Console.ReadLine();


        }



    }





}
