
using System.Text;
namespace GeniyIdiotClassLibrary;

public class InputValidator
{
    public static bool CheckSentenceIsValid(string sentence, out string errorMessage)
    {
        errorMessage = "";
        sentence = sentence.ToLower().Trim();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            errorMessage = "Некорректный ввод, ты ввел пустое значение! Пожалуйста, попробуй снова!";
            return false;
        }
        if (!InputValidator.ContainsRussianLetters(sentence))
        {
            errorMessage = "Неправильный ввод! Вопрос должен обязательно содержать русские буквы и должна отсуствовать латиница!";
            return false;
        }
        if (!InputValidator.ContainsRussianLetters(Convert.ToString(sentence[0])))
        {
            errorMessage = "Некорректный ввод, первый символ должен быть РУССКОЙ буквой! Пожалуйста, попробуй снова!";
            return false;
        }
        return true;
    }
    public static bool ContainsRussianLetters(string input)
    {
        var isСontainsRussianLetters = false;
        for (var i = 0; i < input.Length; i++)
        {
            if ((input[i] >= 'A' && input[i] <= 'Z') || (input[i] >= 'a' && input[i] <= 'z'))
            {
                return false;
            }

            if ((input[i] >= 'А' && input[i] <= 'я') || input[i] == 'Ё' || input[i] == 'ё')
            {
                isСontainsRussianLetters = true;
            }
        }
        return isСontainsRussianLetters;
    }
    public static bool IsAllowedNameSymbol(string inputName)
    {
        for (var i = 0; i < inputName.Length; i++)
        {
            if ((inputName[i] < 'А' || inputName[i] > 'я')
                && inputName[i] != 'Ё'
                && inputName[i] != 'ё'
                && inputName[i] != '-'
                && inputName[i] != ' '
                && inputName[i] != '\'')
            {
                return false;
            }
        }
        return true;
    }
    public static bool ContainsLetter(string inputWord)
    {
        for (var i = 0; i < inputWord.Length; i++)
        {
            if (char.IsLetter(inputWord[i]))
            {
                return true;
            }
        }
        return false;
    }
    public static bool HasSentenceEnding(string inputWord)
    {
        var lastChar = inputWord[inputWord.Length - 1];
        if (lastChar == '.' || lastChar == '!' || lastChar == '?')
        {
            return true;
        }
        return false;
    }
    public static bool CheckNameIsValid(string inputName, out string errorMessage)
    {
        errorMessage = "";

        if (string.IsNullOrWhiteSpace(inputName))
        {
            errorMessage = "Некорректный ввод! Ввод не может быть пустым!";
            return false;
        }
        if (!InputValidator.ContainsRussianLetters(Convert.ToString(inputName[0])))
        {
            errorMessage = "Некорректный ввод! Первый символ всегда должен быть РУССКОЙ буквой!";
            return false;
        }
        if (!InputValidator.IsAllowedNameSymbol(inputName))
        {
            errorMessage = "Полный ввод может содержать только РУССКИЕ буквы, пробелы, апостроф и тире!";
            return false;
        }
        return true;
    }
    public static string NormalizeName(string inputName)
    {
        inputName = inputName.ToLower().Trim(' ', '-', '\'');
        var userName = new StringBuilder();
        var previousCharWasSymbol = false;

        for (var i = 0; i < inputName.Length; i++)
        {
            var currentChar = inputName[i];
            if ((currentChar == ' ' || currentChar == '-' || currentChar == '\'') && previousCharWasSymbol)
            {
                continue;
            }

            if (i == 0 || previousCharWasSymbol)
            {
                userName.Append(char.ToUpper(currentChar));
            }
            else
            {
                userName.Append(currentChar);
            }
            previousCharWasSymbol = currentChar == ' ' || currentChar == '-' || currentChar == '\'';
        }
        return userName.ToString();
    }
    public static string NormalizeQuestion(string inputQuestion)
    {
        while (true)
        {
            var stringBuilder = new StringBuilder();
            var separatedWords = inputQuestion.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var previousCharWasSymbol = false;

            for (var i = 0; i < separatedWords.Length; i++)
            {
                var word = separatedWords[i];
                var isContainsLetter = InputValidator.ContainsLetter(word);
                var currentWord = "";

                for (var j = 0; j < word.Length; j++)
                {
                    if (isContainsLetter)
                    {
                        if (j == 0 && (i == 0 || previousCharWasSymbol))
                        {
                            currentWord += char.ToUpper(word[j]);
                        }
                        else if (!char.IsDigit(word[j]))
                        {
                            currentWord += word[j];
                        }
                    }
                    else
                    {
                        currentWord += word[j];
                    }
                }
                previousCharWasSymbol = InputValidator.HasSentenceEnding(word);
                stringBuilder.Append(currentWord);
                stringBuilder.Append(i != separatedWords.Length - 1 ? ' ' : '?');
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
