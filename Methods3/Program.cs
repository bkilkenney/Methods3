using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)            
        {
            Console.WriteLine("Select a number");
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumbers(number));
        }
        static string ReverseNumbers(string number)
        {
            string answer = "";
            for (int i = (number.Length - 1); i >= 0; i--)
            {
                answer += number[i];
            }
            return answer;
        }
    }
}
