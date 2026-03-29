namespace LifeFly.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string FlightsCollectionName { get; set; }
        string FlightCollectionName { get; }
    }
}
