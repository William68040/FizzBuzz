using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public List<string> GetFizzBuzzResult()
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= 99; i++)
            {
                if (i % 15 == 0)
                {
                    result.Add(FizzBuzz());
                }
                else if (i % 3 == 0)
                {
                    result.Add(Fizz());
                }
                else if (i % 5 == 0)
                {
                    result.Add(Buzz());
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;


        }

        public string Fizz()
        {
            return "Fizz";
        }

        public string Buzz()
        {
            return "Buzz";
        }

        public string FizzBuzz()
        {
            return "FizzBuzz";
        }

    }
}
