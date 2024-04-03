using System;
class HelloWorld {
  static void Main() {
      
      float media;
      int num;
      int quantnum;
      int contador = 0;
      float total=0;
      int quantnumpar = 0;
      
    Console.WriteLine("digite quantos numeros serão digitados");
    quantnum = int.Parse(Console.ReadLine());
    
   
     while (contador < quantnum)
      {
           Console.WriteLine("digite um numero");
           num = int.Parse(Console.ReadLine());
           
           if (num%2==0)
           {
               total = total + num;
               quantnumpar++;
           }
           contador++;
          
      }
 
     media = total/quantnumpar;
     

     Console.WriteLine($"a media é: {media}" );
  }
}