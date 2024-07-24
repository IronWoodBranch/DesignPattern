// See https://aka.ms/new-console-template for more information
using CommandPattern;
using CommandPattern.command;
using CommandPattern.VendorProducts;

Console.WriteLine("Hello, World!");

//从客户端通知Invoker
SimpleRemoteControl src = new SimpleRemoteControl();

LightOnCommand light = new LightOnCommand(new Light());

src.setCommand(light);
src.buttonWasPressed();
