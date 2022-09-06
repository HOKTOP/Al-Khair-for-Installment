using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Al_Khair_for_Installment
{
    public partial class Reguser : Form
    {
        public Reguser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqllite sql = new sqllite();
            if (sql.setadmin(sql.getSQLiteConnection(), username.Text, password.Text))
            {
                MessageBox.Show("تم التسجيل بي نجاح");
            }
            else
            {
                MessageBox.Show("خطاء في معلومات الاتصال");
            }




        }
    }
}
