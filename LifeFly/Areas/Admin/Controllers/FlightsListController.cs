using LifeFly.Dtos.FlightDtos;
using LifeFly.Services.FlightSevices;
using Microsoft.AspNetCore.Mvc;

namespace LifeFly.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlightsListController : Controller
    {
        private readonly IFlightService _flightService;

        public FlightsListController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        public async Task<IActionResult> FlightList()
        {
            var values = await _flightService.GetAllFlightsAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFligth()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFligth(CreateFlightDto createFlightDto)
        {
            await _flightService.CreateFlightAsync(createFlightDto);
            return RedirectToAction("FlightList");

        }

        public async Task<IActionResult> FlightDetails(string id)
        {
            var flight = await _flightService.GetFlightByIdAsync(id);
            var passengers = await _flightService.GetFlightDetailsWithPassengers(id);

            ViewBag.FlightNumber = flight?.FlightNumber ?? "—";
            ViewBag.AirlineCode = flight?.AirlineCode ?? "—";
            ViewBag.DepartureAirportCode = flight?.DepartureAirportCode ?? "—";
            ViewBag.ArrivalAirportCode = flight?.ArrivalAirportCode ?? "—";
            ViewBag.DepartureTime = flight?.DepartureTime;   // DateTime? olarak gider
            ViewBag.ArrivalTime = flight?.ArrivalTime;
            ViewBag.TotalSeats = flight?.TotalSeats ?? 0;
            ViewBag.Status = flight?.Status ?? "—";

            return View(passengers);



            //
            //    var flight = await _flightService.GetFlightByIdAsync(id);
            //    var passengers = await _flightService.GetFlightDetailsWithPassengers(id);
            //    ViewBag.Flight = flight;
            //    return View(passengers);
        }
    }
}
