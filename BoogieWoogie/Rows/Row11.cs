namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row11
    {
        public Block AddRow(Block block)
        {
            int offsetTop = 916;
            block = new Block(Brushes.Yellow, block.Graphics, 221, offsetTop, 676, 98, true);

            AddColumn1(block);
            AddColumn2(block);

            return block;
        }

        private static void AddColumn2(Block block)
        {
            block.AddInner(Brushes.Gray, width: 75, height: 69, offsetTop: 29, offsetLeft: 315);

            block.AddInnerRows(
                new[] { Brushes.Gray, Brushes.Blue, Brushes.Yellow, Brushes.Blue, Brushes.Red },
                new[] { 36, 37, 38, 20, 26 },
                width: 51,
                offsetLeft: 492,
                offsetTop: 29);

            block.AddInnerRows(
                new[] { Brushes.White, Brushes.Red },
                new[] { 54, 60 },
                width: 59,
                offsetLeft: 543,
                offsetTop: 29);

            block.AddInner(Brushes.Red, width: 50, height: 50, offsetLeft: 602, offsetTop: 29);

        }

        private static void AddColumn1(Block block)
        {
            Block inner =
                block.AddInnerColumns(
                    new[] { Brushes.Black, Brushes.LightGray, Brushes.Red, Brushes.Black, Brushes.LightGray },
                    new[] { 128, 27, 20, 24, 18 },
                    height: 29);

            inner.AddBelow(Brushes.Gray, height: 36);

            inner = block.AddInner(Brushes.LightGray, offsetLeft: 223, width: 35, height: 33, offsetTop: 65);
            inner.AddRight(Brushes.Red, width: 52);

            inner = block.AddInner(Brushes.Blue, width: 76, height: 65, offsetLeft: 217);
            inner.AddInner(Brushes.Yellow, width: 23, height: 19, offsetLeft: 25, offsetTop: 16);

            inner.AddInnerColumns(
                new[]
                    {
                        Brushes.LightGray, Brushes.DarkYellow, Brushes.Black, Brushes.Red, Brushes.Invisible, Brushes.Black,
                        Brushes.Red, Brushes.White, Brushes.Black, Brushes.Yellow, Brushes.Blue, Brushes.Black, Brushes.Red,
                        Brushes.Black, Brushes.Yellow, Brushes.Gray, Brushes.Blue
                    },
                new[] { 25, 4, 20, 13, 17, 28, 8, 56, 31, 17, 4, 22, 19, 27, 33, 8, 50 },
                height: 29,
                offsetLeft: inner.Width);
        }
    }
}
