using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_split___Odd_and_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listEven = new List<int>();
            List<int> listOdd = new List<int>();

            for(int i = 1; i <= 20; i++)
            {
                if(i%2 == 0)
                {
                    listEven.Add(i);
                }
                else
                {
                    listOdd.Add(i);
                }
            }
            
            Console.WriteLine("The content of the even list is :");

            for(int i = 0; i < listEven.Count; i++)
            {
                Console.Write($"{listEven[i]} "); ;
            }

            Console.WriteLine("\nThe content of the odd list is :");

            for (int i = 0; i < listOdd.Count; i++)
            {
                Console.Write($"{listOdd[i]} "); ;
            }
            Console.ReadLine();

        }

    }
}
