using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Owl: Bird
    {
        protected int zavitSivuv;

        public Owl(int zavitSivuv, int flightHeight, int wingsLength, string name, bool ispredator, int age, int calories):
            base(flightHeight, wingsLength, name, ispredator, age, calories)
        {
            this.zavitSivuv = zavitSivuv;
        }

        public int GetZavitSivuv()
        {
            return zavitSivuv;
        }

        public void SetZavitSivuv(int zavitSivuv)
        {
            this.zavitSivuv = zavitSivuv;
        }

        public override string ToString()
        {
            return base.ToString() + $"Zavit sivuv rosh; {zavitSivuv}";
        }
    }
}
