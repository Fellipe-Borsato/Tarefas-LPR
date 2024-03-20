using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Bem vindo, escolha sua classe");
    Console.WriteLine("Mago(1), Guerreiro(2), Arqueiro (3), Samurai (4)");
    int classe = int.Parse(Console.ReadLine());
    
    switch (classe)
    {
        case 1: Console.WriteLine("Voce é um mago, suas habilidades são: Bola de Fogo, Escudo de Gelo");
        Console.WriteLine("Suas habilidades consomem pontos de Mana");
        break;
        
        case 2: Console.WriteLine("Voce é um Guerreiro, suas habilidades são: Ataque Pesado, Defesa Total");
        Console.WriteLine("Suas habilidades precisam de pontos de força para serem usadas");
        break;
        
        case 3: Console.WriteLine("Voce é um Arqueiro, suas habilidades são: Flecha Precisa, Disparo Triplo");
        Console.WriteLine("Suas habilidades precisam de pontos de intelçigencia e destreza para serem usadas");
        break;
        
         case 4: Console.WriteLine("Voce é um Samurai, suas habilidades são: Corte rápido, Esquiva");
        Console.WriteLine("Suas habilidades precisam de pontos de destreza para serem usadas");
        break;
        
        default:Console.WriteLine("Classe inválida.");
        break;
    }
  }
}