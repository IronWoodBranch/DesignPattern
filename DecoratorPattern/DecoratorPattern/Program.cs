using DecoratorPattern.beverageImp;
using DecoratorPattern.condimentsImp;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlackRoast br = new BlackRoast();
            Milk milk = new Milk(br);
            Soy soy = new Soy(milk);
            Console.WriteLine(soy.cost());
        }
    }
}
