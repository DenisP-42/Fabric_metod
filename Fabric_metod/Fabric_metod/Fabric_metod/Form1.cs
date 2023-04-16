using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabric_metod
{
    public partial class Form1 : Form
    {
        IShapeFactory creator;
        public Graphics device;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            creator = new SquareFactory();
                Shape shape = creator.CreateShape();
                shape.Draw(pictureBox1.CreateGraphics(), new Point(0, 0), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            creator = new CircleFactory();
            Shape shape = creator.CreateShape();
            shape.Draw(pictureBox1.CreateGraphics(), new Point(0, 0), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            creator = new LineFactory();
            Shape shape = creator.CreateShape();
            shape.Draw(pictureBox1.CreateGraphics(), new Point(0, 0), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }
    }
}
