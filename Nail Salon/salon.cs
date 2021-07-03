using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nail_Salon
{
    public partial class salon : Form
    {
        public salon()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap soba = new Bitmap(Properties.Resources._2);
            g.DrawImage(soba, 0, 0, 900, 700);

            Bitmap sake = new Bitmap(Properties.Resources.ruke);
            g.DrawImage(sake, 150, 310, 540, 417);

            Pen pen = new Pen(Color.Purple);
            g.DrawLine(pen, 100, 30, 110, 20);
            g.DrawLine(pen, 100, 20, 110, 30);
            g.DrawLine(pen, 105, 20, 105, 30);
            g.DrawLine(pen, 100, 25, 110, 25);

            g.DrawLine(pen, 150, 80, 160, 70);
            g.DrawLine(pen, 150, 70, 160, 80);
            g.DrawLine(pen, 155, 70, 155, 80);
            g.DrawLine(pen, 150, 75, 160, 75);

            g.DrawLine(pen, 260, 130, 270, 120);
            g.DrawLine(pen, 260, 120, 270, 130);
            g.DrawLine(pen, 265, 120, 265, 130);
            g.DrawLine(pen, 260, 125, 270, 125);

            g.DrawLine(pen, 350, 180, 360, 170);
            g.DrawLine(pen, 350, 170, 360, 180);
            g.DrawLine(pen, 355, 170, 355, 180);
            g.DrawLine(pen, 350, 175, 360, 175);

            g.DrawLine(pen, 370, 240, 380, 230);
            g.DrawLine(pen, 370, 230, 380, 240);
            g.DrawLine(pen, 375, 230, 375, 240);
            g.DrawLine(pen, 370, 235, 380, 235);

            g.DrawLine(pen, 500, 230, 510, 220);
            g.DrawLine(pen, 500, 220, 510, 230);
            g.DrawLine(pen, 505, 220, 505, 230);
            g.DrawLine(pen, 500, 225, 510, 225);

            g.DrawLine(pen, 550, 130, 560, 120);
            g.DrawLine(pen, 550, 120, 560, 130);
            g.DrawLine(pen, 555, 120, 555, 130);
            g.DrawLine(pen, 550, 125, 560, 125);
        }


        private void button2_Click(object sender, EventArgs e)
        {
           if(panel2.Width == 0)
            {
                panel2.Width = 133;
            }
            else
            {
                panel2.Width = 0;
            }
            
        }


        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap nokti = new Bitmap(Properties.Resources.nokti);
            g.DrawImage(nokti, 0, 1, 120, 90);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap lak = new Bitmap(Properties.Resources.lak__1_);
            g.DrawImage(lak, 0, 2, 120, 90);
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap nakit = new Bitmap(Properties.Resources.nakit);
            g.DrawImage(nakit, 1, 1, 110, 90);
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap nokti1 = new Bitmap(Properties.Resources.nokti1);
            g.DrawImage(nokti1,18, 3, 45, 45);
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Bitmap nokti2 = new Bitmap(Properties.Resources.nokti2);
            g.DrawImage(nokti2, 18, 3, 45, 45);
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Bitmap nokti3 = new Bitmap(Properties.Resources.nokti3);
            g.DrawImage(nokti3, 18, 3, 45, 45);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 0)
            {
                panel3.Width = 133;
            }
            else
            {
                panel3.Width = 0;
            }
        }

        private void button9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr1 = new Bitmap(Properties.Resources.pr1);
            g.DrawImage(pr1, 12, -3, 75, 75);
        }

        private void button10_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr2 = new Bitmap(Properties.Resources.pr2);
            g.DrawImage(pr2, 12, -3, 75, 75);
        }

        private void button11_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr3 = new Bitmap(Properties.Resources.pr3);
            g.DrawImage(pr3, 12, -3, 75, 75);
        }

        private void button12_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr4 = new Bitmap(Properties.Resources.pr4);
            g.DrawImage(pr4, 12, -3, 75, 75);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel4.Width == 0)
            {
                panel4.Width = 133;
            }
            else
            {
                panel4.Width = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel5.Width == 0)
            {
                panel5.Width = 485;
            }
            else
            {
                panel5.Width = 0;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Transparent);
            Bitmap nok1 = new Bitmap(Properties.Resources.nok1);
            Bitmap nok11 = new Bitmap(Properties.Resources.nok11);
            Bitmap nok22 = new Bitmap(Properties.Resources.nok22);
            Bitmap nok21 = new Bitmap(Properties.Resources.nok21);
            Bitmap nok12 = new Bitmap(Properties.Resources.nok12);
            g.DrawImage(nok1, -6, 90, 49, 65);
            g.DrawEllipse(p, 7, 110, 20, 30);
            Point p1 = new Point(8, 115);
            Point p2 = new Point(25, 115);
            Point p3 = new Point(17, 97);
            Point[] prvi = { p1, p2, p3 };
            g.DrawPolygon(p, prvi);

            g.DrawImage(nok1, 25, 45, 49, 65);
            g.DrawEllipse(p, 38, 65, 20, 30);
            Point p4 = new Point(40, 70);
            Point p5 = new Point(57, 70);
            Point p6 = new Point(47, 52);
            Point[] drugi = { p4, p5, p6 };
            g.DrawPolygon(p, drugi);

            g.DrawImage(nok1, 85, 20, 49, 65);
            g.DrawEllipse(p, 98, 40, 20, 30);
            Point p7 = new Point(100, 45);
            Point p8 = new Point(117, 45);
            Point p9 = new Point(107, 27);
            Point[] treci = { p7, p8, p9 };
            g.DrawPolygon(p, treci);

            g.DrawImage(nok11, 165, 55, 49, 65);
            g.DrawEllipse(p, 178, 75, 20, 30);
            Point p10 = new Point(184, 75);
            Point p11 = new Point(199, 87);
            Point p12 = new Point(197, 64);
            Point[] cetvrti = { p10, p11, p12 };
            g.DrawPolygon(p, cetvrti);

            g.DrawImage(nok22, 205, 185, 49, 65);
            g.DrawEllipse(p, 210, 210, 18, 15);
            Point p13 = new Point(215, 210);
            Point p14 = new Point(225, 222);
            Point p15 = new Point(243, 195);
            Point[] peti = { p13, p14, p15 };
            g.DrawPolygon(p, peti);

            g.DrawImage(nok21, 235, 180, 49, 65);
            g.DrawEllipse(p, 255, 210, 18, 15);
            Point p16 = new Point(255, 220);
            Point p17 = new Point(268, 210);
            Point p18 = new Point(245, 195);
            Point[] sesti = { p16, p17, p18 };
            g.DrawPolygon(p, sesti);

            g.DrawImage(nok12, 275, 50, 49, 65);
            g.DrawEllipse(p, 290, 71, 20, 30);
            Point p19 = new Point(289, 86);
            Point p20 = new Point(304, 71);
            Point p21 = new Point(290, 60);
            Point[] sedmi = { p19, p20, p21};
            g.DrawPolygon(p, sedmi);

            g.DrawImage(nok1, 353, 20, 49, 65);
            g.DrawEllipse(p, 366, 40, 20, 30);
            Point p22 = new Point(366, 49);
            Point p23 = new Point(386, 49);
            Point p24 = new Point(376, 25);
            Point[] osmi = { p22, p23, p24 };
            g.DrawPolygon(p, osmi);

            g.DrawImage(nok1, 414, 45, 49, 65);
            g.DrawEllipse(p, 428, 65, 20, 30);
            Point p25 = new Point(428, 74);
            Point p26 = new Point(448, 74);
            Point p27 = new Point(438, 50);
            Point[] deveti = { p25, p26, p27 };
            g.DrawPolygon(p, deveti);

            g.DrawImage(nok1, 445, 90, 49, 65);
            g.DrawEllipse(p, 459, 110, 20, 30);
            Point p28 = new Point(460, 118);
            Point p29 = new Point(479, 118);
            Point p30 = new Point(468, 96);
            Point[] deseti = { p28, p29, p30 };
            g.DrawPolygon(p, deseti);

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Transparent);
            Bitmap nok2 = new Bitmap(Properties.Resources.nok2);
            Bitmap nokt2 = new Bitmap(Properties.Resources.nokt2);
            Bitmap nokt12 = new Bitmap(Properties.Resources.nokt12);
            Bitmap nokt21 = new Bitmap(Properties.Resources.nokt21);
            Bitmap nokt22 = new Bitmap(Properties.Resources.nokt22);
            g.DrawImage(nok2, -6, 95, 49, 65);
            g.DrawEllipse(p, 8, 100, 18, 40);

            g.DrawImage(nok2, 25, 50, 49, 65);
            g.DrawEllipse(p, 39, 55, 18, 40);

            g.DrawImage(nok2, 85, 25, 49, 65);
            g.DrawEllipse(p, 100, 30, 18, 40);

            g.DrawImage(nokt2, 165, 60, 49, 65);
            g.DrawEllipse(p, 185, 67, 16, 23);
            g.DrawEllipse(p, 179, 74, 18, 27);

            g.DrawImage(nokt12, 200, 185, 49, 65);
            g.DrawEllipse(p, 211, 210, 16, 14);
            g.DrawEllipse(p, 219, 202, 16, 15);
            g.DrawEllipse(p, 224, 200, 15, 13);

            g.DrawImage(nokt21, 235, 187, 49, 65);
            g.DrawEllipse(p, 255, 210, 20, 15);
            g.DrawEllipse(p, 243, 200, 20, 15);
            g.DrawEllipse(p, 247, 204, 21, 15);

            g.DrawImage(nokt22, 275, 55, 49, 65);
            g.DrawEllipse(p, 290, 73, 18, 27);
            g.DrawEllipse(p, 288, 63, 17, 24);

            g.DrawImage(nok2, 353, 25, 49, 65);
            g.DrawEllipse(p, 368, 30, 18, 40);

            g.DrawImage(nok2, 414, 50, 49, 65);
            g.DrawEllipse(p, 430, 55, 18, 40);

            g.DrawImage(nok2, 445, 95, 49, 65);
            g.DrawEllipse(p, 461, 100, 18, 40);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel6.Width == 0)
            {
                panel6.Width = 485;
            }
            else
            {
                panel6.Width = 0;
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Transparent);
            Bitmap nok3 = new Bitmap(Properties.Resources.nok3);
            Bitmap nok33 = new Bitmap(Properties.Resources.nok33);
            Bitmap nok32 = new Bitmap(Properties.Resources.nok32);
            Bitmap nok13 = new Bitmap(Properties.Resources.nok13);
            Bitmap nok31 = new Bitmap(Properties.Resources.nok31);
            g.DrawImage(nok3, -6, 92, 49, 65);
            g.DrawEllipse(p, 10, 95, 15, 45);

            g.DrawImage(nok3, 25, 47, 49, 65);
            g.DrawEllipse(p, 41, 50, 15, 45);

            g.DrawImage(nok3, 85, 22, 49, 65);
            g.DrawEllipse(p, 101, 25, 15, 45);

            g.DrawImage(nok33, 162, 57, 49, 65);
            g.DrawEllipse(p, 185, 63, 12, 24);
            g.DrawEllipse(p, 181, 74, 13, 27);

            g.DrawImage(nok32, 201, 182, 49, 65);
            g.DrawEllipse(p, 211, 210, 16, 14);
            g.DrawEllipse(p, 219, 202, 16, 15);
            g.DrawEllipse(p, 226, 198, 15, 13);

            g.DrawImage(nok13, 238, 182, 49, 65);
            g.DrawEllipse(p, 259, 210, 14, 15);
            g.DrawEllipse(p, 246, 197, 14, 17);
            g.DrawEllipse(p, 251, 204, 15, 15);

            g.DrawImage(nok31, 275, 52, 49, 65);
            g.DrawEllipse(p, 292, 73, 13, 27);
            g.DrawEllipse(p, 289, 59, 13, 24);

            g.DrawImage(nok3, 353, 22, 49, 65);
            g.DrawEllipse(p, 369, 25, 15, 45);

            g.DrawImage(nok3, 414, 47, 49, 65);
            g.DrawEllipse(p, 430, 50, 15, 45);

            g.DrawImage(nok3, 445, 94, 49, 65);
            g.DrawEllipse(p, 461, 97, 15, 45);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel7.Width == 0)
            {
                panel7.Width = 485;
            }
            else
            {
                panel7.Width = 0;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr1 = new Bitmap(Properties.Resources.pr1);
            g.DrawImage(pr1, 20, 10, 50, 60);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panel8.Width == 0)
            {
                panel8.Width = 107;
            }
            else
            {
                panel8.Width = 0;
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr2 = new Bitmap(Properties.Resources.pr2);
            g.DrawImage(pr2, 18, 11, 50, 60);       
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (panel9.Width == 0)
            {
                panel9.Width = 104;
            }
            else
            {
                panel9.Width = 0;
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr3 = new Bitmap(Properties.Resources.pr3);
            g.DrawImage(pr3, 20, 10, 50, 60);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel10.Width == 0)
            {
                panel10.Width = 107;
            }
            else
            {
                panel10.Width = 0;
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap pr4 = new Bitmap(Properties.Resources.pr4);
            g.DrawImage(pr4, 18, 11, 50, 60);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (panel11.Width == 0)
            {
                panel11.Width = 104;
            }
            else
            {
                panel11.Width = 0;
            }
        }

        private void button7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap grad1 = new Bitmap(Properties.Resources.grad1);
            g.DrawImage(grad1, 13, -1, 50, 50);
        }

        private void button8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap grad2 = new Bitmap(Properties.Resources.grad2);
            g.DrawImage(grad2, 16, 2, 45,45);
        }

        private void button13_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap blue = new Bitmap(Properties.Resources.blue);
            g.DrawImage(blue, 22, 7, 35, 35);
        }

        private void button14_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap yellow = new Bitmap(Properties.Resources.yellow);
            g.DrawImage(yellow, 20, 6, 36, 36);
        }

        private void button15_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap yellow = new Bitmap(Properties.Resources.pink);
            g.DrawImage(yellow, 13, -1, 50, 50);
        }

        private void button16_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap yellow = new Bitmap(Properties.Resources.red);
            g.DrawImage(yellow, 20, 6, 36, 36);
        }

        private void button13_Click(object sender, EventArgs e)
        {
                Graphics g = panel5.CreateGraphics();
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 7, 110, 20, 30);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 38, 65, 20, 30);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 98, 40, 20, 30);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 178, 75, 20, 30);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 210, 210, 18, 15);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 255, 210, 18, 15);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 290, 71, 20, 30);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 366, 40, 20, 30);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 428, 65, 20, 30);
                g.FillEllipse(new SolidBrush(Color.DodgerBlue), 459, 110, 20, 30);
                Point p1 = new Point(8, 115);
                Point p2 = new Point(25, 115);
                Point p3 = new Point(17, 97);
                Point[] prvi = { p1, p2, p3 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), prvi);

                Point p4 = new Point(40, 70);
                Point p5 = new Point(57, 70);
                Point p6 = new Point(47, 52);
                Point[] drugi = { p4, p5, p6 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), drugi);

                Point p7 = new Point(100, 45);
                Point p8 = new Point(117, 45);
                Point p9 = new Point(107, 27);
                Point[] treci = { p7, p8, p9 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), treci);

                Point p10 = new Point(184, 75);
                Point p11 = new Point(199, 87);
                Point p12 = new Point(197, 64);
                Point[] cetvrti = { p10, p11, p12 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), cetvrti);

                Point p13 = new Point(215, 210);
                Point p14 = new Point(225, 222);
                Point p15 = new Point(243, 195);
                Point[] peti = { p13, p14, p15 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), peti);

                Point p16 = new Point(255, 220);
                Point p17 = new Point(268, 210);
                Point p18 = new Point(245, 195);
                Point[] sesti = { p16, p17, p18 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), sesti);

                Point p19 = new Point(289, 86);
                Point p20 = new Point(304, 71);
                Point p21 = new Point(290, 60);
                Point[] sedmi = { p19, p20, p21 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), sedmi);

                Point p22 = new Point(366, 49);
                Point p23 = new Point(386, 49);
                Point p24 = new Point(376, 25);
                Point[] osmi = { p22, p23, p24 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), osmi);

                Point p25 = new Point(428, 74);
                Point p26 = new Point(448, 74);
                Point p27 = new Point(438, 50);
                Point[] deveti = { p25, p26, p27 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), deveti);

                Point p28 = new Point(460, 118);
                Point p29 = new Point(479, 118);
                Point p30 = new Point(468, 96);
                Point[] deseti = { p28, p29, p30 };
                g.FillPolygon(new SolidBrush(Color.DodgerBlue), deseti);


            drugiNoktiP();
            treciNoktiP();

        }
             
        private void treciNoktiP()
        {
            Graphics g1 = panel7.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 10, 95, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 41, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 101, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 185, 63, 12, 24);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 181, 74, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 226, 198, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 259, 210, 14, 15);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 246, 197, 14, 17);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 251, 204, 15, 15);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 292, 73, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 289, 59, 13, 24);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 369, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 430, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 461, 97, 15, 45);
        }
        private void treciNoktiZ()
        {
            Graphics g1 = panel7.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.Yellow), 10, 95, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 41, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 101, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 185, 63, 12, 24);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 181, 74, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 226, 198, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 259, 210, 14, 15);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 246, 197, 14, 17);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 251, 204, 15, 15);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 292, 73, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 289, 59, 13, 24);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 369, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 430, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 461, 97, 15, 45);
        }
        private void treciNoktiPink()
        {
            Graphics g1 = panel7.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 10, 95, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 41, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 101, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 185, 63, 12, 24);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 181, 74, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 226, 198, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 259, 210, 14, 15);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 246, 197, 14, 17);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 251, 204, 15, 15);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 292, 73, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 289, 59, 13, 24);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 369, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 430, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 461, 97, 15, 45);
        }
        private void treciNoktiRed()
        {
            Graphics g1 = panel7.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.Red), 10, 95, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Red), 41, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Red), 101, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Red), 185, 63, 12, 24);
            g1.FillEllipse(new SolidBrush(Color.Red), 181, 74, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.Red), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.Red), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.Red), 226, 198, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.Red), 259, 210, 14, 15);
            g1.FillEllipse(new SolidBrush(Color.Red), 246, 197, 14, 17);
            g1.FillEllipse(new SolidBrush(Color.Red), 251, 204, 15, 15);
            g1.FillEllipse(new SolidBrush(Color.Red), 292, 73, 13, 27);
            g1.FillEllipse(new SolidBrush(Color.Red), 289, 59, 13, 24);
            g1.FillEllipse(new SolidBrush(Color.Red), 369, 25, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Red), 430, 50, 15, 45);
            g1.FillEllipse(new SolidBrush(Color.Red), 461, 97, 15, 45);
        }
        private void drugiNoktiP()
        {
            Graphics g1 = panel6.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 8, 100, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 39, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 100, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 185, 67, 16, 23);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 179, 74, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 224, 200, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 255, 210, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 243, 200, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 247, 204, 21, 15);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 290, 73, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 288, 63, 17, 24);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 368, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 430, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DodgerBlue), 461, 100, 18, 40);
        }
        private void drugiNoktiZ()
        {
            Graphics g1 = panel6.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.Yellow), 8, 100, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 39, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 100, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 185, 67, 16, 23);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 179, 74, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 224, 200, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 255, 210, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 243, 200, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 247, 204, 21, 15);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 290, 73, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 288, 63, 17, 24);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 368, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 430, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Yellow), 461, 100, 18, 40);
        }
        private void drugiNoktiPink()
        {
            Graphics g1 = panel6.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 8, 100, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 39, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 100, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 185, 67, 16, 23);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 179, 74, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 224, 200, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 255, 210, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 243, 200, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 247, 204, 21, 15);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 290, 73, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 288, 63, 17, 24);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 368, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 430, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.DeepPink), 461, 100, 18, 40);
        }

       

        private void button14_Click(object sender, EventArgs e)
        {
            Graphics g = panel5.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.Yellow), 7, 110, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Yellow), 38, 65, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Yellow), 98, 40, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Yellow), 178, 75, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Yellow), 210, 210, 18, 15);
            g.FillEllipse(new SolidBrush(Color.Yellow), 255, 210, 18, 15);
            g.FillEllipse(new SolidBrush(Color.Yellow), 290, 71, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Yellow), 366, 40, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Yellow), 428, 65, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Yellow), 459, 110, 20, 30);
            Point p1 = new Point(8, 115);
            Point p2 = new Point(25, 115);
            Point p3 = new Point(17, 97);
            Point[] prvi = { p1, p2, p3 };
            g.FillPolygon(new SolidBrush(Color.Yellow), prvi);

            Point p4 = new Point(40, 70);
            Point p5 = new Point(57, 70);
            Point p6 = new Point(47, 52);
            Point[] drugi = { p4, p5, p6 };
            g.FillPolygon(new SolidBrush(Color.Yellow), drugi);

            Point p7 = new Point(100, 45);
            Point p8 = new Point(117, 45);
            Point p9 = new Point(107, 27);
            Point[] treci = { p7, p8, p9 };
            g.FillPolygon(new SolidBrush(Color.Yellow), treci);

            Point p10 = new Point(184, 75);
            Point p11 = new Point(199, 87);
            Point p12 = new Point(197, 64);
            Point[] cetvrti = { p10, p11, p12 };
            g.FillPolygon(new SolidBrush(Color.Yellow), cetvrti);

            Point p13 = new Point(215, 210);
            Point p14 = new Point(225, 222);
            Point p15 = new Point(243, 195);
            Point[] peti = { p13, p14, p15 };
            g.FillPolygon(new SolidBrush(Color.Yellow), peti);

            Point p16 = new Point(255, 220);
            Point p17 = new Point(268, 210);
            Point p18 = new Point(245, 195);
            Point[] sesti = { p16, p17, p18 };
            g.FillPolygon(new SolidBrush(Color.Yellow), sesti);

            Point p19 = new Point(289, 86);
            Point p20 = new Point(304, 71);
            Point p21 = new Point(290, 60);
            Point[] sedmi = { p19, p20, p21 };
            g.FillPolygon(new SolidBrush(Color.Yellow), sedmi);

            Point p22 = new Point(366, 49);
            Point p23 = new Point(386, 49);
            Point p24 = new Point(376, 25);
            Point[] osmi = { p22, p23, p24 };
            g.FillPolygon(new SolidBrush(Color.Yellow), osmi);

            Point p25 = new Point(428, 74);
            Point p26 = new Point(448, 74);
            Point p27 = new Point(438, 50);
            Point[] deveti = { p25, p26, p27 };
            g.FillPolygon(new SolidBrush(Color.Yellow), deveti);

            Point p28 = new Point(460, 118);
            Point p29 = new Point(479, 118);
            Point p30 = new Point(468, 96);
            Point[] deseti = { p28, p29, p30 };
            g.FillPolygon(new SolidBrush(Color.Yellow), deseti);

            drugiNoktiZ();
            treciNoktiZ();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Graphics g = panel5.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.DeepPink), 7, 110, 20, 30);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 38, 65, 20, 30);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 98, 40, 20, 30);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 178, 75, 20, 30);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 210, 210, 18, 15);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 255, 210, 18, 15);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 290, 71, 20, 30);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 366, 40, 20, 30);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 428, 65, 20, 30);
            g.FillEllipse(new SolidBrush(Color.DeepPink), 459, 110, 20, 30);
            Point p1 = new Point(8, 115);
            Point p2 = new Point(25, 115);
            Point p3 = new Point(17, 97);
            Point[] prvi = { p1, p2, p3 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), prvi);

            Point p4 = new Point(40, 70);
            Point p5 = new Point(57, 70);
            Point p6 = new Point(47, 52);
            Point[] drugi = { p4, p5, p6 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), drugi);

            Point p7 = new Point(100, 45);
            Point p8 = new Point(117, 45);
            Point p9 = new Point(107, 27);
            Point[] treci = { p7, p8, p9 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), treci);

            Point p10 = new Point(184, 75);
            Point p11 = new Point(199, 87);
            Point p12 = new Point(197, 64);
            Point[] cetvrti = { p10, p11, p12 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), cetvrti);

            Point p13 = new Point(215, 210);
            Point p14 = new Point(225, 222);
            Point p15 = new Point(243, 195);
            Point[] peti = { p13, p14, p15 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), peti);

            Point p16 = new Point(255, 220);
            Point p17 = new Point(268, 210);
            Point p18 = new Point(245, 195);
            Point[] sesti = { p16, p17, p18 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), sesti);

            Point p19 = new Point(289, 86);
            Point p20 = new Point(304, 71);
            Point p21 = new Point(290, 60);
            Point[] sedmi = { p19, p20, p21 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), sedmi);

            Point p22 = new Point(366, 49);
            Point p23 = new Point(386, 49);
            Point p24 = new Point(376, 25);
            Point[] osmi = { p22, p23, p24 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), osmi);

            Point p25 = new Point(428, 74);
            Point p26 = new Point(448, 74);
            Point p27 = new Point(438, 50);
            Point[] deveti = { p25, p26, p27 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), deveti);

            Point p28 = new Point(460, 118);
            Point p29 = new Point(479, 118);
            Point p30 = new Point(468, 96);
            Point[] deseti = { p28, p29, p30 };
            g.FillPolygon(new SolidBrush(Color.DeepPink), deseti);

            drugiNoktiPink();
            treciNoktiPink();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Graphics g = panel5.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.Red), 7, 110, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Red), 38, 65, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Red), 98, 40, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Red), 178, 75, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Red), 210, 210, 18, 15);
            g.FillEllipse(new SolidBrush(Color.Red), 255, 210, 18, 15);
            g.FillEllipse(new SolidBrush(Color.Red), 290, 71, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Red), 366, 40, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Red), 428, 65, 20, 30);
            g.FillEllipse(new SolidBrush(Color.Red), 459, 110, 20, 30);
            Point p1 = new Point(8, 115);
            Point p2 = new Point(25, 115);
            Point p3 = new Point(17, 97);
            Point[] prvi = { p1, p2, p3 };
            g.FillPolygon(new SolidBrush(Color.Red), prvi);

            Point p4 = new Point(40, 70);
            Point p5 = new Point(57, 70);
            Point p6 = new Point(47, 52);
            Point[] drugi = { p4, p5, p6 };
            g.FillPolygon(new SolidBrush(Color.Red), drugi);

            Point p7 = new Point(100, 45);
            Point p8 = new Point(117, 45);
            Point p9 = new Point(107, 27);
            Point[] treci = { p7, p8, p9 };
            g.FillPolygon(new SolidBrush(Color.Red), treci);

            Point p10 = new Point(184, 75);
            Point p11 = new Point(199, 87);
            Point p12 = new Point(197, 64);
            Point[] cetvrti = { p10, p11, p12 };
            g.FillPolygon(new SolidBrush(Color.Red), cetvrti);

            Point p13 = new Point(215, 210);
            Point p14 = new Point(225, 222);
            Point p15 = new Point(243, 195);
            Point[] peti = { p13, p14, p15 };
            g.FillPolygon(new SolidBrush(Color.Red), peti);

            Point p16 = new Point(255, 220);
            Point p17 = new Point(268, 210);
            Point p18 = new Point(245, 195);
            Point[] sesti = { p16, p17, p18 };
            g.FillPolygon(new SolidBrush(Color.Red), sesti);

            Point p19 = new Point(289, 86);
            Point p20 = new Point(304, 71);
            Point p21 = new Point(290, 60);
            Point[] sedmi = { p19, p20, p21 };
            g.FillPolygon(new SolidBrush(Color.Red), sedmi);

            Point p22 = new Point(366, 49);
            Point p23 = new Point(386, 49);
            Point p24 = new Point(376, 25);
            Point[] osmi = { p22, p23, p24 };
            g.FillPolygon(new SolidBrush(Color.Red), osmi);

            Point p25 = new Point(428, 74);
            Point p26 = new Point(448, 74);
            Point p27 = new Point(438, 50);
            Point[] deveti = { p25, p26, p27 };
            g.FillPolygon(new SolidBrush(Color.Red), deveti);

            Point p28 = new Point(460, 118);
            Point p29 = new Point(479, 118);
            Point p30 = new Point(468, 96);
            Point[] deseti = { p28, p29, p30 };
            g.FillPolygon(new SolidBrush(Color.Red), deseti);

            drugiNoktiRed();
            treciNoktiRed();
        }

        private void drugiNoktiRed()
        {
            Graphics g1 = panel6.CreateGraphics();
            g1.FillEllipse(new SolidBrush(Color.Red), 8, 100, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Red), 39, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Red), 100, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Red), 185, 67, 16, 23);
            g1.FillEllipse(new SolidBrush(Color.Red), 179, 74, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.Red), 211, 210, 16, 14);
            g1.FillEllipse(new SolidBrush(Color.Red), 219, 202, 16, 15);
            g1.FillEllipse(new SolidBrush(Color.Red), 224, 200, 15, 13);
            g1.FillEllipse(new SolidBrush(Color.Red), 255, 210, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.Red), 243, 200, 20, 15);
            g1.FillEllipse(new SolidBrush(Color.Red), 247, 204, 21, 15);
            g1.FillEllipse(new SolidBrush(Color.Red), 290, 73, 18, 27);
            g1.FillEllipse(new SolidBrush(Color.Red), 288, 63, 17, 24);
            g1.FillEllipse(new SolidBrush(Color.Red), 368, 30, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Red), 430, 55, 18, 40);
            g1.FillEllipse(new SolidBrush(Color.Red), 461, 100, 18, 40);
        }
       
        public void treciGrad1()
        {
            Graphics g1 = panel7.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(10, 95, 15, 45);
            PathGradientBrush pBrush = new PathGradientBrush(path);
            pBrush.CenterColor = Color.Red;
            Color[] colors = { Color.Yellow };
            pBrush.SurroundColors = colors;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(41, 50, 15, 45);
            PathGradientBrush pBrush1 = new PathGradientBrush(path1);
            pBrush1.CenterColor = Color.Red;
            Color[] colors1 = { Color.Yellow };
            pBrush1.SurroundColors = colors1;

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(101, 25, 15, 45);
            PathGradientBrush pBrush2 = new PathGradientBrush(path2);
            pBrush2.CenterColor = Color.Red;
            Color[] colors2 = { Color.Yellow };
            pBrush2.SurroundColors = colors2;

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(185, 63, 12, 24);
            PathGradientBrush pBrush3 = new PathGradientBrush(path3);
            pBrush3.CenterColor = Color.Red;
            Color[] colors3 = { Color.Yellow };
            pBrush3.SurroundColors = colors3;

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(181, 74, 13, 27);
            PathGradientBrush pBrush4 = new PathGradientBrush(path4);
            pBrush4.CenterColor = Color.Red;
            Color[] colors4 = { Color.Yellow };
            pBrush4.SurroundColors = colors4;

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(211, 210, 16, 14);
            PathGradientBrush pBrush5 = new PathGradientBrush(path5);
            pBrush5.CenterColor = Color.Red;
            Color[] colors5 = { Color.Yellow };
            pBrush5.SurroundColors = colors5;

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(219, 202, 16, 15);
            PathGradientBrush pBrush6 = new PathGradientBrush(path6);
            pBrush6.CenterColor = Color.Red;
            Color[] colors6 = { Color.Yellow };
            pBrush6.SurroundColors = colors6;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddEllipse(226, 198, 15, 13);
            PathGradientBrush pBrush7 = new PathGradientBrush(path7);
            pBrush7.CenterColor = Color.Red;
            Color[] colors7 = { Color.Yellow };
            pBrush7.SurroundColors = colors7;

            GraphicsPath path8 = new GraphicsPath();
            path8.AddEllipse(259, 210, 14, 15);
            PathGradientBrush pBrush8 = new PathGradientBrush(path8);
            pBrush8.CenterColor = Color.Red;
            Color[] colors8 = { Color.Yellow };
            pBrush8.SurroundColors = colors8;

            GraphicsPath path9 = new GraphicsPath();
            path9.AddEllipse(246, 197, 14, 17);
            PathGradientBrush pBrush9 = new PathGradientBrush(path9);
            pBrush9.CenterColor = Color.Red;
            Color[] colors9 = { Color.Yellow };
            pBrush9.SurroundColors = colors9;

            GraphicsPath path10 = new GraphicsPath();
            path10.AddEllipse(251, 204, 15, 15);
            PathGradientBrush pBrush10 = new PathGradientBrush(path10);
            pBrush10.CenterColor = Color.Red;
            Color[] colors10 = { Color.Yellow };
            pBrush10.SurroundColors = colors10;

            GraphicsPath path11 = new GraphicsPath();
            path11.AddEllipse(292, 73, 13, 27);
            PathGradientBrush pBrush11 = new PathGradientBrush(path11);
            pBrush11.CenterColor = Color.Red;
            Color[] colors11 = { Color.Yellow };
            pBrush11.SurroundColors = colors11;

            GraphicsPath path12 = new GraphicsPath();
            path12.AddEllipse(289, 59, 13, 24);
            PathGradientBrush pBrush12 = new PathGradientBrush(path12);
            pBrush12.CenterColor = Color.Red;
            Color[] colors12 = { Color.Yellow };
            pBrush12.SurroundColors = colors12;

            GraphicsPath path13 = new GraphicsPath();
            path13.AddEllipse(369, 25, 15, 45);
            PathGradientBrush pBrush13 = new PathGradientBrush(path13);
            pBrush13.CenterColor = Color.Red;
            Color[] colors13 = { Color.Yellow };
            pBrush13.SurroundColors = colors13;

            GraphicsPath path14 = new GraphicsPath();
            path14.AddEllipse(430, 50, 15, 45);
            PathGradientBrush pBrush14 = new PathGradientBrush(path14);
            pBrush14.CenterColor = Color.Red;
            Color[] colors14 = { Color.Yellow };
            pBrush14.SurroundColors = colors14;

            GraphicsPath path15 = new GraphicsPath();
            path15.AddEllipse(461, 97, 15, 45);
            PathGradientBrush pBrush15 = new PathGradientBrush(path15);
            pBrush15.CenterColor = Color.Red;
            Color[] colors15 = { Color.Yellow };
            pBrush15.SurroundColors = colors15;

            g1.FillEllipse(pBrush, 10, 95, 15, 45);
            g1.FillEllipse(pBrush1, 41, 50, 15, 45);
            g1.FillEllipse(pBrush2, 101, 25, 15, 45);
            g1.FillEllipse(pBrush3, 185, 63, 12, 24);
            g1.FillEllipse(pBrush4, 181, 74, 13, 27);
            g1.FillEllipse(pBrush5, 211, 210, 16, 14);
            g1.FillEllipse(pBrush6, 219, 202, 16, 15);
            g1.FillEllipse(pBrush7, 226, 198, 15, 13);
            g1.FillEllipse(pBrush8, 259, 210, 14, 15);
            g1.FillEllipse(pBrush9, 246, 197, 14, 17);
            g1.FillEllipse(pBrush10, 251, 204, 15, 15);
            g1.FillEllipse(pBrush11, 292, 73, 13, 27);
            g1.FillEllipse(pBrush12, 289, 59, 13, 24);
            g1.FillEllipse(pBrush13, 369, 25, 15, 45);
            g1.FillEllipse(pBrush14, 430, 50, 15, 45);
            g1.FillEllipse(pBrush15, 461, 97, 15, 45);
        }
        public void treciGrad2()
        {
            Graphics g1 = panel7.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(10, 95, 15, 45);
            PathGradientBrush pBrush = new PathGradientBrush(path);
            pBrush.CenterColor = Color.Purple;
            Color[] colors = { Color.Pink };
            pBrush.SurroundColors = colors;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(41, 50, 15, 45);
            PathGradientBrush pBrush1 = new PathGradientBrush(path1);
            pBrush1.CenterColor = Color.Purple;
            Color[] colors1 = { Color.Pink };
            pBrush1.SurroundColors = colors1;

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(101, 25, 15, 45);
            PathGradientBrush pBrush2 = new PathGradientBrush(path2);
            pBrush2.CenterColor = Color.Purple;
            Color[] colors2 = { Color.Pink };
            pBrush2.SurroundColors = colors2;

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(185, 63, 12, 24);
            PathGradientBrush pBrush3 = new PathGradientBrush(path3);
            pBrush3.CenterColor = Color.Purple;
            Color[] colors3 = { Color.Pink };
            pBrush3.SurroundColors = colors3;

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(181, 74, 13, 27);
            PathGradientBrush pBrush4 = new PathGradientBrush(path4);
            pBrush4.CenterColor = Color.Purple;
            Color[] colors4 = { Color.Pink };
            pBrush4.SurroundColors = colors4;

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(211, 210, 16, 14);
            PathGradientBrush pBrush5 = new PathGradientBrush(path5);
            pBrush5.CenterColor = Color.Purple;
            Color[] colors5 = { Color.Pink };
            pBrush5.SurroundColors = colors5;

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(219, 202, 16, 15);
            PathGradientBrush pBrush6 = new PathGradientBrush(path6);
            pBrush6.CenterColor = Color.Purple;
            Color[] colors6 = { Color.Pink };
            pBrush6.SurroundColors = colors6;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddEllipse(226, 198, 15, 13);
            PathGradientBrush pBrush7 = new PathGradientBrush(path7);
            pBrush7.CenterColor = Color.Purple;
            Color[] colors7 = { Color.Pink };
            pBrush7.SurroundColors = colors7;

            GraphicsPath path8 = new GraphicsPath();
            path8.AddEllipse(259, 210, 14, 15);
            PathGradientBrush pBrush8 = new PathGradientBrush(path8);
            pBrush8.CenterColor = Color.Purple;
            Color[] colors8 = { Color.Pink };
            pBrush8.SurroundColors = colors8;

            GraphicsPath path9 = new GraphicsPath();
            path9.AddEllipse(246, 197, 14, 17);
            PathGradientBrush pBrush9 = new PathGradientBrush(path9);
            pBrush9.CenterColor = Color.Purple;
            Color[] colors9 = { Color.Pink };
            pBrush9.SurroundColors = colors9;

            GraphicsPath path10 = new GraphicsPath();
            path10.AddEllipse(251, 204, 15, 15);
            PathGradientBrush pBrush10 = new PathGradientBrush(path10);
            pBrush10.CenterColor = Color.Purple;
            Color[] colors10 = { Color.Pink };
            pBrush10.SurroundColors = colors10;

            GraphicsPath path11 = new GraphicsPath();
            path11.AddEllipse(292, 73, 13, 27);
            PathGradientBrush pBrush11 = new PathGradientBrush(path11);
            pBrush11.CenterColor = Color.Purple;
            Color[] colors11 = { Color.Pink };
            pBrush11.SurroundColors = colors11;

            GraphicsPath path12 = new GraphicsPath();
            path12.AddEllipse(289, 59, 13, 24);
            PathGradientBrush pBrush12 = new PathGradientBrush(path12);
            pBrush12.CenterColor = Color.Purple;
            Color[] colors12 = { Color.Pink };
            pBrush12.SurroundColors = colors12;

            GraphicsPath path13 = new GraphicsPath();
            path13.AddEllipse(369, 25, 15, 45);
            PathGradientBrush pBrush13 = new PathGradientBrush(path13);
            pBrush13.CenterColor = Color.Purple;
            Color[] colors13 = { Color.Pink };
            pBrush13.SurroundColors = colors13;

            GraphicsPath path14 = new GraphicsPath();
            path14.AddEllipse(430, 50, 15, 45);
            PathGradientBrush pBrush14 = new PathGradientBrush(path14);
            pBrush14.CenterColor = Color.Purple;
            Color[] colors14 = { Color.Pink };
            pBrush14.SurroundColors = colors14;

            GraphicsPath path15 = new GraphicsPath();
            path15.AddEllipse(461, 97, 15, 45);
            PathGradientBrush pBrush15 = new PathGradientBrush(path15);
            pBrush15.CenterColor = Color.Purple;
            Color[] colors15 = { Color.Pink };
            pBrush15.SurroundColors = colors15;

            g1.FillEllipse(pBrush, 10, 95, 15, 45);
            g1.FillEllipse(pBrush1, 41, 50, 15, 45);
            g1.FillEllipse(pBrush2, 101, 25, 15, 45);
            g1.FillEllipse(pBrush3, 185, 63, 12, 24);
            g1.FillEllipse(pBrush4, 181, 74, 13, 27);
            g1.FillEllipse(pBrush5, 211, 210, 16, 14);
            g1.FillEllipse(pBrush6, 219, 202, 16, 15);
            g1.FillEllipse(pBrush7, 226, 198, 15, 13);
            g1.FillEllipse(pBrush8, 259, 210, 14, 15);
            g1.FillEllipse(pBrush9, 246, 197, 14, 17);
            g1.FillEllipse(pBrush10, 251, 204, 15, 15);
            g1.FillEllipse(pBrush11, 292, 73, 13, 27);
            g1.FillEllipse(pBrush12, 289, 59, 13, 24);
            g1.FillEllipse(pBrush13, 369, 25, 15, 45);
            g1.FillEllipse(pBrush14, 430, 50, 15, 45);
            g1.FillEllipse(pBrush15, 461, 97, 15, 45);
        }
        public void drugiGrad1()
        {
            Graphics g1 = panel6.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(8, 100, 18, 40);
            PathGradientBrush pBrush = new PathGradientBrush(path);
            pBrush.CenterColor = Color.Red;
            Color[] colors = { Color.Yellow };
            pBrush.SurroundColors = colors;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(39, 55, 18, 40);
            PathGradientBrush pBrush1 = new PathGradientBrush(path1);
            pBrush1.CenterColor = Color.Red;
            Color[] colors1 = { Color.Yellow };
            pBrush1.SurroundColors = colors1;

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(100, 30, 18, 40);
            PathGradientBrush pBrush2 = new PathGradientBrush(path2);
            pBrush2.CenterColor = Color.Red;
            Color[] colors2 = { Color.Yellow };
            pBrush2.SurroundColors = colors2;

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(185, 67, 16, 23);
            PathGradientBrush pBrush3 = new PathGradientBrush(path3);
            pBrush3.CenterColor = Color.Red;
            Color[] colors3 = { Color.Yellow };
            pBrush3.SurroundColors = colors3;

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(179, 74, 18, 27);
            PathGradientBrush pBrush4 = new PathGradientBrush(path4);
            pBrush4.CenterColor = Color.Red;
            Color[] colors4 = { Color.Yellow };
            pBrush4.SurroundColors = colors4;

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(211, 210, 16, 14);
            PathGradientBrush pBrush5 = new PathGradientBrush(path5);
            pBrush5.CenterColor = Color.Red;
            Color[] colors5 = { Color.Yellow };
            pBrush5.SurroundColors = colors5;

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(219, 202, 16, 15);
            PathGradientBrush pBrush6 = new PathGradientBrush(path6);
            pBrush6.CenterColor = Color.Red;
            Color[] colors6 = { Color.Yellow };
            pBrush6.SurroundColors = colors6;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddEllipse(224, 200, 15, 13);
            PathGradientBrush pBrush7 = new PathGradientBrush(path7);
            pBrush7.CenterColor = Color.Red;
            Color[] colors7 = { Color.Yellow };
            pBrush7.SurroundColors = colors7;

            GraphicsPath path8 = new GraphicsPath();
            path8.AddEllipse(255, 210, 20, 15);
            PathGradientBrush pBrush8 = new PathGradientBrush(path8);
            pBrush8.CenterColor = Color.Red;
            Color[] colors8 = { Color.Yellow };
            pBrush8.SurroundColors = colors8;

            GraphicsPath path9 = new GraphicsPath();
            path9.AddEllipse(243, 200, 20, 15);
            PathGradientBrush pBrush9 = new PathGradientBrush(path9);
            pBrush9.CenterColor = Color.Red;
            Color[] colors9 = { Color.Yellow };
            pBrush9.SurroundColors = colors9;

            GraphicsPath path10 = new GraphicsPath();
            path10.AddEllipse(247, 204, 21, 15);
            PathGradientBrush pBrush10 = new PathGradientBrush(path10);
            pBrush10.CenterColor = Color.Red;
            Color[] colors10 = { Color.Yellow };
            pBrush10.SurroundColors = colors10;

            GraphicsPath path11 = new GraphicsPath();
            path11.AddEllipse(290, 73, 18, 27);
            PathGradientBrush pBrush11 = new PathGradientBrush(path11);
            pBrush11.CenterColor = Color.Red;
            Color[] colors11 = { Color.Yellow };
            pBrush11.SurroundColors = colors11;

            GraphicsPath path12 = new GraphicsPath();
            path12.AddEllipse(288, 63, 17, 24);
            PathGradientBrush pBrush12 = new PathGradientBrush(path12);
            pBrush12.CenterColor = Color.Red;
            Color[] colors12 = { Color.Yellow };
            pBrush12.SurroundColors = colors12;

            GraphicsPath path13 = new GraphicsPath();
            path13.AddEllipse(368, 30, 18, 40);
            PathGradientBrush pBrush13 = new PathGradientBrush(path13);
            pBrush13.CenterColor = Color.Red;
            Color[] colors13 = { Color.Yellow };
            pBrush13.SurroundColors = colors13;

            GraphicsPath path14 = new GraphicsPath();
            path14.AddEllipse(430, 55, 18, 40);
            PathGradientBrush pBrush14 = new PathGradientBrush(path14);
            pBrush14.CenterColor = Color.Red;
            Color[] colors14 = { Color.Yellow };
            pBrush14.SurroundColors = colors14;

            GraphicsPath path15 = new GraphicsPath();
            path15.AddEllipse(461, 100, 18, 40);
            PathGradientBrush pBrush15 = new PathGradientBrush(path15);
            pBrush15.CenterColor = Color.Red;
            Color[] colors15 = { Color.Yellow };
            pBrush15.SurroundColors = colors15;

            g1.FillEllipse(pBrush, 8, 100, 18, 40);
            g1.FillEllipse(pBrush1, 39, 55, 18, 40);
            g1.FillEllipse(pBrush2, 100, 30, 18, 40);
            g1.FillEllipse(pBrush3, 185, 67, 16, 23);
            g1.FillEllipse(pBrush4, 179, 74, 18, 27);
            g1.FillEllipse(pBrush5, 211, 210, 16, 14);
            g1.FillEllipse(pBrush6, 219, 202, 16, 15);
            g1.FillEllipse(pBrush7, 224, 200, 15, 13);
            g1.FillEllipse(pBrush8, 255, 210, 20, 15);
            g1.FillEllipse(pBrush9, 243, 200, 20, 15);
            g1.FillEllipse(pBrush10, 247, 204, 21, 15);
            g1.FillEllipse(pBrush11, 290, 73, 18, 27);
            g1.FillEllipse(pBrush12, 288, 63, 17, 24);
            g1.FillEllipse(pBrush13, 368, 30, 18, 40);
            g1.FillEllipse(pBrush14, 430, 55, 18, 40);
            g1.FillEllipse(pBrush15, 461, 100, 18, 40);

        }
        public void drugiGrad2()
        {
            Graphics g1 = panel6.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(8, 100, 18, 40);
            PathGradientBrush pBrush = new PathGradientBrush(path);
            pBrush.CenterColor = Color.Purple;
            Color[] colors = { Color.Pink };
            pBrush.SurroundColors = colors;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(39, 55, 18, 40);
            PathGradientBrush pBrush1 = new PathGradientBrush(path1);
            pBrush1.CenterColor = Color.Purple;
            Color[] colors1 = { Color.Pink };
            pBrush1.SurroundColors = colors1;

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(100, 30, 18, 40);
            PathGradientBrush pBrush2 = new PathGradientBrush(path2);
            pBrush2.CenterColor = Color.Purple;
            Color[] colors2 = { Color.Pink };
            pBrush2.SurroundColors = colors2;

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(185, 67, 16, 23);
            PathGradientBrush pBrush3 = new PathGradientBrush(path3);
            pBrush3.CenterColor = Color.Purple;
            Color[] colors3 = { Color.Pink };
            pBrush3.SurroundColors = colors3;

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(179, 74, 18, 27);
            PathGradientBrush pBrush4 = new PathGradientBrush(path4);
            pBrush4.CenterColor = Color.Purple;
            Color[] colors4 = { Color.Pink };
            pBrush4.SurroundColors = colors4;

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(211, 210, 16, 14);
            PathGradientBrush pBrush5 = new PathGradientBrush(path5);
            pBrush5.CenterColor = Color.Purple;
            Color[] colors5 = { Color.Pink };
            pBrush5.SurroundColors = colors5;

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(219, 202, 16, 15);
            PathGradientBrush pBrush6 = new PathGradientBrush(path6);
            pBrush6.CenterColor = Color.Purple;
            Color[] colors6 = { Color.Pink };
            pBrush6.SurroundColors = colors6;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddEllipse(224, 200, 15, 13);
            PathGradientBrush pBrush7 = new PathGradientBrush(path7);
            pBrush7.CenterColor = Color.Purple;
            Color[] colors7 = { Color.Pink };
            pBrush7.SurroundColors = colors7;

            GraphicsPath path8 = new GraphicsPath();
            path8.AddEllipse(255, 210, 20, 15);
            PathGradientBrush pBrush8 = new PathGradientBrush(path8);
            pBrush8.CenterColor = Color.Purple;
            Color[] colors8 = { Color.Pink };
            pBrush8.SurroundColors = colors8;

            GraphicsPath path9 = new GraphicsPath();
            path9.AddEllipse(243, 200, 20, 15);
            PathGradientBrush pBrush9 = new PathGradientBrush(path9);
            pBrush9.CenterColor = Color.Purple;
            Color[] colors9 = { Color.Pink };
            pBrush9.SurroundColors = colors9;

            GraphicsPath path10 = new GraphicsPath();
            path10.AddEllipse(247, 204, 21, 15);
            PathGradientBrush pBrush10 = new PathGradientBrush(path10);
            pBrush10.CenterColor = Color.Purple;
            Color[] colors10 = { Color.Pink };
            pBrush10.SurroundColors = colors10;

            GraphicsPath path11 = new GraphicsPath();
            path11.AddEllipse(290, 73, 18, 27);
            PathGradientBrush pBrush11 = new PathGradientBrush(path11);
            pBrush11.CenterColor = Color.Purple;
            Color[] colors11 = { Color.Pink };
            pBrush11.SurroundColors = colors11;

            GraphicsPath path12 = new GraphicsPath();
            path12.AddEllipse(288, 63, 17, 24);
            PathGradientBrush pBrush12 = new PathGradientBrush(path12);
            pBrush12.CenterColor = Color.Purple;
            Color[] colors12 = { Color.Pink };
            pBrush12.SurroundColors = colors12;

            GraphicsPath path13 = new GraphicsPath();
            path13.AddEllipse(368, 30, 18, 40);
            PathGradientBrush pBrush13 = new PathGradientBrush(path13);
            pBrush13.CenterColor = Color.Purple;
            Color[] colors13 = { Color.Pink };
            pBrush13.SurroundColors = colors13;

            GraphicsPath path14 = new GraphicsPath();
            path14.AddEllipse(430, 55, 18, 40);
            PathGradientBrush pBrush14 = new PathGradientBrush(path14);
            pBrush14.CenterColor = Color.Purple;
            Color[] colors14 = { Color.Pink };
            pBrush14.SurroundColors = colors14;

            GraphicsPath path15 = new GraphicsPath();
            path15.AddEllipse(461, 100, 18, 40);
            PathGradientBrush pBrush15 = new PathGradientBrush(path15);
            pBrush15.CenterColor = Color.Purple;
            Color[] colors15 = { Color.Pink };
            pBrush15.SurroundColors = colors15;

            g1.FillEllipse(pBrush, 8, 100, 18, 40);
            g1.FillEllipse(pBrush1, 39, 55, 18, 40);
            g1.FillEllipse(pBrush2, 100, 30, 18, 40);
            g1.FillEllipse(pBrush3, 185, 67, 16, 23);
            g1.FillEllipse(pBrush4, 179, 74, 18, 27);
            g1.FillEllipse(pBrush5, 211, 210, 16, 14);
            g1.FillEllipse(pBrush6, 219, 202, 16, 15);
            g1.FillEllipse(pBrush7, 224, 200, 15, 13);
            g1.FillEllipse(pBrush8, 255, 210, 20, 15);
            g1.FillEllipse(pBrush9, 243, 200, 20, 15);
            g1.FillEllipse(pBrush10, 247, 204, 21, 15);
            g1.FillEllipse(pBrush11, 290, 73, 18, 27);
            g1.FillEllipse(pBrush12, 288, 63, 17, 24);
            g1.FillEllipse(pBrush13, 368, 30, 18, 40);
            g1.FillEllipse(pBrush14, 430, 55, 18, 40);
            g1.FillEllipse(pBrush15, 461, 100, 18, 40);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = panel5.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(7, 110, 20, 30);
            PathGradientBrush pBrush = new PathGradientBrush(path);
            pBrush.CenterColor = Color.Red;
            Color[] colors = { Color.Yellow};
            pBrush.SurroundColors = colors;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(38, 65, 20, 30);
            PathGradientBrush pBrush1 = new PathGradientBrush(path1);
            pBrush1.CenterColor = Color.Red;
            Color[] colors1 = { Color.Yellow };
            pBrush1.SurroundColors = colors1;

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(98, 40, 20, 30);
            PathGradientBrush pBrush2 = new PathGradientBrush(path2);
            pBrush2.CenterColor = Color.Red;
            Color[] colors2 = { Color.Yellow };
            pBrush2.SurroundColors = colors2;

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(178, 75, 20, 30);
            PathGradientBrush pBrush3 = new PathGradientBrush(path3);
            pBrush3.CenterColor = Color.Red;
            Color[] colors3 = { Color.Yellow };
            pBrush3.SurroundColors = colors3;

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(210, 210, 18, 15);
            PathGradientBrush pBrush4 = new PathGradientBrush(path4);
            pBrush4.CenterColor = Color.Red;
            Color[] colors4 = { Color.Yellow };
            pBrush4.SurroundColors = colors4;

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(255, 210, 18, 15);
            PathGradientBrush pBrush5 = new PathGradientBrush(path5);
            pBrush5.CenterColor = Color.Red;
            Color[] colors5 = { Color.Yellow };
            pBrush5.SurroundColors = colors5;

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(290, 71, 20, 30);
            PathGradientBrush pBrush6 = new PathGradientBrush(path6);
            pBrush6.CenterColor = Color.Red;
            Color[] colors6 = { Color.Yellow };
            pBrush6.SurroundColors = colors6;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddEllipse(366, 40, 20, 30);
            PathGradientBrush pBrush7 = new PathGradientBrush(path7);
            pBrush7.CenterColor = Color.Red;
            Color[] colors7 = { Color.Yellow };
            pBrush7.SurroundColors = colors7;

            GraphicsPath path8 = new GraphicsPath();
            path8.AddEllipse(428, 65, 20, 30);
            PathGradientBrush pBrush8 = new PathGradientBrush(path8);
            pBrush8.CenterColor = Color.Red;
            Color[] colors8 = { Color.Yellow };
            pBrush8.SurroundColors = colors8;

            GraphicsPath path9 = new GraphicsPath();
            path9.AddEllipse(459, 110, 20, 30);
            PathGradientBrush pBrush9 = new PathGradientBrush(path9);
            pBrush9.CenterColor = Color.Red;
            Color[] colors9 = { Color.Yellow };
            pBrush9.SurroundColors = colors9;

            g.FillEllipse(pBrush, 7, 110, 20, 30);
            g.FillEllipse(pBrush1, 38, 65, 20, 30);
            g.FillEllipse(pBrush2, 98, 40, 20, 30);
            g.FillEllipse(pBrush3, 178, 75, 20, 30);
            g.FillEllipse(pBrush4, 210, 210, 18, 15);
            g.FillEllipse(pBrush5, 255, 210, 18, 15);
            g.FillEllipse(pBrush6, 290, 71, 20, 30);
            g.FillEllipse(pBrush7, 366, 40, 20, 30);
            g.FillEllipse(pBrush8, 428, 65, 20, 30);
            g.FillEllipse(pBrush9, 459, 110, 20, 30);

            
            Point p1 = new Point(8, 115);
            Point p2 = new Point(25, 115);
            Point p3 = new Point(17, 97);
            Point[] prvi = { p1, p2, p3 };
            PathGradientBrush gradientBrush = new PathGradientBrush(prvi);
            Color[] c = { Color.Yellow };
            gradientBrush.CenterColor = Color.Red;
            gradientBrush.SurroundColors = c;
            g.FillPolygon(gradientBrush, prvi);

            Point p4 = new Point(40, 70);
            Point p5 = new Point(57, 70);
            Point p6 = new Point(47, 52);
            Point[] drugi = { p4, p5, p6 };
            PathGradientBrush gradientBrush1 = new PathGradientBrush(drugi);
            Color[] c1 = { Color.Yellow };
            gradientBrush1.CenterColor = Color.Red;
            gradientBrush1.SurroundColors = c1;
            g.FillPolygon(gradientBrush1, drugi);

            Point p7 = new Point(100, 45);
            Point p8 = new Point(117, 45);
            Point p9 = new Point(107, 27);
            Point[] treci = { p7, p8, p9 };
            PathGradientBrush gradientBrush2 = new PathGradientBrush(treci);
            Color[] c2 = { Color.Yellow };
            gradientBrush2.CenterColor = Color.Red;
            gradientBrush2.SurroundColors = c2;
            g.FillPolygon(gradientBrush2, treci);

            Point p10 = new Point(184, 75);
            Point p11 = new Point(199, 87);
            Point p12 = new Point(197, 64);
            Point[] cetvrti = { p10, p11, p12 };
            PathGradientBrush gradientBrush3 = new PathGradientBrush(cetvrti);
            Color[] c3 = { Color.Yellow };
            gradientBrush3.CenterColor = Color.Red;
            gradientBrush3.SurroundColors = c;
            g.FillPolygon(gradientBrush3, cetvrti);

            Point p13 = new Point(215, 210);
            Point p14 = new Point(225, 222);
            Point p15 = new Point(243, 195);
            Point[] peti = { p13, p14, p15 };
            PathGradientBrush gradientBrush4 = new PathGradientBrush(peti);
            Color[] c4 = { Color.Yellow };
            gradientBrush4.CenterColor = Color.Red;
            gradientBrush4.SurroundColors = c4;
            g.FillPolygon(gradientBrush4, peti);

            Point p16 = new Point(255, 220);
            Point p17 = new Point(268, 210);
            Point p18 = new Point(245, 195);
            Point[] sesti = { p16, p17, p18 };
            PathGradientBrush gradientBrush5 = new PathGradientBrush(sesti);
            Color[] c5 = { Color.Yellow };
            gradientBrush5.CenterColor = Color.Red;
            gradientBrush5.SurroundColors = c5;
            g.FillPolygon(gradientBrush5, sesti);

            Point p19 = new Point(289, 86);
            Point p20 = new Point(304, 71);
            Point p21 = new Point(290, 60);
            Point[] sedmi = { p19, p20, p21 };
            PathGradientBrush gradientBrush6 = new PathGradientBrush(sedmi);
            Color[] c6 = { Color.Yellow };
            gradientBrush6.CenterColor = Color.Red;
            gradientBrush6.SurroundColors = c6;
            g.FillPolygon(gradientBrush6, sedmi);

            Point p22 = new Point(366, 49);
            Point p23 = new Point(386, 49);
            Point p24 = new Point(376, 25);
            Point[] osmi = { p22, p23, p24 };
            PathGradientBrush gradientBrush7 = new PathGradientBrush(osmi);
            Color[] c7 = { Color.Yellow };
            gradientBrush7.CenterColor = Color.Red;
            gradientBrush7.SurroundColors = c;
            g.FillPolygon(gradientBrush7, osmi);

            Point p25 = new Point(428, 74);
            Point p26 = new Point(448, 74);
            Point p27 = new Point(438, 50);
            Point[] deveti = { p25, p26, p27 };
            PathGradientBrush gradientBrush8 = new PathGradientBrush(deveti);
            Color[] c8 = { Color.Yellow };
            gradientBrush8.CenterColor = Color.Red;
            gradientBrush8.SurroundColors = c8;
            g.FillPolygon(gradientBrush8, deveti);

            Point p28 = new Point(460, 118);
            Point p29 = new Point(479, 118);
            Point p30 = new Point(468, 96);
            Point[] deseti = { p28, p29, p30 };
            PathGradientBrush gradientBrush9 = new PathGradientBrush(deseti);
            Color[] c9 = { Color.Yellow };
            gradientBrush9.CenterColor = Color.Red;
            gradientBrush9.SurroundColors = c9;
            g.FillPolygon(gradientBrush9, deseti);

            drugiGrad1();
            treciGrad1();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics g = panel5.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(7, 110, 20, 30);
            PathGradientBrush pBrush = new PathGradientBrush(path);
            pBrush.CenterColor = Color.Purple;
            Color[] colors = { Color.Pink };
            pBrush.SurroundColors = colors;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(38, 65, 20, 30);
            PathGradientBrush pBrush1 = new PathGradientBrush(path1);
            pBrush1.CenterColor = Color.Purple;
            Color[] colors1 = { Color.Pink };
            pBrush1.SurroundColors = colors1;

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(98, 40, 20, 30);
            PathGradientBrush pBrush2 = new PathGradientBrush(path2);
            pBrush2.CenterColor = Color.Purple;
            Color[] colors2 = { Color.Pink };
            pBrush2.SurroundColors = colors2;

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(178, 75, 20, 30);
            PathGradientBrush pBrush3 = new PathGradientBrush(path3);
            pBrush3.CenterColor = Color.Purple;
            Color[] colors3 = { Color.Pink };
            pBrush3.SurroundColors = colors3;

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(210, 210, 18, 15);
            PathGradientBrush pBrush4 = new PathGradientBrush(path4);
            pBrush4.CenterColor = Color.Purple;
            Color[] colors4 = { Color.Pink };
            pBrush4.SurroundColors = colors4;

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(255, 210, 18, 15);
            PathGradientBrush pBrush5 = new PathGradientBrush(path5);
            pBrush5.CenterColor = Color.Purple;
            Color[] colors5 = { Color.Pink };
            pBrush5.SurroundColors = colors5;

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(290, 71, 20, 30);
            PathGradientBrush pBrush6 = new PathGradientBrush(path6);
            pBrush6.CenterColor = Color.Purple;
            Color[] colors6 = { Color.Pink };
            pBrush6.SurroundColors = colors6;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddEllipse(366, 40, 20, 30);
            PathGradientBrush pBrush7 = new PathGradientBrush(path7);
            pBrush7.CenterColor = Color.Purple;
            Color[] colors7 = { Color.Pink };
            pBrush7.SurroundColors = colors7;

            GraphicsPath path8 = new GraphicsPath();
            path8.AddEllipse(428, 65, 20, 30);
            PathGradientBrush pBrush8 = new PathGradientBrush(path8);
            pBrush8.CenterColor = Color.Purple;
            Color[] colors8 = { Color.Pink };
            pBrush8.SurroundColors = colors8;

            GraphicsPath path9 = new GraphicsPath();
            path9.AddEllipse(459, 110, 20, 30);
            PathGradientBrush pBrush9 = new PathGradientBrush(path9);
            pBrush9.CenterColor = Color.Purple;
            Color[] colors9 = { Color.Pink };
            pBrush9.SurroundColors = colors9;

            g.FillEllipse(pBrush, 7, 110, 20, 30);
            g.FillEllipse(pBrush1, 38, 65, 20, 30);
            g.FillEllipse(pBrush2, 98, 40, 20, 30);
            g.FillEllipse(pBrush3, 178, 75, 20, 30);
            g.FillEllipse(pBrush4, 210, 210, 18, 15);
            g.FillEllipse(pBrush5, 255, 210, 18, 15);
            g.FillEllipse(pBrush6, 290, 71, 20, 30);
            g.FillEllipse(pBrush7, 366, 40, 20, 30);
            g.FillEllipse(pBrush8, 428, 65, 20, 30);
            g.FillEllipse(pBrush9, 459, 110, 20, 30);


            Point p1 = new Point(8, 115);
            Point p2 = new Point(25, 115);
            Point p3 = new Point(17, 97);
            Point[] prvi = { p1, p2, p3 };
            PathGradientBrush gradientBrush = new PathGradientBrush(prvi);
            Color[] c = { Color.Pink };
            gradientBrush.CenterColor = Color.Purple;
            gradientBrush.SurroundColors = c;
            g.FillPolygon(gradientBrush, prvi);

            Point p4 = new Point(40, 70);
            Point p5 = new Point(57, 70);
            Point p6 = new Point(47, 52);
            Point[] drugi = { p4, p5, p6 };
            PathGradientBrush gradientBrush1 = new PathGradientBrush(drugi);
            Color[] c1 = { Color.Pink };
            gradientBrush1.CenterColor = Color.Purple;
            gradientBrush1.SurroundColors = c1;
            g.FillPolygon(gradientBrush1, drugi);

            Point p7 = new Point(100, 45);
            Point p8 = new Point(117, 45);
            Point p9 = new Point(107, 27);
            Point[] treci = { p7, p8, p9 };
            PathGradientBrush gradientBrush2 = new PathGradientBrush(treci);
            Color[] c2 = { Color.Pink };
            gradientBrush2.CenterColor = Color.Purple;
            gradientBrush2.SurroundColors = c2;
            g.FillPolygon(gradientBrush2, treci);

            Point p10 = new Point(184, 75);
            Point p11 = new Point(199, 87);
            Point p12 = new Point(197, 64);
            Point[] cetvrti = { p10, p11, p12 };
            PathGradientBrush gradientBrush3 = new PathGradientBrush(cetvrti);
            Color[] c3 = { Color.Pink };
            gradientBrush3.CenterColor = Color.Purple;
            gradientBrush3.SurroundColors = c;
            g.FillPolygon(gradientBrush3, cetvrti);

            Point p13 = new Point(215, 210);
            Point p14 = new Point(225, 222);
            Point p15 = new Point(243, 195);
            Point[] peti = { p13, p14, p15 };
            PathGradientBrush gradientBrush4 = new PathGradientBrush(peti);
            Color[] c4 = { Color.Pink };
            gradientBrush4.CenterColor = Color.Purple;
            gradientBrush4.SurroundColors = c4;
            g.FillPolygon(gradientBrush4, peti);

            Point p16 = new Point(255, 220);
            Point p17 = new Point(268, 210);
            Point p18 = new Point(245, 195);
            Point[] sesti = { p16, p17, p18 };
            PathGradientBrush gradientBrush5 = new PathGradientBrush(sesti);
            Color[] c5 = { Color.Pink };
            gradientBrush5.CenterColor = Color.Purple;
            gradientBrush5.SurroundColors = c5;
            g.FillPolygon(gradientBrush5, sesti);

            Point p19 = new Point(289, 86);
            Point p20 = new Point(304, 71);
            Point p21 = new Point(290, 60);
            Point[] sedmi = { p19, p20, p21 };
            PathGradientBrush gradientBrush6 = new PathGradientBrush(sedmi);
            Color[] c6 = { Color.Pink };
            gradientBrush6.CenterColor = Color.Purple;
            gradientBrush6.SurroundColors = c6;
            g.FillPolygon(gradientBrush6, sedmi);

            Point p22 = new Point(366, 49);
            Point p23 = new Point(386, 49);
            Point p24 = new Point(376, 25);
            Point[] osmi = { p22, p23, p24 };
            PathGradientBrush gradientBrush7 = new PathGradientBrush(osmi);
            Color[] c7 = { Color.Pink };
            gradientBrush7.CenterColor = Color.Purple;
            gradientBrush7.SurroundColors = c;
            g.FillPolygon(gradientBrush7, osmi);

            Point p25 = new Point(428, 74);
            Point p26 = new Point(448, 74);
            Point p27 = new Point(438, 50);
            Point[] deveti = { p25, p26, p27 };
            PathGradientBrush gradientBrush8 = new PathGradientBrush(deveti);
            Color[] c8 = { Color.Pink };
            gradientBrush8.CenterColor = Color.Purple;
            gradientBrush8.SurroundColors = c8;
            g.FillPolygon(gradientBrush8, deveti);

            Point p28 = new Point(460, 118);
            Point p29 = new Point(479, 118);
            Point p30 = new Point(468, 96);
            Point[] deseti = { p28, p29, p30 };
            PathGradientBrush gradientBrush9 = new PathGradientBrush(deseti);
            Color[] c9 = { Color.Pink };
            gradientBrush9.CenterColor = Color.Purple;
            gradientBrush9.SurroundColors = c9;
            g.FillPolygon(gradientBrush9, deseti);

            drugiGrad2();
            treciGrad2();
        }
    }   
}
