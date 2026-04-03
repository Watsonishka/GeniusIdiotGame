using Newtonsoft.Json;

namespace GeniyIdiotClassLibrary;

public class QuestionStorage
{
    private static readonly List<Question> questions = new List<Question>();
    private const string questionsFilePath = "QuestionList.json";
    private const int minFileSize = 559;
    static QuestionStorage()
    {
        if (!File.Exists(questionsFilePath) || new FileInfo(questionsFilePath).Length < minFileSize)
        {
            InizializeDefault();
        }
        else
        {
            var questions = GetAll();
        }
    }
    public static List<Question> GetAll()
    {
        return FileManager.ReadTextFile<Question>(questionsFilePath);
    }
    public static void RewriteFile(List<Question> questions)
    {
        var jsonData = JsonConvert.SerializeObject(questions);
        FileManager.RewriteTextFile(questionsFilePath, jsonData);
    }
    private static void InizializeDefault()
    {
        var questions = new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?",6),
                new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?",9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?",25),
                new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?",2)
            };
        var jsonData = JsonConvert.SerializeObject(questions);
        FileManager.RewriteTextFile(questionsFilePath, jsonData);
    }
}


