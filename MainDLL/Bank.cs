using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseDLL;

namespace MainDLL
{
    public class Bank
    {
        public string CashEnter(string surname, string name, string fname)
        {
            Database db = new Database();
            Cashier cashier = new Cashier();
            List<string> col = new List<string>();
            List<string> val = new List<string>();
            string err = "0";
            if (surname != "" && name != "" && fname != "")
            {
                cashier.NameCashier = surname;
                col.Add("Фамилия");
                col.Add("Имя");
                col.Add("Отчество");
                //
                val.Add(surname);
                val.Add(name);
                val.Add(fname);
                err = db.CheckDB("Кассир", col[0], val[0]);
                if (err == "1")
                {
                    db.EnterToDB("Кассир", col, val);
                }
                err = "1";
            }
            else
            {
                err = "Пожалуйста, заполните все поля и повторите запрос снова.";
            }
            return err;
        }
    }
}
