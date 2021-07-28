using System;

namespace Função
{
    /*class Program2
    { 
        static void Main(string[] args)
        {
            Program.
            var pg = new Program();
        }
    }*/
    class Program
    {
        static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }
        static int soma(int x, int y)
        {
            return x + y;
        }
        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Olá pessoal");
        }

        public static void Tabuada(int num)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularSoma());
            Console.WriteLine(soma(10, 5));
            MostrarMensagemNaTela();
            Tabuada(5);
        }
    }
}
