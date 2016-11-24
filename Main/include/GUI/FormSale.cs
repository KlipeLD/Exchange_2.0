using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainDLL;

namespace Main.include.GUI
{
    public partial class FormSale : Form
    {
        ExMessage message = new ExMessage();
        FormCashierOption formtoopen = new FormCashierOption();
        public FormSale()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            formtoopen.ShowDialog();
            this.Close();
        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                // сообщение об успешной операции + окно выбора
                // успех возврат к текущему окну
            }
        }
    }
}
