using static System.String;

namespace PasswordKata;

public class Password
{
    private const string NOT_ENOUGH_CHARACTERS_ERROR = "Password must be at least 8 characters";
    private const string NOT_ENOUGH_NUMBERS_ERROR = "Password must contain at least two numbers";
    private const string NOT_CAPITAL_LETTER_ERROR = "Password must contain at least one capital letter";
    private const string NOT_SPECIAL_CHARACTER_ERROR = "Password must contain at least one special character";

    public static string Validation(string givenPassword)
    {
        var result = new List<string>();

        var characterError = CheckCharactersInPassword(givenPassword);
        if(!string.IsNullOrEmpty(characterError))
            result.Add(characterError);

        var numberError = CheckNumbersInPassword(givenPassword);
        if(!string.IsNullOrEmpty(numberError))
            result.Add(numberError);

        var capitalLetterError = CheckCapitalLetter(givenPassword);
        if (!string.IsNullOrEmpty(capitalLetterError))
            result.Add(capitalLetterError);

        var specialCharacerError = CheckSpecialCharacter(givenPassword);
        if (!string.IsNullOrEmpty(specialCharacerError))
            result.Add(specialCharacerError);

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

    private static string CheckCapitalLetter(string givenPassword)
    {
        foreach (char c in givenPassword)
        {
            if (Char.IsUpper(c))
                return Empty;
        }

        return NOT_CAPITAL_LETTER_ERROR;
    }

    private static string CheckSpecialCharacter(string givenPassword)
    {
        if(givenPassword.Any(ch => !Char.IsLetterOrDigit(ch)))
            return Empty;
        return NOT_SPECIAL_CHARACTER_ERROR;
        
    }
}