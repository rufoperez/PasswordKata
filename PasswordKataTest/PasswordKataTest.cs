using FluentAssertions;
using PasswordKata;

namespace PasswordKataTest
{
    public class PasswordKataTest
    {
        [Test]
        public void when_password_is_7_characters_lenght_return_error()
        {
            var givenPassword = "aaaaa11";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must be at least 8 characters");
        }

        [Test]
        public void when_password_is_less_than_two_numbers_return_error()
        {
            var givenPassword = "aaaaaaaaaaaaaaaa1";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must contain at least two numbers");
        }

        [Test]
        public void when_password_is_less_than_two_numbers_and_less_than_8_characters_return_errors()
        {
            var givenPassword = "aaaaaa1";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must be at least 8 characters\nPassword must contain at least two numbers");
        }

        [Test]
        public void when_password_not_hava_capitol_letter_return_error()
        {
            var givenPassword = "aaaaaa11";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must contain at least one capital letter");
        }
    }
}