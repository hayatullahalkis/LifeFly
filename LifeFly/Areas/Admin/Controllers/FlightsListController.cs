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
    }
}
