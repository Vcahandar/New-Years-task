using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class FibonacciController
    {
      public void Fibonacci()
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;
            int i = 0;
            int number = 0;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");   
            for (i = 2; i < number; ++i)     
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }


        }
    }
}
