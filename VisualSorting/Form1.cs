using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VisualSorting {
    public partial class Form1 : Form {
        public int RektTopLeft = 10;
        public int RektWidth = 1280;
        public int RektHeight = 720;
        private int _pillarsDrawn = 0;
        private int _pillarsToDraw;
        private bool DrawBackground;
        private int split = 3;

        //////////////////////////////////
        // TODO Calculate size of pillars
        //
        private int HeightDifference = 5;
        private int WidthDifference = 5;
        //
        // TODO Calculate size of pillars
        //////////////////////////////////
        
        private List<Pillar> pillars = new List<Pillar>();

        public Form1() {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
        }

        public void DrawIt() {
            if(!DrawBackground) {
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
                DrawBackground = false;
                _pillarsToDraw = Convert.ToInt32( numOfPillars.Text );
                _pillarsDrawn = 0;
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

        private void timer1_Tick( object sender, EventArgs e ) {
            DrawIt();
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void btnPillarAdd_Click( object sender, EventArgs e ) {
            Pillar pillar = new Pillar( pillars.Count, 10, 500 - _pillarsDrawn );
            pillars.Add( pillar );
            for(int i = 0; i < pillars.Count; i++) {
                var graphics = CreateGraphics();
                var rektAngle = new Rectangle( 
                    RektTopLeft + (split * _pillarsDrawn), // x
                    RektTopLeft + HeightDifference, // y
                    WidthDifference, // Width
                    500 - HeightDifference ); // Height
                graphics.FillRectangle( Brushes.Aqua, rektAngle );
                _pillarsDrawn++;
            }
        }
    }
}
