namespace sentimeter;

public class SentimeterResult
{
    public int normalizedSentimentScore { get; set; }

    public int normalizedTrendMagnitude {get; set; } 

    public bool emergencySirenThresholdExceeded { get; set; }
}
