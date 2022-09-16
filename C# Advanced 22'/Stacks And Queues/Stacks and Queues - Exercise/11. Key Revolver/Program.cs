using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Our favorite super-spy action hero Sam is back from his mission in another exam, and this time he has an even more difficult task. He needs to unlock a safe. The problem is that the safe is locked by several locks in a row, which all have varying sizes.
            //Our hero possesses a special weapon though, called the Key Revolver, with special bullets. Each bullet can unlock a lock with a size equal to or larger than the size of the bullet. The bullet goes into the keyhole, then explodes, destroying it. Sam doesn’t know the size of the locks, so he needs to just shoot at all of them until the safe run out of locks.
            //What’s behind the safe, you ask? Well, intelligence!It is told that Sam’s sworn enemy – Nikoladze, keeps his top - secret Georgian Chacha Brandy recipe inside.It’s valued differently across different times of the year, so Sam’s boss will tell him what it’s worth over the radio.One last thing, every bullet Sam fires will also cost him money, which will be deducted from his pay from the price of the intelligence. 

            //Input
            //•	On the first line of input, you will receive the price of each bullet – an integer in the range[0 - 100]
            int bulletPrice = int.Parse(Console.ReadLine());

            //•	On the second line, you will receive the size of the gun barrel – an integer in the range[1 - 5000] = magazin capacity
            int magazin = int.Parse(Console.ReadLine());

            //•	On the third line, you will receive the bullets – a space-separated integer sequence with[1 - 100] integers
            int[] bulletInfo = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //•	On the fourth line, you will receive the locks – a space-separated integer sequence with[1 - 100] integers
            int[] locksInfo = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //•	On the fifth line, you will receive the value of the intelligence – an integer in the range[1 - 100000]
            int valueInt = int.Parse(Console.ReadLine());

            //queue for the locks
            var locks = new Queue<int>(locksInfo);

            //stack for bullets
            var bullets = new Stack<int>(bulletInfo);

            //counter for shot bullets
            int counter = 0;

            while (bullets.Any() && locks.Any())
            {
                ShootingProccess(bullets, locks, ref counter, magazin);
            }

            //Output
            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int earnedMoney = valueInt - (bulletPrice * counter);

                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }

        }
        static void ShootingProccess(Stack<int> bullets, Queue<int> locks, ref int counter, int magazin)
        {
            //Remove bullet in both caes
            int bulletSize = bullets.Pop();

            int lockSize = locks.Peek();
            counter++;

            if (bulletSize <= lockSize)
            {
                Console.WriteLine("Bang!");
                locks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (counter % magazin == 0 && bullets.Any())
            {
                Console.WriteLine("Reloading!");
            }
        }
    }
}
