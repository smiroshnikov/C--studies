using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    public partial class DrawingBoard : Form
    {
        public DrawingBoard()
        {
            InitializeComponent();
            DrawOnMyCanvas();
        }
        public void DrawOnMyCanvas()
        {
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height); //  initialize object required to work with pixels 
            Graphics graph = Graphics.FromImage(bmp); // initialize a DRAWING SURFACE!
            Pen pen = new Pen(Color.Purple); // initializing pen is also required 

            graph.DrawRectangle(pen , 100, 100, 200, 200);
            
            graph.DrawLine(pen, 100, 100, 200, 10);
            graph.DrawLine(pen, 200, 10, 300, 100);
            Canvas.Image = bmp; // PictureBox method 

            


        }




    }
}
