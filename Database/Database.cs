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



namespace DatabaseDLL
{
    public class Database
    {
        OleDbConnection myOleDbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
@"D:\BSU\Лабы прога\Технологии программирования\Main\MainDLL\Database\Exchange.mdb");

        public string CheckDB(string nameOfTable, string col, string row)
        {
            myOleDbConnection.Open();
            string err = "";

            int condition = col.Count();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + nameOfTable + "] WHERE [" + col + "]= '" + row + "'", myOleDbConnection);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr != null && dr.Read())
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
        public void EnterToDB(string nameOfDb, List<string> col, List<string> val)
        {
            String myOleDbCommand = "INSERT INTO [" + nameOfDb +
                "]([";
            for (int colCount = 0; colCount != col.Count; colCount++)
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
        //Update массива
        public void UpdateDB(string nameOfTable, string newZnachNameOfCol, List<string> newZnach,
            string wherColZnachName, List<string> wherColZnach)
        {
            int ncol = newZnach.Count;
            myOleDbConnection.Open();
            for (int i = 0; i < ncol; i++)
            {
                string cmd0 = string.Format("Update [{0}] Set [{1}] = '{2}' Where [{3}] = '{4}'",
                       nameOfTable, newZnachNameOfCol, newZnach[i], wherColZnachName, wherColZnach[i]);
                using (OleDbCommand cmd = new OleDbCommand(cmd0, this.myOleDbConnection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            myOleDbConnection.Close();
        }
        //Update одного значения
        public void UpdateDBOne(string nameOfTable, string newZnachNameOfCol, string newZnach,
    string wherColZnachName, string wherColZnach)
        {
            myOleDbConnection.Open();
            string cmd0 = string.Format("Update [{0}] Set [{1}] = '{2}' Where [{3}] = '{4}'",
                   nameOfTable, newZnachNameOfCol, newZnach, wherColZnachName, wherColZnach);
            using (OleDbCommand cmd = new OleDbCommand(cmd0, this.myOleDbConnection))
            {
                cmd.ExecuteNonQuery();
            }
            myOleDbConnection.Close();
        }
        public List<string> ReadDB(string nameOfTable, List<string> col, List<string> row)
        {
            List<String> arr = new List<String>();
            using (myOleDbConnection)
            {
                myOleDbConnection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + nameOfTable, myOleDbConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    arr.Add(reader.GetString(0));
                }
            }
            return arr;
        }
        public List<string> ReadData(string nameOfTable, string colName)
        {
            List<string> data = new List<string>();
            OleDbCommand cmd = new OleDbCommand("Select [" + colName + "] From [" + 
                nameOfTable + "]", myOleDbConnection);
            myOleDbConnection.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.HasRows)
            {
                while (dr.HasRows && dr.Read())
                {
                    data.Add(dr.GetValue(0).ToString());
                }
                dr.NextResult();
            }
            myOleDbConnection.Close();
            return data;
        }
        public string ReadData(string nameOfTable, string colName, string whereNameCol, string whereZ)
        {
            myOleDbConnection.Open();
            string data;
            OleDbCommand cmd = new OleDbCommand("Select [" + colName + "] From [" + nameOfTable + "] WHERE [" + whereNameCol + "] ='" + whereZ + "'", myOleDbConnection);
            using (cmd)
            {
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    data = dr.GetValue(0).ToString();
                }
                else
                {
                    data = "error";
                }
                dr.Close();
            }
            myOleDbConnection.Close();
            return data;
        }
        public string ReturnZnach(string nameOfTable, string col, string row, string nameOfCol)
        {
            string textBox;
            myOleDbConnection.Open();
            int condition = col.Count();
            OleDbCommand cmd = new OleDbCommand("SELECT [" + nameOfCol + "] FROM [" + nameOfTable + "] WHERE [" + col + "]= '" + row + "'", myOleDbConnection);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                textBox = dr.GetValue(0).ToString();
            }
            else
            {
                textBox = "error";
            }
            myOleDbConnection.Close();
            return textBox;
        }
    }
}