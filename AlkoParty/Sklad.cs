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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.cOMPCLUBDataSet.Sklad);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Завершить работу прилоджения?", Application.ProductName + " " + Application.ProductVersion,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            skladTableAdapter.Update(cOMPCLUBDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Заказа успешно сделан! Ожидайте поставку.");
        }
    }
}
