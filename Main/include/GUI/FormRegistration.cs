using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using System.IO;
using MainDLL;

namespace Main.include.GUI
{
    public partial class FormRegistration : Form
    {
        ExMessage message = new ExMessage();
        FormCashierOption formtoopen = new FormCashierOption();
        public FormRegistration()
        {
            InitializeComponent();
      
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            string err = cashier.Registration(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (err == "1")
            {
                var result = MessageBox.Show("Регистрация прошла успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
                formtoopen.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            formtoopen.ShowDialog();
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
