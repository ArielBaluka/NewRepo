using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ariel
{
    internal class Park
    {
        private Animal[] animals;
        private int current;

        public Park()
        {
            animals = new Animal[1000];
            current = 0;
        }

        public void addAnimal(Animal animal)
        {
            if(current < animals.Length-1)
            {
                animals[current] = animal;
                current++;
            }
        }

        //רשימה עם כל החיות שמעל גיל 10 והן טורפות על
        public List<Animal> FindTorfimGdolim()
        {
            List<Animal> list = new List<Animal>();
            list.Add(animals[current]);

            foreach(Animal animal in animals)
            {
                if (animal != null)
                {
                    if (animal.Getispredator() && animal.GetAge() > 10)
                    {
                        list.Add(animal);
                    }
                }
            }
            return list;
        }

        //מחזירה את כמות הזוחלים והעופות שהם טורפי על
        public int CountTorfimMesuyamim()
        {
            int count = 0;
            foreach(Animal animal in animals)
            {
                if(animal != null)
                {
                    if (animal.Getispredator())
                    {
                        if (animal is Bird || animal is Reptile)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
