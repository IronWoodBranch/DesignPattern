// See https://aka.ms/new-console-template for more information
using AdapterPattern;
using AdapterPattern.Implementation;

WildTurkey turkey = new WildTurkey();
TurkeyAdapter ta = new TurkeyAdapter(turkey);

turkey.gobble();
turkey.fly();

//这里是重点，已经能够quack了
ta.quack();
ta.fly();