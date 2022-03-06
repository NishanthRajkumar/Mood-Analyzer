using MoodAnalyzer;

MoodAnalyser mood = new MoodAnalyser();

string moodStatus = mood.AnalyseMood("I am really sad");

Console.WriteLine("Input Text: I am really sad");
Console.WriteLine("Mood: " + moodStatus);