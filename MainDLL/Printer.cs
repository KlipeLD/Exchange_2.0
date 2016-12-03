using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace MainDLL
{
    public class Printer
    {
        public void Print(string surnameClient, string passport,string sum, string currency, 
            string NameCashier,string operation)
        {
                System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"D:\BSU\Лабы прога\Технологии программирования\Main\Main\Check\Check.txt");
                textFile.WriteLine("   Check\nОперация " + operation + " валюты произошла успешно\nФамилия: "+ surnameClient + "\nПасспортные данные: "+
                    passport +"\nСумма: " + sum + " "+currency +"\nФамилия кассира: " +
                    NameCashier + "\nДата: "+ DateTime.Now +"\n=============================================\nСпасибо, что выбрали наш банк.");
                textFile.Close();

           //Здесь могла бы быть прямая печать чека при наличии подключенного принтера
           // PrintDocument D = new PrintDocument();
           // D.DocumentName = "Check.txt";
           // D.Print();
        }
    }
}
