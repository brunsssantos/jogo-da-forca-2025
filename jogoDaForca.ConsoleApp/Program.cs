namespace jogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    //acessar o array no indice 0
                    letrasEncontradas[caractere] = '_';
                }

                string dicadaPalavra = String.Join(" ", letrasEncontradas);

                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Palavra secreta: " + dicadaPalavra);
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Digite uma letra: ");

                char chute = Console.ReadLine()[0]; //obtémapenas  caractere do que o usuário digita

                Console.WriteLine(chute);
                Console.ReadLine();

            }
        }    
    }
}
