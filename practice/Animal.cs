using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1_ariel
{
    internal abstract class Animal
    {
        //שם החיה, גיל, האם טורף על?,  כמות קלוריות לארוחה
        protected string name;
        protected bool ispredator;
        protected int age;
        protected int calories;

        public Animal(string name, bool ispredator, int age, int calories)
        {
            this.name = name;
            this.ispredator = ispredator;
            this.age = age;
            this.calories = calories;
        }
        public string GetName()
        {
            return name;
        }
        public bool Getispredator()
        {
            return ispredator;
        }
        public int GetAge()
        {
            return age;
        }
        public int GetCalories()
        {
            return calories;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setIspredator(bool ispredator)
        {
            this.ispredator = ispredator;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setCalories(int calories)
        {
            this.calories = calories;
        }

        public override string ToString()
        {
            return "name: " + name + "\nAge: " + age.ToString() + "\nIspredator: " +
                ispredator + "\nCalories per meal: " + calories;
        }

        public int Eat()
        {
            return 3 * calories;
        }

        public abstract void breathe();
        public abstract void grow();
        
        public abstract void reproduction();
    }
}
