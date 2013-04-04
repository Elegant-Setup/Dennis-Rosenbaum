namespace BoogieWoogie.Rows
{
    using Brushes = global::BoogieWoogie.Brushes;
    public class Row9
    {
        public Block AddRow(Block block)
        {
            block = block.AddRowLeftToRight(221, 828, 22,
                new[] { 244, 262, 281, 287, 292, 326, 343, 353, 354, 363, 368, 384, 394, 410, 431, 445, 467, 474, 493, 498, 526, 545, 563, 582, 600, 615, 626, 640, 652, 661, 677, 685, 704, 716, 731, 736, 752, 767, 776, 786, 805, 832, 839, 855, 868, 895, 911, 928 },
                new[] { Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.Yellow, Brushes.LightGray, Brushes.Yellow, Brushes.Blue, Brushes.Beige, Brushes.Red, Brushes.Beige, Brushes.Blue, Brushes.Black, Brushes.White, Brushes.DarkYellow, Brushes.Black, Brushes.Yellow, Brushes.DarkYellow, Brushes.Yellow, Brushes.Black, Brushes.White, Brushes.Yellow, Brushes.Black, Brushes.DarkYellow, Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.Red, Brushes.Yellow, Brushes.Beige, Brushes.Red, Brushes.Black, Brushes.Red, Brushes.Yellow, Brushes.Beige, Brushes.Red, Brushes.Black, Brushes.Yellow, Brushes.Black, Brushes.Red, Brushes.Yellow, Brushes.Red, Brushes.Yellow, Brushes.White, Brushes.Red, Brushes.Blue, Brushes.Yellow, Brushes.Black, Brushes.Red }
                );

            block.AddRight(Brushes.Yellow, height: 43, width: 50);

            return block;
        }
    }
}
