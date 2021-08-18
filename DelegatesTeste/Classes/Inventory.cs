using System.Linq;
using System.Collections.Generic;
using DelegatesTeste.Classes;

namespace DelegatesTeste.Classes
{

    public class Inventory
    {
        List<InventoryItem> _itens = new List<InventoryItem>();
        private Character _char;
        public Character Character => _char;
        public Inventory(Character character)
        {
            _char = character;
        }
        public List<InventoryItem> Items => _itens;
        public void AddItem(Item item)
        {
            var it = _itens.FirstOrDefault(x => x.ItemUse.Name.ToLower().Contains(item.Name.ToLower()));
            if (it == null)
            {
                _itens.Add(new InventoryItem()
                {
                    Quantidade = 1,
                    ItemUse = item
                });
            }
            else
            {
                it.Quantidade++;
            }
        }

        public Item this[string name]
        {
            get
            {
                return _itens.FirstOrDefault(x => x.ItemUse.Name.ToLower().Contains(name.ToLower())).ItemUse;
            }
        }

        public void UseItem(Item item)
        {
            var actual = _itens.FirstOrDefault(x => x.ItemUse.Name.ToLower().Equals(item.Name.ToLower()));
            if (actual != null)
            {
                actual.Quantidade--;
                if (actual.Quantidade <= 0)
                {
                    _itens.Remove(actual);
                    return;
                }
                if (actual.Quantidade == 0)
                {
                    _itens.Remove(actual);
                }

                actual.ItemUse.UseItem();
            }
        }
    }

    public class InventoryItem
    {
        public int Quantidade { get; set; }
        public Item ItemUse { get; set; }
    }
}