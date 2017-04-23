using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Data.Sql;


namespace AlkoParty
{
    public partial class AlkoListWindow : Form
    {
        public AlkoListWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AlkoListWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Tualet_prinodlez". При необходимости она может быть перемещена или удалена.
            this.tualet_prinodlezTableAdapter.Fill(this.cOMPCLUBDataSet.Tualet_prinodlez);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Mebel_". При необходимости она может быть перемещена или удалена.
            this.mebel_TableAdapter.Fill(this.cOMPCLUBDataSet.Mebel_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Organizacia_Zala". При необходимости она может быть перемещена или удалена.
            this.organizacia_ZalaTableAdapter.Fill(this.cOMPCLUBDataSet.Organizacia_Zala);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Uchet_Oborudovania". При необходимости она может быть перемещена или удалена.
            this.uchet_OborudovaniaTableAdapter.Fill(this.cOMPCLUBDataSet.Uchet_Oborudovania);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.cOMPCLUBDataSet.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            //this.sotrudnikTableAdapter.Fill(this.cOMPCLUBDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Dolznost". При необходимости она может быть перемещена или удалена.
            this.dolznostTableAdapter.Fill(this.cOMPCLUBDataSet.Dolznost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Strana". При необходимости она может быть перемещена или удалена.
            this.stranaTableAdapter.Fill(this.cOMPCLUBDataSet.Strana);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Santeh". При необходимости она может быть перемещена или удалена.
            this.santehTableAdapter.Fill(this.cOMPCLUBDataSet.Santeh);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Tehnika". При необходимости она может быть перемещена или удалена.
            this.tehnikaTableAdapter.Fill(this.cOMPCLUBDataSet.Tehnika);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Zapchasti". При необходимости она может быть перемещена или удалена.
            //this.zapchastiTableAdapter.Fill(this.cOMPCLUBDataSet.Zapchasti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.cOMPCLUBDataSet.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Otvet_zal". При необходимости она может быть перемещена или удалена.
            this.otvet_zalTableAdapter.Fill(this.cOMPCLUBDataSet.Otvet_zal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOMPCLUBDataSet.Otdel_Kadrov". При необходимости она может быть перемещена или удалена.
            this.otdel_KadrovTableAdapter.Fill(this.cOMPCLUBDataSet.Otdel_Kadrov);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bugalteriaTableAdapter.Update(cOMPCLUBDataSet);
            cCTableAdapter.Update(cOMPCLUBDataSet);
            otvet_zalTableAdapter.Update(cOMPCLUBDataSet);
            //skladTableAdapter.Update(cOMPCLUBDataSet);
            organizacia_ZalaTableAdapter.Update(cOMPCLUBDataSet);
            santehTableAdapter.Update(cOMPCLUBDataSet);
            tehnikaTableAdapter.Update(cOMPCLUBDataSet);
            mebel_TableAdapter.Update(cOMPCLUBDataSet);
            otdel_KadrovTableAdapter.Update(cOMPCLUBDataSet);
            dolznostTableAdapter.Update(cOMPCLUBDataSet);
            stranaTableAdapter.Update(cOMPCLUBDataSet);
            sotrudnikTableAdapter.Update(cOMPCLUBDataSet);
            postavshikTableAdapter.Update(cOMPCLUBDataSet);
            tualet_prinodlezTableAdapter.Update(cOMPCLUBDataSet);
            zapchastiTableAdapter.Update(cOMPCLUBDataSet);
            uchet_OborudovaniaTableAdapter.Update(cOMPCLUBDataSet);


        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int a = (int)numericUpDown1.Value;
            int b = 70;
            label1.Text += a * b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Завершить работу приложения?", Application.ProductName + " " + Application.ProductVersion,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       // private void button3_Click_1(object sender, EventArgs e)
        //{
            //string c = label1.Text;
           // label4.Text = c;
      //  }
    }
}
