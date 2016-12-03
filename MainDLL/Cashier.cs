using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseDLL;

namespace MainDLL
{

    public class Cashier
    {
        Database db = new Database();
        public string NameCashier { get; set; }
        public string PurchaseOperation(string surnameClient, string passport, string sum, string currency)
        {
            List<string> col = new List<string>();
            List<string> val = new List<string>();
            string err;
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
                val.Add(NameCashier);
                val.Add(DateTime.Today.ToString());
                val.Add(sum);
                val.Add(currency);
                err = db.CheckDB("Клиент", col[1], val[1]);
                if (err == "0")
                {
                    string dataFromDb; Double dData1, dData2; string dataFromForm;
                    dataFromDb = db.ReturnZnach("Клиент", "Номер паспорта", passport, "Сумма покупки");
                    dataFromForm = ConversOperation(currency, "BYN", sum);
                    dData1 = Convert.ToDouble(dataFromDb);
                    dData2 = Convert.ToDouble(dataFromForm);
                    dData2 = dData1 + dData2;
                    if (dData2 > 1000)
                    {
                        err = "Данный клиент превысил лимит операций на сегодня.";
                    }
                    else
                    {
                        try
                        {
                            db.EnterToDB("Список операций", col, val);
                            err = "1";
                            db.UpdateDBOne("Клиент", "Сумма покупки", dData2.ToString(),
                            "Номер паспорта", passport);
                        }
                        catch (Exception e)
                        {
                            err = e.Source;
                        }
                    }
                }
                else
                {
                    err = "Данного клиента нет в базе данных.";
                }
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
            string err;
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
                val.Add(NameCashier);
                val.Add(DateTime.Today.ToString());
                val.Add(sum);
                val.Add(currency);
                err = db.CheckDB("Клиент", col[1], val[1]);
                if (err == "0")
                {
                    string dataFromDb; Double dData1, dData2; string dataFromForm;
                    dataFromDb = db.ReturnZnach("Клиент", "Номер паспорта", passport, "Сумма продажи");
                    dataFromForm = ConversOperation(currency, "BYN", sum);
                    dData1 = Convert.ToDouble(dataFromDb);
                    dData2 = Convert.ToDouble(dataFromForm);
                    dData2 = dData1 + dData2;
                    if (dData2 > 1000)
                    {
                        err = "Данный клиент превысил лимит операций на сегодня.";
                    }
                    else
                    {
                            db.EnterToDB("Список операций", col, val);
                            err = "1";
                            db.UpdateDBOne("Клиент","Сумма продажи", dData2.ToString(),
                            "Номер паспорта", passport);
                    }
                }
                else
                {
                    err = "Данного клиента нет в базе данных.";
                }
            }
            else
            {
                err = "Пожалуйста, заполните все поля и повторите запрос снова.";
            }
            return err;
        }

        public string Registration(string surname, string name, string fname, string passport)
        {
            List<string> col = new List<string>();
            List<string> val = new List<string>();
            string err;
            if (surname != "" && name != "" && fname != "" && passport != "")
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
        public string ConversOperation(string curFrom, string curTo, string boxData)
        {
            string znach = "";
            Double dataF; Double dataT; Double data;
            znach = db.ReadData("Курс", "Продажа", "Название валюты", curFrom);
            dataF = Convert.ToDouble(znach);
            znach = db.ReadData("Курс", "Покупка", "Название валюты", curTo);
            dataT = Convert.ToDouble(znach);
            data = Convert.ToDouble(boxData);
            data = data * dataF / dataT;
            znach = data.ToString();
            return znach;
        }
    }
}
