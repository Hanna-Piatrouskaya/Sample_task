using NUnit.Framework;
using System;
namespace CustomValidator
{
    [TestFixture]
    public class IdentityValidatorTests
    {
        [Test]
        public void NameShoudNotBeNull_ValidateTest()
        {
            var validator = new IdentityValidator();
            var expected = true;
            var actual = validator.Validate(null);
            Assert.AreEqual(expected, actual);
        }
    }
}
