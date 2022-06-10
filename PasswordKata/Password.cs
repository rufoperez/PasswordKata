namespace PasswordKata;

public class Password
{
    public static bool Validation(string givenPassword)
    {
        if (givenPassword.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters");

        var numbersInPassword = 0;
        foreach (char c in givenPassword)
        {
            var result = 0;
            if(int.TryParse(c.ToString(), out result))
                numbersInPassword++;
        }

        if (numbersInPassword <2)
            throw new ArgumentException("Password must contain at least two numbers");

        return true;

    }
}