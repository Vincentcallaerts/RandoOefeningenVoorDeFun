using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnKnop_Click(object sender, EventArgs e)
        {         
            Controls.Remove(btnKnop);
            g.Clear(Color.Black);
            while (true)
            {
                DrawPoly(10);
            }          
        }
        private Point PointGen() 
        {

            Point temp = new Point(rng.Next(800), rng.Next(500));
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
    }
}
