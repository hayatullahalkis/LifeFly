namespace LifeFly.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; } // ConnectionString için eklenen özellik
        public string DatabaseName { get; set; } // Database adı için eklenen özellik 
        public string FlightCollectionName { get; set; } // Flight koleksiyonu için eklenen özellik
        public string BookingCollectionName { get; set; }  //   Booking koleksiyonu için eklenen özellik
    }
}