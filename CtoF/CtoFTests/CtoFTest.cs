using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CtoF;
using NUnit.Framework;

namespace CtoFTests
{
    [TestFixture]
    public class CtoFTest
    {
        private double delta = 0.01;

        public CtoFConverter converter;
        [SetUp]
        public void SetUp()
        {
            converter = new CtoFConverter();
        }

        [Test]
        public void Negative50CIsNegative58F()
        {
            Assert.AreEqual(-58.0, converter.CtoF(-50.0), delta);
        }

        [Test]
        public void Negative40CIsNegative40F()
        {
            Assert.AreEqual(-40.0, converter.CtoF(-40.0), delta);
        }
        
    }
}
