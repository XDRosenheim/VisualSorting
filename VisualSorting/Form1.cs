using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualSorting {
    public partial class Form1 : Form {
        public int RektTopLeft = 10;
        public int RektWidth = 1280;
        public int RektHeight = 720;
        private int _pillarsDrawn = 0;
        private int _pillarsToDraw = 0;
        private bool DrawBackground = true;
        private int split = 1;

        public Form1() {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
        }

        public void DrawIt() {
            if(DrawBackground) {
                var graphics = CreateGraphics();
                var rektAngle = new Rectangle( RektTopLeft, RektTopLeft, RektWidth, RektHeight );
                graphics.FillRectangle( Brushes.Black, rektAngle );
                DrawBackground = false;
            } else {
                var rektAngle = new Rectangle(
                    RektTopLeft + 2 + _pillarsDrawn * 10 + _pillarsDrawn * split,
                    RektTopLeft + RektHeight - 500 + _pillarsDrawn,
                    10,
                    500 - _pillarsDrawn
                );
                var graphics = CreateGraphics();
                graphics.FillRectangle( Brushes.Crimson, rektAngle );
                _pillarsDrawn++;
            }
        }

        private void btnStart_Click( object sender, EventArgs e ) {
            // TODO start
        }

        private void btnReset_Click( object sender, EventArgs e ) {
            try {
                _pillarsToDraw = Convert.ToInt32( numOfPillars.Text );
                DrawIt();
            } catch(Exception exception) {
                // Something happened...
            }
        }

        private void btnAddPillar_Click( object sender, EventArgs e ) {
            var rektAngle2 = new Rectangle(
                RektTopLeft + 2 + _pillarsDrawn * 10 + _pillarsDrawn * split,
                RektTopLeft + RektHeight - 500 + _pillarsDrawn,
                10,
                500 - _pillarsDrawn
            );
            var graphics = CreateGraphics();
            graphics.FillRectangle( Brushes.Crimson, rektAngle2 );
            _pillarsDrawn++;
        }
    }
}
