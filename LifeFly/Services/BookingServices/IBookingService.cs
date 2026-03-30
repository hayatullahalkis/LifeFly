using LifeFly.Dtos.BookingDtos;

namespace LifeFly.Services.BookingServices
{
    public interface IBookingService
    {
        Task CreateBookingAsync(CreateBookingDto createBookingdto);
    }
}
