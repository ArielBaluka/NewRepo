using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Snake: Reptile
    {
        protected bool isArsi;

        public Snake(bool isArsi, int tailLength, string name, bool ispredator, int age, int calories) :
            base(tailLength, name, ispredator, age, calories)
        {
            this.isArsi = isArsi;
        }

        public bool GetisArsi()
        {
            return isArsi;
        }

        public void SetisArsi(bool isArsi)
        {
            this.isArsi = isArsi;
        }

        public override string ToString()
        {
            return base.ToString() + $"isArsi? {isArsi}";
        }

        public void Dance()
        {
            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("___________________________");
                }
                else
                {
                    Console.WriteLine("\\______________----___");
                }
            }
        }
    }
}
