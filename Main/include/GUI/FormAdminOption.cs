﻿using System;
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
    public partial class FormAdminOption : Form
    {
        ExMessage message = new ExMessage();
        public FormAdminOption()
        {
            InitializeComponent();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (radioButton1.Checked)
                {
                    Hide();
                    FormAdminExchange formAdmin = new FormAdminExchange();
                    formAdmin.ShowDialog();
                    Close();

                }
                else if (radioButton2.Checked)
                {
                    Hide();
                    FormStat formStat = new FormStat();
                    formStat.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать хотя бы 1 из пунктов", "Error 1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            //}
           // catch (Exception t)
            //{
            //    message.MessageErr(t.Message);
           // }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void Admin_enter_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            message.MessageOk("Program Exchange, Version 1.0.1\nCreated by:\nYantsevich Yulia\nhttps://klipeld.github.io\n©Klipe_LD, 2016", "About program");
        }
    }
}
