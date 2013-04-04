namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row10
    {
        public Block AddRow(Block block)
        {
            block = block.AddRowLeftToRight(221, 850, 66,
                new[] { 320, 414, 515, 630, 722, 819, 897, 928 },
                new[] { Brushes.LightGray, Brushes.Yellow, Brushes.LightGray, Brushes.Gray, Brushes.Red, Brushes.Gray, Brushes.Invisible, Brushes.LightGray }
                );

            block = new Block(Brushes.Invisible, block.Graphics, 221, 850, 1, 66, false);
            
            Block inner = block.AddInner(Brushes.Yellow, offsetLeft: 341, offsetTop: 16, height: 28, width: 39);
            inner.AddInner(Brushes.Black, width: 29);

            block.AddInner(Brushes.Red, width: 31, offsetLeft: 676, offsetTop: 25, height: 24);

            return block;
        }
    }
}
