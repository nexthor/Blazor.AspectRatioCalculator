using Blazor.AspectRatioCalculator.Models;

namespace Blazor.AspectRatioCalculator.Utilities
{
    public class CommonUtility
    {
        public static ICollection<Ratio> CommonRatios = new List<Ratio>
        {
            new Ratio { Id = 1, Width = 7680, Height = 4320, Description = "8K UHDTV" },
            new Ratio { Id = 2, Width = 5120, Height = 2880, Description = "5K, iMac with retina screen" },
            new Ratio { Id = 3, Width = 3840, Height = 2160, Description = "4K UHDTV" },
            new Ratio { Id = 4, Width = 2048, Height = 1536, Description = "iPad with retina screen" },
            new Ratio { Id = 5, Width = 1920, Height = 1200, Description = "WUXGA" },
            new Ratio { Id = 6, Width = 1920, Height = 1080, Description = "HD TV, iPhone 6 plus", Selected = true },
            new Ratio { Id = 7, Width = 1334, Height = 750, Description = "iPhone 6" },
            new Ratio { Id = 8, Width = 1200, Height = 630, Description = "Facebook" },
            new Ratio { Id = 9, Width = 1136, Height = 640, Description = "iPhone 5 screen" },
            new Ratio { Id = 10, Width = 1024, Height = 768, Description = "iPad" },
            new Ratio { Id = 11, Width = 1024, Height = 512, Description = "Twitter" },
            new Ratio { Id = 12, Width = 960, Height = 640, Description = "iPhone 4 screen" },
            new Ratio { Id = 13, Width = 800, Height = 600 },
            new Ratio { Id = 14, Width = 728, Height = 90, Description = "Common web banner ad size" },
            new Ratio { Id = 15, Width = 720, Height = 576, Description = "PAL" },
            new Ratio { Id = 16, Width = 640, Height = 480, Description = "VGA" },
            new Ratio { Id = 17, Width = 576, Height = 486, Description = "NTSC" },
            new Ratio { Id = 18, Width = 320, Height = 480, Description = "HVGA" },
        };
    }
}
