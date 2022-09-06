using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Al_Khair_for_Installment
{
    
    public partial class Form1 : Form
    {
        sqllite sql = new sqllite();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (addProduct product =new addProduct())
            {
                if(product.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getproduct();
        }

        void getproduct()
        {
            try
            {
                dataGridView1.DataSource = null;

            }
            catch (Exception e){
            
            }
            SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter("Select * From product", sql.getSQLiteConnection());
            DataSet dataSet = new DataSet();
            sQLiteDataAdapter.Fill(dataSet, "prodect");
            dataGridView1.DataSource = dataSet.Tables[0];
            if (!dataGridView1.Columns.Contains("editdata"))
            {
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.FlatStyle = FlatStyle.Popup;
                edit.HeaderText = "Edit";
                edit.Name = "editdata";
                edit.UseColumnTextForButtonValue = true;
                edit.Text = "تعديل البيانات";
                dataGridView1.Columns.Add(edit);
            }


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            addProduct product = new addProduct();
            product.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ibstall instalslment = new ibstall();
            instalslment.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("غير متاح في الفترة التجربية");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getinstallday();
        }
        void getinstallday()
        {
            try
            {
                dataGridView1.DataSource = null;

            }
            catch (Exception e)
            {

            }
            DateTime dateTime = dateTimePicker1.Value.Date;
            string datetimae = dateTime.ToString().Split(" ")[0].ToString();
            SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter($"Select * From Installments WHERE date_of_payment = '{datetimae}'  ", sql.getSQLiteConnection());
            DataSet dataSet = new DataSet();
            sQLiteDataAdapter.Fill(dataSet, "Installments");
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("غير متاح في الفترة التجربية");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("غير متاح في الفترة التجربية التعديل علي البيانات او السداد او عرض بيانات العميل");
        }
    }
}
