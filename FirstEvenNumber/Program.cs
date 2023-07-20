using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = { 22, 2, 9, 3, 5, 8, 16, 23, 26, 88 };
            EvenNumbers(arrayElements);
            Console.ReadKey();

        }

        public static void EvenNumbers(int[] arr)
        {
            //declaring fields
            int i, j;
            int counteven = 0;
            int countodd = 0;
            int sumofeven = 0;
            int sumofodd = 0;

            Console.WriteLine("List of array numbers:  ");
            //List of array
            for (i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr);
                Console.Write(arr[i] + " ,");
            }

            Console.WriteLine("\n List of Even numbers: ");
            ////count of even numbers
            for (i=0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                    sumofeven += arr[i];
                    counteven++;
                }
            }

            Console.WriteLine("\n List of Odd numbers: ");
            ////count of even numbers
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                    sumofodd += arr[i];
                    countodd++;
                }
            }
            Console.WriteLine("\n Sum of Even Numbers:  {0} ", sumofeven);
            Console.WriteLine("\n Sum of Odd Numbers:  {0} ", sumofodd);
            Console.WriteLine("\n Count of Even Numbers:  {0} ", counteven);
            Console.WriteLine("\n Count of Odd Numbers:  {0} ", countodd);

            Console.ReadLine();


        }
    }
}
