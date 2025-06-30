namespace GamingConfigurator.Models
{
    public class DesktopBuild
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string CPU { get; set; }
        public required string GPU { get; set; }
        public required int RAM_GB { get; set; }
        public required int PriceEUR { get; set; }
        public required string UseCase { get; set; } 
    }
}