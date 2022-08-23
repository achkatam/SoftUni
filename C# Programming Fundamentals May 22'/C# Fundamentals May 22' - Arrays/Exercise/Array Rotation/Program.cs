using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotate the Array [1] [2] [3] => [2] [3] [1]
            //Create array
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //How many rotation will be attempted 
            int rotateCnt = int.Parse(Console.ReadLine());

            //Using For loop we're gonna check the curr position of every element and rotate its position(index)
            for (int i = 0; i < rotateCnt; i++)
            {
                //Creating a temporary num that will be used for manipulations - this will be the first num
                //from the array which means array[0]
                int currNum = array[0];

                //One more loop to change index [i] position opeartion < array.Length - 1
                for (int operation = 0; operation < array.Length - 1; operation++)
                {
                    array[operation] = array[operation + 1];
                }
                array[array.Length - 1] = currNum;
            }
            //Output
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
