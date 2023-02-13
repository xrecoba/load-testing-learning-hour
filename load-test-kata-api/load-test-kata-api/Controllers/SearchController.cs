using Microsoft.AspNetCore.Mvc;

namespace load_test_kata_api.Controllers;


[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{
    private Random _rand;

    public SearchController(ILogger<SearchController> logger)
    {
        _rand = new Random();
    }

    [HttpGet(Name = "Search")]
    public int Get()
    {
        if (_rand.Next(0, 100)>= 85)
        {
            Thread.Sleep(1000);
        }

        return _rand.Next();
    }
}

