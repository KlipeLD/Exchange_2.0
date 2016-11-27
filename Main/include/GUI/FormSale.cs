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
            // TODO: This line of code loads data into the 'exchangeDataSet.Курс' table. You can move, or remove it, as needed.
            this.курсTableAdapter.Fill(this.exchangeDataSet.Курс);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            string err;
            err = cashier.SaleOperation(textBox1.Text, textBox4.Text, textBox5.Text, comboBox1.Text);

            if (err == "1")
            {
                //  Hide();
                // frm4.ShowDialog();
                // Close();
                message.MessageOk("Операция прошла успешно!", "Успех");
            }
            else
            {
                message.MessageOk(err, "Error");
            }
        }
    }
}
