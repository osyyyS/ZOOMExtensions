using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOOMExtensions;

namespace ZOOMExtensions.Tests.xUnit.StringExtensionsTests
{
    public class IsValidEmailTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void TestEmptyOrNull(string email)
        {
            bool result = email.IsValidEmail();
            Assert.False(result);
        }

        [Theory]
        [InlineData("test@example.com")]
        [InlineData("user123@gmail.com")]
        [InlineData("john.doe@example.co.uk")]
        public void TestValidEmail(string email)
        {
            bool result = email.IsValidEmail();
            Assert.True(result);
        }

        [Theory]
        [InlineData("invalidemail")]
        [InlineData("invalidemail@")]
        [InlineData("invalidemail@domain")]
        [InlineData("invalid@.com")]
        [InlineData("invalid@domain.")]
        public void TestInvalidEmail(string email)
        {
            bool result = email.IsValidEmail();
            Assert.False(result);
        }
    }
}
