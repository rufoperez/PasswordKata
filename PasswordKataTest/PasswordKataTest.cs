using FluentAssertions;
using PasswordKata;

namespace PasswordKataTest
{
    public class PasswordKataTest
    {
        [Test]
        public void when_password_is_7_characters_lenght_return_error()
        {
            var givenPassword = "Aa%aa11";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must be at least 8 characters");
        }

        [Test]
        public void when_password_is_less_than_two_numbers_return_error()
        {
            var givenPassword = "aaaaAaaa$aaaaaaaa1";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must contain at least two numbers");
        }

        [Test]
        public void when_password_is_less_than_two_numbers_and_less_than_8_characters_return_errors()
        {
            var givenPassword = "aAaa&a1";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must be at least 8 characters\nPassword must contain at least two numbers");
        }

        [Test]
        public void when_password_not_have_capitol_letter_return_error()
        {
            var givenPassword = "aaaaa%a11";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must contain at least one capital letter");
        }

        [Test]
        public void when_password_not_have_special_character_return_error()
        {
            var givenPassword = "aaAaaa11";
            string result = Password.Validation(givenPassword);
            result.Should().NotBeEmpty().And.Be("Password must contain at least one special character");
        }
    }
}