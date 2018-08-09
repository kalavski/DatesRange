using System;
using NUnit.Framework;
using RangePrinter.Printers;

namespace RangePrinter
{
    [TestFixture]
    class PrinterTest
    {
        [TestCase("01/07/2017", "02/07/2017","01 - 02.07.2017")]
        
        public void Should_Return_Days_In_String(string startDate, string finishDate, string testResult)
        {
            var result = new DayPrinter().Print(DateTime.Parse(startDate), DateTime.Parse(finishDate));
            Assert.AreEqual(result, testResult);
        }

        [TestCase("01/02/2017", "02/07/2017","01.02 - 02.07.2017")]
        public void Should_Return_Days_And_Months_In_String(string startDate, string finishDate, string testResult)
        {
            var result = new MonthPrinter().Print(DateTime.Parse(startDate), DateTime.Parse(finishDate));
            Assert.AreEqual(result, testResult);
        }

        [TestCase("01/02/2016", "02/07/2017","01.02.2016 - 02.07.2017")]
        public void Should_Return_Dates_In_String(string startDate, string finishDate, string testResult)
        {
            var result = new YearPrinter().Print(DateTime.Parse(startDate), DateTime.Parse(finishDate));
            Assert.AreEqual(result, testResult);
        }
    }
}