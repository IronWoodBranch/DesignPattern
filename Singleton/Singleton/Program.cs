namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ins = Singleton.getSingleInstance();
            //cannot create an instance by constructor directly cuz' it's private
            //var b = new Singleton();
            ins.testMethod();
            Console.ReadKey();
        }
    }
}
