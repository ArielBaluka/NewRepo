using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Mammal:Animal
    {
        protected int milkCalories;
        protected int PregnencyMonths;

        public Mammal(int milkCalories, int pregnencyMonths, string name, bool ispredator, int age, int calories) : base(name, ispredator, age, calories)
        {
            this.milkCalories = milkCalories;
            PregnencyMonths = pregnencyMonths;
        }

        public int GetmilkCalories()
        {
            return milkCalories;
        }
        public int GetPregnencyMonths()
        {
            return age;
        }
        public void setmilkCalories(int milkCalories)
        {
            this.milkCalories = milkCalories;
        }
        public void setPregnencyMonths(int PregnencyMonths)
        {
            this.PregnencyMonths = PregnencyMonths;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nmilkCalories: {milkCalories}\nPregnencyMonths: {PregnencyMonths}";
        }

        public new int Eat()
        {
            return base.Eat() + milkCalories;
        }

        public override void breathe()
        {
            Console.WriteLine("Mammal breathing");
        }

        public override void grow()
        {
            Console.WriteLine("Mammal growing");
        }

        public override void reproduction()
        {
            Console.WriteLine("Mammal reproducting");
        }
    }
}
