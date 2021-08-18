using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesTeste.Classes
{
    public class Character
    {
        public Inventory Inventory { get; private set; }
        public string Name { get; set; }
        public double Life { get; set; }

        public Character(string name) : this()
        {
            Name = name;
        }
        private Character()
        {
            Life = 100;
            Inventory = new Inventory(this);
        }
        public void UseItem(Item item)
        {
            try
            {
                Inventory.UseItem(item);
            }
            catch
            {
                
            }
        }

        public string PrintInventory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"----- Inventário do {Inventory.Character.Name}");
            foreach (var item in Inventory.Items)
            {
                sb.AppendLine($"{item.Quantidade}x - {item.ItemUse.Name}");
            }
            sb.AppendLine($"----- FIM DO INVENTÁRIO");
            return sb.ToString();
        }


    }





}