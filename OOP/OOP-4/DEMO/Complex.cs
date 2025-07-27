using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        static public Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1?.Real??0 + c2?.Real??0, c1?.Imaginary??0 + c2?.Imaginary??0);
        }
        static public Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }
        static public Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(
                c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
            );
        }
        static public Complex operator /(Complex c1, Complex c2)
        {
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            if (denominator == 0)
                throw new DivideByZeroException("Cannot divide by zero complex number.");
            return new Complex(
                (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator,
                (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator
            );
        }
        static public Complex operator ++(Complex c)
        {
            return new Complex(c.Real + 1, c.Imaginary);
        }
        static public Complex operator --(Complex c)
        {
            return new Complex(c.Real - 1, c.Imaginary);
        }
        static public bool operator > (Complex c1, Complex c2)
        {
            return (c1.Real > c2.Real) || (c1.Real == c2.Real && c1.Imaginary > c2.Imaginary);
        }
        static public bool operator < (Complex c1, Complex c2)
        {
            return (c1.Real < c2.Real) || (c1.Real == c2.Real && c1.Imaginary < c2.Imaginary);
        }
        static public bool operator >=(Complex c1, Complex c2)
        {
            return (c1.Real > c2.Real) || (c1.Real == c2.Real && c1.Imaginary >= c2.Imaginary);
        }
        static public bool operator <=(Complex c1, Complex c2)
        {
            return (c1.Real < c2.Real) || (c1.Real == c2.Real && c1.Imaginary <= c2.Imaginary);
        }
        static public implicit operator double(Complex c)
        {
            return c?.Real??0; 
        }
        
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

    }
}
