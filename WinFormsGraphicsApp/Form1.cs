using System.Numerics;

namespace WinFormsGraphicsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = this.CreateGraphics();
            /*
            var pen = new Pen(Brushes.Magenta, 15);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.DrawArc(pen, 100, 100, 200, 300, 45, 180);
            g.DrawRectangle(pen, 200, 50, 200, 100);

            var brush = new SolidBrush(Color.Green);
            g.FillRectangle(brush, new Rectangle(200, 50, 200, 100));

            Font font = new("Arial", 16, FontStyle.Italic);

            g.DrawString("Hello world", font, Brushes.Red, 50, 50);
            */

            /*
            Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);

            // Create points that define curve.
            PointF point1 = new PointF(50.0F, 50.0F);
            PointF point2 = new PointF(100.0F, 25.0F);
            PointF point3 = new PointF(200.0F, 5.0F);
            PointF point4 = new PointF(250.0F, 50.0F);
            PointF point5 = new PointF(300.0F, 100.0F);
            PointF point6 = new PointF(350.0F, 200.0F);
            PointF point7 = new PointF(250.0F, 250.0F);
            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point7 };

            // Draw lines between original points to screen.
            e.Graphics.DrawLines(redPen, curvePoints);

            // Draw curve to screen.
            e.Graphics.DrawCurve(greenPen, curvePoints);
            */
            //Pen redPen = new Pen(Color.Red, 5);
            //g.DrawBezier(redPen, new Point(150, 150),
            //                     new Point(1200, 270),
            //                     new Point(380, 10),
            //                     new Point(350, 150));

            Pen penAxes = new Pen(Brushes.Black, 2);
            Pen penGraph = new Pen(Brushes.Red, 5);

            int xMiddle = this.Width / 2;
            int yMiddle = this.Height / 2;

            g.DrawLine(penAxes, 0, yMiddle, this.Width, yMiddle);
            g.DrawLine(penAxes, xMiddle, 0, xMiddle, this.Height);

            double xStart = -3;
            double xEnd = 3;
            double xStep = 0.2;
            int xTiks = (int)((xEnd - xStart) / xStep);

            int hx = this.Width / xTiks;
            int hy = this.Height / xTiks;

            int x = xMiddle + (int)(0 / xStep);
            int y = yMiddle + (int)(Function(0));

            //for(double i = xStart; i < xEnd; i+= xStep)
            //{

            //}

        }

        double Function(double x)
        {
            return Math.Sin(x);
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 
                                                 richTextBox.SelectionFont.Size + 0.2F,
                                                 richTextBox.SelectionFont.Style);
            richTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}