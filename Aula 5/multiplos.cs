using System;
class Helloworld {
    static void Main() {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 % num2 == 0 || num2 % num1 == 0) 
        {
            Console.WriteLine($"{num1} e {num2} são Múltiplos");
        } 
        
        else
        {
            Console.WriteLine($"{num1} e {num2} não são Múltiplos");
        }
    }
}
