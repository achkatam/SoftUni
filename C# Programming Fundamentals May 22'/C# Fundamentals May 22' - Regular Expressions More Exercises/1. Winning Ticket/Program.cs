using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            //. The winning symbols are '@', '#', '$' and '^'. 
            string winningPattern = @"(\@{6,10}|\${6,10}|\#{6,10}|\^{6,10})";

            //You are given a collection of tickets separated by commas and spaces. You need to check every one of them if it has a winning combination of symbols.

            var tickets = Console.ReadLine().Split(new string[] { ", ", " " }
            , StringSplitOptions.RemoveEmptyEntries);
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                }
                else
                {
                    //should uninterruptedly repeat at least 6 times in both the tickets left half and the tickets right half. 
                    var firstHalfMatch = Regex.Match(ticket.Substring(0, 10), winningPattern);
                    var secondHalfMatch = Regex.Match(ticket.Substring(10, 10), winningPattern);

                    if (firstHalfMatch.Success && secondHalfMatch.Success)
                    {
                        //Find the shortest sequence of equal symbols
                        int winLength = Math.Min(firstHalfMatch.Value.Length, secondHalfMatch.Value.Length);

                        var leftSide = firstHalfMatch.Value.Substring(0, winLength);
                        var rightSide = secondHalfMatch.Value.Substring(0, winLength);

                        if (leftSide == rightSide)
                        {
                            //If you have 10 sequences in both side that is the Jackpot
                            if (leftSide.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {leftSide.Length}{leftSide[0]} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {leftSide.Length}{leftSide[0]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");

                    }

                }
            }
        }
    }
}
