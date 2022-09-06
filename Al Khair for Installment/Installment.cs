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
   
    public partial class Installment : Form
    {
        List<string> LISTPRODUCT = new List<string>();
        sqllite sql =new sqllite();
        int idproduct;
        string name;
        double pricet;
        int Quantitya;
        public Installment()
        {
            InitializeComponent();
            getdatatolistproduct();
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }

        private void getdatatolistproduct()
        {
            sql.getSQLiteConnection();
            SQLiteDataReader data =sql.ReadData(sql.getSQLiteConnection(), "product");
            listBox1.Items.Clear();

            while (data.Read())
            {
                listBox1.Items.Add($"{data.GetValue(1)}");
                LISTPRODUCT.Add(data.GetValue(0).ToString()+":"+data.GetValue(1).ToString() + ":"+data.GetValue(2).ToString() + ":"+data.GetValue(3).ToString());
            }
            data.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string dataprodect = LISTPRODUCT[listBox1.SelectedIndex];
            string[] spliter = dataprodect.Split(":");
            idproduct = int.Parse(spliter[0]);
            name = spliter[1];
            pricet = double.Parse(spliter[3].ToString());
            Quantitya = int.Parse(spliter[2]);
            nameproduct_0.Text = name;
            priceproduct_0.Text = pricet.ToString();
            Quantity.Text = Quantitya.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {

                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dataGridView1);

          
            row.Cells[0].Value = nameproduct_0.Text;
            row.Cells[1].Value = Quantity.Text;
            row.Cells[2].Value = priceproduct_0.Text;
            dataGridView1.Rows.Add(row);
            getdata();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

        }
        double value = 0;
        void getdata()
        {
            totalprice.Text = null;
             value =0;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                value +=  Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
            }
            totalprice.Text = value.ToString();
        }
        double getdataa()
        {
            double values = 0;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                values += Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
            }
            return values;
        }
        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!discount.Text.Equals(""))
            {
                label23.Visible = false;
            }
            else
            {
                label23.Visible = true;

            }
        }

        private void Installment_Load(object sender, EventArgs e)
        {

    
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            getdata();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
                        getdata();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void plus_TextChanged(object sender, EventArgs e)
        {
            if (!plus.Text.Equals(""))
            {
                label19.Visible = false;
            }
            else
            {
                label19.Visible = true;

            }
        }
        double text = 0;
        private void interest_rate() {
            if (this.plus.Text.Equals(null))
            {
                 text = 0;

            }
            else
            {
                try
                {
                    text = Convert.ToDouble(this.plus.Text);
                }catch(Exception E)
                {

                }

            }
            double plus = getdataa() * text / 100 ;
            value += plus;
            totalprice.Text = value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interest_rate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ninterest_rate();
        }
        private void ninterest_rate()
        {
        
            if (this.plus.Text.Equals(null))
            {
                text = 0;

            }
            else
            {
                try
                {
                    text = Convert.ToDouble(this.plus.Text);
                }
                catch (Exception E)
                {

                }

            }
            double plus = value * text / 100;
            value = value -plus;
            totalprice.Text = value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string phoneclient =c.Text;
            string id_number__client = textBox2.Text;
            string name_s__client = textBox6.Text;
            string phone_s__client = textBox4.Text;
            string id_number_s__client = textBox5.Text;
            string nameclient = textBox1.Text;
           sqllite sqllites = new sqllite();
            try
            {
               Boolean  s=  sqllites.setdataclient(sqllites.getSQLiteConnection(), nameclient, phoneclient, id_number__client, name_s__client, phone_s__client, id_number_s__client);
                if (s)
                {
                    List<string> lisssdsdt = new List<string>();
                     
                    for(int i = 0; i < LISTPRODUCT.Count; i++)
                    {
                        lisssdsdt.Add(LISTPRODUCT[i]);
                    }
                    string idproducts= String.Join(',', lisssdsdt);
                    sqllites.setinvice(sqllites.getSQLiteConnection(), idproducts, value, id_number__client);
                    for(int i = 0; i < listBox2.Items.Count; i++)
                    {
                        sql.setintal(sqllites.getSQLiteConnection(), id_number__client, listBox2.Items[i].ToString().Split(":")[1], listBox2.Items[0].ToString().Split(":")[0], discount.Text, plus.Text, value.ToString(), "مستحق");

                    }
                }
            }
            catch(Exception       E)
            {
                MessageBox.Show(E.Message);
            }
            }
        int day = 0;
        int payday = 0;
        int totalday =0;
        int totaldaypay =0;
        int check = 0;
        double aa = 0;
        void installment()
        {
            check = 0;
            aa = 0;
            if (radioButton2.Checked)
            {
                priceistall.Enabled = false;

            }
            try
            {
                if (month.Checked)
                {
                    day = 30;
                    totalday = int.Parse(Duration.Text) * day;
                    if (yeary.Checked)
                    {
                        check = totalday / 365;

                    }
                    else if (weekly.Checked)
                    {
                        check = totalday / 7;

                    }
                    else if (mothey.Checked)
                    {
                        check = totalday / 30;
                    }

                }
                else if (year.Checked)
                {
                    day = 365;
                    totalday = int.Parse(Duration.Text) * day;
                    if (yeary.Checked)
                    {
                        check = totalday / 365;

                    }
                    else if (weekly.Checked)
                    {
                        check = totalday / 7;

                    }
                    else if (mothey.Checked)
                    {
                        check = totalday / 30;
                    }
                   

                }


                if (weekly.Checked)
                {
                    payday = 7;
                    totaldaypay = totalday / payday;
                    double price = Convert.ToDouble(totalprice.Text) / totaldaypay;
                    double chesck = Convert.ToDouble(this.check) * price;
                    if (chesck < Convert.ToDouble(totalprice.Text))
                    {
                         aa = Convert.ToDouble(totalprice.Text) - chesck;
                        //ترحيل المبلغ علي الشهر الاول 
                    }
                    priceistall.Text = price.ToString();


                }
                
                else if (mothey.Checked)
                {
                    payday = 30;
                    totaldaypay = totalday / payday;
                    double price = Convert.ToDouble(totalprice.Text) / totaldaypay;
                    double chesck = Convert.ToDouble(this.check) * price;
                    if (chesck < Convert.ToDouble(totalprice.Text))
                    {
                         aa = Convert.ToDouble(totalprice.Text) - chesck;
                        //ترحيل المبلغ علي الشهر الاول 
                    }
                    priceistall.Text = price.ToString();

                }
                else if (yeary.Checked)
                {
                    payday = 365;
                    totaldaypay = totalday / payday;
                    double price = Convert.ToDouble(totalprice.Text) / totaldaypay;
                    double chesck = Convert.ToDouble(this.check) * price;
                    if (chesck < Convert.ToDouble(totalprice.Text))
                    {
                         aa = Convert.ToDouble(totalprice.Text) - chesck;
                        //ترحيل المبلغ علي الشهر الاول 
                    }
                    priceistall.Text = price.ToString();
                }

            }catch(Exception e)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            installment();
            gettimepy();
        }
        DateTime newdate;

        private void gettimepy()
        {
            listBox2.Items.Clear();
            DateTime date = dateTimePicker1.Value.Date;
            if (weekly.Checked)
            {
                for (int i = 1; i <= check; i++)
                {
                    double priceistalls = Convert.ToDouble(priceistall.Text);
                    if (aa != 0 && i == 1)
                    {
                        priceistalls = Convert.ToDouble(priceistall.Text) + aa;
                        listBox2.Items.Add(date + ":" + priceistalls);

                    }
                    else if (i == 1 && aa == 0)
                    {
                        listBox2.Items.Add(date + ":" + priceistalls);
                    }
                    else
                    {
                        newdate = date.AddDays(7 *i-7);
                        listBox2.Items.Add(newdate + ":" + priceistalls);

                    }

                }

            }
            else if (mothey.Checked)
            {

                for (int i = 1; i <= check; i++)
                {

                    double priceistalls = Convert.ToDouble(priceistall.Text);
                    if (aa != 0 && i == 1)
                    {
                        priceistalls = Convert.ToDouble(priceistall.Text) + aa;
                        listBox2.Items.Add(date + ":" + priceistalls);

                    }
                    else if (i == 1 && aa == 0)
                    {
                        listBox2.Items.Add(date + ":" + priceistalls);
                    }
                    else
                    {
                        newdate = date.AddMonths(1*i-1);
                        listBox2.Items.Add(newdate + ":" + priceistalls);

                    }

                }

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                priceistall.Enabled = true;
                timer1.Enabled = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals(""))
            {
                label7.Visible = false;
            }
            else
            {
                label7.Visible = true;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!c.Text.Equals(""))
            {
                label8.Visible = false;
            }
            else
            {
                label8.Visible = true;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!textBox6.Text.Equals(""))
            {
                label11.Visible = false;
            }
            else
            {
                label11.Visible = true;

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!c.Text.Equals(""))
            {
                label10.Visible = false;
            }
            else
            {
                label10.Visible = true;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!c.Text.Equals(""))
            {
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;

            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
                    }

        private void Duration_TextChanged(object sender, EventArgs e)
        {
            //label18
            if (!Duration.Text.Equals(""))
            {
                label18.Visible = false;
            }
            else
            {
                label18.Visible = true;

            }
        }

        private void nameproduct_0_TextChanged(object sender, EventArgs e)
        {
            if (!nameproduct_0.Text.Equals(""))
            {
                label12.Visible = false;
            }
            else
            {
                label12.Visible = true;

            }
        }

        private void priceproduct_0_TextChanged(object sender, EventArgs e)
        {
            if (!priceproduct_0.Text.Equals(""))
            {
                label13.Visible = false;
            }
            else
            {
                label13.Visible = true;

            }
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            if (!Quantity.Text.Equals(""))
            {
                label15.Visible = false;
            }
            else
            {
                label15.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            totalprice.Text =(value - Convert.ToDouble(discount.Text)).ToString();
        }
    }
}
