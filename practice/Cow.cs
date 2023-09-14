using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Cow: Mammal
    {
        protected int HamlatotCount;

        public Cow(int hamlatotCount, int milkCalories, int pregnencyMonths, string name, bool ispredator, int age, int calories): base(milkCalories, pregnencyMonths, name, ispredator, age, calories)
        {
            HamlatotCount = hamlatotCount;
        }
        public int GetHamlatotCount()
        { 
            return HamlatotCount; 
        }

        public void SetHamlatotCount(int HamlatotCount)
        {
            this.HamlatotCount = HamlatotCount;
        }

        public override string ToString()
        {
            return base.ToString() + $"HamlatotCount: {HamlatotCount}";
        }

        public new int Eat()
        {
            return base.Eat()/4;
        }
    }
}
