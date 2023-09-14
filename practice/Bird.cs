using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1_ariel
{
    internal class Bird:Animal,IBird
    {
        protected int FlightHeight;
        protected int WingsLength;

        public Bird(int flightHeight, int wingsLength,string name, bool ispredator, int age, int calories):
            base(name, ispredator, age, calories)
        {
            FlightHeight = flightHeight;
            WingsLength = wingsLength;
        }

        public int GetFlightHeight()
        {
            return FlightHeight;
        }
        public int GetWingsLength()
        {
            return WingsLength;
        }
        public void SetGetWingsLength(int WingsLength)
        {
            this.WingsLength = WingsLength;
        }
        public void SetTailLength(int FlightHeight)
        {
            this.FlightHeight = FlightHeight;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nFlightHeight: {FlightHeight}\nWingsLength: {WingsLength}";
        }

        public void sing()
        {
            Console.WriteLine("mew");
        }

        public void Dance()
        {
            for (int i = 0; i < 4; i++)
            {
                if(i%2 ==0)
                {
                    Console.WriteLine("\\_/");
                }
                else
                {
                    Console.WriteLine("                     \\_/");
                }
                
            }
        }
        public void TakeOff()
        {
            Console.WriteLine("bird is taking of /\\");
        }

        public void Land()
        {
            Console.WriteLine("bird is landing ____________________________");
        }

        public void Gliding()
        {
            Console.WriteLine("bird is gliding \\|__|/");
        }

        public override void breathe()
        {
            Console.WriteLine("Bird breathing");
        }

        public override void grow()
        {
            Console.WriteLine("Bird growing");
        }
        public override void reproduction()
        {
            Console.WriteLine("Bird reproducting");
        }
    }
}
