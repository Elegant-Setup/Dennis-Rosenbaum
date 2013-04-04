namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row13
    {
        public Block AddRow(Block block)
        {
            block = block.AddBelow(Brushes.Gray, height: 64, newStartOffsetLeft: 400, width: 313);

            block.AddInner(Brushes.Yellow, width: 220);
            block.AddInnerColumns(
                new[] { Brushes.LightGray, Brushes.White },
                new[] { 34, 34 },
                height: 33,
                offsetLeft: 43);
            block.AddInner(Brushes.Black, offsetLeft: 84, offsetTop: 33, width: 29, height: 31);

            return block;
        }
    }
}
