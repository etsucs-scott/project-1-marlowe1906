using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Testing
{
    internal class Penguin : IAnimal
    {
        public string Name { get; set; }
        public float Weight { get; set; }

        public void Eat()
        {
            Console.WriteLine("YUM!");
        }
        public void Move()
        {
            Console.WriteLine("I MOVED!");
        }
        public void MakeSound()
        {
            Console.WriteLine("WOOF!");
        }
    }
}
