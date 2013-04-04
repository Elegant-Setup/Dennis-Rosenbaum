namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;

    public class Row7
    {
        public Block AddRow(Block block)
        {
            block = block.AddBelow(Brushes.Red, height: 33, width: 38, newStartOffsetLeft: 131, newStartOffsetTop: 681);

            block = block.AddInnerColumns(
                new[] { Brushes.Yellow, Brushes.LightGray, Brushes.Yellow, Brushes.Red, Brushes.White, Brushes.Beige, Brushes.Yellow, Brushes.Blue, Brushes.Red, Brushes.White, Brushes.Beige, Brushes.Red, Brushes.Yellow, Brushes.Blue, Brushes.Red, Brushes.Blue, Brushes.Yellow, Brushes.Blue, Brushes.Red, Brushes.Yellow, Brushes.Red, Brushes.Beige, Brushes.Red, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Yellow, Brushes.Red, Brushes.White, Brushes.Yellow, Brushes.Red, Brushes.Blue, Brushes.Beige, Brushes.LightGray, Brushes.Yellow, Brushes.White, Brushes.Red, Brushes.White, Brushes.Beige, Brushes.Red, Brushes.White, Brushes.Beige, Brushes.Black, Brushes.Beige, Brushes.Red, Brushes.White, Brushes.Red, Brushes.Blue },
                new[] { 19, 8, 9, 23, 11, 9, 9, 15, 15, 10, 9, 23, 51, 18, 13, 23, 32, 13, 14, 19, 22, 17, 9, 19, 24, 22, 16, 20, 17, 18, 18, 18, 8, 19, 16, 20, 9, 18, 17, 10, 29, 21, 3, 19, 10, 17, 17, 31, 17, 27, 22, 23 },
                height: 18,
                offsetLeft: block.Width,
                offsetTop: 15
                );
            return block;
        }
    }
}
