using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1b
{
    class PagrindineKlase
    {
        static void Main(string[] args)
        {
            double[] Masyvas;
            MasyvasIO NMasyvasIO = new MasyvasIO();
            Rikiavimas NRikiavimas = new Rikiavimas();
            ApdorokMasyva NApdorokMasyva = new ApdorokMasyva();

            Masyvas = NMasyvasIO.Pildyk();
            Masyvas = NApdorokMasyva.ApdorokMasyvaa(Masyvas);
            Console.WriteLine();
            Console.WriteLine("Nerikiuotas masyvas: ");
            NMasyvasIO.Spausdink(Masyvas);
            Console.WriteLine();
            Console.WriteLine("Didejimo tvarka rikiuotas masyvas: ");
            Masyvas = NRikiavimas.RikiuokD(Masyvas);
            NMasyvasIO.Spausdink(Masyvas);
            Console.WriteLine();
            Console.WriteLine("Mazejimo tvarka rikiuotas masyvas: ");
            Masyvas = NRikiavimas.RikiuokM(Masyvas);
            NMasyvasIO.Spausdink(Masyvas);



            //Console.WriteLine(Masyvas.Length);
            Console.ReadLine();
        }
    }

    public class MasyvasIO
    {
        public double[] Pildyk()
        {
            Console.Write("Masyvo elementu skaicius: ");

            int ilgis = Convert.ToInt32(Console.ReadLine());


            double[] masyvas = new double[ilgis];
            Console.WriteLine("Masyvo elementai: ");
            for (int i = 0; i < ilgis; i++)
            {
                Console.Write(i + 1 + " masyvo elementas: ");
                if (!double.TryParse(Console.ReadLine(), out masyvas[i]))
                {
                    // .. error with input
                }
            }

            return masyvas;
        }

        public void Spausdink(double[] masyvas)
        {
            Console.WriteLine();
            Console.WriteLine("Masyvo elementai: ");
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine(i + 1 + " masyvo elementas: " + masyvas[i]);
            }
        }
    }
    public class Rikiavimas
    {
        public double[] RikiuokD(double[] masyvas)
        {
            Array.Sort<double>(masyvas);
            return masyvas;
        }
        public double[] RikiuokM(double[] masyvas)
        {
            Array.Sort<double>(masyvas);
            Array.Reverse(masyvas);
            return masyvas;
        }
    }
    public class ApdorokMasyva
    {
        public double[] ApdorokMasyvaa(double[] masyvas)
        {
            int kiek;
            kiek = 0;


            for (int i = 0; i < masyvas.Length; i++)
            {
                for (int j = i + 1; j < masyvas.Length; j++)
                {
                    if (masyvas[i] == masyvas[j])
                    {
                        masyvas[j] = 0;
                    }
                }
            }
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] == 0)
                {
                    kiek++;
                }
            }
            double[] nmasyvas = new double[masyvas.Length - kiek];
            if (kiek == 0)
            {
                Console.WriteLine("Masyve nera pasikartojanciu skaiciu");
            }
            else
            {
                int x = 0;
                for (int i = 0; i < masyvas.Length; i++)
                {
                    if (masyvas[i] != 0)
                    {
                        nmasyvas[x] = masyvas[i];
                        x++;
                    }
                }
            }



            return nmasyvas;
        }
    }
}
