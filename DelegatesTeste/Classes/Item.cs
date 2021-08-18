using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesTeste.Classes
{
    public abstract class Item
    {
        private readonly List<Delegate> _callbacks = new List<Delegate>();
        public string Name { get; private set; }
        public string Descripption { get; private set; }
        public double Price { get; private set; }


        public void AddCallback(Delegate callback)
        {
            if (callback == null)
                new ArgumentException($"{nameof(callback)} não pode ser nulo");

            _callbacks.Add(callback);
        }

        public void AddCallbacks(IEnumerable<Delegate> callback)
        {
            if (callback == null)
                new ArgumentException($"{nameof(callback)} não pode ser nulo");

            _callbacks.AddRange(callback);
        }
        public Item(string name, string description, double price)
        {
            Name = name;
            Descripption = description;
            Price = price;
            _callbacks = new List<Delegate>();
        }

        public virtual void UseItem()
        {
            if (_callbacks.Count > 0)
                foreach (var item in _callbacks)
                    item?.DynamicInvoke();
        }





    }





}