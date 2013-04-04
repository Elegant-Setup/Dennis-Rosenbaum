namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row4
    {
        public Block AddRow(Block block)
        {
            block = block.AddRowLeftToRight(326, 320, 26,
            new[] { 356, 384, 404, 430, 476, 509, 523, 540, 549, 571, 580, 600, 612, 627, 630, 647, 692, 707, 719, 730, 745, 755, 763, 777, 798, 815, 822, 848, 861, 867, 895, 937, 951 },
            new[] { Brushes.Gray, Brushes.Red, Brushes.Gray, Brushes.Blue, Brushes.Yellow, Brushes.Red, Brushes.Beige, Brushes.Red, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Blue, Brushes.Beige, Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Blue, Brushes.Beige, Brushes.Black, Brushes.Beige, Brushes.Blue, Brushes.Black, Brushes.LightGray, Brushes.Yellow, Brushes.LightGray, Brushes.Black, Brushes.Beige, Brushes.Yellow, Brushes.Red, Brushes.Yellow, Brushes.Blue });

            block = new Block(Brushes.Yellow, block.Graphics, 248, 315, 286 - 248, 346 - 315);
            block = new Block(Brushes.LightGray, block.Graphics, 286, 265, 40, 50);
            block = block.AddBelow(Brushes.Blue, 31);
            return block;
        }
    }
}
