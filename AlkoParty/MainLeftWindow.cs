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
    public partial class MainLeftWindow : Form
    {
        
        public MainLeftWindow()
        {
            InitializeComponent();
        }

        private void MainLeftWindow_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " \"Вспомогательное окно\"";
            this.Height = SystemInformation.PrimaryMonitorSize.Height;
            this.Dock = DockStyle.Left;
            this.Anchor = AnchorStyles.Left;
            this.Height = SystemInformation.PrimaryMonitorSize.Height - (175);
            this.Top = 175;
            this.MaximumSize = new Size(300, SystemInformation.PrimaryMonitorSize.Height - (175));
            this.Left = 0;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
