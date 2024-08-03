// See https://aka.ms/new-console-template for more information
using StatePattern;

Console.WriteLine("Hello, World!");

GumballMachine gm = new GumballMachine(5);
gm.insertQuarters();
gm.ejectQuarters();

Console.WriteLine(gm.state);
gm.insertQuarters();
gm.truncrank();