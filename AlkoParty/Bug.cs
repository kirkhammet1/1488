using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlkoParty
{
    public partial class Bug : Form
    {
        public Bug()
        {
            InitializeComponent();
        }

        private void Bug_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Bugalteria". При необходимости она может быть перемещена или удалена.
            //this.bugalteriaTableAdapter.Fill(this.cOMPCLUBDataSet.Bugalteria);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Завершить работу приложения?", Application.ProductName + " " + Application.ProductVersion,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bugalteriaTableAdapter.Update(cOMPCLUBDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сотруднику " + textBox2.Text +  " было начислено " + textBox3.Text + " рублей ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отчёт о доходах был составлен и отправлен на почту!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отчёт о расходах был составлен и отправлен на почту!");
        }
    }
}
