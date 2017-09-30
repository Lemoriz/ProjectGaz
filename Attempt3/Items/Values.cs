using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Attempt3
{
    class Values
    {


        const double a1 = 0.047;
        const double a2 = 0.095;
        const double a3 = 0.140;
        const double a4 = 0.190;
        const double a5 = 0.230;
        const double a6 = 0.280;

        const double pow11 = 0.4;
        const double pow12 = 0.3;
        const double pow13 = 0.2;
        const double pow14 = 0.1;

        const double pow21 = 0.4;
        const double pow22 = 0.3;
        const double pow23 = 0.2;
        const double pow24 = 0.1;

        const double pow31 = 0.3;
        const double pow32 = 0.26;
        const double pow33 = 0.2;
        const double pow34 = 0.13;
        const double pow35 = 0.006;

        const double pow41 = 0.2;
        const double pow42 = 0.25;
        const double pow43 = 0.21;
        const double pow44 = 0.14;
        const double pow45 = 0.1;
        const double pow46 = 0.07;
        const double pow47 = 0.035;

        const double pow51 = 0.1;
        const double pow52 = 0.21;
        const double pow53 = 0.035;
        const double pow54 = 0.07;
        const double pow55 = 0.025;
        const double pow56 = 0.14;
        const double pow57 = 0.2;

        const double pow61 = 0.3;
        const double pow62 = 0.26;
        const double pow63 = 0.2;
        const double pow64 = 0.13;
        const double pow65 = 0.06;


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
    }




}
  
