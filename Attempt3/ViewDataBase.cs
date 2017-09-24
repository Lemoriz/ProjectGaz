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

    public partial class ViewDataBase : Form
    {

        private MainScreen mainScreen;

        public ViewDataBase()
        {

        }
        public ViewDataBase(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
            ControlBox = false;

        }

        private void BackToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainScreen.Visible = true;
        }

        private void ViewDataBase_Load(object sender, EventArgs e)
        {
            this.ShowIcon = true;
            this.MinimizeBox = true;
            this.MaximizeBox = true;

        }

        private void ComboBoxChooseSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ShowData()
        {
            //Values aa = new Values();

            //string asd = aa.ThePathToTheFolder;

            //if (asd != null)
            //{
            //    try
            //    {
            //        System.Data.OleDb.OleDbConnection MyConnection;
            //        System.Data.DataSet DtSet;
            //        System.Data.OleDb.OleDbDataAdapter MyCommand;
            //        MyConnection = new System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + asd + ";Extended Properties=Excel 12.0;"); MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
            //        MyCommand.TableMappings.Add("Table", "TestTable");
            //        DtSet = new System.Data.DataSet();
            //        MyCommand.Fill(DtSet);
            //        DataGridViewShowExcelDataBase.DataSource = DtSet.Tables[0];
            //        MyConnection.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
            //else { MessageBox.Show("Нет открытого файла", "Ошибка!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewShowExcelDataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ShowData();
        }

        DataSet result;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx", ValidateNames = true })
            //    {
            //        if (ofd.ShowDialog() == DialogResult.OK)
            //        {
            //Read excel file

            Values values = new Values();
            if (values.ThePathToTheFolder != null)
            {
                FileStream fs = File.Open(values.ThePathToTheFolder, FileMode.Open, FileAccess.Read);
                IExcelDataReader reader;
                if (values.TheFilterIndex == 1)
                    reader = ExcelReaderFactory.CreateBinaryReader(fs);
                else
                    reader = ExcelReaderFactory.CreateOpenXmlReader(fs);

                result = reader.AsDataSet();
                sboShee.Items.Clear();
                //Add sheet to combobox
                foreach (DataTable dt in result.Tables)
                    sboShee.Items.Add(dt.TableName);
                reader.Close();
            }
            else { MessageBox.Show("Нет открытого файла", "Ошибка!"); }
            //    }
            //}
        }
        
    

        private void sboShee_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Select sheet

            dataGridView.DataSource = result.Tables[sboShee.SelectedIndex];
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string a;
            string msg = String.Format("Row: {0}, Column: {1}",
            dataGridView.CurrentCell.RowIndex,
            dataGridView.CurrentCell.ColumnIndex);
            MessageBox.Show(msg, "Current Cell");
            a = Convert.ToString(dataGridView.Rows[3].Cells[2].Value);
            MessageBox.Show(a);

        }
    }
}