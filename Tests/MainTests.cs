using System;
using NUnit.Framework;
using myapp.Interfaces;

namespace myapp
{
    [TestFixture]
    class MainTests
    {
        [TestCase("01/02/2016", "02/07/2017","01.02.2016 - 02.07.2017")]
        [TestCase("01/07/2017", "02/07/2017","01 - 02.07.2017")]
        [TestCase("01/02/2017", "02/07/2017","01.02 - 02.07.2017")]
        public void Should_Return_Dates_In_String(string startDate, string finishDate, string testResult)
        {
            var result = new MainClass().ShowRange(startDate, finishDate);
            Assert.AreEqual(result, testResult);
        }
    }
}
