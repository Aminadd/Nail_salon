using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nail_Salon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources._1);
            TextureBrush tBrush = new TextureBrush(bitmap);
            e.Graphics.FillRectangle(tBrush,0, 0, 900,700);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            salon s = new salon();
            s.Show();
        }
    }
}
