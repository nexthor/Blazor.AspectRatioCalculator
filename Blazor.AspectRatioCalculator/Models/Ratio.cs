namespace Blazor.AspectRatioCalculator.Models
{
    public class Ratio
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Description { get; set; }
        public bool Selected { get; set; }
    }
}
