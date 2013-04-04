namespace BoogieWoogie
{
    using System;
    using System.Drawing;

    public class Block
    {
        internal Brush Brush { get; private set; }
        internal int Height { get; private set; }
        internal int Width { get; private set; }
        internal int OffsetLeft { get; private set; }
        internal int OffsetTop { get; private set; }
        internal Graphics Graphics { get; private set; }

        public Block(Brush brush, Graphics graphics, int offsetLeft, int offsetTop, int width, int height, bool add = true)
        {
            Graphics = graphics;
            this.Brush = brush;
            this.Width = width;
            this.Height = height;
            this.OffsetLeft = offsetLeft;
            this.OffsetTop = offsetTop;
            if(add && brush != Brushes.Invisible)
                Add();

            if(brush != Brushes.Invisible)
                System.Threading.Thread.Sleep(BoogieWoogieDrawing.DrawingSpeed);
        }

        public Block AddRight(Brush brush, int width, int? height = null, int? newOffsetHeight = null, int? newOffsetLeft = null)
        {
            if (!height.HasValue) height = Height;
            if (!newOffsetHeight.HasValue) newOffsetHeight = OffsetTop;
            if (!newOffsetLeft.HasValue) newOffsetLeft = OffsetLeft + Width;
            return new Block(
                    brush,
                    Graphics,
                    newOffsetLeft.Value,
                    newOffsetHeight.Value,
                    width,
                    height.Value
                );
        }


        public void Add()
        {
            Graphics.FillRectangle(Brush, new Rectangle(OffsetLeft, OffsetTop, Width, Height));
            if (!BoogieWoogieDrawing.DrawDiamondOnlyAtEnd)
                BoogieWoogieDrawing.CutOutDiamond(Graphics);
        }

        public Block AddBelow(Brush brush, int height, int? newStartOffsetLeft = null, int? width = null, int? newStartOffsetTop = null)
        {
            if (!newStartOffsetLeft.HasValue) newStartOffsetLeft = OffsetLeft;
            if (!newStartOffsetTop.HasValue) newStartOffsetTop = OffsetTop + Height;
            if (!width.HasValue) width = Width;
            return new Block(
                    brush,
                    Graphics,
                    newStartOffsetLeft.Value,
                    newStartOffsetTop.Value,
                    width.Value,
                    height
                );
        }

        public Block AddRowLeftToRight(int offsetLeft, int offsetTop, int height, 
            int[] xcoords, Brush[] brushes)
        {
            if(xcoords.Length != brushes.Length)
                throw new NotSupportedException("Amount xcoords must be the same as amount brushes");

            if (xcoords.Length < 1) return null;

            Block b = new Block(brushes[0], Graphics, offsetLeft, offsetTop, xcoords[0] - offsetLeft, height);
            for(int i = 1; i < xcoords.Length; i++)
            {
                b = b.AddRight(brushes[i], xcoords[i] - xcoords[i - 1]);
            }
            return b;
        }

        public Block AddRowsRight(int width, int[] ycoords, Brush[] brushes)
        {
            if (ycoords.Length != brushes.Length)
                throw new NotSupportedException("Amount ycoords must be the same as amount brushes");

            if (ycoords.Length < 1) return null;

            Block b = new Block(brushes[0], Graphics, OffsetLeft + Width, OffsetTop, width, ycoords[0] - OffsetTop);
            for (int i = 1; i < ycoords.Length; i++)
            {
                b = b.AddBelow(brushes[i], ycoords[i] - ycoords[i - 1]);
            }
            return b;
        }

        public Block AddInner(Brush brush, int? width = null, int? height = null, int? offsetLeft = null, int? offsetTop = null)
        {
            if(!width.HasValue) width = Width;
            if(!height.HasValue) height = Height;
            if (offsetLeft.HasValue) offsetLeft += OffsetLeft;
            else offsetLeft = OffsetLeft;
            if (offsetTop.HasValue) offsetTop += OffsetTop;
            else offsetTop = OffsetTop;
            return new Block(brush,
                Graphics,
                offsetLeft.Value,
                offsetTop.Value,
                width.Value,
                height.Value);
        }

        public Block AddInnerColumns(Brush[] brushes, int[] lengths, int? height = null, int? offsetLeft = null, int? offsetTop = null)
        {
            if (!height.HasValue) height = Height;
            if (!offsetLeft.HasValue) offsetLeft = 0;
            if (!offsetTop.HasValue) offsetTop = 0;
            if (lengths.Length != brushes.Length)
                throw new NotSupportedException("Amount lengths must be the same as amount brushes");

            int startOffsetLeft = offsetLeft.Value;
            int totalLength = 0;
            for (int i = 0; i < lengths.Length; i++)
            {
                this.AddInner(brushes[i], lengths[i], height, offsetLeft, offsetTop);
                offsetLeft += lengths[i];
                totalLength += lengths[i];
            }

            return new Block(Brushes.Blue, Graphics, OffsetLeft + startOffsetLeft, OffsetTop + offsetTop.Value, totalLength, height.Value, false);

        }

        public Block AddInnerRows(Brush[] brushes, int[] heights, int? width = null, int? offsetLeft = null, int? offsetTop = null)
        {
            if (!width.HasValue) width = Width;
            if (!offsetLeft.HasValue) offsetLeft = 0;
            if (!offsetTop.HasValue) offsetTop = 0;
            if (heights.Length != brushes.Length)
                throw new NotSupportedException("Amount heights must be the same as amount brushes");
            
            int startOffsetTop = offsetTop.Value;
            int totalHeight = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                this.AddInner(brushes[i], width, heights[i], offsetLeft, offsetTop);
                offsetTop += heights[i];
                totalHeight += heights[i];
            }

            return new Block(Brushes.Blue, Graphics, OffsetLeft + offsetLeft.Value, OffsetTop + startOffsetTop, width.Value, totalHeight, false);

        }
    }
}
