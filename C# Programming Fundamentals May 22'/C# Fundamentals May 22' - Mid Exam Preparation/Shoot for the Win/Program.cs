using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that helps you keep track of your shot targets. You will receive a sequence with integers, separated by a single space, representing targets and their value.Afterward, you will be receiving indices until the "End" command is given, and you need to print the targets and the count of shot targets.
            //Every time you receive an index, you need to shoot the target on that index, if it is possible.
            // Along with that, you also need to:
            //Keep in mind that you can't shoot a target, which is already shot. You also can't increase or reduce a target, which is considered shot.
            //When you receive the "End" command, print the targets in their current state and the count of shot targets in the following format:
            //            "Shot targets: {count} -> {target1} {target2}… {targetn}"

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Counter for shot targets
            int counter = 0;
            //
            string command = Console.ReadLine();

            while (command != "End")
            {
                //variable for the index of the target that we're gonna shot
                int indexOfShotTarget = int.Parse(command);

                //Use if statement to make sure you stay in the bounds of the array
                if (indexOfShotTarget >= 0 && indexOfShotTarget <= numbers.Length - 1)
                {
                    // Ff statement to make sure we do not se the shot target and for loop to iterate thru the rest of the targets(numbers)
                    if (numbers[indexOfShotTarget] != -1)
                    {
                        //keep the value of the shotTarget in new target
                        int currTarget = numbers[indexOfShotTarget];
                        counter++;
                        //If u successfully shot a target, its value equals -1
                        numbers[indexOfShotTarget] = -1;

                        //For loop
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            //One more If statement to make sure we DO NOT WORK on the shot target
                            if (numbers[i] != -1)
                            {
                                //	Reduce all the other targets, which have greater values than your current target, with its value. 
                                if (numbers[i] > currTarget)
                                {
                                    numbers[i] -= currTarget;
                                }
                                else if (numbers[i] <= currTarget)
                                {
                                    //	Increase all the other targets, which have less than or equal value to the shot target, with its value
                                    numbers[i] += currTarget;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.Write($"Shot targets: {counter} -> ");
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
