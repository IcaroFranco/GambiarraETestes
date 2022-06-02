using System;

namespace ConsoleAppSoma
{
    public class ProgramTeste
    {
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 1;

            Soma(n1,n2);
        }

        //public static void Tabuada(int numero)
        //{

        //    Console.WriteLine("\n      Tabuada do " + numero + "\n");

        //    for(int i = 1; i<=10; i++)
        //    {
        //        Console.WriteLine("      " + numero + " x " + i + " = " + (numero * i));
        //    }

        //    Linha();
        //}
        //public static void TabuadaInvertida(int numero)
        //{

        //    Console.WriteLine("\n      Tabuada Invertida do " + numero + "\n");

        //    for (int i = 10; i >= 1; i--)
        //    {
        //        Console.WriteLine("      " + numero + " x " + i + " = " + (numero * i));
        //    }

        //    Linha();
        //}
        //public static void Linha()
        //{
        //        Console.WriteLine("\n------------------------ Line ------------------------");
        //        Console.WriteLine("------------------------------------------------------ \n");
        //}
    }
}
