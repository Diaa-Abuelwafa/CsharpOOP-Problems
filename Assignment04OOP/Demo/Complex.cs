using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public Complex(int real, int img)
        {
            this.Real = real;
            this.Img = img;
        }

        public Complex()
        {
            
        }

        public static Complex operator+(Complex C1, Complex C2)
        {
            Complex C3 = new Complex();

            C3.Real = C1.Real + C2.Real;
            C3.Img = C1.Img + C2.Img;

            return C3;
        }

        public static Complex operator-(Complex C1, Complex C2)
        {
            Complex C3 = new Complex();

            C3.Real = C1.Real - C2.Real;
            C3.Img = C1.Img - C2.Img;

            return C3;
        }

        public static Complex operator++(Complex C)
        {
            C.Real++;
            return C;
        }

        public static Complex operator --(Complex C)
        {
            C.Real--;
            return C;
        }

        public static bool operator >(Complex C1, Complex C2)
        {
            if(C1.Real == C2.Real)
            {
                return C1.Img > C2.Img;
            }

            return C1.Real > C2.Real;
        }

        public static bool operator <(Complex C1, Complex C2)
        {
            if (C1.Real == C2.Real)
            {
                return C1.Img < C2.Img;
            }

            return C1.Real < C2.Real;
        }


        public static bool operator >=(Complex C1, Complex C2)
        {
            return C1.Real > C2.Real;
        }

        public static bool operator <=(Complex C1, Complex C2)
        {
            return C1.Real > C2.Real;
        }

        public static bool operator ==(Complex C1, Complex C2)
        {
            return C1.Real == C2.Real;
        }

        public static bool operator !=(Complex C1, Complex C2)
        {
            return C1.Real != C2.Real;
        }

        public override string ToString()
        {
            return $"{Real} + {Img} i";
        }

        public static implicit operator int(Complex C)
        {
            return C.Real;
        }

        public static explicit operator string(Complex C)
        {
            return C.ToString();
        }
    }
}
