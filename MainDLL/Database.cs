using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.OleDb;
using System.IO;



namespace MainDLL
{
    public class Database
    {
        public void EnterToDB(string surname, string name, string fname)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
            @"D:\BSU\Лабы прога\Технологии программирования\Main\MainDLL\Database\Exchange.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            String myOleDbCommand = "INSERT INTO [Кассир] " +
                "(Фамилия, Имя, Отчество)" + "VALUES ('" + surname + "','" + name + "','" + fname + "')";
            myOleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand(myOleDbCommand, myOleDbConnection);
            cmd.ExecuteNonQuery();
            myOleDbConnection.Close();
        }
        public void EnterToDB(string surname, string name, string fname, string passport)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                @"D:\BSU\Лабы прога\Технологии программирования\Main\MainDLL\Database\Exchange.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            String myOleDbCommand = "INSERT INTO [Клиент] " +
                "(Фамилия, Имя, Отчество, [Номер паспорта])" + "VALUES ('" + surname + "','" + name + "','" + fname + "','" + passport + "')";
            myOleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand(myOleDbCommand, myOleDbConnection);
            cmd.ExecuteNonQuery();
            myOleDbConnection.Close();
        }
        /*public void UpdateDB()
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
     @"D:\BSU\Лабы прога\Технологии программирования\Obmennik\Obmennik\Exchange.mdb");

            // Объект DataAdapter является посредником при взаимодействии базы данных и объекта DataSet
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapter1 = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapterUSD = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapterEUR = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapterRUB = new OleDbDataAdapter();
            OleDbDataAdapter adaptUSBupdate = new OleDbDataAdapter();
            // DataSet сохраняет данные в памяти с помощью таблиц данных DataTable      
            DataSet myDataSet = new DataSet();
            DataSet myDataSet1 = new DataSet();
            DataSet dsUSD = new DataSet();
            DataSet dsEUR = new DataSet();
            DataSet dsRUB = new DataSet();
            DataSet dsUpUSB = new DataSet();

            BindingSource myBS = new BindingSource();
            BindingSource myBS1 = new BindingSource();
            BindingSource bsUSD = new BindingSource();
            BindingSource bsEUR = new BindingSource();
            BindingSource bsRUB = new BindingSource();

            try
            {
                myConn.Open();
            }
            catch
            {
          //      MessageBox.Show("Не удалось подключиться к базе данных.", "Error 205", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //MessageBox.Show("Курс валют успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            myConn.Close();
        }
        */

        public void ReadDB()
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
    @"D:\BSU\Лабы прога\Технологии программирования\Main\MainDLL\Database\Exchange.mdb");
            /*
            // Объект DataAdapter является посредником при взаимодействии базы данных и объекта DataSet
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapter1 = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapterUSD = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapterEUR = new OleDbDataAdapter();
            OleDbDataAdapter myDataAdapterRUB = new OleDbDataAdapter();
            OleDbDataAdapter adaptUSBupdate = new OleDbDataAdapter();
            // DataSet сохраняет данные в памяти с помощью таблиц данных DataTable      
            DataSet myDataSet = new DataSet();
            DataSet myDataSet1 = new DataSet();
            DataSet dsUSD = new DataSet();
            DataSet dsEUR = new DataSet();
            DataSet dsRUB = new DataSet();
            DataSet dsUpUSB = new DataSet();
            
            BindingSource myBS = new BindingSource();
            BindingSource myBS1 = new BindingSource();
            BindingSource bsUSD = new BindingSource();
            BindingSource bsEUR = new BindingSource();
            BindingSource bsRUB = new BindingSource();
            */
            /*myDataSet.Tables.Add("Курс");
            myDataSet1.Tables.Add("Курс");
            dsUSD.Tables.Add("Курс");
            dsEUR.Tables.Add("Курс");
            dsRUB.Tables.Add("Курс");
            dsUpUSB.Tables.Add("Курс");
            try
            {
                myConn.Open();
            }
            catch
            {
              //  MessageBox.Show("Не удалось подключиться к базе данных.", "Error 206", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            myDataAdapter.SelectCommand = new OleDbCommand("SELECT * FROM [Курс]", myConn);
            myDataAdapter1.SelectCommand = new OleDbCommand("SELECT * FROM [Курс]", myConn);
            myDataAdapterUSD.SelectCommand = new OleDbCommand("SELECT [Название валюты],[Покупка],[Продажа] FROM [Курс] WHERE [Название валюты]='USD'", myConn);
            myDataAdapterEUR.SelectCommand = new OleDbCommand("SELECT [Название валюты],[Покупка],[Продажа] FROM [Курс] WHERE [Название валюты]='EUR'", myConn);
            myDataAdapterRUB.SelectCommand = new OleDbCommand("SELECT [Название валюты],[Покупка],[Продажа] FROM [Курс] WHERE [Название валюты]='RUB'", myConn);


            //Заполняем находящийся в памяти объект DataSet данными
            myDataAdapter.Fill(myDataSet.Tables["Курс"]);
            myDataAdapter1.Fill(myDataSet1.Tables["Курс"]);
            myDataAdapterUSD.Fill(dsUSD.Tables["Курс"]);
            myDataAdapterEUR.Fill(dsEUR.Tables["Курс"]);
            myDataAdapterRUB.Fill(dsRUB.Tables["Курс"]);

            myBS.DataMember = "Курс";
            myBS.DataSource = myDataSet;
            myBS1.DataMember = "Курс";
            myBS1.DataSource = myDataSet1;
            bsEUR.DataMember = "Курс";
            bsEUR.DataSource = dsEUR;
            bsUSD.DataMember = "Курс";
            bsUSD.DataSource = dsUSD;
            bsRUB.DataMember = "Курс";
            bsRUB.DataSource = dsRUB;


            comboBox2.DataSource = myBS;
            comboBox2.DisplayMember = "Название валюты";
            comboBox1.DataSource = myBS1;
            comboBox1.DisplayMember = "Название валюты";

            textBox16.DataBindings.Add(new Binding("Text", myBS, "Покупка", true));
            textBox15.DataBindings.Add(new Binding("Text", myBS, "Продажа", true));
            textBox2.DataBindings.Add(new Binding("Text", myBS1, "Покупка", true));
            textBox1.DataBindings.Add(new Binding("Text", myBS1, "Продажа", true));
            //USD
            textBox12.DataBindings.Add(new Binding("Text", bsUSD, "Покупка", true));
            textBox11.DataBindings.Add(new Binding("Text", bsUSD, "Продажа", true));
            textBox6.DataBindings.Add(new Binding("Text", bsUSD, "Покупка", true));
            textBox5.DataBindings.Add(new Binding("Text", bsUSD, "Продажа", true));
            //EUR
            textBox10.DataBindings.Add(new Binding("Text", bsEUR, "Покупка", true));
            textBox9.DataBindings.Add(new Binding("Text", bsEUR, "Продажа", true));
            textBox8.DataBindings.Add(new Binding("Text", bsEUR, "Покупка", true));
            textBox7.DataBindings.Add(new Binding("Text", bsEUR, "Продажа", true));
            //RUB
            textBox4.DataBindings.Add(new Binding("Text", bsRUB, "Покупка", true));
            textBox3.DataBindings.Add(new Binding("Text", bsRUB, "Продажа", true));
            textBox14.DataBindings.Add(new Binding("Text", bsRUB, "Покупка", true));
            textBox13.DataBindings.Add(new Binding("Text", bsRUB, "Продажа", true));
            */
            myConn.Close();
        }
    }
}