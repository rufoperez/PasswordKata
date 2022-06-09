namespace PasswordKata;

public class Password
{
    public static bool Validation(string givenPassword)
    {
        if (givenPassword.Length >= 8)
            return true;
        return false;
    }
}