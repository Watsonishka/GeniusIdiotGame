
namespace GeniyIdiotClassLibrary;

public class Randomizer
{
    public static List<int> RemoveRandomIndexes(List<int> randomIndexes, int removeCount)
    {
        var randomizer = new Random();
        for (var i = 0; i < removeCount; i++)
        {
            var removingIndex = randomizer.Next(randomIndexes.Count);
            randomIndexes.RemoveAt(removingIndex);
        }
        return randomIndexes;
    }
    public static List<int> GetRandomIndexes(int numberOfIndexes)
    {
        var randomIndexes = new List<int>();
        var randomizer = new Random();

        for (var i = 0; i < numberOfIndexes; i++)
        {
            randomIndexes.Add(i);
        }

        for (var i = randomIndexes.Count - 1; i > 0; i--)
        {
            var index = randomizer.Next(i + 1);
            var temp = randomIndexes[index];
            randomIndexes[index] = randomIndexes[i];
            randomIndexes[i] = temp;
        }
        return randomIndexes;
    }
}



