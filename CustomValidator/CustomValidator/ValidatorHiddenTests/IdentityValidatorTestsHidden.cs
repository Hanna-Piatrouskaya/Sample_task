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

        [Test]
        public void NameShoudNotBeShorter9Symbols_ValidateTest()
        {
            var validator = new IdentityValidator();
            var expected = true;
            var actual = validator.Validate("shortname");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NameShoudNotBeEmptyString_ValidateTest()
        {
            var validator = new IdentityValidator();
            var expected = true;
            var actual = validator.Validate(string.Empty);
            Assert.AreEqual(expected, actual);
        }
    }
}
