using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(150 , 80);
            btn.Location = new Point(120, 100);
            btn.Text = "我是被动态创建的";

            btn.Click += Btn_Click;
            btn.Click += Btn_Click1;
            btn.Click -= Btn_Click;

            this.Controls.Add(btn);
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("我也被点击了");
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我被点击了");
        }
    }
}
