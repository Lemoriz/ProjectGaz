using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;




namespace Attempt3
{
    public partial class Perform : Form
    {
        private MainScreen mainScreen;

        public Perform(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
            ControlBox = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainScreen.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {}

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {}

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Values values = new Values();
            Calculations calculations = new Calculations();
            //Создаём приложение.
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            //Открываем книгу.                                                                                                                                                        
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(values.ThePathToTheFolder);
            //Выбираем таблицу(лист).
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            double[,] array = new double[33,33];
            string[,] arrayString = new string[33, 33];

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arrayString[i, j] = Convert.ToString(ObjWorkSheet.Rows[i+3].Cells[j+1].Text);
                }

            }

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    array[i, j] = Convert.ToDouble(ObjWorkSheet.Rows[i + 3].Cells[j + 3].Text);

                    if (array[i,j] == 0)
                    {
                        array[i,j] = 0.01;
                    }
                }
            }
 
            double b =0;
            double c = 0;
            double d = 0;
            double f = 0;
            

            for (int i = 0; i < 13; i++)
            {
                dataGridView.Rows.Add(1);

                b = calculations.Add(a1, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);
                c = calculations.Mult(a1, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);
                d = calculations.Comb(a1, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);
                f = calculations.Comb1(a1, pow11, pow12, pow13, pow14, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);

                dataGridView.Rows[i].Cells[0].Value = arrayString[i, 0];
                dataGridView.Rows[i].Cells[1].Value = arrayString[i, 1];

                dataGridView.Rows[i].Cells[2].Value = calculations.FormatForAddAndComb(b); ;
                dataGridView.Rows[i].Cells[3].Value = calculations.FormatForMult(c); ;
                dataGridView.Rows[i].Cells[4].Value = calculations.FormatForAddAndComb(d);
                dataGridView.Rows[i].Cells[5].Value = calculations.FormatForComb1(f);

            }

            ObjExcel.Quit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void BackToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainScreen.Visible = true;
        }
    }
}
