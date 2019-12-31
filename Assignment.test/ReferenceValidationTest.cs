using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.test
{
    [TestClass]
    public class ReferenceValidationTest
    {
        [TestMethod]
        public void YearValidation()
        {
            //will return false when more then 4 characters or characters are not numeric
            ReferencesValidation r = new ReferencesValidation();
            Assert.AreEqual(true, r.yearValid("2018"));
        }

        [TestMethod]
        public void Numbericvalidation()
        {
            //will return true when numberic value is given.
            ReferencesValidation r = new ReferencesValidation();
            Assert.AreEqual(false, r.numberValid("aa"));
        }
        [TestMethod]
        public void CheckEmpty()
        {
            //will return true when all characters are not null
            ReferencesValidation r = new ReferencesValidation();
            string[] arr = new string[] { "", "aman", "wagle" };
            Assert.AreEqual(false, r.checkEmpty(arr));
        }
    }
}
