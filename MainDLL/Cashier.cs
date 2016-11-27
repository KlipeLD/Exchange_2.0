using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainDLL
{

    public class Cashier
    {
        Database db = new Database();
        public string nameCashier { get; set; }
        public string PurchaseOperation(string surnameClient, string passport, string sum, string currency)
        {
            
            List<string> col = new List<string>();
            List<string> val = new List<string>();
            string err = "0";
            if (surnameClient != "" && passport != "" && sum != "" && currency != "")
            {
                col.Add("Фамилия клиента");
                col.Add("Номер паспорта");
                col.Add("Фамилия кассира");
                col.Add("Дата");
                col.Add("Сумма покупки");
                col.Add("Валюта");
                //
                val.Add(surnameClient);
                val.Add(passport);
                val.Add(nameCashier);
                val.Add(DateTime.Now.ToString());
                val.Add(sum);
                val.Add(currency);
                //
                //   err = db.CheckDB("Кассир", col[0], val[0]);
                // if (err == "1")
                // {
                db.EnterToDB("Список операций", col, val);
                // }
                err = "1";
            }
            else
            {
                err = "Пожалуйста, заполните все поля и повторите запрос снова.";
            }
            return err;
        }
        public string SaleOperation(string surnameClient, string passport, string sum, string currency)
        {
            List<string> col = new List<string>();
            List<string> val = new List<string>();
            string err = "0";
            if (surnameClient != "" && passport != "" && sum != "" && currency != "")
            {
                col.Add("Фамилия клиента");
                col.Add("Номер паспорта");
                col.Add("Фамилия кассира");
                col.Add("Дата");
                col.Add("Сумма продажи");
                col.Add("Валюта");
                //
                val.Add(surnameClient);
                val.Add(passport);
                val.Add(nameCashier);
                val.Add(DateTime.Today.ToString());
                val.Add(sum);
                val.Add(currency);
                //
                //   err = db.CheckDB("Кассир", col[0], val[0]);
                // if (err == "1")
                // {
                    db.EnterToDB("Список операций", col, val);
                // }
                err = "1";
            }
            else
            {
                err = "Пожалуйста, заполните все поля и повторите запрос снова.";
            }
            return err;
        }
        public string CashEnter(string surname, string name, string fname)
        {
            List<string> col = new List<string>();
            List<string> val = new List<string>();
            string err ="0";
            if (surname != "" && name != "" && fname != "")
            {
                nameCashier = surname;
                col.Add("Фамилия");
                col.Add("Имя");
                col.Add("Отчество");
                //
                val.Add(surname);
                val.Add(name);
                val.Add(fname);
                err = db.CheckDB("Кассир",col[0],val[0]);
                if (err == "1")
                {
                    db.EnterToDB("Кассир", col, val);
                }
                err = "1";
            }
            else
            {
                err ="Пожалуйста, заполните все поля и повторите запрос снова.";
            }
            return err;
        }
        public string Registration(string surname, string name, string fname, string passport)
        {
            List<string> col = new List<string>();
            List<string> val = new List<string>();
            string err;
            if (surname != "" && name != "" && fname != "" && passport != "" )
            {
                col.Add("Фамилия");
                col.Add("Имя");
                col.Add("Отчество");
                col.Add("Номер паспорта");
                //
                val.Add(surname);
                val.Add(name);
                val.Add(fname);
                val.Add(passport);
                err = db.CheckDB("Клиент", col[3], val[3]);
                if (err == "1")
                {
                    db.EnterToDB("Клиент", col, val);
                }
                if (err == "0")
                {
                    err = "Данный клиент уже есть в базе данных";
                }
            }
            else
            {
                err = "Пожалуйста, заполните все поля и повторите запрос";
            }
            return err;
        }
    }
}
