namespace BoogieWoogie.Rows
{
    using System.Drawing;
    using Brushes = global::BoogieWoogie.Brushes;

    public class Row6
    {
        public Block AddRow(Block block)
        {
            this.AddColumn1(block);

            block = AddColumn2(block);
            block = AddColumn3(block);
            block = AddColumn4(block);
            block = AddColumn5(block);
            block = AddColumn6(block);
            block = AddColumn7(block);

            return block;
        }

        private Block AddColumn3(Block block)
        {
            block = AddColumn3Column1(block);
            
            block.AddInnerColumns(
                new Brush[] { Brushes.Yellow, Brushes.Beige, Brushes.Red, Brushes.Yellow, Brushes.Gray, Brushes.Yellow, Brushes.Black, Brushes.Blue, Brushes.Yellow, Brushes.Black, Brushes.Blue, Brushes.Yellow, Brushes.Black, Brushes.Blue, Brushes.White, Brushes.Yellow, Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Red, Brushes.Black, Brushes.Beige, Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.Red, Brushes.Yellow, Brushes.Red, Brushes.Yellow, Brushes.White, Brushes.Black, Brushes.Yellow, Brushes.White, Brushes.Black, Brushes.Red, Brushes.Yellow, Brushes.Gray },
                new int[] { 19, 20, 28, 23, 15, 23, 16, 22, 35, 7, 16, 14, 16, 5, 9, 6, 22, 14, 22, 17, 10, 21, 17, 15, 22, 20, 21, 9, 41, 21, 11, 3, 18, 14, 10, 13, 14, 2, 27 },
                height: 25);

            Block inner = this.AddColumn3Column2(block);
            inner = this.AddColumn3Column3(inner);

            Block inner2 =
                inner.AddInnerRows(
                    new Brush[] { Brushes.Red, Brushes.Yellow, Brushes.White, Brushes.Red, Brushes.Blue, Brushes.Yellow, Brushes.Invisible, Brushes.Yellow, Brushes.Blue, Brushes.Red, Brushes.Beige },
                    new int[] { 22, 15, 6, 10, 13, 15, 18, 17, 16, 18, 19 },
                    width: 30,
                    offsetLeft: 87 + inner.Width);
            inner.AddInner(Brushes.LightGray, 15, height: 15, offsetLeft: 87 + inner.Width + 15, offsetTop: 66);

            inner.AddInnerColumns(
                new Brush[] { Brushes.Beige, Brushes.Red, Brushes.Yellow, Brushes.Blue, Brushes.LightGray, Brushes.Blue, Brushes.Red, Brushes.LightGray, Brushes.Blue, Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.Blue, Brushes.LightGray, Brushes.Black, Brushes.Beige, Brushes.Red, Brushes.Black, Brushes.Beige, Brushes.Red, Brushes.Beige, Brushes.White, Brushes.Red, Brushes.Blue, Brushes.White, Brushes.Black, Brushes.Beige, Brushes.Red, Brushes.Yellow, Brushes.White, Brushes.Red, Brushes.Beige, Brushes.Blue },
                new int[] { 17, 22, 10, 19, 18, 15, 16, 16, 14, 15, 21, 12, 5, 11, 18, 20, 9, 13, 25, 22, 10, 8, 16, 4, 7, 19, 16, 16, 6, 15, 16, 21, 22 },
                height: 18,
                offsetLeft: 72,
                offsetTop: 81);

            AddColumn3RowRightBottom(inner2);
            AddColumn3RowRightTop(inner2);

            return block;
        }

        private static void AddColumn3RowRightTop(Block block)
        {
            Block inner = block.AddInner(Brushes.Yellow, width: 93, height: 81, offsetLeft: block.Width + 604 - 523);
            inner = inner.AddInner(Brushes.Gray, width: 62, offsetLeft: 135);
            inner.AddInnerColumns( new Brush[] { Brushes.Blue, Brushes.Yellow, Brushes.Red }, new int[] { 19, 18, 25 }, offsetTop: 60, height: 21);
            inner.AddInner(Brushes.White, offsetLeft: 19, offsetTop: 24, width: 29, height: 23);
            inner.AddInner(Brushes.Black, height: 23, offsetTop: 39, offsetLeft: inner.Width, width: 22);
        }

        private static void AddColumn3RowRightBottom(Block block)
        {
            Block inner = block.AddInner( Brushes.Red, width: 98, height: 81, offsetLeft: block.Width + 602 - 523, offsetTop: 99);
            inner.AddRight(Brushes.Blue, 61);
        }

        private static Block AddColumn3Column1(Block block)
        {
            block = block.AddRight(Brushes.White, 822 - 241);
            block.AddInner(Brushes.Yellow, 38, 44, offsetTop: 90);
            return block;
        }

        private static Block AddColumn2(Block block)
        {
            block = block.AddBelow(Brushes.Blue, 194, 169, 72);
            block.AddInner(Brushes.Gray, height: 633 - 571, offsetTop: 571 - 503);
            block.AddInner(Brushes.Red, 18, 20, 23, 152);
            return block;
        }

        private Block AddColumn7(Block block)
        {
            block = block.AddRight(Brushes.Gray, 115);
            block.AddInner(Brushes.Black, width: 27, height: 31, offsetTop: 21);
            block.AddInner(Brushes.Yellow, width: 21, height: 27, offsetTop: 106);
            Block inner = block.AddInner(Brushes.Yellow, width: 26, height: 25, offsetLeft: 21, offsetTop: 96);
            inner.AddInner(Brushes.Beige, width: 18, offsetLeft: 4, height: 33);
            block.AddInner(Brushes.Yellow, width: 56, height: 37, offsetTop: 174);

            return block;
        }

        private Block AddColumn6(Block block)
        {
            block = block.AddRight(Brushes.Invisible, 45);

            Block inner = block.AddInner(Brushes.Yellow, height: 44, offsetTop: 52);
            inner.AddInner(Brushes.Black, width: 21, height: 22);
            inner.AddInner(Brushes.Red, width: 27, height: 22, offsetLeft: 18, offsetTop: 22);

            inner = block.AddInner(Brushes.Yellow, height: 20, offsetTop: 133);
            inner.AddInner(Brushes.Blue, width: 18);

            inner = block.AddInner(Brushes.Red, height: 18, offsetTop: 175);
            inner.AddInner(Brushes.Blue, width: 22);

            return block;
        }

        private Block AddColumn5(Block block)
        {
            block = block.AddRight(Brushes.Yellow, 85);

            block.AddInnerRows( 
                new Brush[] { Brushes.Gray, Brushes.White, Brushes.Invisible, Brushes.Gray, Brushes.Red },
                new int[] { 26, 49, 27, 22, 14 },
                22, offsetTop: 65 );
            block.AddInnerRows(
                new Brush[] { Brushes.Red, Brushes.Gray },
                new int[] { 46, 46 },
                63, offsetTop: 65, offsetLeft: 22 );
            block.AddInner(Brushes.White, 25, 36, 22, 157);

            return block;
        }

        private Block AddColumn4(Block block)
        {
            block = block.AddRight(Brushes.Red, 56, newOffsetLeft: 899);
            block.AddInnerRows(
                new Brush[] { Brushes.Invisible, Brushes.Blue, Brushes.Invisible, Brushes.Blue, Brushes.Yellow, Brushes.White },
                new int[] { 55, 36, 47, 18, 23, 15 });

            block.AddInner(Brushes.Black, 42, 8, offsetTop: 91);
            block.AddInner(Brushes.White, 12, 18, 22, 138);
            block.AddInner(Brushes.Red, 22, 23, 15, 156);
            block.AddInner(Brushes.Black, 25, 15, offsetTop: 179);

            return block;
        }

        private void AddColumn1(Block block)
        {
            Block inner = block.AddBelow(Brushes.Beige, 59, 87, 38, 545);
            inner.AddInner(Brushes.Black, width: 29, height: 27, offsetLeft: 9, offsetTop: 32);

            inner = block.AddBelow(Brushes.Beige, 43, 131, 38, 589);
            inner.AddInner(Brushes.Red, height: 33, offsetTop: 10);
            inner.AddBelow(Brushes.Gray, 49);

            inner = block.AddBelow(Brushes.Beige, 46, 88, 33, 640);
            inner.AddInner(Brushes.Black, 26, 25, 7, 21);

            inner = block.AddBelow(Brushes.Yellow, 9, 91, 40, 707);
            inner.AddBelow(Brushes.Gray, 16);
        }

        private Block AddColumn3Column3(Block block)
        {
            block = block.AddRight(Brushes.Red, width: 72);
            block.AddInnerRows(
                new Brush[] { Brushes.Yellow, Brushes.Blue, Brushes.Yellow },
                new int[] { 43, 31, 19 },
                width: 38,
                offsetLeft: 72 - 38,
                offsetTop: 555 - 528);

            block.AddInnerRows(
                new Brush[] { Brushes.White, Brushes.Gray, Brushes.White },
                new int[] { 50, 30, 40 },
                width: 34);

            block.AddInner(Brushes.Black, width: 22, height: 17, offsetTop: 103);
            return block;
        }

        private Block AddColumn3Column2(Block block)
        {
            Block inner = block.AddInner(Brushes.Blue, 54, 169, 38, 25);
            Block inner2 = inner.AddInner(Brushes.Black, height: 17);
            inner2.AddInner(Brushes.Yellow, width: 14, offsetLeft: 20);
            inner2 = inner2.AddBelow(Brushes.Gray, 31);
            inner2 = inner2.AddBelow(Brushes.Red, 4);
            inner2 = inner2.AddBelow(Brushes.Beige, 9);
            inner2 = inner2.AddBelow(Brushes.Red, 17);
            inner2 = inner2.AddBelow(Brushes.Blue, 18);
            inner2.AddInner(Brushes.Yellow, width: 18, offsetLeft: 22);
            inner2 = inner2.AddBelow(Brushes.Gray, 30);

            return inner;
        }
    }
}
