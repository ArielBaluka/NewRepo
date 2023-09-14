using System;

namespace Task1_ariel
{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Moshe", "Omer", "Menahem", "David", "Muhamad" };
            bool[] vals = { true, false };

            Random random = new Random();

            Mammal[] arrMammal = new Mammal[]
            {
                new Mammal(random.Next(1,100), random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Cow(random.Next(1,100),random.Next(1,100), random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Mammal(random.Next(1,100), random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Hipo(random.Next(1,100),random.Next(1,100), random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Cow(random.Next(1,100),random.Next(1,100), random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
            };


            Reptile[] arrReptile = new Reptile[]
            {
                new Reptile(random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Reptile(random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Reptile(random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Reptile(random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
                new Reptile(random.Next(1,100), names[random.Next(0,names.Length)], vals[random.Next(0,vals.Length)], random.Next(1,100), random.Next(1,100)),
            };




            Animal[] arrAnimal = new Animal[8];

            for (int i = 0; i < arrAnimal.Length; i++)
            {
                arrAnimal[i] = new Owl(random.Next(1, 271), random.Next(1, 100), random.Next(1, 100), names[random.Next(0, names.Length)], vals[random.Next(0, vals.Length)], random.Next(1, 100), random.Next(1, 100));
            }

            foreach (Animal Anim in arrAnimal)
            {
                Console.WriteLine(Anim);
                Console.WriteLine("\n");
            }

            foreach (Reptile rep in arrReptile)
            {
                Console.WriteLine(rep);
                Console.WriteLine("\n");
            }

            foreach (Mammal mam in arrMammal)
            {
                Console.WriteLine(mam);
                Console.WriteLine("\n");
            }


        }
        //פעולה המחזירה את כמות הקלוריות היומית שאוכלות כל החיות במערך
        public static int SumCalories(Animal[] arrAnimal)
        {
            int sum = 0;

            foreach (Animal animal in arrAnimal)
            {
                sum += animal.Eat();

            }
            return sum;
        }

        public static int NumberOfMammal(Animal[] arrAnimal)
        {
            int count = 0;
            foreach (Animal animal in arrAnimal)
            {
                if(animal is Mammal)
                {
                    count++;
                }
            }
            return count;
        }

        public static void ForceDance(Animal[] arrAnimal)
        {
            foreach(Animal animal in arrAnimal)
            {
                if(animal is Bird)
                {
                    ((Bird)animal).Dance();
                }
                else if(animal is Snake)
                {
                    ((Snake)animal).Dance();
                }
            }
        }

        public string FattestHippo(Animal[] arrAnimal)
        {
            string name = "no hipos";
            int HighestFatPrecent = -1;
            int current = 0;
            foreach(Animal animal in arrAnimal)
            {
                if(animal is Hipo)
                {
                    current = ((Hipo)animal).GetFatPrecent();
                    if (current > HighestFatPrecent)
                    {
                        HighestFatPrecent = current;
                        name = ((Hipo)animal).GetName();
                    }
                }
            }
            return name;
        }
    }
}