namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row1
    {
        public Block AddRow(Block block)
        {
            block = new Block(Brushes.Gray, block.Graphics, 440, 0, 43, 160);
            block = block.AddRight(Brushes.LightGray, 267);
            block = block.AddRight(Brushes.Yellow, 15);
            return block;
        }
    }
}
