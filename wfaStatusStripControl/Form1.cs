using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaStatusStripControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
            for (int counter = 0; counter <= 95; counter++)
            {
                this.toolStripStatusLabel2.ProgressBar.Value = counter;
                System.Threading.Thread.Sleep(50);

            }
        }
    }
}
