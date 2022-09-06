using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Al_Khair_for_Installment
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            sqllite sql = new sqllite();
            int size = int.Parse(sizeproduct.Text);
            float price = (float)Convert.ToDouble(priceproduct.Text);
            if (electric_machines.Checked)
            {
               Boolean stauts= sql.setproduct(sql.getSQLiteConnection(), nameProduct.Text, size, price, "اجهزة كهربائية");
                if (stauts)
                {
                    MessageBox.Show("تم تسجل المنتج بي نجاح");
                }
                else
                {
                    MessageBox.Show("خطاء في تسجيل المنتج");
                }

            }else if (mobile.Checked)
            {
                Boolean stauts= sql.setproduct(sql.getSQLiteConnection(), nameProduct.Text, size, price,"محمول");
                if (stauts)
                {
                    MessageBox.Show("تم تسجل المنتج بي نجاح");
                }
                else
                {
                    MessageBox.Show("خطاء في تسجيل المنتج");
                }
            }
            
        }
    }
}
