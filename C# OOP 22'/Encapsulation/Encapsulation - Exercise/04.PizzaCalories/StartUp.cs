namespace _04.PizzaCalories
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            //test 2 input
            //Pizza Meatfull
            //Dough White cheWy 200
            //Topping Meat 50
            //Topping Cheese 50
            //Topping meat 20
            //Topping sauce 10
            //Topping Meat 30
            //END

            try 
            {
                //here might be an error when using SplitOption.RemoveEmptySpaces 
                var pizzaInput = Console.ReadLine()
                    .Split(" ");

                var doughInput = Console.ReadLine()
                    .Split(" ");

                Dough dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));

                Pizza pizza = new Pizza(pizzaInput[1], dough);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    var toppingInput = command.Split(" ");
                    Toppings topping = new Toppings(toppingInput[1], double.Parse(toppingInput[2]));

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
