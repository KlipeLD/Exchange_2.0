using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MainDLL;

namespace Main.include.GUI
{
    public partial class FormPurchase : Form
    {
        ExMessage message = new ExMessage();
        OleDbConnection conn = new OleDbConnection();
        FormCashierOption formtoopen2 = new FormCashierOption();
        public FormPurchase()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                message.MessageOk("Пожалуйста заполните все поля", "Ошибка");                
            }
            else
            {
                message.MessageOk("Операция совершена успешно", "Успех");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            formtoopen2.ShowDialog();
            this.Close();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {

        }
    }
}
