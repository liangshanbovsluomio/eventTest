using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace 自定义事件_播放器_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayMusic p = new PlayMusic("告白气球");
            
            p.DelPlayOver += P_DelPlayOver; //注册事件
            p.PlaySong();
        }

        private void P_DelPlayOver(object sender, EventArgs e)
        {
            PlayMusic p = sender as PlayMusic; //此处需要调用类的属性Name，因此将sender强转PlayMusic对象
            MessageBox.Show("《"+p.Name + "》播放完成");
        }

        class PlayMusic
        {
            public event EventHandler DelPlayOver;

            public string Name { get; set; }

            public PlayMusic(string name)
            {
                this.Name = name;

            }
            public void PlaySong()
            {
                Console.WriteLine("正在播放{0}"+this.Name);
                Thread.Sleep(2000);

                
                if (DelPlayOver != null)
                {
                    EventArgs e = new EventArgs();
                    DelPlayOver(this, e);
                }
            }
        }
        
    }
}
