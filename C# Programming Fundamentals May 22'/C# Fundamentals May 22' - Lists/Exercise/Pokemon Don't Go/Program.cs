using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {

            //You will receive a sequence of integers, separated by spaces – the distances to the pokemon.Then you will begin receiving integers, which will correspond to indexes in that sequence.
            //When you receive an index, you must remove the element at that index from the sequence (as if you’ve captured the pokemon).
            //•	You must increase the value of all elements in the sequence, which are less or equal to the removed element, with the value of the removed element.
            //•	You must decrease the value of all elements in the sequence, which are greater than the removed element, with the value of the removed element.
            //If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.
            //If the given index is greater than the last index of the sequence, remove the last element from the sequence, and copy the first element to its place.
            //The increasing and decreasing of elements should be done in these cases, also.The element, whose value you should use is the removed element.
            //The program ends when the sequence has no elements (there are no pokemon left for Ely to catch).

            //Create the list
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            //add-ons
            int index, currValue;
            int sum = 0;

            while (sequence.Count != 0)
            {
                index = int.Parse(Console.ReadLine());
                if (index > 0)
                {
                    //Always have to stay in the sequence lenght
                    currValue = sequence[0];
                    sum += currValue;
                    //If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.

                    sequence[0] = sequence[sequence.Count - 1];

                }
                else if (index > sequence.Count - 1)
                {
                    //If the given index is greater than the last index of the sequence, remove the last element from the sequence, and copy the first element to its place.
                    currValue = sequence[sequence.Count - 1];
                    sum += currValue;
                    sequence[sequence.Count - 1] = sequence[0];

                }
                else
                {
                    currValue = sequence[index];
                    sum += currValue;
                    sequence.RemoveAt(index);
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] >= currValue)
                    {
                        sequence[i] += currValue;
                    }
                    else
                    {
                        sequence[i] -= currValue;
                    }
                }

            }
            Console.WriteLine(sum);

        }
    }
}
