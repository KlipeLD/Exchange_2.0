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
    public partial class FormEnter : Form
    {
        ExMessage message = new ExMessage();
        public FormEnter()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (radioButton1.Checked)
                {
                    Hide();
                    FormAdminOption formAdmin = new FormAdminOption();
                    formAdmin.ShowDialog();
                    Close();

                }
                else if (radioButton2.Checked)
                {
                    Hide();
                    FormCashier formStat = new FormCashier();
                    formStat.ShowDialog();
                    Close();
                }
                else
                {
                    message.MessageOk("Необходимо выбрать хотя бы 1 из пунктов", "Error 1");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            message.MessageExit();
        }
    }
}
