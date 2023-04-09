using Microsoft.AspNetCore.Mvc;

namespace sentimeter.Controllers;

[ApiController]
[Route("[controller]")]
public class SentimeterMainController : ControllerBase
{
    [HttpGet(Name = "GetSentimeterMain")]
    public IEnumerable<SentimeterResult> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new SentimeterResult
        {
            normalizedSentimentScore = Random.Shared.Next(0,100),
            normalizedTrendMagnitude = Random.Shared.Next(0,10),
            emergencySirenThresholdExceeded = Random.Shared.NextDouble() > 0.8
        })
        .ToArray();

    }
}
