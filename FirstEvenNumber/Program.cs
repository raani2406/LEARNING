using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEvenNumber
{
    internal class Program
    {
        private static int sumofeven;
        private static int counteven;
        private static int sumofodd;
        private static int countodd;

        static void Main(string[] args)
        {
            int[] arrayElements = { 25,22,36,2, 3, 5, 8, 16, 23, 26, 88 };
            EvenNumbers(arrayElements);

            ForandForEachLoopEven(arrayElements);
            int a = 10;
            int b = 5;
            int c = 15;
            float x = 10.327f;
            float y = 10.327f;
            float z = 10.327f;
            
            Add(a, b);
            
            Add(a, b, c);
            Add(x, y,z);

            BaseClass obj = new DerivedClass();
            obj.Greetings();

            #region  Odd Characters in a String

                    String name = "Philip";
                    StringBuilder sb = new StringBuilder(name.Length / 2 + 1);
                    for(int i = 0; i < name.Length; i+=2 )
                    {
                        sb.Append(name[i]);
                        Console.WriteLine("Place {0}", i);
                        Console.WriteLine("Value {0}", name[i]);
                    }
                    String res = sb.ToString();
                    Console.WriteLine("Odd Characters in a String is {0}",res);

            #endregion Odd Characters in a String

            Console.ReadKey();

        
        }

        #region *To get listofArrays, Count & Sum of even and odd nos in Array( using For and Foreach loops)
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
            ////count of odd numbers
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

        public static void ForandForEachLoopEven(int[] arr)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("List of array numbers:  ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n List of Even numbers: ");

            foreach (int items in arr)
            {
                if (items % 2 == 0)
                {
                    Console.Write("{0} ", items);
                    sumofeven += items;
                    counteven++;
                }
            }

            Console.WriteLine("\n List of Odd numbers: ");
            for (int i=0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write("{0} ", arr[i]);
                    sumofodd += arr[i];
                    countodd++;
                }
            }

            Console.WriteLine("\n Sum of Even Numbers:  {0} ", sumofeven);
            Console.WriteLine("\n Sum of Odd Numbers:  {0} ", sumofodd);
            Console.WriteLine("\n Count of Even Numbers:  {0} ", counteven);
            Console.WriteLine("\n Count of Odd Numbers:  {0} ", countodd);
        }

        #endregion * To get listofArrays, Count & Sum of even and odd nos in Array( using For and Foreach loops)

        #region Method OverLoading and OverRiding

        public static int Add(int a, int b)
        {
            Console.WriteLine("-----------------------------------------------------");
            int sum = a + b;
            Console.WriteLine("add a + b = {0}", sum);
            return sum;

        }
        public static int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("int add a + b + c = {0}", sum);
            return sum;
        }
        public static float Add(float a, float b, float c)
        {
            float result = a + b + c;
            Console.WriteLine("float add a + b + c = {0}", result);
            return result;
        }
        public static float Add(float x, float y, int z)
        {
            float res = x + y + z;
            Console.Write("float add x + y + z", res);
            Console.WriteLine("-----------------------------------------------------");
            return res;
        }

        #endregion
    }
}
