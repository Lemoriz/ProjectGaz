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
  
