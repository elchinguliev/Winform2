using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm1._2.Properties;

namespace WinForm1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
            }
            Button newbtn1=new Button();
            newbtn1.BackgroundImage = new Bitmap(Resources.Bakiu);

            newbtn1.BackColor=Color.Transparent;
            newbtn1.FlatStyle=FlatStyle.Flat;   
            newbtn1.Size=button1.Size;

            newbtn1.FlatAppearance.BorderSize=button1.FlatAppearance.BorderSize;
            newbtn1.FlatAppearance.BorderColor=button1.FlatAppearance.BorderColor;
            newbtn1.FlatAppearance.MouseOverBackColor=System.Drawing.Color.Transparent;
            newbtn1.FlatAppearance.MouseDownBackColor=System.Drawing.Color.Transparent; 
            Random random=new Random();
            int x = random.Next(10, 800);
            int y = random.Next(10, 600);
            newbtn1.AutoSize=true;
            newbtn1.MouseMove+=button1_MouseMove;
            this.Controls.Add(newbtn1);
        }
    }
}
