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
    public partial class FormAdminExchange : Form
    {
        Admin admin = new Admin();
        ExMessage message = new ExMessage();
        FormAdminOption formtoopen = new FormAdminOption();
        public FormAdminExchange()
        {
            InitializeComponent();
            List<string> data = new List<string>();
            data.AddRange(admin.CurrencyOperation());
            int countArr = data.Count;
            countArr /= 2;   //половина покупка, половина продажа
            //покупка
            textBox6.Text = textBox12.Text = data[0];
            textBox8.Text = textBox10.Text = data[1];
            textBox14.Text = textBox4.Text = data[2];
            textBox2.Text = textBox16.Text = data[3];
            //продажа
            textBox5.Text = textBox11.Text = data[countArr];
            textBox7.Text = textBox9.Text = data[countArr+1];
            textBox13.Text = textBox3.Text = data[countArr+2];
            textBox1.Text = textBox15.Text = data[countArr+3];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> newZnachP = new List<string>(); //Purchase
            newZnachP.Add(textBox12.Text);
            newZnachP.Add(textBox10.Text);
            newZnachP.Add(textBox4.Text);
            newZnachP.Add(textBox16.Text);
            //
            List<string> newZnachS = new List<string>(); //Sale
            newZnachP.Add(textBox11.Text);
            newZnachP.Add(textBox9.Text);
            newZnachP.Add(textBox3.Text);
            newZnachP.Add(textBox15.Text);
            //
            admin.UpdateCurrency(newZnachP, newZnachS);
            textBox6.Text = textBox12.Text;
            textBox5.Text = textBox11.Text;
            textBox8.Text = textBox10.Text;
            textBox7.Text = textBox9.Text;
            textBox14.Text = textBox4.Text;
            textBox13.Text = textBox3.Text;
            admin.UpdateCurrencyCBox(textBox16.Text, textBox15.Text, comboBox2.Text);

        }

        private void label10_Click(object sender, EventArgs e)
        {
 
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            formtoopen.ShowDialog();
            Close();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exchangeDataSet.Курс' table. You can move, or remove it, as needed.
            this.курсTableAdapter.Fill(this.exchangeDataSet.Курс);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> textBox = new List<string>();
            string cb1=comboBox1.Text;
            textBox = admin.CurrChangeOp(cb1);
            textBox2.Text = textBox[0];
            textBox1.Text = textBox[1];
        }
        
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<string> textBoxx = new List<string>();
            string cb2 = comboBox2.Text;
            textBoxx = admin.CurrChangeOp(cb2);
            textBox16.Text = textBoxx[0];
            textBox15.Text = textBoxx[1];
        }
    }
}
