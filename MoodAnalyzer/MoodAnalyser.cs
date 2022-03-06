namespace MoodAnalyzer;

public class MoodAnalyser
{
    public string AnalyseMood(string message)
    {
        if (message.Contains("Sad", StringComparison.OrdinalIgnoreCase) is true)
            return "Sad";
        return "Happy";
    }
}
