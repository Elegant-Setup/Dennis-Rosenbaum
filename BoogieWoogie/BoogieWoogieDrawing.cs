using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoogieWoogie
{
    using global::BoogieWoogie.Rows;

    public partial class BoogieWoogieDrawing : UserControl
    {
        private bool isDrawn = false;

        public static int DrawingSpeed = 2;
        public static bool DrawDiamondOnlyAtEnd = false;

        public BoogieWoogieDrawing()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!isDrawn)
            {
                Graphics g = this.CreateGraphics();
                Block block = new Block(Brushes.Invisible, g, 0, 0, 0, 0, false);
                block = new Row1().AddRow(block);
                block = new Row2().AddRow(block);
                block = new Row3().AddRow(block);
                block = new Row4().AddRow(block);
                block = new Row5().AddRow(block);
                block = new Row6().AddRow(block);
                block = new Row7().AddRow(block);
                block = new Row8().AddRow(block);
                block = new Row9().AddRow(block);
                block = new Row10().AddRow(block);
                block = new Row11().AddRow(block);
                block = new Row12().AddRow(block);
                block = new Row13().AddRow(block);
                block = new Row14().AddRow(block);

                if (DrawDiamondOnlyAtEnd) CutOutDiamond(g);

                isDrawn = true;
            }
            base.OnPaint(e);
        }

        public static void CutOutDiamond(Graphics g)
        {
            Color c = Color.FromArgb(255, 0, 0, 0);
            g.FillPolygon(new SolidBrush(c), DiamondPoints);
        }

        private static Point[] _diamondPoints;
        private static Point[] DiamondPoints
        {
            get
            {
                if(_diamondPoints == null)
                {
                    _diamondPoints = new List<Point>
                    {
                        new Point(603, 0),
                        new Point(0, 595),
                        new Point(597, 1200),
                        new Point(1200, 603),
                        new Point(603, 0),
                        new Point(1200, 0),
                        new Point(1200, 1200),
                        new Point(0, 1200),
                        new Point(0, 0),
                        new Point(603, 0)
                    }.ToArray();
                }
                return _diamondPoints;
            }
        }

    }
}
