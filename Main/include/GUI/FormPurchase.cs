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
            try
            {
                Cashier cashier = new Cashier("");
                string err;
                err = cashier.PurchaseOperation(textBox1.Text, textBox4.Text, textBox5.Text, comboBox1.Text);

                if (err == "1")
                {

                    message.MessageOk("Операция прошла успешно!", "Успех");
                     Hide();
                     formtoopen2.ShowDialog();
                     Close();
                }
                else
                {
                    message.MessageOk(err, "Error");
                }
            }
            catch (Exception t)
            {
                message.MessageErr(t.Message);
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

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSetExchange.Курс' table. You can move, or remove it, as needed.
            this.курсTableAdapter.Fill(this.dSetExchange.Курс);

        }
    }
}
