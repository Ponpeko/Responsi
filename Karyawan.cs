using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi1
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set;}
        public int GajiBulanan { get; set; }

        public Karyawan (string nik, string nama, int gajiBulanan)
        {
            Nama = nama;
            NIK = nik;
            GajiBulanan = gajiBulanan;

            if(gajiBulanan < 0)
            {
                gajiBulanan = 0;
            }
        }

        public void naikGaji()
        {
            GajiBulanan = GajiBulanan + (GajiBulanan * 10 / 100);
        }

        public void printData(int no)
        {
            Console.WriteLine(no + ". {0} \t{1} \t{2}", NIK, Nama, GajiBulanan);
        }
    }

}
