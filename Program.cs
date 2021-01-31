using System;
using System.Threading.Tasks;

namespace Sortowanie
{
    class Program
    {
        static void Sortuj(int[] tab)
        {
            int n = tab.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }

         static void Main(string[] args)
        {
            int[] tab = new int[100];
            var rand = new Random();

            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Wygenerowane liczby: ");
            Console.ResetColor();

            for (int i = 0; i < 100; i++)
            {
                tab[i] = rand.Next();

                System.Console.Write(tab[i]);
                System.Console.Write(", ");
            }

            System.Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Wpisz liczbę 1 aby posortować lub inną aby wyjść: ");
            Console.ResetColor();
            int wybor = Convert.ToInt32(Console.ReadLine());
 
            if (wybor == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Posortowane liczby: ");
                Console.ResetColor();

                Task t = Task.Run(() => Sortuj(tab));
                t.Wait();

                for (int i = 0; i < 100; i++)
                {
                    System.Console.WriteLine(tab[i]);
                }
                System.Console.WriteLine("____________________");
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
