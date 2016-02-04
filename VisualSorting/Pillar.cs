using System.Drawing;

namespace VisualSorting {
    public class Pillar {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color;

        public Pillar( int id, int width, int height ) {
            Id = id;
            Width = width;
            Height = height;
            Color = Color.White;
        }

        public Pillar( int id, int width, int height, Color color ) {
            Id = id;
            Width = width;
            Height = height;
            Color = color;
        }

        public void Draw( int id, int bottom ) {
            var graphics = Form1.ActiveForm.CreateGraphics();
            var rektAngle = new Rectangle( bottom, Width, Width, -Height );
            graphics.FillRectangle( Brushes.Black, rektAngle );
        }
    }
}
