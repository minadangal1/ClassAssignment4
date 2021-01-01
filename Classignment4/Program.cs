using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Classignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remove();
            //subString();
            // longestWord();
           // sumOfPrimeNumber();
            // sumOfDegiete();
            // Array();
            ClassAssignment4 c = new ClassAssignment4();
             c.Hello();
            // ClassAssignment4.cubeNumber();
            // ClassAssignment4.pattern();
             ClassAssignment4.swarp();
        }

        public static void Remove()
        {
            Console.WriteLine("orginal value before remove");
            string input = Console.ReadLine();
            string value = input.Replace("1111", "");

            Console.WriteLine(" new value after replace:" + value);
        }
        static void subString()
        {
            int startindex = 0;
            int length = 1;

            Console.Write("Input a string : ");
            string input = Console.ReadLine();


            var s = input.Substring(startindex, length);
            Console.WriteLine(s + input + s);

        }
        static void longestWord()
        {
            string data = "write a c# program to display the fllowing pattern using the alphabet";
            int startindex = 34;
            int length = 8;


            string newData = data.Substring(startindex, length);

            Console.WriteLine(newData);

        }
        static void sumOfPrimeNumber()
        {
            int n, i,  k, sum = 0;
            bool result = false;
            Console.Write("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n; i++)
            {
                k = 2;
                result = true;
                while (k < i)
                {
                    if (i % k == 0)
                    {
                        result = false;
                        break;
                    }
                    k++;
                }
                if (result)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("Sum of prime numbers:" + sum);
        }
    


















        public static void sumOfDegiete()

        {
            Console.WriteLine("please provided ihe input number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n % 10 != 0)
            {

                sum = sum + n % 10;
                n = n / 10;
            }

            Console.WriteLine("sum of the input number" + sum);
        }


        public static void Array()
        {


            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };

            // array1 = Convert.(Console.ReadLine());
            Console.WriteLine(string.Join(",", "array1"));
            Console.WriteLine(string.Join(",", "array2"));
            Console.WriteLine("\nMultiply corresponding elements of two arrays: ");
            for (int i = 0; i < array1.Length; i++)
            {

                int array = array1[i] * array2[i];

                Console.Write(" " + array);
            }




        }
    }
}