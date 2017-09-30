using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attempt3
{
    class Calculations
    {
        //Add
        public double Add(double a, double value1, double value2, double value3, double value4)
        {
            return (a * value1 / 10) + (a * value2 / 10) + (a * value3 / 10) + (a * value4 / 10);
        }

        public double Add(double a, double value1, double value2, double value3, double value4, double value5)
        {
            return (a * value1 / 10) + (a * value2 / 10) + (a * value3 / 10) + (a * value4 / 10) + (a * value5 / 10);
        }

        public double Add(double a, double value1, double value2, double value3, double value4, double value5, double value6, double value7)
        {
            return (a * value1 / 10) + (a * value2 / 10) + (a * value3 / 10) + (a * value4 / 10) + (a * value5 / 10) + (a * value6 / 10) + (a * value7 / 10);
        }

        //Mult
        public double Mult(double a, double value1, double value2, double value3, double value4)
        {
            return ((a * value1 / 10) * (a * value2 / 10) * (a * value3 / 10) * (a * value4 / 10));
        }

        public double Mult(double a, double value1, double value2, double value3, double value4, double value5)
        {
            return ((a * value1 / 10) * (a * value2 / 10) * (a * value3 / 10) * (a * value4 / 10) * (a * value5 / 10));
        }

        public double Mult(double a, double value1, double value2, double value3, double value4, double value5, double value6, double value7)
        {
            return ((a * value1 / 10) * (a * value2 / 10) * (a * value3 / 10) * (a * value4 / 10) * (a * value5 / 10) * (a * value6 / 10) * (a * value7 / 10));
        }

        //Comb
        public double Comb(double a, double value1, double value2, double value3, double value4)
        {
            return Math.Pow((value1 / 10), a) * Math.Pow((value2 / 10), a) * Math.Pow((value3 / 10), a) * Math.Pow((value4 / 10), a);
        }

        public double Comb(double a, double value1, double value2, double value3, double value4, double value5)
        {
            return Math.Pow((value1 / 10), a) * Math.Pow((value2 / 10), a) * Math.Pow((value3 / 10), a) * Math.Pow((value4 / 10), a) * Math.Pow((value5 / 10), a);
        }

        public double Comb(double a1, double value1, double value2, double value3, double value4, double value5, double value6, double value7)
        {
            return Math.Pow((value1 / 10), a1) * Math.Pow((value2 / 10), a1) * Math.Pow((value3 / 10), a1) * Math.Pow((value4 / 10), a1) * Math.Pow((value5 / 10), a1) * Math.Pow((value6 / 10), a1) * Math.Pow((value7 / 10), a1);
        }

        //Comb1
        public double Comb1(double a, double pow1, double pow2, double pow3, double pow4, double value1, double value2, double value3, double value4)
        {
            return Math.Pow((a*(value1/10)),pow1) * Math.Pow((a * (value2 / 10)), pow2) * Math.Pow((a * (value3 / 10)), pow3) * Math.Pow((a * (value4 / 10)), pow4);
        }

        public double Comb1(double a, double pow1, double pow2, double pow3, double pow4, double pow5, double value1, double value2, double value3, double value4, double value5)
        {
            return Math.Pow((a * (value1 / 10)), pow1) * Math.Pow((a * (value2 / 10)), pow2) * Math.Pow((a * (value3 / 10)), pow3) * Math.Pow((a * (value4 / 10)), pow4) * Math.Pow((a * (value5 / 10)), pow5);
        }

        public double Comb1(double a, double pow1, double pow2, double pow3, double pow4, double pow5, double pow6, double pow7, double value1, double value2, double value3, double value4, double value5, double value6, double value7)
        {
            return Math.Pow((a * (value1 / 10)), pow1) * Math.Pow((a * (value2 / 10)), pow2) * Math.Pow((a * (value3 / 10)), pow3) * Math.Pow((a * (value4 / 10)), pow4) * Math.Pow((a * (value5 / 10)), pow5) * Math.Pow((a * (value6 / 10)), pow6) * Math.Pow((a * (value7 / 10)), pow7);
        }


        //AverageValue
        public double AverageValue(double value1, double value2, double value3, double value4)
        {
            return (value1 + value2 + value3 + value4) / 4;
        }

        public double AverageValue(double value1, double value2, double value3, double value4, double value5)
        {
            return (value1 + value2 + value3 + value4 + value5) / 5;
        }

        public double AverageValue(double value1, double value2, double value3, double value4, double value5, double value6, double value7)
        {
            return (value1 + value2 + value3 + value4 + value5 + value6 + value7) / 7;
        }

        //AverageValueAll
        public double AllAverageValue(double value1, double value2, double value3, double value4, double value5, double value6)
        {
            return (value1 + value2 + value3 + value4 + value5 + value6) / 6;
        }

        //Format
        public string FormatForMult(double value)
        {
            return String.Format("{0:E}", value);
        }

        public string FormatForAddAndComb(double value)
        {
            return String.Format("{0:0.000}", value);
        }

        public string FormatForComb1(double value)
        {
            return String.Format("{0:0.000000000}", value);
        }

        public string FormatForAverageValue(double value)
        {
            return String.Format("{0:0.00}", value);
        }
    }
}
