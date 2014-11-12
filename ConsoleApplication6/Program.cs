using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test Nummer 1
            AlarmClock ac = new AlarmClock();
            string HoLine = ("_____________________________________");
            ViewTestHeader("Test nummer 1\nTestar standardkonstruktorn. ");
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HoLine);

            //Test Nummer 2
            ViewTestHeader("Test nummer 2\nTestar standardkonstruktorn. ");
            ac = new AlarmClock(9, 42);
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HoLine);

            //Test Nummer 3
            ViewTestHeader("Test nummer 3\nTestar standardkonstruktorn. ");
            ac = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HoLine);
            Console.WriteLine();
            Console.ResetColor();

            //Test Nummer 4
            ViewTestHeader("Test nummer 4\nStäll ett befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter. ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t \t \tVäckarklockan URLED <TM>\t \t");
            Console.WriteLine("\t \t \tModellnr. 1DV402S2L2B\t \t \t");
            Console.ResetColor();
            ac = new AlarmClock(23, 58, 7, 35);
            Run(ac, 13);
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HoLine);

            //Test Nummer 5
            ViewTestHeader("Test nummer 5\nStäller befintligt AlarmClock-objekt till tiden 6:12 \n och alarmtiden till 6:15 och låter den gå 6 minuter.\n ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t \t \tVäckarklockan URLED <TM>\t \t");
            Console.WriteLine("\t \t \tModellnr. 1DV402S2L2B\t \t \t");
            Console.ResetColor();
            ac = new AlarmClock(6, 12, 6, 15);
            Run(ac, 6);
            Console.WriteLine(ac.ToString());
            Console.WriteLine(HoLine);

            //Test Nummer 6
            ViewTestHeader("Test nummer 6\n\nTest av egenskaperna så att undantag kastas då tid och \n alarmtid tilldelas felaktiga värden.\n ");
            ac = new AlarmClock(0, 0, 0, 0);
            try { ac.Hour = 25; }

            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try { ac.Minute = 60; }

            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try { ac.AlarmHour = 25; }

            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try { ac.AlarmMinute = 60; }

            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            Console.WriteLine(HoLine);

            //Test Nummer 7
            ViewTestHeader("Test nummer 7\n\nTest av konstruktorer så att undantag \n kastas då tid och alarmtid tilldelas felaktiga värden.\n ");
            try { ac = new AlarmClock(67, 12, 6, 15); }

            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try 
            { 
                ac = new AlarmClock(6, 12, 678, 15); 
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            Console.WriteLine(HoLine);

        }

        //Metod som gör så att klcokan går ett inmatat antal minuter
        static void Run(AlarmClock ac, int minutes)
        {

            //Så länge variabeln counter är mindre än variabeln minutes så körs tiktok metoden 
            for (int counter = 0; counter < minutes; counter++)
            {

                //Om alarmtiden övernsstämmer med det inställda alarmet så "Ringer klockan"
                if (ac.TickTok())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0}        Hoj Hoj nu ringer jag lite här", ac.ToString());
                    Console.ResetColor();
                }
                //Annars så bara kör det på "tyst"  
                else
                { 
                    Console.WriteLine("{0}", ac.ToString()); 
                }
            }
        }


        //Metod som tar emot en sträng och skriver ut den som felmedelande
        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        //En metod som hämtar in en sträng och skrive rut den som header till testen
        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }



    }

}
