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
        public void when_password_is_7_characters_lenght_return_false()
        {
            var givenPassword = "aaaaaaa";
            bool result = Password.Validation(givenPassword);
            result.Should().Be(false);
        }
    }
}