using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomeControls
{
    public partial class TestControl : Control
    {
        
        
        public TestControl()
        {
            InitializeComponent();
            this.Width = 100;
            this.Height = 100;
        }

        private int _Values;


        [Category("Custome Control")]
        public int value { get { return _Values; } set { _Values = value;this.Refresh(); } }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Point[] points = new Point[]
                {
                    new Point{X= 0,Y = 0 },
                    new Point{ X = this.Width,Y = 0},
                    new Point{ X = this.Width,Y = this.Height},
                    new Point{ X= 0, Y =this.Height}
                }; 

            pe.Graphics.FillPolygon(Brushes.Red, points);
            
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }


    }
}
