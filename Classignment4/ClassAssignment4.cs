using System;
using System.Collections.Generic;
using System.Text;

namespace Classignment4
{
    class ClassAssignment4
    {
        public string Hello()


        {
            String s = "hello";

            string input1 = Console.ReadLine();
          
            if (input1.StartsWith("hello"))
            {


                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
           // Console.WriteLine("input string:" +input1);

      


           
           // Console.WriteLine(input1.StartsWith("hello"));

            return input1;




        
        }
         public static void cubeNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int cube;
            
            for (int i = 0; i <= n; i++)
            {

                cube = i * i * i;

                Console.Write("\nNumber is : "+i+" and cube of the :" +i +".is."+cube);
            }
        }
        public static void pattern()
        {
            Console.WriteLine("Display the pattern like right angle triangle");
            Console.Write("input the number of raw:");
            int row = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= row; i++)
            {
                for(int j=1;j <= i; j++)
                
                    Console.Write("{0}",j);
                    Console.Write("\n");
                
               // Console.WriteLine("\n");
            }
            //Console.WriteLine("\n");

        }
        public static void swarp()
        {
            Console.WriteLine("value before swap");
            int number1 = 2;
            Console.WriteLine("Enter the First Number : "+number1);
            int number2 = 3;
            
            Console.WriteLine("Enter the Second Number : " +number2);
            
            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("after swap");
            
            Console.WriteLine("\nfirst number is:  " + number1 + " \n second number is:" + number2);

            
        }

    }
}
