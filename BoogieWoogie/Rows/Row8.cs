namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;

    public class Row8
    {
        public Block AddRow(Block block)
        {
            block = AddColumn1(block);
            block = AddColumn2(block);
            block = AddColumn4(block);
            block = AddColumn5(block);
            block = AddColumn6(block);

            return block;
        }

        private Block AddColumn6(Block block)
        {
            block = block.AddRight(Brushes.Invisible, width: 131);

            block.AddInnerColumns(
                new[] { Brushes.Invisible, Brushes.Gray, Brushes.LightGray },
                new[] { 44, 46, 41 },
                height: 42
                );
            block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.LightGray },
                new[] { 44, 46 },
                height: 41,
                offsetTop: 42
                );
            block.AddInner(Brushes.LightGray, width: 44, height: 31, offsetTop: 83);

            return block;
        }

        private Block AddColumn5(Block block)
        {
            block = block.AddRight(Brushes.Red, width: 92);

            block.AddInner(Brushes.Yellow, height: 42);
            block.AddInner(Brushes.Yellow, height: 21, width: 22, offsetLeft: 31, offsetTop: 60);

            block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.White, Brushes.Blue },
                new[] { 23, 44, 25 },
                height: 15,
                offsetTop: 99
                );

            return block;
        }

        private Block AddColumn4(Block block)
        {
            block = block.AddRight(Brushes.Invisible, width: 161, newOffsetLeft: 716);

            int totalHeight = 0;
            Block inner = block.AddInnerColumns(
                new[] { Brushes.Gray, Brushes.Invisible, Brushes.Red, Brushes.Invisible, Brushes.Black, Brushes.Blue, Brushes.Invisible, Brushes.Black, Brushes.Blue },
                new[] { 20, 42, 19, 16, 9, 18, 16, 9, 12 },
                height: 18
                );
            totalHeight = inner.Height;
            inner = block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.Invisible, Brushes.Blue, Brushes.Invisible, Brushes.Red, Brushes.Invisible },
                new[] { 62, 19, 21, 22, 19, 18 },
                height: 17,
                offsetTop: totalHeight
                );
            totalHeight += inner.Height;

            inner = block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.Red, Brushes.Invisible, Brushes.Black, Brushes.Red, Brushes.Black, Brushes.Invisible, Brushes.Blue },
                new[] { 62, 19, 13, 12, 11, 16, 10, 18 },
                height: 15,
                offsetTop: totalHeight
                );
            totalHeight += inner.Height;

            inner = block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.Invisible, Brushes.Blue, Brushes.Invisible, Brushes.Red, Brushes.Invisible },
                new[] { 62, 19, 21, 22, 19, 18 },
                height: 17,
                offsetTop: totalHeight
                );

            totalHeight += inner.Height;

            inner = block.AddInnerColumns(
                new[] { Brushes.Red, Brushes.Gray, Brushes.Yellow, Brushes.Red, Brushes.Blue, Brushes.Invisible, Brushes.Red, Brushes.Yellow, Brushes.Blue },
                new[] { 20, 17, 7, 18, 19, 21, 22, 19, 18 },
                height: 17,
                offsetTop: totalHeight
                );

            inner = inner.AddBelow(Brushes.Yellow, height: 13, width: 20);
            inner.AddBelow(Brushes.Blue, 17);

            return block;
        }

        private Block AddColumn2(Block block)
        {
            block = block.AddRight(Brushes.Invisible, width: 204);

            block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.Invisible, Brushes.Yellow, Brushes.Red, Brushes.Invisible, Brushes.Red, Brushes.Yellow },
                new[] { 24, 60, 26, 22, 34, 28, 10 },
                height: 19);
            block.AddInnerColumns(
                new[] { Brushes.Gray, Brushes.Blue },
                new[] { 84, 120 },
                height: 56,
                offsetTop: 19);
            block.AddInnerColumns(
                new[] { Brushes.LightGray, Brushes.Red },
                new[] { 84, 120 },
                height: 39,
                offsetTop: 75);

            block.AddInner(Brushes.Red, width: 30, height: 25, offsetTop: 33, offsetLeft: 31);
            block.AddInner(Brushes.Yellow, width: 25, height: 22, offsetTop: 33, offsetLeft: 131);

            return block;
        }

        private Block AddColumn1(Block block)
        {
            block = block.AddBelow(Brushes.White, height: 114, newStartOffsetLeft: 131, width: 195);

            Block inner = block.AddInner(Brushes.Yellow, offsetLeft: 16, width: 17, height: 45, offsetTop: 19);
            block.AddInner(Brushes.Yellow, width: 15, offsetLeft: 33, offsetTop: 33, height: 31);
            block.AddInnerColumns(
                new[] { Brushes.Yellow, Brushes.DarkYellow },
                new[] { 73, 51 },
                height: 64,
                offsetLeft: 48);

            inner = block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.Invisible, Brushes.Red },
                new[] { 73, 25, 49 },
                offsetTop: 64,
                offsetLeft: 48,
                height: 50);
            inner.AddInner(Brushes.Yellow, offsetLeft: 30, offsetTop: 12, height: 21, width: 23);
            inner.AddInner(Brushes.Gray, offsetLeft: 73, width: 25, height: 20);

            return block;
        }
    }
}
