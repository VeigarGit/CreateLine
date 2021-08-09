using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reta_dois_pontos
{
    public partial class Form1 : Form
    {
        Graphics drawnArea;
        
        public Form1()
        {
            InitializeComponent();
            drawnArea = DrawningArea.CreateGraphics();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
            x1 = Convert.ToInt32(TBX1.Text);
            x2 = Convert.ToInt32(TBX2.Text);
            y1 = Convert.ToInt32(TBY1.Text);
            y2 = Convert.ToInt32(TBY2.Text);
            Pen blackPen = new Pen(Color.Black);
            drawnArea.DrawLine(blackPen, x1, y1, x2, y2);
        }
    }
}
