using AutoMapper;
using LifeFly.Dtos.FlightDtos;
using LifeFly.Dtos.PassengerDtos;
using LifeFly.Entities;
using LifeFly.Settings;
using MongoDB.Driver;

namespace LifeFly.Services.FlightSevices
{
    public class FlightService : IFlightService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection <Flight>  _flightCollection;
        private readonly IMongoCollection<Booking> _bookingCollection;
        public FlightService(IMapper mapper,IDatabaseSettings _databaseSettings)
        { 
            var client= new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _flightCollection = database.GetCollection<Flight>(_databaseSettings.FlightCollectionName);
                _bookingCollection = database.GetCollection<Booking>(_databaseSettings.BookingCollectionName);

            _mapper = mapper;
        }

        public async Task CreateFlightAsync(CreateFlightDto createFlightDto)
        {
            var values = _mapper.Map<Flight>(createFlightDto);
            await _flightCollection.InsertOneAsync(values);
        }

        public async Task DeleteFlightAsync(string flightId)
        {
            await _flightCollection.DeleteOneAsync(x => x.FlightId == flightId);
        }

        public async Task<List<ResultFlightDto>> GetAllFlightsAsync()
        {
            var values = await _flightCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultFlightDto>>(values);
        }

        public async Task<GetFlightByIdDto> GetFlightByIdAsync(string flightId)
        {
            var value = await _flightCollection.Find(x => x.FlightId == flightId).FirstOrDefaultAsync();
            return _mapper.Map<GetFlightByIdDto>(value);
        }

        public async Task<List<PassgenerListItemDto>> GetFlightDetailsWithPassengers(string id)
        {
            //uçuşa ait tüm rezervasyonları bul
            var bookings = await _bookingCollection
                .Find(x=>x.FlightId==id)
                .ToListAsync();

            //Her Booking için yolcu bilgilerini al ve Dto'ya map et
            var passengers=bookings
                .SelectMany(y=>y.Passengers.Select(p=> new PassgenerListItemDto
                {
                    Name = p.Name, //Booking içindeki yolcu bilgilerini PassgenerListItemDto'ya map et
                    Surname = p.Surname, //
                    Email = y.ContactEmail,
                    Gender = p.Gender,
                    PassengerType = p.PassengerType,
                    Pnr = y.BookingId,
                    Phone = y.ContactPhone,
                    SeatNumber=p.SeatNumber,
                    TicketStatus = p.TicketStatus,
                    PaymentStatus = p.PaymentStatus,
                    CheckInStatus = p.CheckInStatus
                }
                )).ToList();
            return passengers;


        }

        public async Task UpdateFlightAsync(string flightId, UpdateFlightDto updateFlightDto)
        {
            var value = _mapper.Map<Flight>(updateFlightDto);
            await _flightCollection.FindOneAndReplaceAsync(x => x.FlightId == updateFlightDto.FlightId, value);
            
        }
    }
}
 