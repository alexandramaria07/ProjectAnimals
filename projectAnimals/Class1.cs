using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Animal
    {
        public string Name;
        public string Sound;
        public void MakeSound()
        {
            Console.WriteLine(this.Name + " makes " + this.Sound);
        }
        public Animal(string animalName)
        {
            this.Name = animalName;
        }
    }
    class Dog : Animal
    {
        public Dog(string dogName) : base(dogName)
        {
            this.Sound = "Woof-wooof-wooof";
        }
    }
    class Cat : Animal
    {
        public Cat(string catName) : base(catName)
        {
            this.Sound = "Meooooooow-meeeowww";
        }
    }
    class Horse : Animal
    {
        public Horse(string horseName)
            : base(horseName)
        {
            this.Sound = "Ni-ha-haaa";
        }
    }
    class Pig : Animal
    {
        public Pig(string pigName)
            : base(pigName)
        {
            this.Sound = "Oink-oink-oink";
        }
        class Cat : Animal
        {
            public Cat(string catName) : base(catName)
            {
                this.Sound = "Meooooooow-meeeowww";
            }

        }
        class Horse : Animal

        {
            public Horse(string horseName)
                : base(horseName)
            {
                this.Sound = "Ni-ha-haaa";
            }
        }
    }
}
