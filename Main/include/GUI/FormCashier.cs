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
    public partial class FormCashier : Form
    {
        ExMessage message = new ExMessage();
        FormCashierOption frm4 = new FormCashierOption();
        public FormCashier()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            string err;
           err = cashier.CashEnter(textBox1.Text, textBox2.Text,textBox3.Text);
            
            if (err =="1")
            {
                Hide();
                frm4.ShowDialog();
                Close();         
            }
            else
            {
                message.MessageOk(err, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
