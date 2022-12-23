using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTestConsoleApp.FizzBuzz
{
    internal class FizzBuzzOutput : IFizzBuzzOutput
    {
        public void OutputNextElement(string nextElement) 
        {
            Console.WriteLine(nextElement);
        }
    }
}
