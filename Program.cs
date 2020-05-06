using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
// Compiler version 4.0, .NET Framework 4.5


namespace PrinterWindows
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrinterWindows printer = new PrinterWindows();



            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet");

            Console.Write("Pilih Printer [1.2.3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            if (pilihPrinter > 0 && pilihPrinter < 4)
            {
                if (pilihPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (pilihPrinter == 2)
                {
                    printer = new Canon();
                }
                else
                {
                    printer = new LaserJet();
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak tersedia \n");
            }



            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }

    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
    }

    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printer Epson dimension: 10 * 11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }


    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }

    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printer LaserJet dimension: 12 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing ...");
        }
    }


}