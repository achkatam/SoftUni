using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            // As a MOBA challenger player, Petar has the bad habit to trash his PC when he loses a game and rage quits.His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count. 
            //You will receive the price of each item in his gaming setup.Calculate his rage expenses for renewing his gaming equipment.
            //Input / Constraints
            //•	On the first input line - lost games count – integer in the range[0, 1000].
            //•	On the second line – headset price - the floating - point number in the range[0, 1000].
            //•	On the third line – mouse price - the floating - point number in the range[0, 1000].
            //•	On the fourth line – keyboard price - the floating - point number in the range[0, 1000].
            //•	On the fifth line – display price - the floating - point number in the range[0, 1000].
            //Output
            //•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv."

            //input
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            //add-ons
            int keyboardTrashedCounter = 0;
            double expenses = 0;
            //Every second lost game, Petar trashes his headset.
            //Every third lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.

            for (int i = 1; i <= lostGames; i++)
            {
                if(i % 2 == 0)
                {
                    expenses += headsetPrice; //When i%2 ==0 we add the headsetPrice, as well when it's divisble by 2 - 
                                              

                }
                if (i % 3 == 0)
                {
                    expenses += mousePrice; // When i %3==0 we add the mousePrice
                }
                if (i % 6 == 0)
                {
                    expenses += keyboardPrice;// When i%6==0 we add headsetPrice + mousePrice+keyboardPrice to the expenses
                }
                if (i % 12 == 0)
                {
                    expenses += displayPrice;//When i%12==0 we add headsetPrice+mousePrice+keyboardPrice+displayPrice to the                                 expenses
                }
            }

            //Output
            //•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv."
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");


        }
    }
}
