using System;

namespace oop_lab_2
{
    class CPU
    {
        public string Number, Segment;
        public int Core, Year;
        public double BFrequency, TFrequency;
        public bool HyperT;

        public int GetNumberOfThreads()
        {
            if (HyperT == true) return (Core * 2);
            else return (Core);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Номер процесора: ");
            string sNumber = Console.ReadLine();

            Console.Write("Кількість ядер: ");
            string sCore = Console.ReadLine();

            Console.Write("Рiк випуску: ");
            string sYear = Console.ReadLine();

            Console.Write("Базова частота: ");
            string sBFrequency = Console.ReadLine();

            Console.Write("Максимальна частота: ");
            string sTFrequency = Console.ReadLine();

            Console.Write("Чи є підтримка Hyper-Threading? (y-так, n-нi): ");
            ConsoleKeyInfo keyHyperT = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Вертикальний сегмент(m-Mobile, d-Desktop): ");
            ConsoleKeyInfo keySegment = Console.ReadKey();

            CPU OurCPU = new CPU();

            OurCPU.Number = sNumber;
            OurCPU.Core = int.Parse(sCore);
            OurCPU.Year = int.Parse(sYear);
            OurCPU.BFrequency = double.Parse(sBFrequency);
            OurCPU.TFrequency = double.Parse(sTFrequency);
            OurCPU.HyperT = keyHyperT.Key == ConsoleKey.Y ? true : false;
            OurCPU.Segment = keySegment.Key == ConsoleKey.D ? "Desktop" : "Mobile";
            int NumberOfThreads = OurCPU.GetNumberOfThreads();

            Console.WriteLine(
            "\n__________________________" +
            "\n     Дані про об’єкт" +
            "\n__________________________" +
            "\nНазва: " + OurCPU.Number +
            "\nСегмент: " + OurCPU.Segment +
            "\nЯдер: " + OurCPU.Core +
            "\nКількість потоків: " + NumberOfThreads +
            "\nРік випуску: " + OurCPU.Year.ToString() +
            "\nБазова частота: " + OurCPU.BFrequency.ToString("0.00") +
            "\nМаксимальна частота: " + OurCPU.TFrequency.ToString("0.00") +

            (OurCPU.HyperT ? "\nЄ підтримка Hyper-Threading" :
                             "\nНемає підтримки Hyper-Threading"));

            Console.ReadKey();
        }
    }
}
