﻿namespace jogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

             string[] frutas = [
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            ];

            while (true)
            {
                Random geradorDeNumeros = new Random();

                int indicePalavraEscolhida = geradorDeNumeros.Next(frutas.Length);

                string palavraSecreta = frutas[indicePalavraEscolhida];

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                    //acessar o array no indice 0
                    letrasEncontradas[caractere] = '_';


                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicadaPalavra = String.Join(" ", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("--------------------------------------");

                    if (quantidadeErros == 0)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 1)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 2)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 3)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                 ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (quantidadeErros == 5)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /x\\      ");
                        Console.WriteLine(" |         x        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |        ---       ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }



                    Console.WriteLine("--------------------------------------");


                    Console.WriteLine("Palavra secreta: " + dicadaPalavra);
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Quantidade de erros: " + quantidadeErros);
                    Console.WriteLine("--------------------------------------");

                    Console.Write("Digite uma letra: ");

                    char chute = Console.ReadLine()!.ToUpper()[0]; //obtém apenas  caractere do que o usuário digita

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                        char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                        
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

                    dicadaPalavra = String.Join(" ", letrasEncontradas);

                    jogadorAcertou = dicadaPalavra.Replace(" ", "") == palavraSecreta;
                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta! Era: " + palavraSecreta);
                        Console.WriteLine("--------------------------------------");
                    }

                    else if (jogadorEnforcou)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Jogo da Forca");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O        ");
                        Console.WriteLine(" |        /|\\      ");
                        Console.WriteLine(" |         |        ");
                        Console.WriteLine(" |        / \\      ");
                        Console.WriteLine(" |        ---       ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Que azar, tente novamente! A palavra era: " + palavraSecreta);
                        Console.WriteLine("--------------------------------------");
                    }

                } while (jogadorAcertou == false && jogadorEnforcou == false);

                Console.ReadLine();

            }
        }    
    }
}
