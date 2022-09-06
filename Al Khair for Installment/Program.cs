using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Khair_for_Installment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            sqllite sql = new sqllite();
            SQLiteConnection sQLiteConnection = sql.getSQLiteConnection();
            sql.CreateTables(sQLiteConnection);
            SQLiteDataReader datauser = sql.ReadData(sQLiteConnection, "adminuser");
            int countdata = 0;

            if (checkWesbsite("https://hokssss.000webhostapp.com/"))
            {
                while (datauser.Read())
                {

                    Console.WriteLine(datauser.GetString(1));
                    countdata++;
                }
                if (countdata == 0)
                {
                    Application.Run(new Reguser());

                }
                else
                {

                    Application.Run(new Login());

                }
            }
            else
            {
                MessageBox.Show("تم اغلاق النظام يرجا الاتصل بي المبرمج  : 01032648474");
            }


        }
        public static Boolean checkWesbsite(string URL)
        {
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(URL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
       
        }

    }
}
