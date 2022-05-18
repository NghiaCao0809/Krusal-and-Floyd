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
    public partial class Floyd : Form
    {
        public static Floyd instance;
        public Floyd()
        {
            InitializeComponent();
            instance = this;
        }

        private void loadCombobox1()
        {
            int n = Form1.instance.FloydN;
            List<int> DanhSachDi = new List<int>();       // tạo list mới để combobox không bị lặp lại
            for (int i = 1; i <= n; i++)
            {
                DanhSachDi.Add(i);
            }
            Chon1cbx.DataSource = DanhSachDi;
        }

        private void loadCombobox2()
        {
            int n = Form1.instance.FloydN;
            List<int> DanhSachDen = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (i != int.Parse(Chon1cbx.Text)) DanhSachDen.Add(i);
            }
            Chon2cbx.DataSource = DanhSachDen;
        }

        private void Floyd_Load(object sender, EventArgs e)
        {
            loadCombobox1();
            loadCombobox2();
        }

        private void Chon1cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCombobox2();
        }

        private void Chaybtn_Click(object sender, EventArgs e)
        {
            Form1.instance.number1 = int.Parse(Chon1cbx.Text);
            Form1.instance.number2 = int.Parse(Chon2cbx.Text);
            this.Close();
        }
        private void Huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }    
    }
}
