using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using NUnit.Framework;
using StanfordAlgo;


namespace UnitTest
{
    public class KaratsubaTest
    {

        [Test]
        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "0")]
        [TestCase("0", "12", "0")]
        [TestCase("0", "123", "0")]
        [TestCase("5", "25", "125")]
        [TestCase("12", "65", "780")]
        [TestCase("99", "98", "9702")]
        [TestCase("12", "598", "7176")]
        [TestCase("123", "5890", "724470")]
        [TestCase("1234", "91834", "113323156")]
        [TestCase("66818", "52364", "3498857752")]
        [TestCase("123456789", "987654321", "121932631112635269")]
        [TestCase("1234567890123456", "1234567890123456", "1524157875323881726870921383936")]
        public void KaratsubaTests(string int1, string int2, string expectedProduct)
        {
            //var first = new MyBigInteger(int1);
            //var second = new MyBigInteger(int2);
            var expected = BigInteger.Parse(expectedProduct);
            

            Assert.AreEqual(expectedProduct, Karatsuba.multiply(int1, int2));
        }
    }
}
