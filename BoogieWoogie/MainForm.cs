using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoogieWoogie
{
    using global::BoogieWoogie.Rows;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            ((Control)sender).Visible = false;

            this.Controls.Add(new BoogieWoogieDrawing());
        }

    }
}
