using Newtonsoft.Json;

namespace GeniyIdiotClassLibrary;

public class UserResultStorage
{
    private const string quizHistoryFilePath = "QuizHistory.json";
    public string QuizHistoryFilePath
    {
        get => quizHistoryFilePath;
    }
    static UserResultStorage()
    {
        if (!File.Exists(quizHistoryFilePath))
        {
            FileManager.RewriteTextFile(quizHistoryFilePath, "[]");
        }
    }
    public static void SaveQuizResultToFile(User user)
    {
        var users = GetQuizHistory();
        users.Add(user);
        var jsonData = JsonConvert.SerializeObject(users);
        FileManager.RewriteTextFile(quizHistoryFilePath, jsonData);
    }
    public static List<User> GetQuizHistory()
    {
        return FileManager.ReadTextFile<User>(quizHistoryFilePath);
    }
}



