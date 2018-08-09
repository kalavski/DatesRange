using System;
using NUnit.Framework;
using myapp2.Interfaces;

namespace myapp2
{
    [TestFixture]
    class ValidationTests
    {
        [TestCase("01.02.2016", "02/07/2017", true)]
        [TestCase("01/07", "02/07/2017", false)]
        [TestCase("01/02/2017", "02/07/2017", true)]
        public void Should_Return_Correct_String(string startDate, string finishDate, string testResult)
        {
            var result = Validation.Validation.IsValid(startDate, finishDate);
            Assert.AreEqual(result, testResult);
        }
    }
}
