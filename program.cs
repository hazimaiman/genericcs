using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic =  "not specific to a particular data type"
            //            add <T> to: classes, methods, fields, etc.
            //            allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElement(intArray);
            displayElement(doubleArray);
            displayElement(stringArray);

            Console.ReadKey();


        }

        public static void displayElement<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

        /*  public static void displayElement(int[] array)
          {
              foreach (int item in array)
              {
                  Console.WriteLine(item + " ");
              }
          }
          public static void displayElement(double[] array)
          {
              foreach (double item in array)
              {
                  Console.WriteLine(item + " ");
              }
              Console.WriteLine();
          }
          public static void displayElement(String[] array)
          {
              foreach (String item in array)
              {
                  Console.WriteLine(item + " ");
              }
              Console.WriteLine();
          }*/

    }
}






