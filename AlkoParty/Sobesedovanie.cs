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
    public partial class Sobesedovanie : Form
    {
        public Sobesedovanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Высшее" && textBox2.Text == "Больше 5" && textBox3.Text == "30000" && textBox4.Text == "Интернет" && textBox5.Text == "РФ")
            {
                MessageBox.Show("Вы прошли собеседование");
                this.Close();
                Kadr form = new Kadr();
                form.ShowDialog();


            }
            else
            {
                MessageBox.Show("Вы не прошли собеседование");
                this.Close();
                Kadr form = new Kadr();
                form.ShowDialog();

            }


        }
    }
}