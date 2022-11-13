namespace SOLID
{

    public class Program
    {
        static void Main(string[] args)
        {
            /* SOLID PRINCIPLES
             1.|S|ingle Responsibility.
             2.|O|pen/Closed
             3.|L|iskov Subtitution
             4.|I|nterface Segreagation
             5.|D|ependancy Inversion*/

            //1.1 Every class should be responsible for only a single part of the functionality and that responsibility should be entirely encapsulated by the class.

            //2.1. Software entities like classes, modules and functions should be open for extension BUT closed for modification.

            //3.1. Derived types must be completely subtituable for their base type ->The Child class must subtitute the Parent class

            //4.1. The clients should NOT be forced to depend on methods it does NOT use. Segregate to smaller and more specific ones.

            //5.1 DIP states high-level modules SHOULD NOT depend on low-level modules. They both depend on the ABSTRACTION.
            // Abstraction SHOULD NOT depend on details. The details DEPEND on abstraction.

            //5.2 BREAK - DOWN:
            //5.2.1. Client - Your Main class/Abstraction that runs the High-lvl module.
            //5.2.2. High-level Modules: Interfaces/Abstraction that your client uses.
            //5.2.3. Low-level Modules: Details of your interface or abstraction

            //5.3 Simple Example - You have a car.
            //5.3.1. Client - You as the person driving the car.
            //5.3.2. High-level Modules:The steering wheel and the gas/brake pedals.
            //5.3.3. Low-level Modules: The Engine
        }
    }
}
