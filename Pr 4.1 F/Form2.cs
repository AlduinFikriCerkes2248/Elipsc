using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Arzubov 1p-24
namespace Pr_4._1_F
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double area = Math.PI * Math.Pow(radius, 2);
            txtArea.Text = area.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            int x = Convert.ToInt32(txtX.Text);
            int y = Convert.ToInt32(txtY.Text);
            int diameter = Convert.ToInt32(radius * 2);

            Pen myPen = new Pen(Color.Black, 3);
            Graphics g = Graphics.FromHwnd(this.Handle);

            g.DrawEllipse(myPen, x, y, diameter, diameter);
        }

        private void txty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
