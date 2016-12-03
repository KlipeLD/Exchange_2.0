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
    public partial class FormConversion : Form
    {
        ExMessage message = new ExMessage();
        FormCashierOption formtoopen = new FormCashierOption();
        public FormConversion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            formtoopen.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSetExchange.Курс' table. You can move, or remove it, as needed.
            this.курсTableAdapter.Fill(this.dSetExchange.Курс);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cashier cashier = new Cashier();
                textBox2.Text = cashier.ConversOperation(comboBox1.Text, comboBox2.Text, textBox1.Text);
            }
            catch (Exception t)
            {
                message.MessageErr(t.Message);
            }
        }
    }
}
