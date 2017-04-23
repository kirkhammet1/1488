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
    public partial class Kadr : Form
    {
        public Kadr()
        {
            InitializeComponent();
        }

        private void Kadr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Otdel_Kadrov". При необходимости она может быть перемещена или удалена.
            this.otdel_KadrovTableAdapter.Fill(this.cOMPCLUBDataSet.Otdel_Kadrov);

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
            otdel_KadrovTableAdapter.Update(cOMPCLUBDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            void NewForm()
            {
                Sobesedovanie form = new Sobesedovanie();
                form.ShowDialog();
            }
            new System.Threading.Thread(NewForm).Start();

        }
    }
}
