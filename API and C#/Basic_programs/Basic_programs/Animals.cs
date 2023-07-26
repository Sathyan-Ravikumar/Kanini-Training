using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class Animals : College, Sound, AnimalType
    {
        private int tail,eyes,mouth,legs;
        private string name;

        public Animals(int tail, int eyes, int mouth, int legs, string name, 
            string collegename, string address, int pincode)
            :base(collegename,address, pincode)
        {
            this.Tail = tail;
            this.Eyes = eyes;
            this.Mouth = mouth;
            this.Legs = legs;
            this.Name = name;
        }

        public int Tail { get => tail; set => tail = value; }
        public int Eyes { get => eyes; set => eyes = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Legs { get => legs; set => legs = value; }
        public string Name { get => name; set => name = value; }

        public void MakeSound(string name)
        {
            if (name == "dog")
            {
                Console.WriteLine("Bow Bow");
            }
            else if (name == "cat")
            {
                Console.WriteLine("Meow Meow");
            }
        }

        public void type(string name)
        {
            if (name == "dog")
            {
                Console.WriteLine("Carnivore");
            }
            else if (name == "cow")
            {
                Console.WriteLine("Herbivore");
            }
        }
    }
}
