namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row3
    {
        public Block AddRow(Block block)
        {
            block.AddRowLeftToRight(326, 240, 80,
                new[] { 431, 528, 719, 822, 848, 925 },
                new[] { Brushes.Yellow, Brushes.Blue, Brushes.White, Brushes.Red, Brushes.Yellow, Brushes.White });

            new Block(Brushes.Black, block.Graphics, 822, 288, 26, 20);

            block.AddRowLeftToRight(431, 240, 25,
                new[] { 465, 480, 500, 526, 537, 561, 578, 587, 602, 622, 646, 679, 700, 719, 744, 754, 773, 786, 793, 812, 820, 844, 869 },
                new[] { Brushes.Red, Brushes.LightGray, Brushes.Yellow, Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.LightGray, Brushes.Red, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Yellow, Brushes.Red, Brushes.Yellow, Brushes.Blue, Brushes.Beige, Brushes.Black, Brushes.Beige, Brushes.Yellow, Brushes.Gray, Brushes.Red, Brushes.Blue, Brushes.Yellow });
        
            return block;
        }
    }
}
