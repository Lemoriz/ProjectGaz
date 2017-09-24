using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Runtime.InteropServices;

namespace Attempt3
{
    public partial class MainScreen : Form
    {
        private ViewDataBase viewDataBase;
        private Create_new__file createFile;

        public MainScreen()
        {
            InitializeComponent();
            viewDataBase = new ViewDataBase(this) { Visible = false };
            createFile = new Create_new__file(this) { Visible = false };
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void CreateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void CreateProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            createFile.Visible = true;

            //Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            //if (xlApp == null)
            //{
            //    MessageBox.Show("Excel is not properly installed!!");
            //    return;
            //}


            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //xlWorkSheet.Cells[1, 1] = "ID";
            //xlWorkSheet.Cells[1, 2] = "Name";
            //xlWorkSheet.Cells[2, 1] = "1";
            //xlWorkSheet.Cells[2, 2] = "One";
            //xlWorkSheet.Cells[3, 1] = "2";
            //xlWorkSheet.Cells[3, 2] = "Two";



            //xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //Marshal.ReleaseComObject(xlWorkSheet);
            //Marshal.ReleaseComObject(xlWorkBook);
            //Marshal.ReleaseComObject(xlApp);

            //MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");

        }

        private void OpenProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            Values thePathToTheFile = new Values();
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx", ValidateNames = true })

            //    openFile.Title = "Выберите файл";
            //openFile.Filter = "Excel|* xlsx";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                thePathToTheFile.TheFilterIndex = openFile.FilterIndex;
                thePathToTheFile.ThePathToTheFolder = openFile.FileName;
                MessageBox.Show(openFile.FileName, "Загружен файл из папки");
            }

        }

        private void SaveProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void CloseProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void СalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PerformToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConstructAGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void ViewDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            viewDataBase.Visible = true;
            
            
        }
    }
}
