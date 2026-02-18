using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Testing
{
    internal interface IAnimal
    {
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
