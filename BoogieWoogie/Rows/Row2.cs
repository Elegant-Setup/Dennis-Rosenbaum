namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row2
    {
        public Block AddRow(Block block)
        {
            block = block.AddBelow(Brushes.Red, 80, 357, 28);
            block = block.AddRight(Brushes.LightGray, 98);
            block = block.AddRight(Brushes.Gray, 267);
            block = block.AddRight(Brushes.Red, 97);

            new Block(Brushes.LightGray, block.Graphics, 750, 195, 81, 45);
            new Block(Brushes.White, block.Graphics, 790, 160, 50, 195 - 160);
            new Block(Brushes.Gray, block.Graphics, 385, 160, 11, 213 - 160);
            return block;
        }
    }
}
