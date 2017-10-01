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
using System.ComponentModel;
using System.Data;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            Values values = new Values();
            Calculations calculations = new Calculations();
            //Создаём приложение.
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            //Открываем книгу.                                                                                                                                                        
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(values.ThePathToTheFolder);
            //Выбираем таблицу(лист).
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            int MaxCellsInAExcel = 33;
            int MaxRowsInAExcel = 0;

            for (; ; )
            {
                MaxRowsInAExcel++;
                if (ObjWorkSheet.Rows[MaxRowsInAExcel+3].Cells[1].Value == null)
                {
                    break;
                }
            }

            string[,] arrayString = new string[MaxRowsInAExcel, 2];

            for (int i = 0; i < MaxRowsInAExcel; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arrayString[i, j] = Convert.ToString(ObjWorkSheet.Rows[i + 3].Cells[j + 1].Text);
                }
            }

            double[,] array = new double[MaxRowsInAExcel, MaxCellsInAExcel];

            for (int i = 0; i < MaxRowsInAExcel; i++)
            {
                for (int j = 0; j < MaxCellsInAExcel-1; j++)
                {
                    array[i, j] = Convert.ToDouble(ObjWorkSheet.Rows[i + 3].Cells[j + 3].Text);

                    if (array[i,j] == 0)
                    {
                        array[i,j] = 0.01;
                    }
                }
            }

            double[,] arrayResult = new double[MaxRowsInAExcel, MaxCellsInAExcel+4];

            double[,] allAverageValue = new double[3, 4];

            for (int i = 0; i < MaxRowsInAExcel; i++)
            {
                dataGridView.Rows.Add(1);

                //Part1
                arrayResult[i, 0]= calculations.Add(Constants.ValueA.a1, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);
                arrayResult[i, 1]= calculations.Mult(Constants.ValueA.a1, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);
                arrayResult[i, 2]= calculations.Comb(Constants.ValueA.a1, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);
                arrayResult[i, 3] = calculations.Comb1(Constants.ValueA.a1, Constants.ValuePow1.pow11, Constants.ValuePow1.pow12, Constants.ValuePow1.pow13, Constants.ValuePow1.pow14, array[i, 0], array[i, 1], array[i, 2], array[i, 3]);
                arrayResult[i, 4] = calculations.AverageValue(arrayResult[i, 0], arrayResult[i, 1], arrayResult[i, 2], arrayResult[i, 3]);

                dataGridView.Rows[i].Cells[0].Value = arrayString[i, 0];
                dataGridView.Rows[i].Cells[1].Value = arrayString[i, 1];
                dataGridView.Rows[i].Cells[2].Value = calculations.FormatForAddAndComb(arrayResult[i, 0]);
                dataGridView.Rows[i].Cells[3].Value = calculations.FormatForMult(arrayResult[i, 1]);
                dataGridView.Rows[i].Cells[4].Value = calculations.FormatForAddAndComb(arrayResult[i, 2]);
                dataGridView.Rows[i].Cells[5].Value = calculations.FormatForComb1(arrayResult[i, 3]);
                dataGridView.Rows[i].Cells[6].Value = calculations.FormatForAverageValue(arrayResult[i, 4]);
                dataGridView.Rows[i].Cells[7].Value = null;

                //Part2
                arrayResult[i, 5] = calculations.Add(Constants.ValueA.a2, array[i, 4], array[i, 5], array[i, 6], array[i, 7]);
                arrayResult[i, 6]= calculations.Mult(Constants.ValueA.a2, array[i, 4], array[i, 5], array[i, 6], array[i, 7]);
                arrayResult[i, 7]= calculations.Comb(Constants.ValueA.a2, array[i, 4], array[i, 5], array[i, 6], array[i, 7]);
                arrayResult[i, 8] = calculations.Comb1(Constants.ValueA.a2, Constants.ValuePow2.pow21, Constants.ValuePow2.pow22, Constants.ValuePow2.pow23, Constants.ValuePow2.pow24, array[i, 4], array[i, 5], array[i, 6], array[i, 7]);
                arrayResult[i, 9]= calculations.AverageValue(arrayResult[i, 5], arrayResult[i, 6], arrayResult[i, 7], arrayResult[i, 8]);

                dataGridView.Rows[i].Cells[8].Value = arrayString[i, 1];
                dataGridView.Rows[i].Cells[9].Value = calculations.FormatForAddAndComb(arrayResult[i, 5]);
                dataGridView.Rows[i].Cells[10].Value = calculations.FormatForMult(arrayResult[i, 6]);
                dataGridView.Rows[i].Cells[11].Value = calculations.FormatForAddAndComb(arrayResult[i, 7]);
                dataGridView.Rows[i].Cells[12].Value = calculations.FormatForComb1(arrayResult[i, 8]);
                dataGridView.Rows[i].Cells[13].Value = calculations.FormatForAverageValue(arrayResult[i, 9]);
                dataGridView.Rows[i].Cells[14].Value = null;

                //Part3
                arrayResult[i, 10] = calculations.Add(Constants.ValueA.a3, array[i, 8], array[i, 9], array[i, 10], array[i, 11], array[i, 12]);
                arrayResult[i, 11]= calculations.Mult(Constants.ValueA.a3, array[i, 8], array[i, 9], array[i, 10], array[i, 11], array[i, 12]);
                arrayResult[i, 12]= calculations.Comb(Constants.ValueA.a3, array[i, 8], array[i, 9], array[i, 10], array[i, 11], array[i, 12]);
                arrayResult[i, 13] = calculations.Comb1(Constants.ValueA.a3, Constants.ValuePow3.pow31, Constants.ValuePow3.pow32, Constants.ValuePow3.pow33, Constants.ValuePow3.pow34, Constants.ValuePow3.pow35, array[i, 8], array[i, 9], array[i, 10], array[i, 11], array[i, 12]);
                arrayResult[i, 14] = calculations.AverageValue(arrayResult[i, 10], arrayResult[i, 11], arrayResult[i, 12], arrayResult[i, 13]);

                dataGridView.Rows[i].Cells[15].Value = arrayString[i, 1];
                dataGridView.Rows[i].Cells[16].Value = calculations.FormatForAddAndComb(arrayResult[i, 10]);
                dataGridView.Rows[i].Cells[17].Value = calculations.FormatForMult(arrayResult[i, 11]);
                dataGridView.Rows[i].Cells[18].Value = calculations.FormatForAddAndComb(arrayResult[i, 12]);
                dataGridView.Rows[i].Cells[19].Value = calculations.FormatForComb1(arrayResult[i, 13]);
                dataGridView.Rows[i].Cells[20].Value = calculations.FormatForAverageValue(arrayResult[i, 14]);
                dataGridView.Rows[i].Cells[21].Value = null;

                //Part4
                arrayResult[i, 15] = calculations.Add(Constants.ValueA.a4, array[i, 13], array[i, 14], array[i, 15], array[i, 16], array[i, 17], array[i, 18], array[i, 19]);
                arrayResult[i, 16]= calculations.Mult(Constants.ValueA.a4, array[i, 13], array[i, 14], array[i, 15], array[i, 16], array[i, 17], array[i, 18], array[i, 19]);
                arrayResult[i, 17]= calculations.Comb(Constants.ValueA.a4, array[i, 13], array[i, 14], array[i, 15], array[i, 16], array[i, 17], array[i, 18], array[i, 19]);
                arrayResult[i, 18] = calculations.Comb1(Constants.ValueA.a4, Constants.ValuePow4.pow41, Constants.ValuePow4.pow42, Constants.ValuePow4.pow43, Constants.ValuePow4.pow44, Constants.ValuePow4.pow45, Constants.ValuePow4.pow46, Constants.ValuePow4.pow47, array[i, 13], array[i, 14], array[i, 15], array[i, 16], array[i, 17], array[i, 18], array[i, 19]);
                arrayResult[i, 19] = calculations.AverageValue(arrayResult[i, 15], arrayResult[i, 16], arrayResult[i, 17], arrayResult[i, 18]);

                dataGridView.Rows[i].Cells[22].Value = arrayString[i, 1];
                dataGridView.Rows[i].Cells[23].Value = calculations.FormatForAddAndComb(arrayResult[i, 15]);
                dataGridView.Rows[i].Cells[24].Value = calculations.FormatForMult(arrayResult[i, 16]);
                dataGridView.Rows[i].Cells[25].Value = calculations.FormatForAddAndComb(arrayResult[i, 17]);
                dataGridView.Rows[i].Cells[26].Value = calculations.FormatForComb1(arrayResult[i, 18]);
                dataGridView.Rows[i].Cells[27].Value = calculations.FormatForAverageValue(arrayResult[i, 19]);
                dataGridView.Rows[i].Cells[28].Value = null;

                //Part5
                arrayResult[i, 20] = calculations.Add(Constants.ValueA.a5, array[i, 20], array[i, 21], array[i, 22], array[i, 23], array[i, 24], array[i, 25], array[i, 26]);
                arrayResult[i, 21]= calculations.Mult(Constants.ValueA.a5, array[i, 20], array[i, 21], array[i, 22], array[i, 23], array[i, 24], array[i, 25], array[i, 26]);
                arrayResult[i, 22]= calculations.Comb(Constants.ValueA.a5, array[i, 20], array[i, 21], array[i, 22], array[i, 23], array[i, 24], array[i, 25], array[i, 26]);
                arrayResult[i, 23] = calculations.Comb1(Constants.ValueA.a5, Constants.ValuePow5.pow51, Constants.ValuePow5.pow52, Constants.ValuePow5.pow53, Constants.ValuePow5.pow54, Constants.ValuePow5.pow55, Constants.ValuePow5.pow56, Constants.ValuePow5.pow57, array[i, 20], array[i, 21], array[i, 22], array[i, 23], array[i, 24], array[i, 25], array[i, 26]);
                arrayResult[i, 24] = calculations.AverageValue(arrayResult[i, 20], arrayResult[i, 21], arrayResult[i, 22], arrayResult[i, 23]);

                dataGridView.Rows[i].Cells[29].Value = arrayString[i, 1];
                dataGridView.Rows[i].Cells[30].Value = calculations.FormatForAddAndComb(arrayResult[i, 20]);
                dataGridView.Rows[i].Cells[31].Value = calculations.FormatForMult(arrayResult[i, 21]);
                dataGridView.Rows[i].Cells[32].Value = calculations.FormatForAddAndComb(arrayResult[i, 22]);
                dataGridView.Rows[i].Cells[33].Value = calculations.FormatForComb1(arrayResult[i, 23]);
                dataGridView.Rows[i].Cells[34].Value = calculations.FormatForAverageValue(arrayResult[i, 24]);
                dataGridView.Rows[i].Cells[35].Value = null;

                //Part6
                arrayResult[i, 25] = calculations.Add(Constants.ValueA.a6, array[i, 27], array[i, 28], array[i, 29], array[i, 30], array[i, 31]);
                arrayResult[i, 26]= calculations.Mult(Constants.ValueA.a6, array[i, 27], array[i, 28], array[i, 29], array[i, 30], array[i, 31]);
                arrayResult[i, 27]= calculations.Comb(Constants.ValueA.a6, array[i, 27], array[i, 28], array[i, 29], array[i, 30], array[i, 31]);
                arrayResult[i, 28] = calculations.Comb1(Constants.ValueA.a6, Constants.ValuePow6.pow61, Constants.ValuePow6.pow62, Constants.ValuePow6.pow63, Constants.ValuePow6.pow64, Constants.ValuePow6.pow65, array[i, 27], array[i, 28], array[i, 29], array[i, 30], array[i, 31]);
                arrayResult[i, 29] = calculations.AverageValue(arrayResult[i, 25], arrayResult[i, 26], arrayResult[i, 27], arrayResult[i, 28]);

                dataGridView.Rows[i].Cells[36].Value = arrayString[i, 1];
                dataGridView.Rows[i].Cells[37].Value = calculations.FormatForAddAndComb(arrayResult[i, 25]);
                dataGridView.Rows[i].Cells[38].Value = calculations.FormatForMult(arrayResult[i, 26]);
                dataGridView.Rows[i].Cells[39].Value = calculations.FormatForAddAndComb(arrayResult[i, 27]);
                dataGridView.Rows[i].Cells[40].Value = calculations.FormatForComb1(arrayResult[i, 28]);
                dataGridView.Rows[i].Cells[41].Value = calculations.FormatForAverageValue(arrayResult[i, 29]);
                dataGridView.Rows[i].Cells[42].Value = null;

                //AverageValueAll
                arrayResult[i, 30] = (arrayResult[i, 0] + arrayResult[i, 5] + arrayResult[i, 10] + arrayResult[i, 15] + arrayResult[i, 20] + arrayResult[i, 25]) / 6;
                arrayResult[i, 31] = (arrayResult[i, 1] + arrayResult[i, 6] + arrayResult[i, 11] + arrayResult[i, 16] + arrayResult[i, 21] + arrayResult[i, 26]) / 6;
                arrayResult[i, 32] = (arrayResult[i, 2] + arrayResult[i, 7] + arrayResult[i, 12] + arrayResult[i, 17] + arrayResult[i, 22] + arrayResult[i, 27]) / 6;
                arrayResult[i, 33] = (arrayResult[i, 3] + arrayResult[i, 8] + arrayResult[i, 13] + arrayResult[i, 18] + arrayResult[i, 23] + arrayResult[i, 28]) / 6;

                dataGridView.Rows[i].Cells[43].Value = calculations.FormatForAverageValue(arrayResult[i, 30]);
                dataGridView.Rows[i].Cells[44].Value = calculations.FormatForMult(arrayResult[i, 31]);
                dataGridView.Rows[i].Cells[45].Value = calculations.FormatForAverageValue(arrayResult[i, 32]);
                dataGridView.Rows[i].Cells[46].Value = calculations.FormatForAverageValue(arrayResult[i, 33]);
            }

            //AllAverageValue
            for (int i = 0; i < MaxRowsInAExcel; i++)
            {
                allAverageValue[0, 0] += arrayResult[i, 30];
                allAverageValue[0, 1] += arrayResult[i, 31];
                allAverageValue[0, 2] += arrayResult[i, 32];
                allAverageValue[0, 3] += arrayResult[i, 33];
            }

            //average
            allAverageValue[0, 0] = allAverageValue[0, 0] / MaxRowsInAExcel;
            allAverageValue[0, 1] = allAverageValue[0, 1] / MaxRowsInAExcel;
            allAverageValue[0, 2] = allAverageValue[0, 2] / MaxRowsInAExcel;
            allAverageValue[0, 3] = allAverageValue[0, 3] / MaxRowsInAExcel;

            //average.gen.
            allAverageValue[1, 0] = (allAverageValue[0, 0] + allAverageValue[0, 1] + allAverageValue[0, 2] + allAverageValue[0, 3]) / 4;

            //OptimumMode
            allAverageValue[2, 0] = Math.Abs( allAverageValue[0, 0] - allAverageValue[1, 0]);
            allAverageValue[2, 1]= Math.Abs(allAverageValue[0, 1] - allAverageValue[1, 0]);
            allAverageValue[2, 2]= Math.Abs(allAverageValue[0, 2] - allAverageValue[1, 0]);
            allAverageValue[2, 3]= Math.Abs(allAverageValue[0, 3] - allAverageValue[1, 0]);

            dataGridView.Rows.Add(1);

            dataGridView.Rows[MaxRowsInAExcel].Cells[42].Value = "cреднее";
            dataGridView.Rows[MaxRowsInAExcel].Cells[43].Value = calculations.FormatForAverageValue(allAverageValue[0, 0]);
            dataGridView.Rows[MaxRowsInAExcel].Cells[44].Value = calculations.FormatForAverageValue(allAverageValue[0, 1]);
            dataGridView.Rows[MaxRowsInAExcel].Cells[45].Value = calculations.FormatForAverageValue(allAverageValue[0, 2]);
            dataGridView.Rows[MaxRowsInAExcel].Cells[46].Value = calculations.FormatForAverageValue(allAverageValue[0, 3]);

            dataGridView.Rows.Add(1);
            dataGridView.Rows[MaxRowsInAExcel+1].Cells[42].Value = "средн.ген.";
            dataGridView.Rows[MaxRowsInAExcel + 1].Cells[43].Value = calculations.FormatForAverageValue(allAverageValue[1, 0]);

            dataGridView.Rows.Add(1);
            dataGridView.Rows[MaxRowsInAExcel + 2].Cells[42].Value = "оптим.мод";
            dataGridView.Rows[MaxRowsInAExcel + 2].Cells[43].Value = calculations.FormatForAverageValue(allAverageValue[2, 0]);
            dataGridView.Rows[MaxRowsInAExcel + 2].Cells[44].Value = calculations.FormatForAverageValue(allAverageValue[2, 1]);
            dataGridView.Rows[MaxRowsInAExcel + 2].Cells[45].Value = calculations.FormatForAverageValue(allAverageValue[2, 2]);
            dataGridView.Rows[MaxRowsInAExcel + 2].Cells[46].Value = calculations.FormatForAverageValue(allAverageValue[2, 3]);

            Values asd = new Values();
            asd.DouvleArray(arrayResult);
            asd.MaxRowInExcel = MaxRowsInAExcel;
            asd.AllAverageValue(allAverageValue);
            asd.AddString(arrayString);
            ObjExcel.Quit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void BackToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainScreen.Visible = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Values values = new Values();

            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Cохранить в Excel файл";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Calculations calculations = new Calculations();

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 10;

                //for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                //{
                //    ExcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                //}
                //Tabl1
                ExcelApp.Cells[1, 1] = "№ ПП";
                ExcelApp.Range[ExcelApp.Cells[1, 1], ExcelApp.Cells[3, 1]].Merge();
                ExcelApp.Cells[1, 2] = "Наименование участков";
                ExcelApp.Range[ExcelApp.Cells[1, 2], ExcelApp.Cells[3, 2]].Merge();
                ExcelApp.Cells[1, 3] = "Внешние антропогенные воздействия";
                ExcelApp.Range[ExcelApp.Cells[1, 3], ExcelApp.Cells[2, 5]].Merge();
                ExcelApp.Cells[3, 3] = "адд";
                ExcelApp.Range["C3"].Font.Bold = true;
                ExcelApp.Cells[3, 4] = "мулт";
                ExcelApp.Range["D3"].Font.Bold = true;
                ExcelApp.Cells[3, 5] = "комб";
                ExcelApp.Range["E3"].Font.Bold = true;
                ExcelApp.Cells[3, 6] = "комб1";
                ExcelApp.Range["F3"].Font.Bold = true;
                ExcelApp.Cells[1, 6] = "№1";
                ExcelApp.Cells[1, 7] = "средн. генер.";
                ExcelApp.Range[ExcelApp.Cells[1, 7], ExcelApp.Cells[3, 7]].Merge();

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 1] = Values.addString[i, j];
                    }
                }

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 3] = Values.addValue[i, j];
                    }
                }


                //Tabl2
                ExcelApp.Cells[1, 9] = "Наименование участков";
                ExcelApp.Range[ExcelApp.Cells[1, 9], ExcelApp.Cells[3, 9]].Merge();
                ExcelApp.Cells[1, 10] = "Природные воздействия";
                ExcelApp.Range[ExcelApp.Cells[1, 10], ExcelApp.Cells[2, 12]].Merge();
                ExcelApp.Cells[3, 10] = "адд";
                ExcelApp.Range["J3"].Font.Bold = true;
                ExcelApp.Cells[3, 11] = "мулт";
                ExcelApp.Range["K3"].Font.Bold = true;
                ExcelApp.Cells[3, 12] = "комб";
                ExcelApp.Range["L3"].Font.Bold = true;
                ExcelApp.Cells[3, 13] = "комб1";
                ExcelApp.Range["M3"].Font.Bold = true;
                ExcelApp.Cells[1, 13] = "№2";
                ExcelApp.Cells[1, 14] = "средн. генер.";
                ExcelApp.Range[ExcelApp.Cells[1, 14], ExcelApp.Cells[3, 14]].Merge();

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 8] = Values.addString[i, j];
                    }
                }

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 5; j < 10; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 5] = Values.addValue[i, j];
                    }
                }

                //Tabl3
                ExcelApp.Cells[1, 16] = "Наименование участков";
                ExcelApp.Range[ExcelApp.Cells[1, 16], ExcelApp.Cells[3, 16]].Merge();
                ExcelApp.Cells[1, 17] = "Качество строительномонтажных работ";
                ExcelApp.Range[ExcelApp.Cells[1, 17], ExcelApp.Cells[2, 19]].Merge();
                ExcelApp.Cells[3, 17] = "адд";
                ExcelApp.Range["Q3"].Font.Bold = true;
                ExcelApp.Cells[3, 18] = "мулт";
                ExcelApp.Range["R3"].Font.Bold = true;
                ExcelApp.Cells[3, 19] = "комб";
                ExcelApp.Range["S3"].Font.Bold = true;
                ExcelApp.Cells[3, 20] = "комб1";
                ExcelApp.Range["T3"].Font.Bold = true;
                ExcelApp.Cells[1, 20] = "№3";
                ExcelApp.Cells[1, 21] = "средн. генер.";
                ExcelApp.Range[ExcelApp.Cells[1, 21], ExcelApp.Cells[3, 21]].Merge();

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 15] = Values.addString[i, j];
                    }
                }

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 10; j < 15; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 7] = Values.addValue[i, j];
                    }
                }


                //Tabl4
                ExcelApp.Cells[1, 23] = "Наименование участков";
                ExcelApp.Range[ExcelApp.Cells[1, 23], ExcelApp.Cells[3, 23]].Merge();
                ExcelApp.Cells[1, 24] = "Эксплуатационные факторы";
                ExcelApp.Range[ExcelApp.Cells[1, 24], ExcelApp.Cells[2, 26]].Merge();
                ExcelApp.Cells[3, 24] = "адд";
                ExcelApp.Range["X3"].Font.Bold = true;
                ExcelApp.Cells[3, 25] = "мулт";
                ExcelApp.Range["Y3"].Font.Bold = true;
                ExcelApp.Cells[3, 26] = "комб";
                ExcelApp.Range["Z3"].Font.Bold = true;
                ExcelApp.Cells[3, 27] = "комб1";
                ExcelApp.Range["AA3"].Font.Bold = true;
                ExcelApp.Cells[1, 27] = "№4";
                ExcelApp.Cells[1, 28] = "средн. генер.";
                ExcelApp.Range[ExcelApp.Cells[1, 28], ExcelApp.Cells[3, 28]].Merge();

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 22] = Values.addString[i, j];
                    }
                }

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 15; j < 20; j++)                                               
                    {
                        ExcelApp.Cells[i + 4, j + 9] = Values.addValue[i, j];
                    }
                }

                //Tabl5
                ExcelApp.Cells[1, 30] = "Наименование участков";
                ExcelApp.Range[ExcelApp.Cells[1, 30], ExcelApp.Cells[3, 30]].Merge();
                ExcelApp.Cells[1, 31] = "Качество производства труб и ЗА";
                ExcelApp.Range[ExcelApp.Cells[1, 31], ExcelApp.Cells[2, 33]].Merge();
                ExcelApp.Cells[3, 31] = "адд";
                ExcelApp.Range["AE3"].Font.Bold = true;
                ExcelApp.Cells[3, 32] = "мулт";
                ExcelApp.Range["AF3"].Font.Bold = true;
                ExcelApp.Cells[3, 33] = "комб";
                ExcelApp.Range["AG3"].Font.Bold = true;
                ExcelApp.Cells[3, 34] = "комб1";
                ExcelApp.Range["AH3"].Font.Bold = true;
                ExcelApp.Cells[1, 34] = "№5";
                ExcelApp.Cells[1, 35] = "средн. генер.";
                ExcelApp.Range[ExcelApp.Cells[1, 35], ExcelApp.Cells[3, 35]].Merge();

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 29] = Values.addString[i, j];
                    }
                }

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 20; j < 25; j++)
                    {                                                                               
                        ExcelApp.Cells[i + 4, j + 11] = Values.addValue[i, j];
                    }
                }

                //Tabl6
                ExcelApp.Cells[1, 37] = "Наименование участков";
                ExcelApp.Range[ExcelApp.Cells[1, 37], ExcelApp.Cells[3, 37]].Merge();
                ExcelApp.Cells[1, 38] = "Конструктивно-технологические факторы";
                ExcelApp.Range[ExcelApp.Cells[1, 38], ExcelApp.Cells[2, 40]].Merge();
                ExcelApp.Cells[3, 38] = "адд";
                ExcelApp.Range["AL3"].Font.Bold = true;
                ExcelApp.Cells[3, 39] = "мулт";
                ExcelApp.Range["AM3"].Font.Bold = true;
                ExcelApp.Cells[3, 40] = "комб";
                ExcelApp.Range["AN3"].Font.Bold = true;
                ExcelApp.Cells[3, 41] = "комб1";
                ExcelApp.Range["AO3"].Font.Bold = true;
                ExcelApp.Cells[1, 41] = "№6";
                ExcelApp.Cells[1, 42] = "средн. генер.";
                ExcelApp.Range[ExcelApp.Cells[1, 42], ExcelApp.Cells[3, 42]].Merge();

                for (int i = 0; i < values.MaxRowInExcel; i++)
                {
                    for (int j = 1; j < 2; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 36] = Values.addString[i, j];
                    }
                }

                for (int i = 0; i < values.MaxRowInExcel; i++)                                              
                {
                    for (int j = 25; j < 30; j++)
                    {
                        ExcelApp.Cells[i + 4, j + 13] = Values.addValue[i, j];
                    }
                }

                ExcelApp.Cells[values.MaxRowInExcel + 6, 2] = "для всего участка";
                ExcelApp.Range[ExcelApp.Cells[values.MaxRowInExcel + 6, 2], ExcelApp.Cells[values.MaxRowInExcel + 6, 3]].Merge();

                ExcelApp.Cells[values.MaxRowInExcel + 7, 3] = "среднее";
                ExcelApp.Range[ExcelApp.Cells[values.MaxRowInExcel + 7, 3], ExcelApp.Cells[values.MaxRowInExcel + 8, 5]].Merge();
                ExcelApp.Cells[values.MaxRowInExcel + 9, 3] = "адд";
                ExcelApp.Cells[values.MaxRowInExcel + 9, 4] = "мулт";
                ExcelApp.Cells[values.MaxRowInExcel + 9, 5] = "комб";
                ExcelApp.Cells[values.MaxRowInExcel + 9, 6] = "комб1";

                for (int i = values.MaxRowInExcel + 10; i < values.MaxRowInExcel + 10 + values.MaxRowInExcel; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        ExcelApp.Cells[i, j + 3] = Values.addValue[(i - (values.MaxRowInExcel + 10)), j + 30];
                    }
                }

                ExcelApp.Cells[(values.MaxRowInExcel + 6 + values.MaxRowInExcel+4), 2] = "среднее";
                for (int j = 0; j < 4; j++)
                {
                    ExcelApp.Cells[(values.MaxRowInExcel + 6 + values.MaxRowInExcel + 4), 3+j] = Values.allAverageValue[0,j];
                }

                ExcelApp.Cells[(values.MaxRowInExcel + 6 + values.MaxRowInExcel + 5), 2] = "средн.ген.";
                ExcelApp.Cells[(values.MaxRowInExcel + 6 + values.MaxRowInExcel + 5), 3] = Values.allAverageValue[1, 0];

                ExcelApp.Cells[(values.MaxRowInExcel + 6 + values.MaxRowInExcel + 6), 2] = "оптим.мод";
                for (int j = 0; j < 4; j++)
                {
                    ExcelApp.Cells[(values.MaxRowInExcel + 6 + values.MaxRowInExcel + 6), 3 + j] = Values.allAverageValue[2, j];
                }



                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();

                MessageBox.Show(saveFileDialog1.FileName, "Сохранение файла успешно выполнено");
            }
        }
    }
}
