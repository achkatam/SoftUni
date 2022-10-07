using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace _01._Tiles_Master
{
    public class Program
    {
        static void Main(string[] args)
        {
            //First, you will be given a sequence of numbers, representing the areas of the white tiles.
            var whiteTilesInput = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse).ToArray();

            // Afterward, you will be given another sequence, representing the areas of the grey tiles.
            var greyTilesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            //LIFO
            var whiteTiles = new Stack<int>(whiteTilesInput);

            //FIFO
            var greyTiles = new Queue<int>(greyTilesInput);

            //Dictionari<location, tilesUsed>()
            var tiles = new Dictionary<string, int>()
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0 },
                {"Wall", 0 },
                {"Floor", 0 },
            };

            //Sink	40
            //Oven    50
            //Countertop  60
            //Wall    70


            while (whiteTiles.Any() && greyTiles.Any())
            {
                //if (whiteTiles.Count <= 0 || greyTiles.Count <= 0) break;

                if (whiteTiles.Peek() == greyTiles.Peek())
                {
                    int areaSum = whiteTiles.Peek() + greyTiles.Peek();


                    switch (areaSum)
                    {
                        case 40:
                            whiteTiles.Pop();
                            greyTiles.Dequeue();
                            tiles["Sink"]++;
                            break;
                        case 50:
                            whiteTiles.Pop();
                            greyTiles.Dequeue();
                            tiles["Oven"]++;
                            break;
                        case 60:
                            whiteTiles.Pop();
                            greyTiles.Dequeue();
                            tiles["Countertop"]++;
                            break;
                        case 70:
                            whiteTiles.Pop();
                            greyTiles.Dequeue();
                            tiles["Wall"]++;
                            break;
                        default:
                            whiteTiles.Pop();
                            greyTiles.Dequeue();
                            tiles["Floor"]++;
                            break;
                    }
                }
                else
                {
                    //If their areas don't match at all, you take the white tile, decrease its area in half and insert it back to the sequence. After that, you change the grey's tile position by putting it at the back of the sequence.
                    //white tiles
                    int toDecrease = whiteTiles.Pop();
                    toDecrease /= 2;
                    whiteTiles.Push(toDecrease);
                    //grey tiles
                    int currTile = greyTiles.Dequeue();
                    greyTiles.Enqueue(currTile);
                }
            }

            PrintOutput(whiteTiles, greyTiles, tiles);

        }

        public static void PrintOutput(Stack<int> whiteTiles, Queue<int> greyTiles, Dictionary<string, int> tiles)
        {
            //o	If there are no white tiles left: "White tiles left: none"
            //o If there are white tiles left: "White tiles left: {whiteTile1}, 
            Console.WriteLine(whiteTiles.Count > 0 ? $"White tiles left: {string.Join(", ", whiteTiles)}" : $"White tiles left: none");

            //same with for greyTiles
            Console.WriteLine(greyTiles.Count > 0 ? $"Grey tiles left: {string.Join(", ", greyTiles)}" : $"Grey tiles left: none");

            //The locations must be ordered descending by number (count of new tiles per location) and then sorted ascending alphabetically.
            foreach (var tile in tiles.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{tile.Key}: {tile.Value}");
            }

        }
    }
}
