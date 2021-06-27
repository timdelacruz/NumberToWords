using API.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DigitsToWordsTest()
        {
            var expected = "One";
            var result = Essentials.DigitsToWords(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TensToWordsTest()
        {
            var expected = "Twenty";
            var result = Essentials.TensToWords(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TeensToWordsTest()
        {
            var expected = "Thirteen";
            var result = Essentials.TeensToWords(13);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HundredsToWordsTest()
        {
            var expected = "Nine Hundred And Ninety Nine";
            var result = Essentials.HundredToWords(999);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ThousandsToWordsTest()
        {
            var expected = "Five Thousand One Hundred And Twenty Three";
            var result = Essentials.ThousandsToWords(5123);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MillionsToWordsTest()
        {
            var expected = "One Million Nine Hundred And Twenty Thousand Eight Hundred And Seventy Two";
            var result = Essentials.MillionsToWords(1920872);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BillionsToWordsTest()
        {
            var expected = "Four Billion Eight Hundred And Thirty Nine Million One Hundred And Twenty One Thousand And Twenty Two";
            var result = Essentials.BillionToWords(4839121022);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StandardToWordsTest()
        {
            var expected = "ONE HUNDRED AND TWENTY THREE DOLLARS AND FORTY FIVE CENTS";
            var result = Essentials.NumberToWords(123.45);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NegativeTest()
        {
            var expected = "NEGATIVE ONE HUNDRED AND TWENTY THREE DOLLARS AND FORTY FIVE CENTS";
            var result = Essentials.NumberToWords(-123.45);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CentsTest()
        {
            var expected = "FORTY FIVE CENTS AND FIVE MILLS";
            var result = Essentials.NumberToWords(.455);

            Assert.AreEqual(expected, result);
        }
    }
}
