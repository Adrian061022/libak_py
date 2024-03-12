using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libak
{
    class Program
    {
        static void Kiir(int[] t, string cim)
        {
            Console.WriteLine(cim);
            foreach (int szam in t)
            {
                Console.Write($"{szam}, ");
            }
            Console.WriteLine();
        }

        static int Osszegez(int[] t)
        {
            int osszeg = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    osszeg += t[i];
                }
            }
            return osszeg;
        }

        static void Kiir_eredmenyek(int roka_liba_suly)
        {

            Console.WriteLine($"A roka libáinak súlya: {roka_liba_suly}kg.");

        }
        static double Atlag_suly(int[] t)
        {
            int osszeg = 0;
            int darab = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    osszeg += t[i];
                    darab++;
                }
            }

            if (darab == 0)
            {
                return 0;
            }
            else
            {
                return (double)osszeg / darab;
            }



        }
        static void Main(string[] args)
        {

            /*
             * LIBÁK

            A róka libát lop a faluból. A libák súlyát – pontosabban tömegét – listában adjuk meg. A farkas a dűlőútnál várja a rókát, és a három kilónál nagyobb libákat elveszi – a piciket nagylel�kűen otthagyja a rókának.
            libak = [1,5,2,3,4]

            a. Hány kiló libát ehet meg a róka?
            b. Átlagosan hány kilósak a rókának maradt libák?
            c1. Előfordult-e olyan, hogy a róka legalább háromkilós libát lopott?
            c2. Előfordult-e olyan, hogy a róka kisebb libát hozott, mint az előző napon?
            d. Hányadik napon sikerült a rókának először legalább háromkilós libát lopnia?
            e. Melyik a róka első legalább háromkilós libája?
            f. Hány libát tarthat meg a róka?
            g. Mekkora a legkisebb liba, amit a farkas elvesz a rókától?

             */

            int[] libak = { 1, 5, 2, 3, 4 };
            Kiir(libak, "libak sullyai");
            int hany_kilo_libat_ehet_meg_a_roka = Osszegez(libak);
            Kiir_eredmenyek(hany_kilo_libat_ehet_meg_a_roka);
            double atlagos_suly = Atlag_suly(libak);
            Console.WriteLine(atlagos_suly);
            Console.WriteLine("Nyomj egy billentyűt");
            Console.ReadKey(true);
        }
    }
}