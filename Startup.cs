using DesignPatternsExercise.Composite;
using DesignPatternsExercise.Prototype;
using DesignPatternsExercise.TemplatePattern;
using System;

namespace DesignPatternsExercise
{
    class Startup
    {
        static void Main(string[] args)
        {
            // Prototype
            var sandwichMenu = new SandwichMenu();

            sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            sandwichMenu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Onion, Tomato, Olives");
            sandwichMenu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Bacon", "Provolone", "Lettuce, Onion");
            sandwichMenu["Vegetarian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

            var sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
            var sandwich2 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
            var sandwich3 = sandwichMenu["Vegetarian"].Clone() as Sandwich;

            // Composite
            var phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootBox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("TruckToy", 289);
            var plainToy = new SingleGift("PlainToy", 587);
            rootBox.Add(truckToy);
            rootBox.Add(plainToy);
            var childBox = new CompositeGift("ChildBox", 0);
            var soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");

            // TemplatePattern
            var sourdough = new Sourdough();
            sourdough.Make();

            var twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            var wholeWheat = new WholeWheat();
            wholeWheat.Make();
        }
    }
}
