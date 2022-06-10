using static System.String;

namespace PasswordKata;

public class Password
{
    private const string NOT_ENOUGH_CHARACTERS_ERROR = "Password must be at least 8 characters";
    private const string NOT_ENOUGH_NUMBERS_ERROR = "Password must contain at least two numbers";

    public static string Validation(string givenPassword)
    {
        var result = new List<string>();

        var characterError = CheckCharactersInPassword(givenPassword);
        if(!string.IsNullOrEmpty(characterError))
            result.Add(characterError);
        var numberError = CheckNumbersInPassword(givenPassword);
        if(!string.IsNullOrEmpty(numberError))
            result.Add(numberError);


        return ComposeErrorMessage(result);
    }

    private static string ComposeErrorMessage(List<string> result)
    {
        var errorMessage = string.Empty;
        for (int i = 0; i < result.Count; i++)
        {
            if (i == 0)
                errorMessage += result[i];
            else
            {
                errorMessage += $"\n{result[i]}";
            }
        }
        return errorMessage;
    }

    private static string CheckCharactersInPassword(string givenPassword)
    {
        if (givenPassword.Length < 8)
            return NOT_ENOUGH_CHARACTERS_ERROR;
        return Empty;
    }

    private static string CheckNumbersInPassword(string givenPassword)
    {
        var numbersInPassword = 0;

        foreach (char c in givenPassword)
        {
            var numberResult = 0;
            if (int.TryParse(c.ToString(), out numberResult))
                numbersInPassword++;
        }

        if (numbersInPassword < 2)
            return NOT_ENOUGH_NUMBERS_ERROR;

        return Empty;
    }
}