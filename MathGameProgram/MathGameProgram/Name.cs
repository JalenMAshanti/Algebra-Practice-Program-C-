using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameProgram
{
    internal class Name
    {
        internal string GetName()
        {
            Console.WriteLine("Please enter you name:");
            string name = Console.ReadLine();
            Console.Clear();
            return name;
        }
    }
}
