namespace LifeFly.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string FlightsCollectionName { get; set; }

        public string FlightCollectionName => throw new NotImplementedException();
    }
}
