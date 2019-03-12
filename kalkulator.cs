using System;

namespace CalculatorConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            //int a = 10;
            //int b = 6;
            Console.Write("Pilih Menu Calculator : ");
            Console.WriteLine();
            Console.Write("1. Penjumlahan");
            Console.WriteLine();
            Console.Write("2. Pengurangan");
            Console.WriteLine();
            Console.Write("3. Perkalian");
            Console.WriteLine();
            Console.Write("4. Pembagian");
            Console.WriteLine();
            Console.Write("Inputkan nomor menu : ");
            int pilih = int.Parse(Console.ReadLine());
            Console.Write("Inputkan nilai a = ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (pilih == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + "+" + b + "-" + Penambahan(a, b));
              
            }
            else if (pilih == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
               
            }
           else if (pilih == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            
            }
            else if (pilih == 4){
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
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
