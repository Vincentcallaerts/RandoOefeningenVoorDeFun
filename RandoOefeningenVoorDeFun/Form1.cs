using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandoOefeningenVoorDeFun
{
    public partial class Form1 : Form
    {
        private Random rng;
        private Graphics g;
        public Form1()
        {                       
            InitializeComponent();
            g = CreateGraphics();
            rng = new Random();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
        private Point PointGen() 
        {
            Point temp = new Point(rng.Next(140,800), rng.Next(500));
            return temp;        
        }
        private Point[] PointsForPoly()
        {
            Point[] temp = new Point[20];
            for (int i = 0; i < 20; i++)
            {
                temp[i] = PointGen();
            }
            return temp;
        }
        private void DrawPoly(int counter)
        {           
            for (int i = 0; i < counter; i++)
            {                              
                Pen myPen = new Pen(Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256)));                
                g.DrawPolygon(myPen, PointsForPoly());                
            }                       
        }
        private void btnKnop_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            DrawPoly(1000);
        }
        private void btnRainbow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                g.Clear(Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256)));
                Thread.Sleep(50);
            }
        }
        private void btnActualRainbow_Click(object sender, EventArgs e)
        {
            
            Pen myPen = new Pen(Color.Red,10);
            g.DrawArc(myPen, 140, 150, 500, 300, 0, -180);
            Thread.Sleep(50);
            myPen = new Pen(Color.Orange, 10);
            Thread.Sleep(50);
            g.DrawArc(myPen, 140, 160, 500, 300, 0, -180);
            Thread.Sleep(50);
            myPen = new Pen(Color.Yellow, 10);
            g.DrawArc(myPen, 140, 170, 500, 300, 0, -180);
            Thread.Sleep(50);
            myPen = new Pen(Color.Green, 10);
            g.DrawArc(myPen, 140, 180, 500, 300, 0, -180);
            Thread.Sleep(50);
            myPen = new Pen(Color.LightBlue, 10);
            g.DrawArc(myPen, 140, 190, 500, 300, 0, -180);
            Thread.Sleep(50);
            myPen = new Pen(Color.DarkBlue, 10);
            g.DrawArc(myPen, 140, 200, 500, 300, 0, -180);
            Thread.Sleep(50);
            myPen = new Pen(Color.Magenta, 10);
            g.DrawArc(myPen, 140, 210, 500, 300, 0, -180);
            Thread.Sleep(50);
        }

        private void btnCookie_Click(object sender, EventArgs e)
        {
            g.DrawIcon(new Icon("iconCookie.ico"), rng.Next(140, 800), rng.Next(500));
        }
    }
}
