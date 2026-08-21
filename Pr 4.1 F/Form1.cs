using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4._1_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Aqua, 3);
            Rectangle r = new Rectangle(123, 24, 200, 300);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.DrawEllipse(myPen, r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 3);
            Rectangle r = new Rectangle(123, 24, 200, 300);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.DrawRectangle(myPen, r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(Color.Aqua);
            Rectangle r = new Rectangle(123, 24, 200, 300);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.FillEllipse(myBrush, r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Rectangle r = new Rectangle(123, 24, 200, 300);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.FillRectangle(myBrush, r);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
