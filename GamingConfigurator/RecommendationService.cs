using GamingConfigurator.Models;

namespace GamingConfigurator.Services
{
    public class RecommendationService
    {
        private List<DesktopBuild> _builds;

        public RecommendationService()
        {
            // Sample data
            _builds = new List<DesktopBuild>
            {
                // New Gaming builds
                new DesktopBuild
                {
                    Id = "1",
                    Name = "Budget Gamer",
                    CPU = "Intel i5-12400F",
                    GPU = "NVIDIA GTX 1660 Super",
                    RAM_GB = 16,
                    PriceEUR = 850,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "5",
                    Name = "Entry Gaming",
                    CPU = "AMD Ryzen 5 5600",
                    GPU = "AMD RX 7600",
                    RAM_GB = 16,
                    PriceEUR = 700,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "6",
                    Name = "Mid-Tier Gaming",
                    CPU = "Intel i5-14400F",
                    GPU = "NVIDIA RTX 4060",
                    RAM_GB = 16,
                    PriceEUR = 1000,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "7",
                    Name = "High-FPS Gaming",
                    CPU = "AMD Ryzen 5 7600",
                    GPU = "NVIDIA RTX 4070",
                    RAM_GB = 16,
                    PriceEUR = 1300,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "8",
                    Name = "Pro Gaming",
                    CPU = "Intel i7-14700F",
                    GPU = "AMD RX 7900 GRE",
                    RAM_GB = 32,
                    PriceEUR = 1600,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "9",
                    Name = "Elite Gaming",
                    CPU = "AMD Ryzen 7 9700X",
                    GPU = "NVIDIA RTX 4080",
                    RAM_GB = 32,
                    PriceEUR = 2000,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "10",
                    Name = "Gaming Ultra",
                    CPU = "Intel i9-14900K",
                    GPU = "NVIDIA RTX 5090",
                    RAM_GB = 32,
                    PriceEUR = 2500,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "11",
                    Name = "Competitive Edge",
                    CPU = "AMD Ryzen 5 9600X",
                    GPU = "AMD RX 7800 XT",
                    RAM_GB = 16,
                    PriceEUR = 1100,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "12",
                    Name = "Budget Pro",
                    CPU = "Intel i3-13100F",
                    GPU = "NVIDIA RTX 3050",
                    RAM_GB = 16,
                    PriceEUR = 600,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "13",
                    Name = "Gaming Streamer",
                    CPU = "AMD Ryzen 7 7700",
                    GPU = "NVIDIA RTX 4060 Ti",
                    RAM_GB = 32,
                    PriceEUR = 1400,
                    UseCase = "Gaming"
                },
                new DesktopBuild
                {
                    Id = "14",
                    Name = "Tournament Ready",
                    CPU = "Intel i5-14600KF",
                    GPU = "NVIDIA RTX 4070 Ti",
                    RAM_GB = 16,
                    PriceEUR = 1700,
                    UseCase = "Gaming"
                },

                // Streaming build
                new DesktopBuild
                {
                    Id = "2",
                    Name = "Streaming Beast",
                    CPU = "AMD Ryzen 7 5800X",
                    GPU = "NVIDIA RTX 4070",
                    RAM_GB = 32,
                    PriceEUR = 1600,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "15",
                    Name = "Budget Streamer",
                    CPU = "AMD Ryzen 5 5600X",
                    GPU = "NVIDIA RTX 3060",
                    RAM_GB = 16,
                    PriceEUR = 900,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "16",
                    Name = "Mid-Tier Streamer",
                    CPU = "Intel i7-12700F",
                    GPU = "AMD RX 7700 XT",
                    RAM_GB = 32,
                    PriceEUR = 1400,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "17",
                    Name = "Pro Streamer",
                    CPU = "AMD Ryzen 9 7900X",
                    GPU = "NVIDIA RTX 4080",
                    RAM_GB = 64,
                    PriceEUR = 2200,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "18",
                    Name = "Streaming Elite",
                    CPU = "Intel i9-13900KF",
                    GPU = "NVIDIA RTX 5090",
                    RAM_GB = 64,
                    PriceEUR = 3000,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "19",
                    Name = "Content Creator",
                    CPU = "AMD Ryzen 7 7700X",
                    GPU = "NVIDIA RTX 4070 Ti",
                    RAM_GB = 32,
                    PriceEUR = 1800,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "20",
                    Name = "Streaming Pro",
                    CPU = "Intel i7-14700K",
                    GPU = "AMD RX 7900 XTX",
                    RAM_GB = 32,
                    PriceEUR = 2000,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "21",
                    Name = "Entry Streamer",
                    CPU = "Intel i5-13400F",
                    GPU = "NVIDIA RTX 4060",
                    RAM_GB = 16,
                    PriceEUR = 1100,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "22",
                    Name = "Multi-Stream",
                    CPU = "AMD Ryzen 9 9900X",
                    GPU = "NVIDIA RTX 5080",
                    RAM_GB = 64,
                    PriceEUR = 2600,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "23",
                    Name = "Streaming Starter",
                    CPU = "AMD Ryzen 5 7600",
                    GPU = "AMD RX 7600",
                    RAM_GB = 16,
                    PriceEUR = 800,
                    UseCase = "Streaming"
                },
                new DesktopBuild
                {
                    Id = "24",
                    Name = "Broadcast Pro",
                    CPU = "Intel i9-14900KF",
                    GPU = "NVIDIA RTX 4090",
                    RAM_GB = 64,
                    PriceEUR = 2800,
                    UseCase = "Streaming"
                },

                // VR build
                new DesktopBuild
                {
                    Id = "3",
                    Name = "VR Ready Pro",
                    CPU = "Intel i7-13700K",
                    GPU = "NVIDIA RTX 4080",
                    RAM_GB = 32,
                    PriceEUR = 2200,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "25",
                    Name = "Budget VR",
                    CPU = "AMD Ryzen 5 5600X",
                    GPU = "NVIDIA RTX 3060 Ti",
                    RAM_GB = 16,
                    PriceEUR = 1000,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "26",
                    Name = "Mid-Tier VR",
                    CPU = "Intel i5-14600K",
                    GPU = "AMD RX 7800 XT",
                    RAM_GB = 32,
                    PriceEUR = 1500,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "27",
                    Name = "VR Enthusiast",
                    CPU = "AMD Ryzen 7 7700X",
                    GPU = "NVIDIA RTX 4070 Ti",
                    RAM_GB = 32,
                    PriceEUR = 1900,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "28",
                    Name = "VR Elite",
                    CPU = "Intel i9-14900K",
                    GPU = "NVIDIA RTX 5090",
                    RAM_GB = 64,
                    PriceEUR = 3200,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "29",
                    Name = "VR Pro",
                    CPU = "AMD Ryzen 9 7900X",
                    GPU = "NVIDIA RTX 4090",
                    RAM_GB = 32,
                    PriceEUR = 2500,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "30",
                    Name = "VR Starter",
                    CPU = "Intel i5-13400F",
                    GPU = "NVIDIA RTX 4060",
                    RAM_GB = 16,
                    PriceEUR = 1200,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "31",
                    Name = "VR Ultra",
                    CPU = "AMD Ryzen 9 9900X",
                    GPU = "AMD RX 7900 XTX",
                    RAM_GB = 64,
                    PriceEUR = 2700,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "32",
                    Name = "VR Gamer",
                    CPU = "Intel i7-14700KF",
                    GPU = "NVIDIA RTX 4080",
                    RAM_GB = 32,
                    PriceEUR = 2300,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "33",
                    Name = "Entry VR",
                    CPU = "AMD Ryzen 5 7600",
                    GPU = "AMD RX 7700 XT",
                    RAM_GB = 16,
                    PriceEUR = 1100,
                    UseCase = "VR"
                },
                new DesktopBuild
                {
                    Id = "34",
                    Name = "VR Master",
                    CPU = "Intel i9-13900KF",
                    GPU = "NVIDIA RTX 5080",
                    RAM_GB = 64,
                    PriceEUR = 2900,
                    UseCase = "VR"
                },
                // All round
                new DesktopBuild
                {
                    Id = "4",
                    Name = "Mid-Range Allrounder",
                    CPU = "AMD Ryzen 5 7600X",
                    GPU = "NVIDIA RTX 4060 Ti",
                    RAM_GB = 16,
                    PriceEUR = 1200,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "35",
                    Name = "Budget Allrounder",
                    CPU = "Intel i3-13100F",
                    GPU = "NVIDIA RTX 3050",
                    RAM_GB = 16,
                    PriceEUR = 650,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "36",
                    Name = "Balanced Allrounder",
                    CPU = "AMD Ryzen 5 5600X",
                    GPU = "AMD RX 7600",
                    RAM_GB = 16,
                    PriceEUR = 900,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "37",
                    Name = "High-End Allrounder",
                    CPU = "Intel i7-13700F",
                    GPU = "NVIDIA RTX 4070",
                    RAM_GB = 32,
                    PriceEUR = 1700,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "38",
                    Name = "Elite Allrounder",
                    CPU = "AMD Ryzen 9 7900X",
                    GPU = "NVIDIA RTX 4080",
                    RAM_GB = 32,
                    PriceEUR = 2300,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "39",
                    Name = "Allrounder Pro",
                    CPU = "Intel i9-14900KF",
                    GPU = "AMD RX 7900 XTX",
                    RAM_GB = 64,
                    PriceEUR = 2800,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "40",
                    Name = "Entry Allrounder",
                    CPU = "AMD Ryzen 3 5300G",
                    GPU = "NVIDIA GTX 1650",
                    RAM_GB = 16,
                    PriceEUR = 550,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "41",
                    Name = "Versatile Allrounder",
                    CPU = "Intel i5-14400F",
                    GPU = "NVIDIA RTX 4060",
                    RAM_GB = 16,
                    PriceEUR = 1000,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "42",
                    Name = "Premium Allrounder",
                    CPU = "AMD Ryzen 7 7700X",
                    GPU = "NVIDIA RTX 4070 Ti",
                    RAM_GB = 32,
                    PriceEUR = 1900,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "43",
                    Name = "Allrounder Ultra",
                    CPU = "Intel i9-13900K",
                    GPU = "NVIDIA RTX 5090",
                    RAM_GB = 64,
                    PriceEUR = 3100,
                    UseCase = "All-Round"
                },
                new DesktopBuild
                {
                    Id = "44",
                    Name = "Balanced Pro",
                    CPU = "AMD Ryzen 5 9600X",
                    GPU = "AMD RX 7800 XT",
                    RAM_GB = 16,
                    PriceEUR = 1300,
                    UseCase = "All-Round"
                }
            };
        }

        public List<DesktopBuild> GetAllBuilds() => _builds;

        public List<DesktopBuild> GetRecommendations(string useCase, int? maxPrice = null)
        {
            Console.WriteLine($"GetRecommendations: useCase={useCase}, maxPrice={maxPrice}");
            var result = _builds.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(useCase))
                result = result.Where(b => b.UseCase.ToLower().Contains(useCase.ToLower()));

            if (maxPrice.HasValue)
                result = result.Where(b => b.PriceEUR <= maxPrice.Value);

            result = result.OrderBy(b => b.PriceEUR);
            var builds = result.ToList();
            Console.WriteLine($"Returning {builds.Count} builds: {string.Join(", ", builds.Select(b => b.Name))}");
            return builds;
        }
    }
}