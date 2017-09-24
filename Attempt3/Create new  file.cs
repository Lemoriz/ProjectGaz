using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attempt3
{
    public partial class Create_new__file : Form
    {

        private MainScreen mainScreen;

        public Create_new__file(MainScreen mainScreen)
        {
            this.mainScreen = mainScreen;
            InitializeComponent();
            ControlBox = false;
        }

        DataTable table = new DataTable();

        int selectedRow;

        public Create_new__file()
        {

        }

        private void BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainScreen.Visible = true;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // add row to datatable from textboxes
            dataGridView1.Rows.Add(textBox1.Text, NameLand.Text, B11.Text, Bb12.Text, Bb13.Text, Bb14.Text, Bb21.Text, Bb22.Text, Bb23.Text, Bb24.Text, Bb31.Text, Bb32.Text, Bb33.Text, Bb34.Text, Bb35.Text, Bb41.Text, Bb42.Text, Bb43.Text, Bb44.Text, Bb45.Text, Bb46.Text, Bb47.Text, Bb51.Text, Bb52.Text, Bb53.Text, Bb54.Text, Bb55.Text, Bb56.Text, Bb57.Text, Bb61.Text, Bb62.Text, Bb63.Text, Bb64.Text, Bb65.Text);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            /////
            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];

            newDataRow.Cells[0].Value = textBox1.Text;
            newDataRow.Cells[1].Value = NameLand.Text;
            newDataRow.Cells[2].Value = B11.Text;
            newDataRow.Cells[3].Value = Bb12.Text;
            newDataRow.Cells[4].Value = Bb13.Text;
            newDataRow.Cells[5].Value = Bb14.Text;
            newDataRow.Cells[6].Value = Bb21.Text;
            newDataRow.Cells[7].Value = Bb22.Text;
            newDataRow.Cells[8].Value = Bb23.Text;
            newDataRow.Cells[9].Value = Bb24.Text;
            newDataRow.Cells[10].Value = Bb31.Text;
            newDataRow.Cells[11].Value = Bb32.Text;
            newDataRow.Cells[12].Value = Bb33.Text;
            newDataRow.Cells[13].Value = Bb34.Text;
            newDataRow.Cells[14].Value = Bb35.Text;
            newDataRow.Cells[15].Value = Bb41.Text;
            newDataRow.Cells[16].Value = Bb42.Text;
            newDataRow.Cells[17].Value = Bb43.Text;
            newDataRow.Cells[18].Value = Bb44.Text;
            newDataRow.Cells[19].Value = Bb45.Text;
            newDataRow.Cells[20].Value = Bb46.Text;
            newDataRow.Cells[21].Value = Bb47.Text;
            newDataRow.Cells[22].Value = Bb51.Text;
            newDataRow.Cells[23].Value = Bb52.Text;
            newDataRow.Cells[24].Value = Bb53.Text;
            newDataRow.Cells[25].Value = Bb54.Text;
            newDataRow.Cells[26].Value = Bb55.Text;
            newDataRow.Cells[27].Value = Bb56.Text;
            newDataRow.Cells[28].Value = Bb57.Text;
            newDataRow.Cells[29].Value = Bb61.Text;
            newDataRow.Cells[30].Value = Bb62.Text;
            newDataRow.Cells[31].Value = Bb63.Text;
            newDataRow.Cells[32].Value = Bb64.Text;
            newDataRow.Cells[33].Value = Bb65.Text;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // delete datagridview row selected row
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get datagridview selected row
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            // display datagridview selected row data into textboxes
            if (dataGridView1.Rows[selectedRow].Cells[selectedRow].Value != null)
            {
                textBox1.Text = row.Cells[0].Value.ToString();
                NameLand.Text = row.Cells[1].Value.ToString();
                B11.Text = row.Cells[2].Value.ToString();
                Bb12.Text = row.Cells[3].Value.ToString();
                Bb13.Text = row.Cells[4].Value.ToString();
                Bb14.Text = row.Cells[5].Value.ToString();
                Bb21.Text = row.Cells[6].Value.ToString();
                Bb22.Text = row.Cells[7].Value.ToString();
                Bb23.Text = row.Cells[8].Value.ToString();
                Bb24.Text = row.Cells[9].Value.ToString();
                Bb31.Text = row.Cells[10].Value.ToString();
                Bb32.Text = row.Cells[11].Value.ToString();
                Bb33.Text = row.Cells[12].Value.ToString();
                Bb34.Text = row.Cells[13].Value.ToString();
                Bb35.Text = row.Cells[14].Value.ToString();
                Bb41.Text = row.Cells[15].Value.ToString();
                Bb42.Text = row.Cells[16].Value.ToString();
                Bb43.Text = row.Cells[17].Value.ToString();
                Bb44.Text = row.Cells[18].Value.ToString();
                Bb45.Text = row.Cells[19].Value.ToString();
                Bb46.Text = row.Cells[20].Value.ToString();
                Bb47.Text = row.Cells[21].Value.ToString();
                Bb51.Text = row.Cells[22].Value.ToString();
                Bb52.Text = row.Cells[23].Value.ToString();
                Bb53.Text = row.Cells[24].Value.ToString();
                Bb54.Text = row.Cells[25].Value.ToString();
                Bb55.Text = row.Cells[26].Value.ToString();
                Bb56.Text = row.Cells[27].Value.ToString();
                Bb57.Text = row.Cells[28].Value.ToString();
                Bb61.Text = row.Cells[29].Value.ToString();
                Bb62.Text = row.Cells[30].Value.ToString();
                Bb63.Text = row.Cells[31].Value.ToString();
                Bb64.Text = row.Cells[32].Value.ToString();
                Bb65.Text = row.Cells[33].Value.ToString();
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            NameLand.Text = null;
            B11.Text = null;
            Bb12.Text = null;
            Bb13.Text = null;
            Bb14.Text = null;
            Bb21.Text = null;
            Bb22.Text = null;
            Bb23.Text = null;
            Bb24.Text = null;
            Bb31.Text = null;
            Bb32.Text = null;
            Bb33.Text = null;
            Bb34.Text = null;
            Bb35.Text = null;
            Bb41.Text = null;
            Bb42.Text = null;
            Bb43.Text = null;
            Bb44.Text = null;
            Bb45.Text = null;
            Bb46.Text = null;
            Bb47.Text = null;
            Bb51.Text = null;
            Bb52.Text = null;
            Bb53.Text = null;
            Bb54.Text = null;
            Bb55.Text = null;
            Bb56.Text = null;
            Bb57.Text = null;
            Bb61.Text = null;
            Bb62.Text = null;
            Bb63.Text = null;
            Bb64.Text = null;
            Bb65.Text = null;
        }
    }
}
