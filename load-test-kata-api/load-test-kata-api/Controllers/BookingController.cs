using Microsoft.AspNetCore.Mvc;

namespace load_test_kata_api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{
    private static int callsCount = 0;
    private static readonly string[] Summaries = new[]
    {
        "Rotterdam", "Girona", "Paris"
    };

    private readonly ILogger<BookingController> _logger;

    public BookingController(ILogger<BookingController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Book")]
    public string Get()
    {
        callsCount++;
        Random rand = new Random();
        var something = Math.Max(Math.Min(callsCount - 100, 100), 0);
        Thread.Sleep(something * something);

        return Summaries[Random.Shared.Next(Summaries.Length)];
    }
}