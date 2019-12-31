using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.test
{
    [TestClass]
    public class UserValidationTest
    {
        [TestMethod]
        public void PasswordValidation()
        {
            UserValidation u = new UserValidation();
            Assert.AreEqual(true, u.passwordValidation("abcde", "abcde"));
        }

        [TestMethod]
        public void EmptyFieldValidation()
        {
            UserValidation u = new UserValidation();
            Assert.AreEqual(false, u.emptyValidation(""));
        }

        [TestMethod]
        public void duplicateUserTest()
        {
            UserValidation u = new UserValidation();
            Assert.AreEqual(true, u.CheckEmail("wagle@gmail.com"));
        }

        [TestMethod]
        public void emailValidation()
        {
            UserValidation u = new UserValidation();
            Assert.AreEqual(true, u.CheckEmail("wagle@gmail.com"));
        }

    }
}
