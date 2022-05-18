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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public int number1, number2; //Lấy đỉnh chạy thuật toán Floyd
        public int FloydN;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        int[,] a = new int[100, 100];
        int[,] d = new int[100, 100];
        int[,] next = new int[100, 100];  // Floyd
        int s, v = new int();
        int SoDinhFloyd = new int();

        private void DocFloyd(string fileName)
        {
            var Lines = System.IO.File.ReadAllLines(fileName);
            foreach (var Line in Lines)
            {
                var p = Line.Split(',');
                int DinhDau = int.Parse(p[0]);
                int DinhSau = int.Parse(p[1]);
                a[DinhDau, DinhSau] = int.Parse(p[2]);
                //cboDinh.Items.Clear();
                List<string> dsDinh = new List<string>();
                foreach (Edge edge in Graph)
                {
                    if (!dsDinh.Contains(edge.s))
                        dsDinh.Add(edge.s);
                    if (!dsDinh.Contains(edge.e))
                        dsDinh.Add(edge.e);
                }
                SoDinhFloyd = dsDinh.Count;
                FloydN = SoDinhFloyd;
            }
        }

        //tao cau truc canh
        public struct Edge
        {
            public string s;
            public string e;
            public int w;
            public Edge(int _s, int _e, int _w)
            {
                s = _s.ToString();
                e = _e.ToString();
                w = _w;
            }
            public Edge(string _s, string _e, string _w)
            {
                s = _s;
                e = _e;
                w = int.Parse(_w);
            }
        }

        //tao do thi bang danh sach cac canh
        public List<Edge> Graph;
        int SoDinh;

        //thuat toan Prim
        public List<Edge> Prim()
        {

            List<Edge> Tree = new List<Edge>();
            List<string> DanhDau = new List<string>();
            //DanhDau.Add(cboDinh.Text);
            List<Edge> G2 = new List<Edge>();
            G2.AddRange(Graph);
            while (DanhDau.Count < SoDinh)
            {
                var Edges = G2.Where(p => (DanhDau.Contains(p.s) && !DanhDau.Contains(p.e)) || (DanhDau.Contains(p.e) && !DanhDau.Contains(p.s)));
                var minw = Edges.Min(p => p.w);
                var minEdge = Edges.Where(p => p.w == minw).First();
                Tree.Add(minEdge);
                G2.Remove(minEdge);
                if (!DanhDau.Contains(minEdge.s))
                    DanhDau.Add(minEdge.s);
                if (!DanhDau.Contains(minEdge.e))
                    DanhDau.Add(minEdge.e);
            }
            return Tree;
        }

        public void ReadGraphFormFile(string fileName)
        {
            var Lines = System.IO.File.ReadAllLines(fileName);
            Graph = new List<Edge>();
            foreach (var Line in Lines)
            {
                var p = Line.Split(',');
                Graph.Add(new Edge(p[0], p[1], p[2]));
            }
            //cboDinh.Items.Clear();
            List<string> dsDinh = new List<string>();
            foreach (Edge edge in Graph)
            {
                if (!dsDinh.Contains(edge.s))
                    dsDinh.Add(edge.s);
                if (!dsDinh.Contains(edge.e))
                    dsDinh.Add(edge.e);
            }

            SoDinh = dsDinh.Count;

            //cboDinh.Items.AddRange(dsDinh.ToArray());
            //cboDinh.SelectedIndex = 0;
        }

        public void PrintGraph()
        {
            richTextBox1.Text += "Đồ thị ban đầu: \n\n";
            foreach (Edge edge in Graph)
            {
                richTextBox1.Text += "(" + edge.s + "," + edge.e + ") = " + edge.w + "\n";
            }
            richTextBox1.Text += "\n----------------------------\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoDoThi_Click(object sender, EventArgs e)
        {

            frmTaoDoThi frm = new frmTaoDoThi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ReadGraphFormFile("tmpGraph.txt");
                lblTrangThai.Text = ("Trạng thái: Đồ thị mới tạo!");
                PrintGraph();
            }
        }

        private void btnDocDoThi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Graph  Files | *.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                ReadGraphFormFile(dlg.FileName);
                DocFloyd(dlg.FileName);
                lblTrangThai.Text = ("Trạng thái: Đã đọc xong đồ thị!");
                PrintGraph();

            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public List<Edge> Kruskal()
        {
            List<Edge> G2 = new List<Edge>();
            G2.AddRange(Graph);
            G2 = G2.OrderBy(p => p.w).ToList(); //B1: sx cac canh cua do thi theo thu tu trong so tang dan
                                                // Ngay sau B1 cua thuat toan, ta gan dinh i cua do thi 1 nhan la i
            int i = 1;
            Dictionary<string, int> Labels = new Dictionary<string, int>();
            foreach (Edge edge in G2)
            {
                if (!Labels.ContainsKey(edge.s))
                    Labels.Add(edge.s, i++);
                if (!Labels.ContainsKey(edge.e))
                    Labels.Add(edge.e, i++);
            }
            //B2: Khoi tao T khac rong
            List<Edge> Tree = new List<Edge>();
            //B3: Lan luot lay tung canh thuoc ds da sx. Neu T + {e} khong chua chu trinh thi gan T:=T+{e}
            for (i = 0; i < G2.Count; i++)
            {
                Edge edge = G2[i];
                string s = edge.s;
                string e = edge.e;
                if (Labels[s] != Labels[e])
                {
                    Tree.Add(edge);
                    int lab1 = Math.Min(Labels[s], Labels[e]);
                    int lab2 = Math.Min(Labels[s], Labels[e]);
                    for (int j = 0; j < Labels.Count; j++)
                    {
                        if (Labels.ElementAt(j).Value == lab2)
                        {
                            Labels[Labels.ElementAt(j).Key] = lab1;
                        }
                    }
                }
                // Neu T du n-1 thi dung
                if (Tree.Count == SoDinh - 1)
                    break;
            }
            return Tree;
        }

        private void btnTimCayKhungKruskal_Click(object sender, EventArgs e)
        {
            if (Graph.Count > 0)
            {
                List<Edge> Tree = Kruskal();
                richTextBox1.Text += "\nThuật toán Kruskal: \n\n";
                foreach (Edge edge in Tree)
                {
                    richTextBox1.Text += "(" + edge.s + " , " + edge.e + " ) = " + edge.w + "\n";
                }
                richTextBox1.Text += "\nTrọng lượng cây: " + Tree.Sum(p => p.w) + "\n";
                richTextBox1.Text += "\n----------------------------\n";
                lblTrangThai.Text = ("Kruskal đã chạy xong!");
            }
        }

       

        private void FloydLoad()
        {
            for (int i = 0; i < SoDinhFloyd; i++)
            {
                for (int j = 0; j < SoDinhFloyd; j++)
                {
                    if (i != j && a[i, j] == 0)
                        a[i, j] = 99999;
                }
            }
        }

        private void Floyd(int[,] a, int n, int s, int v) // n là số lượng đỉnh s là đỉnh 1 v là đỉnh 2
        {
            int[,] d = new int[100, 100];
            int[,] p = new int[100, 100];
            int MAX = 9999;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    d[i, j] = a[i, j];
                    p[i, j] = i;
                }
            }
            for (int k = 1; k <= n; k++)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (d[i, k] > 0)
                    {
                        for (int j = 1; j <= n; j++)
                            if (d[k, j] > 0)
                                if (((d[i, j] == 0) && (i != j)) || (d[i, j] > d[i, k] + d[k, j]))
                                {
                                    d[i, j] = d[i, k] + d[k, j];
                                    p[i, j] = p[k, j];
                                }
                    }
                }
            }

            if (d[s, v] <= 0 || d[s, v] >= MAX)
            {
                richTextBox1.Text += "\n Không có đường đi!\n";
                //MessageBox.Show("Khong co duong di");
                //Console.WriteLine("Khong co duong di");
                //cout << "Khong co duong di...";
                return;
            }
            else
            {
                richTextBox1.Text += "\nDuong di ngan nhat tu " + s.ToString() + " den " + v.ToString() + ": \n\n";
                //MessageBox.Show("Duong di ngan nhat tu {0} den {1} la" +  s + v);
                //Console.WriteLine("Duong di ngan nhat tu {0} den {1} la", s, v);
                //cout << "Duong di ngan nhat tu " << s << " den " << v << " la:\n";
                int[] duong = new int[50];
                int k = v;
                int i = 0;
                duong[0] = v;
                i++;
                while (s != k)
                {
                    duong[i] = p[s, k];
                    i++;
                    k = p[s, k];
                }
                duong[i] = s;
                for (int j = i - 1; j > 0; j--)
                {
                    richTextBox1.Text += duong[j].ToString() + "-->";
                    //Console.Write("{0}->", duong[j]);
                    //Console.WriteLine("Do dai duong di:{0}", d[s, v]);
                    //cout << duong[j] << "->";
                    //cout << v << endl;
                    //cout << "Do dai duong di: " << d[s][v] << endl;
                }
                richTextBox1.Text += v.ToString();
                //Console.WriteLine("{0}", v);
                richTextBox1.Text += "\n\n";
                richTextBox1.Text += "Độ dài đường đi: " + d[s, v].ToString();
                //Console.WriteLine("Do dai duong di:{0}", d[s, v]);
            }
        }

        private void btnTimCayKhungFloyd_Click(object sender, EventArgs e)
        {
            Floyd form = new Floyd();
            form.ShowDialog();
            s = number1;
            v = number2;
            if (s != 0 && v != 0)
            {
                richTextBox1.Text += "\nThuật toán Floyd: \n\n";
                FloydLoad();
                Floyd(a, SoDinhFloyd, s, v);
            }
            //MessageBox.Show(s.ToString() + " " + v.ToString());
        }

    }
}
