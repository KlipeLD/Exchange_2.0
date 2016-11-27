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
        OleDbConnection myOleDbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
@"D:\BSU\Лабы прога\Технологии программирования\Main\MainDLL\Database\Exchange.mdb");

        public string CheckDB(string nameOfTable, string col, string row)
        {
            myOleDbConnection.Open();
            string err="";

                int condition = col.Count();
                    OleDbCommand cmd =new OleDbCommand("SELECT * FROM [" + nameOfTable + "] WHERE [" + col + "]= '" + row + "'",myOleDbConnection);
                    OleDbDataReader dr = cmd.ExecuteReader();
                if (dr !=null && dr.Read())
                {
                    err = "0";
                }        
                else
                {
                    err = "1";
                }     
                
            myOleDbConnection.Close();
            return err;
        }
        public void EnterToDB(string nameOfDb , List<string> col, List<string> val)
        {
            String myOleDbCommand = "INSERT INTO [" + nameOfDb +
                "]([";
           for (int colCount =0; colCount !=col.Count; colCount ++)
            {
                myOleDbCommand += col[colCount];
                if (colCount == col.Count - 1)
                {
                    myOleDbCommand += "]) VALUES ('";
                }
                else
                {
                    myOleDbCommand += "],[";
                }
            }
           
            for (int valCount = 0; valCount != val.Count; valCount++)
            {
                myOleDbCommand += val[valCount];
                if (valCount == val.Count - 1)
                {
                    myOleDbCommand += "')";
                }
                else
                {
                    myOleDbCommand += "','";
                }
            }
            myOleDbConnection.Open();
            OleDbCommand cmd = new OleDbCommand(myOleDbCommand, myOleDbConnection);
            cmd.ExecuteNonQuery();
            myOleDbConnection.Close();
        }
        public void UpdateDB()
        {
            DataSet ds = new DataSet();
            using (myOleDbConnection)
            {
                myOleDbConnection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand("sp_CreateUser", myOleDbConnection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new OleDbParameter("@Покупка", OleDbType.Double, 10, "Покупка"));
                adapter.InsertCommand.Parameters.Add(new OleDbParameter("@Продажа", OleDbType.Double, 10, "Продажа"));
                /*
                OleDbParameter parameter = adapter.InsertCommand.Parameters.Add("@[Название валюты]", OleDbType.Char, 0, "USD");
                parameter.Direction = ParameterDirection.Output;
                */
                adapter.Update(ds);
            }
            }
        

        public List<string> ReadDB(string nameOfTable, string where, string znachenie)
        { 
            List<String> arr = new List<String>();
            using (myOleDbConnection)
            {
                myOleDbConnection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Продажа FROM Курс", myOleDbConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    arr.Add(reader.GetString(0));
                }
            }
            foreach (String row in arr)
            {
                arr.Add(row.ToString());
            }
            return arr;
        }
    }
}