using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    public partial class DrawingBoard : Form
    {
        Line line1;
        Line line2;


        public DrawingBoard()
        {
            InitializeComponent();
            Init_Lines_and_Drawing_Surface();
            DrawOnMyCanvas();
        }

        private void Init_Lines_and_Drawing_Surface()
        { // will initialize lines 
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height); //  initialize object required to work with pixels 
            Graphics graph = Graphics.FromImage(bmp); // initialize a DRAWING SURFACE!
            Pen pen = new Pen(Color.Purple); // initializing pen is also required 

            line1 = new Line(100, 100, 200, 10);
            line2 = new Line(200, 10, 300, 100);

        }

        public void DrawOnMyCanvas()
        {
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height); //  initialize object required to work with pixels 
            Graphics graph = Graphics.FromImage(bmp); // initialize a DRAWING SURFACE!
            Pen pen = new Pen(Color.Purple); // initializing pen is also required 

            graph.DrawRectangle(pen , 100, 100, 200, 200);

            graph.DrawLine(pen, line1.X1,line1.Y1, line1.X2 , line1.Y2);
            graph.DrawLine(pen, line2.X1, line2.Y1, line2.X2, line2.Y2);

            Canvas.Image = bmp; // PictureBox method 
        }

      /*  public void DrawOnMyCanvas2(Line line)
        {
            
            graph.DrawLine(pen, line1.X1, line1.Y1, line1.X2, line1.Y2);
            graph.DrawLine(pen, line2.X1, line2.Y1, line2.X2, line2.Y2);
        }*/


    }
}
