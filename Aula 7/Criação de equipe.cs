using System;
using System.Diagnostics;
class HelloWorld
{
    static string nomeEquipe;
    static string nome1, nome2, nome3, nome4, nome5;
    static string poder1, poder2, poder3, poder4, poder5, poderInteg1, poderInteg2, poderInteg3;
    static int pontos1, pontos2, pontos3, pontos4, pontos5;
    static int pontosInteg1, pontosInteg2, pontosInteg3, pontostotais;
    static string integrante1, integrante2, integrante3;

    static void cadastroHerois()
    {
        //cadastro heroi 1
        Console.WriteLine("digite seu nome, heroi");
        nome1 = Console.ReadLine();
        Console.WriteLine("digite seu super poder");
        poder1 = Console.ReadLine();
        Console.WriteLine("digite sua quantidade de pontos");
        pontos1 = int.Parse(Console.ReadLine());

        Console.WriteLine("deseja cadastrar mais herois? (1)sim (2)nCo");
        byte continuar = byte.Parse(Console.ReadLine());

        if (continuar == 1) //cadastro heroi 2
        {
            Console.WriteLine("digite seu nome, heroi");
            nome2 = Console.ReadLine();
            Console.WriteLine("digite seu super poder");
            poder2 = Console.ReadLine();
            Console.WriteLine("digite sua quantidade de pontos");
            pontos2 = int.Parse(Console.ReadLine());

            Console.WriteLine("deseja cadastrar mais herois? (1)sim (2)nao");
            byte continuar2 = byte.Parse(Console.ReadLine());

            if (continuar2 == 1) //cadastro heroi 3
            {
                Console.WriteLine("digite seu nome, heroi");
                nome3 = Console.ReadLine();
                Console.WriteLine("digite seu super poder");
                poder3 = Console.ReadLine();
                Console.WriteLine("digite sua quantidade de pontos");
                pontos3 = int.Parse(Console.ReadLine());

                Console.WriteLine("deseja cadastrar mais herois? (1)sim (2)nao");
                byte continuar3 = byte.Parse(Console.ReadLine());

                if (continuar3 == 1)// cadastro heroi 4
                {
                    Console.WriteLine("digite seu nome, heroi");
                    nome4 = Console.ReadLine();
                    Console.WriteLine("digite seu super poder");
                    poder4 = Console.ReadLine();
                    Console.WriteLine("digite sua quantidade de pontos");
                    pontos4 = int.Parse(Console.ReadLine());

                    Console.WriteLine("deseja cadastrar mais herois? (1)sim (2)nao");
                    byte continuar4 = byte.Parse(Console.ReadLine());

                    if (continuar4 == 1)
                    {
                        Console.WriteLine("digite seu nome, heroi");
                        nome5 = Console.ReadLine();
                        Console.WriteLine("digite seu super poder");
                        poder5 = Console.ReadLine();
                        Console.WriteLine("digite sua quantidade de pontos");
                        pontos5 = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        //codigo penta
                    }
                }
                else
                {
                    //codigo quad
                }


            }
            else
            {
                //codigo duo
            }
        }

        else
        {
            //fazer codigo solo
        }

        return;
    }

    static void selecionarEquipe()
    {
        Console.WriteLine("Digite o nome da sua equipe");
        nomeEquipe = Console.ReadLine();

        Console.WriteLine("Selecione 3 herois para criar sua equipe sua equipe");

        Console.WriteLine($"(1) {nome1} seu poder é {poder1} e possui {pontos1} pontos");
        Console.WriteLine($"(2) {nome2} seu poder é {poder2} e possui {pontos2} pontos");
        Console.WriteLine($"(3) {nome3} seu poder é {poder3} e possui {pontos3} pontos");
        Console.WriteLine($"(4) {nome4} seu poder é {poder4} e possui {pontos4} pontos");
        Console.WriteLine($"(5) {nome5} seu poder é {poder5} e possui {pontos5} pontos");

        Console.WriteLine($"digite o numero do primeiro membro:");
        int escolha1 = int.Parse(Console.ReadLine());
        switch (escolha1)
        {
            case 1:
                integrante1 = nome1;
                break;
            case 2:
                integrante1 = nome2;
                break;
            case 3:
                integrante1 = nome3;
                break;
            case 4:
                integrante1 = nome4;
                break;
            case 5:
                integrante1 = nome5;
                break;
            default:
                Console.WriteLine("invalido");
                break;
        }
        Console.WriteLine($"o primeiro integrante da equipe é {integrante1}");

        Console.WriteLine($"digite o numero do segundo membro:");
        int escolha2 = int.Parse(Console.ReadLine());
        switch (escolha2)
        {
            case 1:
                integrante2 = nome1;
                break;
            case 2:
                integrante2 = nome2;
                break;
            case 3:
                integrante2 = nome3;
                break;
            case 4:
                integrante2 = nome4;
                break;
            case 5:
                integrante2 = nome5;
                break;
            default:
                Console.WriteLine("invalido");
                break;
        }
        Console.WriteLine($"o segundo integrante da equipe é {integrante2}");

        Console.WriteLine(" ");

        Console.WriteLine($"digite o numero do primeiro membro:");
        int escolha3 = int.Parse(Console.ReadLine());
        switch (escolha3)
        {
            case 1:
                integrante3 = nome1;
                break;
            case 2:
                integrante3 = nome2;
                break;
            case 3:
                integrante3 = nome3;
                break;
            case 4:
                integrante3 = nome4;
                break;
            case 5:
                integrante3 = nome5;
                break;
            default:
                Console.WriteLine("invalido");
                break;
        }
        Console.WriteLine($"o terceiro integrante da equipe é {integrante3}");
        Console.WriteLine(" ");



    }
    static void pontuacao()
    {

        // pontos integrante 1 --------------------------
        if (integrante1 == nome1)
        {
            pontosInteg1 = pontos1;
        }

        else if (integrante1 == nome2)
        {
            pontosInteg1 = pontos2;
        }

        else if (integrante1 == nome3)
        {
            pontosInteg1 = pontos3;
        }

        else if (integrante1 == nome4)
        {
            pontosInteg1 = pontos4;
        }

        else if (integrante1 == nome5)
        {
            pontosInteg1 = pontos5;
        }

        // pontos integrante 2 --------------------------
        if (integrante2 == nome1)
        {
            pontosInteg2 = pontos1;
        }

        else if (integrante2 == nome2)
        {
            pontosInteg2 = pontos2;
        }

        else if (integrante2 == nome3)
        {
            pontosInteg2 = pontos3;
        }

        else if (integrante2 == nome4)
        {
            pontosInteg2 = pontos4;
        }

        else if (integrante2 == nome5)
        {
            pontosInteg2 = pontos5;
        }

        // pontos integrante 3 --------------------------
        if (integrante3 == nome1)
        {
            pontosInteg3 = pontos1;
        }

        else if (integrante3 == nome2)
        {
            pontosInteg3 = pontos2;
        }

        else if (integrante3 == nome3)
        {
            pontosInteg3 = pontos3;
        }

        else if (integrante3 == nome4)
        {
            pontosInteg3 = pontos4;
        }

        else if (integrante3 == nome5)
        {
            pontosInteg3 = pontos5;
        }

        pontostotais = pontosInteg1 + pontosInteg2 + pontosInteg3;


        // poder integrante 1 --------------------------
        if (integrante1 == nome1)
        {
            poderInteg1 = poder1;
        }

        else if (integrante1 == nome2)
        {
            poderInteg1 = poder2;
        }

        else if (integrante1 == nome3)
        {
            poderInteg1 = poder3;
        }

        else if (integrante1 == nome4)
        {
            poderInteg1 = poder4;
        }

        else if (integrante1 == nome5)
        {
            poderInteg1 = poder5;
        }

        //poder integrante 2 --------------------------
        if (integrante2 == nome1)
        {
            poderInteg2 = poder1;
        }

        else if (integrante2 == nome2)
        {
            poderInteg2 = poder2;
        }

        else if (integrante2 == nome3)
        {
            poderInteg2 = poder3;
        }

        else if (integrante2 == nome4)
        {
            poderInteg2 = poder4;
        }

        else if (integrante2 == nome5)
        {
            poderInteg2 = poder5;
        }

        // poder integrante 3 --------------------------
        if (integrante3 == nome1)
        {
            poderInteg3 = poder1;
        }

        else if (integrante3 == nome2)
        {
            poderInteg3 = poder2;
        }

        else if (integrante3 == nome3)
        {
            poderInteg3 = poder3;
        }

        else if (integrante3 == nome4)
        {
            poderInteg3 = poder4;
        }

        else if (integrante3 == nome5)
        {
            poderInteg3 = poder5;
        }

        pontostotais = pontosInteg1 + pontosInteg2 + pontosInteg3;
    }

    static void exibirEquipe()
    {
        Console.WriteLine($"Sua equipe se chama {nomeEquipe} será formada com {integrante1}, {integrante2} e {integrante3}");
        Console.WriteLine($"Seus poders são: {poderInteg1}, {poderInteg2}, {poderInteg3}");
        Console.WriteLine($"A pontuação total da sua equipe é {pontostotais}");
    }

    static void menu()
    {
        int continuar = 0;
        do
        {
            Console.WriteLine("(1) Cadastro");
            Console.WriteLine("(2) Formacao de equipe");
            Console.WriteLine("(3) exibir equipe");
            Console.WriteLine("(4) sair");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    cadastroHerois();
                    break;

                case 2:
                    selecionarEquipe();
                    break;

                case 3:
                    pontuacao();
                    exibirEquipe();
                    break;

                case 4:
                    Console.WriteLine("obrigado");
                    continuar = 1;
                    break;
            }
        } while (continuar == 0);
    }


    static void Main()
    {
        Console.WriteLine("Bem Vindo ao criador de equipes MARVEL");
        Console.WriteLine("Cadastre até 5 herois e forme uma equipe com no maximo 3 deles!");
        menu();
    }
}