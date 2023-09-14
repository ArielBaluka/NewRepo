using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Cobra: Snake
    {
        protected bool isDeaf;

        public Cobra(bool isDeaf, bool isArsi, int tailLength, string name, bool ispredator, int age, int calories):
            base(isArsi, tailLength, name, ispredator, age, calories)
        {
            this.isDeaf = isDeaf;
        }

        public bool GetIsDeaf()
        {
            return isDeaf;
        }

        public void SetIsDeaf(bool isDeaf)
        {
            this.isDeaf = isDeaf;
        }

        public override string ToString()
        {
            return base.ToString() + $"is deaf: {isDeaf}";
        }
    }
}
