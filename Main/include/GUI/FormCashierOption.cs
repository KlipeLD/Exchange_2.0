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
    public partial class FormCashierOption : Form
    {
        ExMessage message = new ExMessage();
        public FormCashierOption()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    Hide();
                    FormSale frmSale = new FormSale();
                    frmSale.ShowDialog();
                    Close();
                }
                else if (radioButton2.Checked)
                {
                    Hide();
                    FormPurchase frmPurchase = new FormPurchase();
                    frmPurchase.ShowDialog();
                    Close();
                }
                else if (radioButton4.Checked)
                {
                    Hide();
                    FormConversion frmConv = new FormConversion();
                    frmConv.ShowDialog();
                    Close();
                }
                else if (radioButton3.Checked)
                {
                    Hide();
                    FormRegistration frmReg = new FormRegistration();
                    frmReg.ShowDialog();
                    Close();
                }
                else
                {
                    message.MessageOk("Необходимо выбрать хотя бы 1 из пунктов", "Error 2");
                }
            }
            catch (Exception t)
            {
                message.MessageErr(t.Message);
            }
        }
        
        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void Cashier_change_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormCashier frmCashier = new FormCashier();
            frmCashier.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            message.MessageOk("Program Exchange, Version 1.0.1\nCreated by:\nYantsevich Yulia\nhttps://klipeld.github.io\n©Klipe_LD, 2016", "About program");
        }
    }
}
