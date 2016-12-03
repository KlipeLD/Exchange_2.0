using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.include.GUI
{
    class ExMessage
    {
        public void MessageYesNo(string message,string header)
        {
            var result = MessageBox.Show(message, header,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void MessageExit()
        {
            const string message =
            "Вы действительно хотите выйти из приложения?";
            const string caption = "Выход";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void MessageOk(string text, string heading)
        {
            MessageBox.Show(text,heading, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void MessageErr(string text)
        {
            MessageBox.Show("Упс..Что-то пошло не так...\nТекст ошибки:\n" +text, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
