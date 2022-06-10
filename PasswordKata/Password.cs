namespace PasswordKata;

public class Password
{
    private const string NOT_ENOUGH_CHARACTERS_ERROR = "Password must be at least 8 characters";
    private const string NOT_ENOUGH_NUMBERS_ERROR = "Password must contain at least two numbers";

    public static string Validation(string givenPassword)
    {
        var result = string.Empty;

        if (givenPassword.Length < 8)
            result += NOT_ENOUGH_CHARACTERS_ERROR;

        var numbersInPassword = 0;
        foreach (char c in givenPassword)
        {
            var numberResult = 0;
            if(int.TryParse(c.ToString(), out numberResult))
                numbersInPassword++;
        }

        if (numbersInPassword < 2)
          result +=  string.IsNullOrEmpty(result)
                ? NOT_ENOUGH_NUMBERS_ERROR
                : $"\n{NOT_ENOUGH_NUMBERS_ERROR}";

        return result;
    }
}