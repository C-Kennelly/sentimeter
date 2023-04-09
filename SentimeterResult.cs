namespace sentimeter;

public class SentimeterResult
{
    public int normalizedSentimentScore { get; set; }

    public int normalizedTrendMagnitude {get; set; } 

    public bool emergencySirenThresholdExceeded {
        get { return EmergencySirenThresholdExceeded(); }
    }
    
    private bool EmergencySirenThresholdExceeded()
    {
        if ((normalizedSentimentScore) > 80 && (normalizedTrendMagnitude > 5))
        {
            return true;
        }

        return false;
    }
}
