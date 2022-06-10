namespace PasswordKata;

public class Password
{
    public static string Validation(string givenPassword)
    {
        var result = string.Empty;

        if (givenPassword.Length < 8)
            result += "Password must be at least 8 characters";

        var numbersInPassword = 0;
        foreach (char c in givenPassword)
        {
            var numberResult = 0;
            if(int.TryParse(c.ToString(), out numberResult))
                numbersInPassword++;
        }

        if (numbersInPassword < 2)
          result +=  string.IsNullOrEmpty(result)
                ? "Password must contain at least two numbers"
                : "\nPassword must contain at least two numbers";

        return result;
        ;

    }
}