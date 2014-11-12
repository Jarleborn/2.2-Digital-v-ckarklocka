using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        //metod som hämtar ett värde och sedan ser om det är  passande för en timvissare om det är det så stoppar man in det i fältet för timmvisaren annars kastas ett ArgumentException
        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }
            set
            {
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23");
                }
                _alarmHour = value;

            }
        }
        //metod som hämtar ett värde och sedan ser om det är  passande för en minutvissare om det är det så stoppar man in det i fältet för minutvisaren annars kastas ett ArgumentException
        public int AlarmMinute
        {
            get
            {
                return _alarmMinute;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException("Alarminuten är inte i intervallet 0-59");
                }
                _alarmMinute = value;

            }
        }
        //metod som hämtar ett värde och sedan ser om det är  passande för en timvissare om det är det så stoppar man in det i fältet för timmvisaren annars kastas ett ArgumentException
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23");
                }
                _hour = value;

            }
        }
        //metod som hämtar ett värde och sedan ser om det är  passande för en minutvissare om det är det så stoppar man in det i fältet för minutvisaren annars kastas ett ArgumentException
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59");
                }
                _minute = value;

            }
        }

        //Konstruktorer som hämtar in värden och skickar vidare dessa till metoderna som kontrollerar om dom är passande för tim och minut vissarna
        static AlarmClock()
            : this(0, 0)
        {
        }

        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        //Metod som låter klockan gå en minut
        public bool TickTok()
        {
            //Om minutvissaren står på något mindre än 59 så ökar minuten med ett
            if (Minute < 59)
            {
                Minute++;
            }
            //annars nollstäls den
            else
            {
                Minute = 0;
                //Om timvissaren står på något mindre än 59 så ökar minuten med ett
                if (Hour < 23)
                {
                    Hour++;
                }
                //annars nollstäls den
                else
                {
                    Hour = 0;
                }


            }
            //Om Minute och Hour matchar AlarmHour och Alarm minute så är ticktok true och då ringer alarmet i run metoden
            return Minute == AlarmMinute && Hour == AlarmHour;
        }

        //Metod som skriver ut klockan
        public override string ToString()
        {

            return String.Format("{0,2}:{1:00} ({2}:{3:00})", Hour, Minute, AlarmHour, AlarmMinute);
        }




    }
}
