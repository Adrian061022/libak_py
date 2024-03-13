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

        static void Kiir_eredmenyek(int roka_liba_suly, double roka_atlag, string volt_harom)
        {

            Console.WriteLine($"A roka libáinak súlya: {roka_liba_suly}kg.");
            Console.WriteLine($"A roka libáinak súlyának átlaga: {roka_atlag}kg.");
            Console.WriteLine($" {volt_harom} olyan, hogy a róka leglabb harmokilos libat lopott.");

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

        static int Megszamolas(int[] l) {

            int db = 0;
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i] <= 3) {

                    db++;
                }

            }
            return db;
        
        }

        static bool Eldontes(int[] l)
        {

            bool van = false;
            int i = 0;
            while (i<l.Length && !(l[i]>=3))
            {
                if (i<l.Length)
                {

                    van = true;

                }
               
            }
            return van;

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
            //a
            int hany_kilo_libat_ehet_meg_a_roka = Osszegez(libak);
            double atlagos_suly = Atlag_suly(libak);
            //b
            int hany_db_libat_ehet_meg_a_roka = Megszamolas(libak);
            double rokanal_maradt_libak_atlaga = (double)hany_kilo_libat_ehet_meg_a_roka / hany_db_libat_ehet_meg_a_roka;
            //c1
            bool volt_legalabb_harom_kilos_liba = Eldontes(libak);
            string volt_legalabb_harom_kilos_liba_szoveg = "Nem fordult elő";
            if (volt_legalabb_harom_kilos_liba)
            {
                volt_legalabb_harom_kilos_liba_szoveg = "Előfordult";
            }
            
            Kiir(libak, "libak sullyai");
            Kiir_eredmenyek(hany_kilo_libat_ehet_meg_a_roka, hany_kilo_libat_ehet_meg_a_roka, volt_legalabb_harom_kilos_liba_szoveg);
            

            Console.WriteLine(atlagos_suly);
            Console.WriteLine("Nyomj egy billentyűt");
            Console.ReadKey(true);
        }
    }
}