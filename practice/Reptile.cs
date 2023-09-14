using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1_ariel
{
    internal class Reptile : Animal, IReptile
    {
        protected int tailLength;

        public Reptile(int tailLength, string name, bool ispredator, int age, int calories):
            base(name, ispredator, age, calories)
        {
            this.tailLength = tailLength;
        }

        public int GetTailLength()
        {
            return tailLength;
        }
        public void SetTailLength(int Length)
        {
            tailLength = Length;
        }

        public override string ToString()
        {
            return base.ToString() + $"\ntailLength: {tailLength}";
        }

        public void Crawl()
        {
            Console.WriteLine("crawling");
        }

        public void Protecting()
        {
            Console.WriteLine("activating self protection protocol (----)");
        }

        public void CheckHeat()
        {
            int heat = 0;
            Console.WriteLine("enter body heat: ");
            heat = int.Parse(Console.ReadLine());
            if(heat < 0 || heat > 100)
            {
                Console.WriteLine("no good");
            }
            else
            {
                Console.WriteLine("you are fine");
            }
        }
        public override void breathe()
        {
            Console.WriteLine("Reptile breathing");
        }

        public override void grow()
        {
            Console.WriteLine("Reptile growing");
        }
        public override void reproduction()
        {
            Console.WriteLine("Reptile reproducting");
        }
    }
}
