using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 10);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen whitePen = new Pen(Color.White, 13);
            Pen goldPen = new Pen(Color.Gold, 15);
            SolidBrush goldBrush = new SolidBrush(Color.Gold);
            Pen greenPen = new Pen(Color.Green, 13);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush blackBrush = new SolidBrush(Color.Black);


            Font subwayFont = new Font("Helvetica", 80, FontStyle.Bold);
            SolidBrush whiteTextBrush = new SolidBrush(Color.White);
            SolidBrush goldTextBrush = new SolidBrush(Color.Gold);

            Font tmFont = new Font("Times New Roman", 12);

            g.Clear(Color.White);

            g.FillEllipse(greenBrush, 15, 7, 520, 240);

            g.DrawString("SUB", subwayFont, whiteTextBrush, 15, 60);
            g.DrawString("WAY", subwayFont, goldTextBrush, 245, 60);

            g.FillRectangle(greenBrush, 30, 130, 40, 40);
            g.DrawLine(whitePen, 70, 151, 40, 151);
            g.FillPie(whiteBrush, 17, 136, 30, 30, 320, 80);

            g.FillRectangle(greenBrush, 78, 96, 20, 10);

            g.FillRectangle(greenBrush, 480, 70, 25, 25);
            g.DrawArc(goldPen, 482, 87, 30, 30, 200, 100);
            g.DrawLine(goldPen, 492, 87, 510, 87);
            g.FillPie(goldBrush, 505, 72, 30, 30, 140, 80);

            g.TranslateTransform(220, 50);

            g.RotateTransform(330);

            g.DrawString("Subway LLC", tmFont, blackBrush, 90, 260);

            g.ResetTransform();

        }
    }
}
