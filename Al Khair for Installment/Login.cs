using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Al_Khair_for_Installment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginb_Click(object sender, EventArgs e)
        {
            sqllite sqllite = new sqllite();
            SQLiteConnection CON = sqllite.getSQLiteConnection();
            SQLiteDataReader data = sqllite.ReadData(CON, "adminuser");
            while (data.Read())
            {
               if(data.GetValue(1).ToString() == user.Text && data.GetValue(2).ToString() == passowrd.Text)
                {
                    Form1 form1 = new Form1();
              
                    form1.Show();
                    this.Visible = false;
                    data.Close();
                    break;
                }

            }
        }
    }
}
