using System.CodeDom.Compiler;
using System.Dynamic;

namespace FoodShortage.Models.Interfaces
{

    public interface IBuyer
    {
        string Name { get; set; }

        void BuyFood();

        int Food { get; set; }
    }
}
