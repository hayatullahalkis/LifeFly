using LifeFly.Dtos.FlightDtos;
using LifeFly.Dtos.PassengerDtos;

namespace LifeFly.Services.FlightSevices
{
    public interface IFlightService
    {
        Task<List<ResultFlightDto>> GetAllFlightsAsync(); // bütün uçuşları getirir

        Task<GetFlightByIdDto> GetFlightByIdAsync(string flightId); // id'ye göre uçuş getirir

        Task CreateFlightAsync(CreateFlightDto createFlightDto); // uçuş oluşturur

        Task DeleteFlightAsync(string flightId); // id'ye göre uçuş siler

        Task UpdateFlightAsync(string flightId, UpdateFlightDto updateFlightDto); // id'ye göre uçuş günceller

        Task<List<PassgenerListItemDto>> GetFlightDetailsWithPassengers(string id);

    }
}
 