using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Attempt3
{
    static class Constants
    {
        public static class ValueA
        {
            public const double a1 = 0.047;
            public const double a2 = 0.095;
            public const double a3 = 0.140;
            public const double a4 = 0.190;
            public const double a5 = 0.230;
            public const double a6 = 0.280;
        }

        public static class ValuePow1
        {
            public const double pow11 = 0.4;
            public const double pow12 = 0.3;
            public const double pow13 = 0.2;
            public const double pow14 = 0.1;
        }

        public static class ValuePow2
        {
            public const double pow21 = 0.4;
            public const double pow22 = 0.3;
            public const double pow23 = 0.2;
            public const double pow24 = 0.1;
        }

        public static class ValuePow3
        {
            public const double pow31 = 0.3;
            public const double pow32 = 0.26;
            public const double pow33 = 0.2;
            public const double pow34 = 0.13;
            public const double pow35 = 0.006;
        }

        public static class ValuePow4
        {
            public const double pow41 = 0.2;
            public const double pow42 = 0.25;
            public const double pow43 = 0.21;
            public const double pow44 = 0.14;
            public const double pow45 = 0.1;
            public const double pow46 = 0.07;
            public const double pow47 = 0.035; 
        }

        public static class ValuePow5
        {
            public const double pow51 = 0.1;
            public const double pow52 = 0.21;
            public const double pow53 = 0.035;
            public const double pow54 = 0.07;
            public const double pow55 = 0.025;
            public const double pow56 = 0.14;
            public const double pow57 = 0.2;
        }

        public static class ValuePow6
        {
            public const double pow61 = 0.3;
            public const double pow62 = 0.26;
            public const double pow63 = 0.2;
            public const double pow64 = 0.13;
            public const double pow65 = 0.06;
        }
    }


    class Values
    {
        private static string thePathToTheFolder;

        public string ThePathToTheFolder
        {
            get { return thePathToTheFolder; }

            set
            {
                thePathToTheFolder = value;
            }           
        }

        private static int theFilterIndex;

        public int TheFilterIndex
        {
            get { return theFilterIndex; }

            set
            {
                value = theFilterIndex;          
            }
        }

        private static int maxRowInExcel;

        public int MaxRowInExcel
        {
            get { return maxRowInExcel; }

            set
            {
                maxRowInExcel = value;
            }
        }

        public static double [,] addValue;

        public double [,] DouvleArray(double [,] a)
        {
            return addValue = a;
        }

        public static string[,] addString;

        public string[,] AddString(string[,] l)
        {
            return addString = l;
        }
    }




}
  
