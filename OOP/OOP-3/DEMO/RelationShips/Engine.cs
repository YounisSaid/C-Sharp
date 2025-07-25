using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.RelationShips
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }
    public class Car
    {
        public Engine Engine = new Engine(); // Composition
        public Car()
        {
            Engine.Start();
        }
    }
}
