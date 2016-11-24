using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainDLL
{
    public class Cashier
    {
        public int ID { get; set; }
        public bool CashEnterToDB(string surname, string name, string fname)
        {
            bool boolTrueFalse;
            if (surname != "" || name != "" || fname != "")
            {
                Database db = new Database();
                db.EnterToDB(surname, name, fname);
                boolTrueFalse = true;
            }
            else
            {
                boolTrueFalse = false;
            }
            return boolTrueFalse;
        }
        public bool CashEnterToDB(string surname, string name, string fname, string passport)
        {
            bool boolTrueFalse;
            if (surname != "" || name != "" || fname != "" || passport != "" )
            {
                Database db = new Database();
                db.EnterToDB(surname, name, fname,passport);
                boolTrueFalse = true;
            }
            else
            {
                boolTrueFalse = false;
            }
            return boolTrueFalse;
        }
    }
}
