using System;

namespace DesignPatternsExercise.TemplatePattern
{
    public abstract class Bread
    {
        public abstract void MixIngrediants();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slice the" + GetType().Name + "bread!");
        }

        public void Make()
        {
            MixIngrediants();
            Bake();
            Slice();
        }
    }
}
