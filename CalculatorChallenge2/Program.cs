using System;

namespace CalculatorChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka dan operator: ");
            decimal pertama = 0m, kedua = 0m, hasil = 0m;
            while (true)
            {
                string input = Console.ReadLine();

                if (input.EndsWith("="))
                {
                    string hitung = input.Remove(input.Length - 1);
                    char[] symbol = { '+', '-', '*', '/', ':' };
                    int PosisiSymbol = input.IndexOfAny(symbol);
                    char operasi = input[PosisiSymbol];
                    string[] angka = hitung.Split(operasi);

                    if (PosisiSymbol > 0)
                    {
                        angka = hitung.Split(operasi);
                        pertama = decimal.Parse(angka[0]);
                        kedua = decimal.Parse(angka[1]);
                    }
                    else
                    {
                        pertama = hasil;
                        angka = hitung.Split(operasi);
                        kedua = decimal.Parse(angka[1]);
                    }

                    switch (operasi)
                    {
                        case '+':
                            hasil = pertama + kedua;
                            Console.Write($"{pertama} + {kedua} = {hasil}");
                            break;
                        case '-':
                            hasil = pertama - kedua;
                            Console.Write($"{pertama} - {kedua} = {hasil}");
                            break;
                        case '*':
                            hasil = pertama * kedua;
                            Console.Write($"{pertama} * {kedua} = {hasil}");
                            break;
                        case '/':
                        case ':':
                            hasil = pertama / kedua;
                            Console.Write($"{pertama} {operasi} {kedua} = {hasil}");
                            break;
                    }
                }
                else Console.WriteLine("Tambahkan symbol \"=\" di akhir");
            }
        }
    }
}