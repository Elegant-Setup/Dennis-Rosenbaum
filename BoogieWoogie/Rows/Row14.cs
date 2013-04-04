namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row14
    {
        public Block AddRow(Block block)
        {
            block = block.AddBelow(Brushes.Yellow, height: 98);

            Block inner = block.AddInner(Brushes.White, width: 154, offsetLeft: 113);
            inner.AddInner(Brushes.LightGray, width: 111, offsetLeft: 43, height: 66);
            inner.AddInner(Brushes.Gray, width: 43, offsetTop: 44, height: 54);

            return block;
        }
    }
}
