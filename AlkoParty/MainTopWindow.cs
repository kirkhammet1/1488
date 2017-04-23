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
    public partial class MainTopWindow : Form
    {

        public MainTopWindow()
        {
            InitializeComponent();
        }

        private void MainTopWindow_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " \"Основное меню\"";
            this.Width = SystemInformation.PrimaryMonitorSize.Width;
            this.Dock = DockStyle.Top;
            this.Anchor = AnchorStyles.Top;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void покинутьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            switch (MessageBox.Show("Завершить работу прилоджения?", Application.ProductName + " " + Application.ProductVersion,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    this.BackColor = Color.Green;
                    break;
            }
        }

        private void выходИзПрофиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            switch (MessageBox.Show("Покинуть профиль?",Application.ProductName+" "+Application.ProductVersion,MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Start_Window SWS = new Start_Window();
                    SWS.Show();
                    this.Close();
                    MainLeftWindow MWL = new MainLeftWindow();
                    MWL.Close();
                    break;
                case DialogResult.No:
                    this.BackColor = Color.Green;
                    break;
            }
        }

        private void списокАлкоголяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlkoListWindow ALWS = new AlkoListWindow();
            ALWS.ShowDialog();
        }
    }
}
