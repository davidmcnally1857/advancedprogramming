using System;

namespace ConsoleApp1
{
   public class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 3, 1, 9, 10, 2, 3 };

            SortArray(array);
            Console.ReadLine();

            

        }

        

         public static void SortArray(int [] sortArray)
        {

            int temp = 0;
            for (int j = 0; j < sortArray.Length-1; j++)
            {
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        temp = sortArray[i + 1];
                        sortArray[i + 1] = sortArray[i];
                        sortArray[i] = temp;

                    }
                }
            }

            foreach(var item in sortArray)
            {
                if (item % 2 == 1)
                {
                    Console.Write(item + " ");
                }


                }
            foreach(var item in sortArray)
            {
                if(item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}