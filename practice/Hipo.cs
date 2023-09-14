using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Hipo:Mammal
    {
        int FatPrecent;
        
        public Hipo(int fatprecent,int milkCalories, int pregnencyMonths, string name, bool ispredator, int age, int calories) : base(milkCalories, pregnencyMonths, name, ispredator, age, calories)
        {
            FatPrecent = fatprecent;
        }

        public int GetFatPrecent()
        {
            return FatPrecent;
        }

        public void SetFatPrecent(int FatPrecent)
        {
            this.FatPrecent =  FatPrecent;
        }

        public override string ToString()
        {
            return base.ToString() + $"FatPrecent: {FatPrecent}"; 
        }
    }
}
