// See https://aka.ms/new-console-template for more information
using TemplateMethod;

Console.WriteLine("Hello, World!");
CoffeeWithHook coffee = new CoffeeWithHook();
TeaWithHook tea = new TeaWithHook();
coffee.prepareRecipe();
tea.prepareRecipe();