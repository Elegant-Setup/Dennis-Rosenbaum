namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row12
    {
        public Block AddRow(Block block)
        {
            block = block.AddBelow(Brushes.Black, 24, newStartOffsetLeft: 400, width: 313);

            block.AddInnerColumns(
                new[] { Brushes.Invisible, Brushes.Yellow, Brushes.Invisible, Brushes.Yellow, Brushes.White, Brushes.Invisible, Brushes.DarkRed, Brushes.Red, Brushes.Blue, Brushes.Red, Brushes.Yellow, Brushes.Red, Brushes.Yellow, Brushes.Red, Brushes.Invisible },
                new[] { 43, 41, 31, 8, 72, 10, 8, 12, 14, 4, 8, 1, 9, 35, 17 });

            block.AddInner(Brushes.Yellow, width: 9, height: block.Height - 4, offsetTop: 2, offsetLeft: 261);

            return block;
        }
    }
}
