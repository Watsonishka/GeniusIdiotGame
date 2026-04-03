namespace GeniyIdiotClassLibrary;

public class User
{
    public Diagnose Diagnose;
    public int RightAnswerCount;
    private string lastName;
    private string firstName;
    private string patronymic;
    public string LastName
    {
        get => lastName;
        set
        {
            if (!InputValidator.CheckNameIsValid(value, out string errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }
            lastName = InputValidator.NormalizeName(value);
        }
    }
    public string FirstName
    {
        get => firstName;
        set
        {
            if (!InputValidator.CheckNameIsValid(value, out string errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }
            firstName = InputValidator.NormalizeName(value);
        }
    }
    public string Patronymic
    {
        get => patronymic;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                patronymic = "";
                return;
            }
            if (!InputValidator.CheckNameIsValid(value, out string errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }
            patronymic = InputValidator.NormalizeName(value);
        }
    }
    public string FullName
    {
        get => $"{firstName} {lastName} {patronymic}".Trim();
    }
    public User(string firstName, string lastName, string patronymic, Diagnose diagnose, int rightAnswerCount)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Diagnose = diagnose;
        RightAnswerCount = rightAnswerCount;
    }
    public User(string firstName, string lastName, string patronymic)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Diagnose = new Diagnose("Неизвестно");
        RightAnswerCount = 0;
    }
    public User() { }
}


