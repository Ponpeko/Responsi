using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("12345", "Sigit Gutomo", 5000000);
            Karyawan karyawan2 = new Karyawan("44321", "Abdul Azis", 4000000);

            Console.WriteLine("No NIK \t\t Nama \t\tGaji Bulanan");
            Console.WriteLine("----------------------------------------");

            karyawan1.printData(1);
            karyawan2.printData(2);

            Console.WriteLine("\n\nAsyiiiik Kenaikan Gaji 10% !!!\n");

            Console.WriteLine("No NIK \t\t Nama \t\tGaji Bulanan");
            Console.WriteLine("----------------------------------------");

            karyawan1.naikGaji();
            karyawan2.naikGaji();

            karyawan1.printData(1);
            karyawan2.printData(2);
        }   
    }
}
