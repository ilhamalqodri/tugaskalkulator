using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi kalkulator";
            
            Console.Write("plh Menu kalkulator : ");
            Console.WriteLine();
            Console.Write("1. Penjumlahan");
            Console.WriteLine();
            Console.Write("2. Pengurangan");
            Console.WriteLine();
            Console.Write("3. Perkalian");
            Console.WriteLine();
            Console.Write("4. Pembagian");
            Console.WriteLine();
            lagi:
            Console.Write("Inputkan nomor menu : ");
            int plh = int.Parse(Console.ReadLine());
            if(plh >= 1 && plh <= 4)
            {
            Console.Write("Inputkan nilai a = ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (plh == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + "+" + b + "-" + Penambahan(a, b));
              
            }
            else if (plh == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
               
            }
           else if (plh == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            
            }
            else if (plh == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
        }
        else
        {
            Console.WriteLine("\nInput anda salah, mohon ulangi... (input 1-4)");
            goto lagi;
        }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
            
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
