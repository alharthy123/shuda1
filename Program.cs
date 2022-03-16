using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stunde_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello leute");
            // Datentypen: ganze zahlen;Dezimalzahlen,Zeichenketten,zeichnen
            //Wahreitswert(Boolean)

            //ganze zahlen 
            int ganzezahlA = 5;
            int ganzezahlB;
            ganzezahlB = 7;
            short kleineGanzeZahl;
            long großeGanzeZahl;

            int ganzezahlC = ganzezahlA % ganzezahlB;
            Console.WriteLine(ganzezahlC);

            //Gleitkommazahlen (Dezimalzahlen)
            double gleikommaZahlA = 1;
            double gleikommaZahlB = 3;
            decimal großeGleikommazahl;
            Console.WriteLine(gleikommaZahlA / gleikommaZahlB);
            double gleitkommezahlC = ganzezahlC + gleikommaZahlA;
            Console.WriteLine( ganzezahlC + gleikommaZahlA);

            bool warheitswert = true;

            //Zeichen und zeichnenketten
            Char Zeichen='&';
                string zeichnenketten= "Hello";
                string zeichnenkettenB= "Leute";

                //string+string:=kontakenation


        }
    }
}
