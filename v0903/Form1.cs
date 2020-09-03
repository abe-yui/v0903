using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int vx = rand.Next(-20, 21);
        int vy = rand.Next(-20, 21);

        int vxa = rand.Next(-20, 21);
        int vya = rand.Next(-20, 21);

        int vxb = rand.Next(-20, 21);
        int vyb = rand.Next(-20, 21);


        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
          
            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);
        
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            label2.Left += vxa;
            label2.Top += vya;

            label3.Left += vxb;
            label3.Top += vyb;

            if(label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom >ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }


            if (label2.Left < 0)
            {
                vxa = Math.Abs(vxa);
            }
            if (label2.Top < 0)
            {
                vya = Math.Abs(vya);
            }
            if (label2.Right > ClientSize.Width)
            {
                vxa = -Math.Abs(vxa);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vya = -Math.Abs(vya);
            }


            if (label3.Left < 0)
            {
                vxb = Math.Abs(vxb);
            }
            if (label3.Top < 0)
            {
                vyb = Math.Abs(vyb);
            }
            if (label3.Right > ClientSize.Width)
            {
                vxb = -Math.Abs(vxb);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vyb = -Math.Abs(vyb);
            }

            Point mp = PointToClient(MousePosition);
            

            if (    (mp.X >= label1.Left)
                &&  (mp.X < label1.Right)
                &&  (mp.Y >= label1.Top)
                &&  (mp.Y < label1.Bottom)
                )
            {
                timer1.Enabled = false;
                label1.Text="(/ω＼)";
            }


            if (   (mp.X >= label2.Left)
                && (mp.X < label2.Right)
                && (mp.Y >= label2.Top)
                && (mp.Y < label2.Bottom)
                )
            {
                timer1.Enabled = false;
                label2.Text = "(/ω＼)";
            }


            if (   (mp.X >= label3.Left)
                && (mp.X < label3.Right)
                && (mp.Y >= label3.Top)
                && (mp.Y < label3.Bottom)
                )
            {
                timer1.Enabled = false;
                label3.Text = "(/ω＼)";
            }
        }
    }
}
