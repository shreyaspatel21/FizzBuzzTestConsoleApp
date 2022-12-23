using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTestConsoleApp.FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        IFizzBuzzOutput __FizzBuzzOutput;
        private const string FIZZ_STRING = "FIZZ";
        private const string BUZZ_STRING = "BUZZ";

        public int __StartFrom {
            get
            {
                return __StartFrom;
            }
            set
            {
                __StartFrom = value;
            }
        }
        public int __StopAt
        {
            get
            {
                return __StopAt;
            }
            set
            {
                __StopAt= value;
            }
        }

        public FizzBuzz() 
            : this(new FizzBuzzOutput())
        {
        }

        private FizzBuzz(IFizzBuzzOutput fizzBuzzOutput)
        {
            __FizzBuzzOutput = fizzBuzzOutput;
        }




    }
}
