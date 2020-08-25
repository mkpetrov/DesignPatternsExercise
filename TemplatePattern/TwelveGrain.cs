using System;

namespace DesignPatternsExercise.TemplatePattern
{
    class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
        }

        public override void MixIngrediants()
        {
            Console.WriteLine("Gathering Ingrediants for 12-Grain Bread.");
        }
    }
}
