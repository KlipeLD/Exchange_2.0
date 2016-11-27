using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL
{
    public class Admin
    {
        public List<String> ReadFromDB()
        {
            string nameOfTable="Курс";
            string where="";
            string znach="";
            Database db = new Database();
            List<string> arr = new List<string>(db.ReadDB(nameOfTable, where, znach));
            return arr;
        }
    }
}
