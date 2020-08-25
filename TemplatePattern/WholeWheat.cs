﻿using System;

namespace DesignPatternsExercise.TemplatePattern
{
    public class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
        }

        public override void MixIngrediants()
        {
            Console.WriteLine("Gathering Ingrediants for Whole Wheat Bread.");
        }
    }
}
