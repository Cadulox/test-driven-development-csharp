using NUnit.Framework;
using NumberConverter;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverterTest
{
    [TestFixture]
    class RomanNumberConverterTest
    {
        [Test]
        public void MustUnderstandTheSymbolI()
        {
            RomanNumberConverter roman = new RomanNumberConverter();
            int number = roman.Converts("I");
            Assert.AreEqual(1, number);
        }

        [Test]
        public void MustUnderstandTheSymbolV()
        {
            RomanNumberConverter roman = new RomanNumberConverter();
            int number = roman.Converts("V");
            Assert.AreEqual(5, number);
        }
        
        [Test]
        public void MustUnderstandTwoSymbolsAsII()
        {
            RomanNumberConverter roman = new RomanNumberConverter();
            int number = roman.Converts("II");
            Assert.AreEqual(2, number);
        }

        [Test]
        public void MustUnderstandFourSymbolsTwoByTwoAsXXII()
        {
            RomanNumberConverter roman = new RomanNumberConverter();
            int number = roman.Converts("XXII");
            Assert.AreEqual(22, number);
        }

        [Test]
        public void MustUnderstandNumbersAsIX()
        {
            RomanNumberConverter roman = new RomanNumberConverter();
            int number = roman.Converts("IX");
            Assert.AreEqual(9, number);
        }

        [Test]
        public void MustUnderstandComplexNumbersAsXXIV()
        {
            RomanNumberConverter roman = new RomanNumberConverter();
            int number = roman.Converts("XXIV");
            Assert.AreEqual(24, number);
        }
    }
}
