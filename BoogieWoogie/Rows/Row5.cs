namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;

    public class Row5
    {
        public Block AddRow(Block block)
        {
            block = AddColumn1(block);
            block = AddColumn2(block);
            block = AddColumn3(block);
            block = AddColumn4(block);
            block = AddColumn5(block);
            block = block.AddRight(Brushes.White, 717 - 531);
            block = AddColumn7(block);
            block = AddColumn8(block);
            block = AddColumn9(block);

            return block;
        }

        private static Block AddColumn9(Block block)
        {
            block = block.AddRight(Brushes.Gray, 205);

            block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.Yellow },
                new[] { 38, 42 },
                height: 37);
            block.AddInnerColumns(
                new[] { Brushes.Red, Brushes.Blue, Brushes.White, Brushes.Red },
                new[] { 15, 21, 20, 24 },
                height: 20,
                offsetTop: 82);

            Block inner = block.AddInner(Brushes.White, 61, 46, 80, 52);
            Block blueInner = inner.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.Invisible, Brushes.Yellow },
                new[] { 48, 13, 64 },
                height: 41,
                offsetTop: inner.Height);
            blueInner.AddInner(Brushes.Yellow, 21, 21, 12, 13);

            block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.White, Brushes.Blue, Brushes.Yellow, Brushes.White },
                new[] { 19, 13, 24, 85, 45 },
                height: 18,
                offsetTop: block.Height - 18);

            return block;
        }

        private static Block AddColumn8(Block block)
        {
            block = block.AddRight(Brushes.White, 77);
            block.AddInnerRows(
                new[] { Brushes.Red, Brushes.Blue, Brushes.Yellow, Brushes.Black, Brushes.Red, Brushes.Yellow, Brushes.Blue, Brushes.Black, Brushes.Yellow, Brushes.Red, Brushes.Invisible, Brushes.Red, Brushes.Black, Brushes.Yellow, Brushes.Red, Brushes.Blue, Brushes.Invisible, Brushes.Red, Brushes.Blue, Brushes.Yellow, Brushes.Blue },
                new[] { 17, 17, 25, 14, 13, 23, 5, 16, 18, 9, 25, 21, 17, 16, 14, 13, 18, 18, 18, 17, 17 },
                width: 26);
            return block;
        }

        private static Block AddColumn7(Block block)
        {
            block = block.AddRight(Brushes.LightGray, 105);
            Block inner = block.AddInner(Brushes.Yellow, 804 - 717, 53);
            inner = inner.AddBelow(Brushes.Gray, 485 - 399, width: block.Width);
            Block innerBlack = inner.AddInner(Brushes.Black, offsetLeft: 39, offsetTop: 32, height: 25, width: 28);
            innerBlack.AddInner(Brushes.Blue, 13, 14, 15, 11);

            Block bottom = inner.AddBelow(Brushes.White, 18);
            bottom.AddInnerColumns(
                new[] { Brushes.Red, Brushes.Beige, Brushes.White, Brushes.Black, Brushes.Blue, Brushes.Beige },
                new[] { 24, 9, 12, 12, 12, 11 });
            return block;
        }

        private static Block AddColumn5(Block block)
        {
            block = block.AddRight(Brushes.Gray, 111);
            Block inner = block.AddInnerColumns(
                new[] { Brushes.Red, Brushes.LightGray, Brushes.Blue, Brushes.Yellow },
                new[] { 32, 27, 30, 22 }, 
                height: 27);

            inner = inner.AddBelow(Brushes.Gray, 109);
            inner.AddInner(Brushes.Red, 514 - 432, 472 - 415, 12, 42);

            block.AddInnerColumns(
                new[] { Brushes.Blue, Brushes.White, Brushes.Red, Brushes.Yellow, Brushes.White, Brushes.Black },
                new[] { 26, 18, 21, 9, 8, 29 },
                height: 21, 
                offsetTop: 136);

            return block;
        }

        private static Block AddColumn4(Block block)
        {
            block = block.AddRight(Brushes.White, 96);
            Block inner = block.AddInner(Brushes.Red, 390 - 357, 444 - 416, 33, 70);
            inner.AddBelow(Brushes.Yellow, 15);
            return block;
        }

        private static Block AddColumn3(Block block)
        {
            block = block.AddRight(Brushes.Blue, 76);
            block.AddInner(Brushes.Yellow, 35, 39, 41);
            Block inner = block.AddInner(Brushes.Red, 36, 37, offsetTop: 37);
            inner = inner.AddBelow(Brushes.Gray, 58, width: 76);
            inner.AddInner(Brushes.White, 300 - 271, 466 - 444, 13, 21);
            inner = inner.AddBelow(Brushes.Red, 25, width: 32);
            inner = inner.AddRight(Brushes.Yellow, 17);
            inner.AddRight(Brushes.Blue, 27);
            return block;
        }

        private static Block AddColumn2(Block block)
        {
            block = block.AddRight(Brushes.White, 79);
            Block inner = block.AddInner(Brushes.Gray, 39, 92);
            inner.AddRowsRight(40, new[] { 358, 392, 438 }, new[] { Brushes.Beige, Brushes.Red, Brushes.Yellow });
            return block;
        }

        private static Block AddColumn1(Block block)
        {
            block = block.AddBelow(Brushes.LightGray, 157, 92, 77);
            Block inner = block.AddInner(Brushes.Gray, height: 75, offsetTop: 82);
            inner.AddInner(Brushes.Blue, 28, 28, 41, 23);
            return block;
        }
    }
}
