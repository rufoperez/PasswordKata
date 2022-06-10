using FluentAssertions;
using PasswordKata;

namespace PasswordKataTest
{
    public class PasswordKataTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void when_password_is_7_characters_lenght_return_error()
        {
            var givenPassword = "aaaaaaa";
            Action act = () => Password.Validation(givenPassword);
            act.Should().Throw<ArgumentException>("Password must be at least 8 characters");
        }

        [Test]
        public void when_password_is_8_characters_lenght_return_true()
        {
            var givenPassword = "aaaaaaaa";
            bool result = Password.Validation(givenPassword);
            result.Should().Be(true);
        }

        [Test]
        public void when_password_is_8_characters_or_more_lenght_return_true()
        {
            var givenPassword = "aaaaaaaaaaaa";
            bool result = Password.Validation(givenPassword);
            result.Should().Be(true);
        }
    }
}