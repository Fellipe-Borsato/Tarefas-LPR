using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("digite um numero para saber se ele é par ou não");
    int num = int.Parse(Console.ReadLine());
    
    if (num == 0)
    {
        Console.WriteLine("zero é nulo");
    }
    
    else
    {
        
    switch (num%2)
    {
        case 0:  Console.WriteLine($"{num} é par!");
        break;
        
        default: Console.WriteLine($"{num} é ímpar!");
        break;
    }
    
    }
  }
}