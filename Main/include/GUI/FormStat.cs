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
    public partial class FormStat : Form
    {
        Admin admin = new Admin();
        ExMessage message = new ExMessage();
        FormAdminOption formtoopen2 = new FormAdminOption();
        public FormStat()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            formtoopen2.ShowDialog();
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            message.MessageExit();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            списокОперацийBindingSource.Filter = string.Format("Дата = '{0}'", dateTimePicker1.Value.ToString());
        }
        private void FormStat_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'dSetExchange.Список_операций' table. You can move, or remove it, as needed.
            this.список_операцийTableAdapter.Fill(this.dSetExchange.Список_операций);
        }
    }
}
