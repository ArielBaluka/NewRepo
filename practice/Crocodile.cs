using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Crocodile:Reptile
    {
        protected bool wasMetupal;

        public Crocodile(bool wasMetupal, int tailLength, string name, bool ispredator, int age, int calories): 
            base(tailLength, name, ispredator, age, calories)
        {
            this.wasMetupal = wasMetupal;
        }

        public bool GetWasMetupal()
        {
            return wasMetupal;
        }

        public void SetWasMetupal(bool wasMetupal)
        {
            this.wasMetupal = wasMetupal;
        }

        public override string ToString()
        {
            return base.ToString() + $"Was metupal? {wasMetupal}";
        }
    }
}
