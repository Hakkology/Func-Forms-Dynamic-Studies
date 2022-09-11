using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hakan.WindowsForms2.Study
{
    public partial class Form1 : Form
    {
        delegate int Del(int x);
        delegate void Write(string text);

        public Form1()
        {
            InitializeComponent();
            //    this.Load += Form1_Load;
            //    this.DoubleClick += Form1_DoubleClick;
            //}

            //private void Form1_DoubleClick(object sender, EventArgs e)
            //{
            //    MessageBox.Show("Naber");
            //}

            //private void Form1_Load(object sender, EventArgs e)
            //{
            //    MessageBox.Show("Merhaba");
            //}

            //Del myDelegate = x => x * x;
            //int y = myDelegate(4);
            //MessageBox.Show(y.ToString());

            //Write write = x => MessageBox.Show(x);
            //write("Nabıyon");

            //this.Click += Form1_Click;
            //this.Click += (s, e) => { MessageBox.Show(((MouseEventArgs)e).Location.ToString()); };

            //Dinamik Nesne ve Event Kullanımı

            //Button btn = new Button();
            //btn.Text = "Click!";
            //btn.Name = "ClickButton";
            //btn.Width = 200;
            //btn.Height = 50;
            //btn.Left = btn.Left + 10;
            //btn.Click += delegate (object sender, EventArgs e)
            //{
            //    string message = (sender as Button).Text;
            //    MessageBox.Show(message);
            //};
            //this.Controls.Add(btn);

            button1.Click += delegate
            {
                MessageBox.Show("Clicked");
            };
        }

        //private void Form1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(((MouseEventArgs)e).Location.ToString());
        //}
    }
}
