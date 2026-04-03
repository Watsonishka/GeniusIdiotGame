namespace GeniyIdiotClassLibrary;

public class Question
{
    private string message;
    private int rightAnswer;
    public string Message
    {
        get => message;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Значение не может быть пустым!");
            }
            message = value;
        }
    }
    public int RightAnswer
    {
        get => rightAnswer;
        set
        {
            rightAnswer = value;
        }
    }
    public Question(string message, int rightAnswer)
    {
        this.message = message;
        this.rightAnswer = rightAnswer;
    }
    public static bool IsAvaliableIndex(List<int> avaliableQuestionIndexex, int userInputIndex)
    {
        foreach (var index in avaliableQuestionIndexex)
        {
            if (index == userInputIndex)
            {
                return true;
            }
        }
        return false;
    }
}



