using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakmaPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ciz;
        int baslaX, baslaY;
        int kalinlik = 5;
        ColorDialog renkSec = new ColorDialog();
        Graphics g1;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            g1 = this.CreateGraphics();
            Pen p = new Pen(renkSec.Color, kalinlik);

            Point nokta1 = new Point(baslaX, baslaY);
            Point nokta2 = new Point(e.X, e.Y);

            if (ciz == true)
            {
                g1.DrawLine(p, nokta1, nokta2);
                baslaX = e.X;
                baslaY = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //g1.Clear(ActiveForm.BackColor);
            this.Invalidate();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            renkSec.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalinlik = Convert.ToInt32(comboBox1.Text);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            baslaX = e.X;
            baslaY = e.Y;
        }


    }
}
