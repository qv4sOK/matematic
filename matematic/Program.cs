using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число с точкой: ");
            // user input = Convert.ToDuble(Console.ReadLine());

            float user_input = float.Parse(Console.ReadLine());

            float result;

            result = user_input + 10f;

            result += 10;
        }
    }
}
