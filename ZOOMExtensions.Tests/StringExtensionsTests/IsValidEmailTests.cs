namespace ZOOMExtensions.Tests.StringExtensionsTests
{
    [TestClass]
    public class IsValidEmailTests
    {
        [TestMethod]
        public void ValidEmail_ReturnsTrue()
        {
            Assert.IsTrue("test@example.com".IsValidEmail());
        }

        [TestMethod]
        public void InvalidEmail_ReturnsFalse()
        {
            Assert.IsFalse("invalid.email".IsValidEmail());
        }

        [TestMethod]
        public void EmptyOrNullOrEmptyEmail_ReturnsFalse()
        {
            string? nullEmail = null;

            Assert.IsFalse("".IsValidEmail());
            Assert.IsFalse(nullEmail.IsValidEmail());
        }

        [TestMethod]
        public void InvalidFormat_ReturnsFalse()
        {
            Assert.IsFalse("@example.com".IsValidEmail());
            Assert.IsFalse("test@.com".IsValidEmail());
            Assert.IsFalse("test@example".IsValidEmail());
        }
    }
}