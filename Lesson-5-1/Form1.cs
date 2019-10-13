using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5_1
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        FiguresFabric figuresFabric;
        RandomRect random = new RandomRect(200);

        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            figuresFabric = new FiguresFabric();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            IDrawFigure figure = figuresFabric.GetFigure("Ellips");
            figure.Draw(graphics, new Pen(Color.Red), random.GetRect);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            IDrawFigure figure = figuresFabric.GetFigure("Rectangle");
            figure.Draw(graphics, new Pen(Color.Blue), random.GetRect);
        }
    }
}
