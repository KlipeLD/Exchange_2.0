using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseDLL;

namespace MainDLL
{
    public class Admin
    {
        Database db = new Database();
        public List<string> CurrencyOperation()
        {
            List<string> dataS = new List<string>();
            List<string> data = new List<string>();
            string nameOfTable = "Курс";
            string wherColZnach = "Покупка";
            data.AddRange(db.ReadData(nameOfTable, wherColZnach));
            wherColZnach = "Продажа";
            dataS.AddRange(db.ReadData(nameOfTable, wherColZnach));
            data.AddRange(dataS);
            return data;
        }
        public void UpdateCurrency(List<string> newZnachP, List<string> newZnachS)
        {
            string nameOfTable = "Курс";
            List<string> data = new List<string>();
            string newSale = "Продажа";
            string newPurch = "Покупка";
            string wherColZnachName = "Название валюты";
            List<string> wherColZnach = new List<string>();
            wherColZnach = db.ReadData(nameOfTable, wherColZnachName);//
            db.UpdateDB(nameOfTable, newPurch, newZnachP, wherColZnachName, wherColZnach);
            db.UpdateDB(nameOfTable, newSale, newZnachS, wherColZnachName, wherColZnach);
            data = db.ReadData(nameOfTable, wherColZnachName);
        }
        public void UpdateCurrencyCBox(string newZnachP, string newZnachS, string nameOfBox)
        {
            string nameOfTable = "Курс";
            List<string> data = new List<string>();
            string newSale = "Продажа";
            string newPurch = "Покупка";
            string wherColZnachName = "Название валюты";
            db.UpdateDBOne(nameOfTable, newPurch, newZnachP, wherColZnachName, nameOfBox);
            db.UpdateDBOne(nameOfTable, newSale, newZnachS, wherColZnachName, nameOfBox);
            data = db.ReadData(nameOfTable, wherColZnachName);
        }
        public List<string> CurrChangeOp(string combBox)
        {
            List<string> textBox = new List<string>();
            textBox.Add(db.ReturnZnach("Курс", "Название валюты", combBox, "Покупка"));
            textBox.Add(db.ReturnZnach("Курс", "Название валюты", combBox, "Продажа"));
            return textBox;
        }
    }
}
