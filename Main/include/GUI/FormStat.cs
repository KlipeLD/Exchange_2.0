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
        ExMessage message = new ExMessage();
        FormAdminOption formtoopen2 = new FormAdminOption();
        public FormStat()
        {
            InitializeComponent();
            //создаём три колонки
            DataTable dt = new DataTable();
            DataColumn colID = new DataColumn("Код", typeof(Int32));
            DataColumn colNameClient = new DataColumn("Фамилия клиента", typeof(String));
            DataColumn colPasp = new DataColumn("Номер пасспорт", typeof(String));
            DataColumn colDate = new DataColumn("Дата", typeof(DateTime));
            DataColumn colPurch = new DataColumn("Покупка", typeof(Int64));
            DataColumn colSale = new DataColumn("Продажа", typeof(Int64));
            DataColumn colCurr = new DataColumn("Валюта", typeof(String));
            DataColumn colNameCash = new DataColumn("Фамилия кассира", typeof(String));
            //добавляем колонки в таблицу
            dt.Columns.Add(colID);
            dt.Columns.Add(colNameClient);
            dt.Columns.Add(colPasp);
            dt.Columns.Add(colDate);
            dt.Columns.Add(colPurch);
            dt.Columns.Add(colSale);
            dt.Columns.Add(colCurr);
            dt.Columns.Add(colNameCash);
             for (int i = 0; i < 5; ++i)
            {
            //Добавляем строку, указывая значения колонок поочереди слева направо
               dataGridView1.Rows.Add("Пример 1, Товар " + i, i * 1000, i);
            }
            for (int i = 0; i < 5; ++i)
            {
            //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                dataGridView1.Rows.Add();
                dataGridView1["colID", dataGridView1.Rows.Count - 1].Value = i;
                dataGridView1["colNameClient", dataGridView1.Rows.Count - 1].Value = "Пример 2, Товар " + i;
                dataGridView1["colPasp", dataGridView1.Rows.Count - 1].Value = i * 1000;
                dataGridView1["colSale", dataGridView1.Rows.Count - 1].Value = i;
                dataGridView1["colPurch", dataGridView1.Rows.Count - 1].Value = i;
                dataGridView1["colCurr", dataGridView1.Rows.Count - 1].Value = i;
                dataGridView1["colNameCash", dataGridView1.Rows.Count - 1].Value = i;
                dataGridView1["colDate", dataGridView1.Rows.Count - 1].Value = i;
            }
            //А теперь простой пройдемся циклом по всем ячейкам
            // for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            // {
            //   for (int j = 0; j < dataGridView1.Columns.Count; ++j)
            // {
            //Значения ячеек хряняться в типе object
            //это позволяет хранить любые данные в таблице
            //    object o = dataGridView1[j, i].Value;
            //}
    }

        private void Stat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exchangeDataSet1.Список_операций' table. You can move, or remove it, as needed.
            this.список_операцийTableAdapter1.Fill(this.exchangeDataSet1.Список_операций);
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
        }
    }
}
