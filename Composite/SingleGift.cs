using System;

namespace DesignPatternsExercise.Composite
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, decimal price)
            : base(name,price)
        {
        }

        public override decimal CalculateTotalPrice()
        {
            Console.WriteLine($"{name} with price {price}");

            return price;
        }
    }
}
