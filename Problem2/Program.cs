using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("The old array is");
            PrintArray(inputArray);
            Console.WriteLine("Enter the index");
            if (int.TryParse(Console.ReadLine(), out int result) && result >= 0 && result < inputArray.Length)
            {
                int targetIndex = result;
                DeleteMember(ref inputArray, targetIndex);
                Console.WriteLine("New Array is ");
                PrintArray(inputArray);
            }
            else
            {
                Console.WriteLine("You've entered wrong symbol");
            }

            Console.ReadKey();
        }

        static void PrintArray(int [] inputArray)
        {
            int length = inputArray.Length;
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }

        }
        static  void DeleteMember(ref int[] inputArray,int targetIndex)
        {
            int[] newArray = new int[inputArray.Length - 1];
            int indexofNewArr = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i != targetIndex)
                {
                   newArray[indexofNewArr] = inputArray[i];  
                   indexofNewArr++;
                }              
            }

            inputArray = newArray;

              
            
        }



    }
}
