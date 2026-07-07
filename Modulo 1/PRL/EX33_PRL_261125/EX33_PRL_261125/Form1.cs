using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX33_PRL_261125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics MyGraphics = base.CreateGraphics();
            Pen MyPen = new Pen(Color.DarkRed);
            SolidBrush MyBrush = new SolidBrush(Color.DarkBlue);

            MyGraphics.Clear(Color.White);

            switch (cbFigura.SelectedIndex) { 
            case 0:
                    MyGraphics.DrawEllipse(MyPen, 50, 50, 150, 150);
                    break;
                case 1:
                    MyGraphics.DrawRectangle(MyPen, 50, 50, 150, 150);
                    break;
                case 2:
                    MyGraphics.DrawEllipse(MyPen, 50, 50, 150, 115);
                    break;
                case 3:
                    MyGraphics.DrawPie(MyPen, 50, 50, 150, 150, 0, 45);
                    break;
                case 4:
                    MyGraphics.DrawRectangle(MyPen, 50, 50, 150, 100);
                    break;
                case 5:
                    MyGraphics.FillEllipse(MyBrush, 50, 50, 150, 150);
                    break;
                case 6:
                    MyGraphics.FillRectangle(MyBrush, 50, 50, 150, 100);
                    break;
                case 7:
                    MyGraphics.FillEllipse(MyBrush, 50, 50, 150, 115);
                    break;
                case 8:
                    MyGraphics.FillPie(MyBrush, 50, 50, 150, 150, 0, 45);
                    break;
                    case 9:
                    MyGraphics.FillRectangle(MyBrush, 50, 50, 150, 100);
                    break;
               
            }
        }
    }
}
