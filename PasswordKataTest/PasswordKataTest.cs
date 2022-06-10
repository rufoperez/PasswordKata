using FluentAssertions;
using PasswordKata;

namespace PasswordKataTest
{
    public class PasswordKataTest
    {
        [Test]
        public void when_password_is_7_characters_lenght_return_error()
        {
            var givenPassword = "aaaaaaa";
            Action act = () => Password.Validation(givenPassword);
            act.Should().Throw<ArgumentException>("Password must be at least 8 characters");
        }

        [Test]
        public void when_password_is_less_than_two_numbers_return_error()
        {
            var givenPassword = "aaaaaaaaaaaaaaaa1";
            Action act = () => Password.Validation(givenPassword);
            act.Should().Throw<ArgumentException>("Password must contain at least two numbers");
        }
    }
}