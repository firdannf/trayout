using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masukan nilai harian:");
            int nilaiharian = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukan nilai UTS:");
            int nilaiuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukan nilai UAS:");
            int nilaiuas = Convert.ToInt32(Console.ReadLine());

            double nilairatarata = hitungratarata(nilaiharian, nilaiuts, nilaiuas);
            string predikat = hitungpredikat(nilairatarata);
            Console.WriteLine("");
            Console.WriteLine("======================================================");
            Console.WriteLine("======================================================");
            Console.WriteLine("masukan nilai harian:" + nilaiharian);
            Console.WriteLine("masukan nilai UTS:" + nilaiuts);
            Console.WriteLine("masukan nilai UAS:" + nilaiuas);
            Console.WriteLine("nilai rata rata nya adalah :" + nilairatarata);
            Console.WriteLine("predikat nilai nya adalah : " + predikat);
            Console.WriteLine("======================================================");
            Console.WriteLine("======================================================");
        }
        static double hitungratarata(int harian, int uts, int uas)
        {
            return (uts + harian + uas) / 3.0;
        }

        static string hitungpredikat(double nilai)
        {
            if (nilai >= 80)
            {
                return "A";
            }
            else if (nilai >= 70 && nilai < 80)
            {
                return "B";
            }
            else if (nilai >= 60 && nilai < 70)
            {
                return "C";
            }
            else if (nilai >= 50 && nilai < 60)
            {
                return "D";
            }
            else
            {
                return "E";
            }
        }
       
    }
}
