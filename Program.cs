using System;

namespace ejercicios
{
    class Program
    {
        static int num;
        static void Main(string[] args)
        {
            Console.WriteLine("Dame base del triángulo: ");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                tri(num);
            }
            else
                Console.WriteLine("Número inválido.");
        }
        static void tri(int val)
        {
            String cade = "";
            int lim = val, aux = 1;
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < lim; j++)
                {
                    cade += " ";
                }
                for (int j = 0; j < aux; j++)
                {
                    cade += "1 ";
                }
                Console.WriteLine($"{cade}");
                cade = "";
                aux++;
                lim--;
            }
        }
    }
}