namespace SimpleFactory
{
    public class Program
    {

        static void Main(string[] args)
        {
            PizzaStore store = new PizzaStore();
            store.ServeOrder("PineapplePizza");
           
        }
    }
}
