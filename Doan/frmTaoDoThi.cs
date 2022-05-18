using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class frmTaoDoThi : Form
    {
        public frmTaoDoThi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Lines = richTextBox1.Lines;
            System.IO.File.WriteAllLines("tmpGraph.txt", Lines);
            this.DialogResult = DialogResult.OK;
        }
    }
}
