using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Ques2
    {
        static void Main2()
        {
            Console.Write("Enter Number of Batches : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[b][];
            for (int i = 0; i < b; i++)
            {
                Console.Write($"Enter Number of Student in {i + 1} : ");
                int s = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[s];
                for (int j = 0; j < s; j++)
                {
                    Console.Write($"Enter Marks Batch {i + 1} Student {j + 1} : ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Batch {i + 1} Stuendt {j + 1} Marks are :" + arr[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
