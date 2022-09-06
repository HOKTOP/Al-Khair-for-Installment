using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace Al_Khair_for_Installment
{
    internal class sqllite
    {

        SQLiteConnection sQLiteConnection;
        public  sqllite()
        {
            // Create a new database connection:
            sQLiteConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            string data = "./MyDatabase.db";
            if (!File.Exists(data))
            {
                SQLiteConnection.CreateFile("MyDatabase.db");
                sQLiteConnection = new SQLiteConnection("Data Source = MyDatabase.sqlite; Version = 3; ");
                sQLiteConnection.SetPassword("1231235a");

            }


            try
            {
                sQLiteConnection.Open();
            }
            catch (Exception ex)
            {

            }
        }

        public SQLiteConnection getSQLiteConnection()
        {
            return sQLiteConnection;
        }


        public Boolean setdataclient(SQLiteConnection conn,string nameclient, string phone, string id_number,string name_client_s, string phone_s, string id_number_s)
        {
            //اذا كان هناك اي دي كلينت موجود التحقق من وجود العميل في قاعدة البيانات
            //اذا لم يتم العصور علي العميل يقوم بي ادخال البيانات الممره كا عميل جديد
            if (!checkuser(conn, id_number))
            {
                try
                {
                    SQLiteDataReader sqlite_datareader;
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string addclient = $"INSERT INTO client('id','name','phone_number','number_id','clients_name','phone_number_s','id_number_s') VALUES (NULL, '{nameclient}', '{phone}', '{id_number}', '{name_client_s}', '{phone_s}', '{id_number_s}')";
                    sqlite_cmd.CommandText = addclient;
                    sqlite_cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception E)
                {
                    Console.WriteLine(E.Message);
                    return false;
                }
                return true;
            }
            return true;

        }
        public Boolean setintal(SQLiteConnection conn, string id_number, string Payable, string date_of_payment, string Discount, string Installment_percentage, string total_price, string type)
        {
            try
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                //نقوم بي الحصول علي اي دي العميل الجديد بعد تسجيله عن طريق رقم البطاقة
                int newclient = GETIDUSER(conn, id_number);
                int getidinvic = getidinvice(conn);
                //نقوم بي حفظ العاملية مرتبطة بي اي دي العميل
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = $"INSERT INTO Installments('id','idclient','Payable','date_of_payment','prodect','Discount','Installment_percentage','total_price','type') VALUES (NULL,'{newclient}','{Payable}','{date_of_payment}','{getidinvic}','{Discount}','{Installment_percentage}','{total_price}','{type}')";
                sqlite_cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                return false;
            }
        }
        public int GETIDUSER(SQLiteConnection conn, string idnumber)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT id FROM client WHERE number_id='{idnumber}'";
            int id = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
        
                return id;
            
        }
        public int getidinvice(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT id  FROM invoice ORDER BY id DESC LIMIT 1;";
            int id = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

            return id;
        }
        public Boolean checkuser(SQLiteConnection conn, string id_number)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT count(*) FROM client WHERE number_id='{id_number}'";
            int count = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
            if(count == 0)
            {
               return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean setinvice(SQLiteConnection conn,string products, double totalprice,string number_id)
        {
            try
            {
                int idclient = GETIDUSER(conn, number_id);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string invoice = $"INSERT INTO invoice(id ,products  ,totalprice ,number_id ,id_client) VALUES (NULL,'{products}','{totalprice}','{number_id}','{idclient}')";
                sqlite_cmd.CommandText = invoice;
                sqlite_cmd.ExecuteNonQuery();
                conn.Clone();
                return true;
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
        public void CreateTables(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string users = "create table if not exists adminuser(id INTEGER PRIMARY KEY AUTOINCREMENT,username TEXT, password TEXT)";
         sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = users;
            sqlite_cmd.ExecuteNonQuery();
            string product = "create table if not exists product(id INTEGER PRIMARY KEY AUTOINCREMENT,name TEXT, size int, price REAL,type TEXT,Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = product;
            sqlite_cmd.ExecuteNonQuery();
            string Installments = "create table if not exists Installments(id INTEGER PRIMARY KEY AUTOINCREMENT,idclient string ,Payable string,date_of_payment string,prodect string,Discount string,Installment_percentage string,total_price string,type string)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Installments;
            sqlite_cmd.ExecuteNonQuery();
            string client = "create table if not exists client(id INTEGER PRIMARY KEY AUTOINCREMENT,name TEXT ,phone_number TEXT,number_id TEXT,clients_name TEXT ,phone_number_s TEXT,id_number_s TEXT)";
            sqlite_cmd.CommandText = client;
            sqlite_cmd.ExecuteNonQuery();
            conn.Clone();
            string invoice = "create table if not exists invoice(id INTEGER PRIMARY KEY AUTOINCREMENT,products TEXT ,totalprice Real,number_id int,id_client int,Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP)";
            sqlite_cmd.CommandText = invoice;
            sqlite_cmd.ExecuteNonQuery();
            conn.Clone();

        }
        public SQLiteDataReader ReadData(SQLiteConnection conn,string nametable)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT * FROM {nametable}";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            
            return sqlite_datareader;
        }
        public Boolean closereader(SQLiteDataReader sqlite_datareader)
        {
            try
            {
                sqlite_datareader.Close();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
           
        }

        public Boolean setadmin(SQLiteConnection conn ,string username, string password)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO adminuser(id,username,password) VALUES(null,'{username}', '{password}')";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
                conn.Clone();
                return true;
            }catch(Exception E)
            {
                return false;
            }
        }
        public Boolean setproduct(SQLiteConnection conn, string name, int size,float price,string type)
        {
            SQLiteCommand sqlite_cmd;


            try
            {
                sqlite_cmd = conn.CreateCommand();
                string queryString = $"INSERT INTO product(id,name,size,price,type) VALUES(null,'{name}', '{size}','{price}','{type}')";
  

                    using (var command = new SQLiteCommand(queryString, conn))
                    {
                        command.ExecuteNonQuery();
                    }
               
                return true;
            }
            catch (Exception E)
            {
                return false;
            }
        }
    }
}
