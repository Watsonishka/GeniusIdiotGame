namespace GeniyIdiotClassLibrary;

public class Diagnose
{
    private string name;
    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Значение не может быть пустым!");
            }
            name = value;
        }
    }
    public Diagnose(string name)
    {
        Name = name; ;
    }
}

