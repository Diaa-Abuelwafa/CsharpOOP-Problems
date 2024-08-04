using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Duration
    {
        int Hours;
        int Minutes;
        int Seconds;

        public Duration(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public Duration(int seconds)
        {
            int Hours = seconds / (60 * 60);
            int Minutes = (seconds % (60 * 60)) / 60;
            int Seconds = ((seconds % (60 * 60)) % 60);

            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }

        public override bool Equals(object? obj)
        {
            Duration D = (Duration)obj;

            if(this.Hours == D.Hours && this.Minutes == D.Minutes && this.Seconds == D.Seconds)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            if(this.Hours == 0)
            {
                return $"Minutes : {Minutes}, Seconds : {Seconds}";
            }
            else
            {
                return $"Hours : {Hours}, Minutes : {Minutes}, Seconds : {Seconds}";
            }
        }

        public override int GetHashCode()
        {
            return (Hours * Minutes * Seconds) / 100;
        }

        public static Duration operator + (Duration D1, Duration D2)
        {
            int Hours = D1.Hours + D2.Hours;
            int Minutes = D1.Minutes + D2.Minutes;
            int Seconds = D1.Seconds + D2.Seconds;

            return new Duration(Hours, Minutes, Seconds);
        }

        public static Duration operator +(Duration D1, int X)
        {
            Duration D2 = new Duration(X);

            return D1 + D2;
        }

        public static Duration operator +(int X, Duration D1)
        {
            Duration D2 = new Duration(X);

            return D2 + D1;
        }

        public static Duration operator ++ (Duration D)
        {
            D.Minutes++;
            return D;
        }

        public static Duration operator --(Duration D)
        {
            D.Minutes--;
            return D;
        }

        public static Duration operator -(Duration D1, Duration D2)
        {
            int Hours = D1.Hours - D2.Hours;
            int Minutes = D1.Minutes - D2.Minutes;
            int Seconds = D1.Seconds - D2.Seconds;

            // or

            //int Hours = Math.Abs(D1.Hours - D2.Hours);
            //int Minutes = Math.Abs(D1.Minutes - D2.Minutes);
            //int Seconds = Math.Abs(D1.Seconds - D2.Seconds);

            return new Duration(Hours, Minutes, Seconds);
        }

        public static bool operator > (Duration D1, Duration D2)
        {
            if(D1.Hours > D2.Hours)
            {
                return true;
            }

            if(D1.Minutes > D2.Minutes)
            {
                return true;
            }

            if(D1.Seconds > D2.Seconds)
            {
                return true;
            }

            return false;
        }

        public static bool operator < (Duration D1, Duration D2)
        {
            if (D1 > D2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >= (Duration D1, Duration D2)
        {
            if (D1.Hours >= D2.Hours)
            {
                return true;
            }

            if (D1.Minutes >= D2.Minutes)
            {
                return true;
            }

            if (D1.Seconds >= D2.Seconds)
            {
                return true;
            }

            return false;
        }

        public static bool operator <= (Duration D1, Duration D2)
        {
            if (D1 >= D2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static implicit operator bool(Duration D)
        {
            if (D.Hours > 0 && D.Minutes > 0 && D.Seconds > 0)
            {
                return true;
            }

            return false;
        }

        public static explicit operator DateTime(Duration D)
        {
            DateTime Date = new DateTime(2024, 7, 25, D.Hours, D.Minutes, D.Seconds);
            return Date;
        }
    }
}
