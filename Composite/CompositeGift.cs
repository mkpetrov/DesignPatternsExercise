using System;
using System.Collections.Generic;

namespace DesignPatternsExercise.Composite
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private List<GiftBase> _gifts;

        public CompositeGift(string name, decimal price)
            : base(name, price)
        {
            _gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            _gifts.Remove(gift);
        }

        public override decimal CalculateTotalPrice()
        {
            var total = 0M;

            Console.WriteLine($"{name} contains the following products with prices:");

            foreach (var gift in _gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
