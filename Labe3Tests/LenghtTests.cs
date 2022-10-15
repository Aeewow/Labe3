using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labe3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labe3.Tests
{
    [TestClass()]
    public class LengthTests
    {
 
        [TestMethod()]
        public void AddNumberTest()
        {
            var length = new Length(1, MeasureType.m);
            length = length + 2;
            Assert.AreEqual("3 м/c.", length.Verbose());
        }
        [TestMethod()]
        public void MulNumberTest()
        {
            var length = new Length(2, MeasureType.m);
            length = length * 2;
            Assert.AreEqual("4 м/c.", length.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var length = new Length(3, MeasureType.m);
            length = length - 2;
            Assert.AreEqual("1 м/c.", length.Verbose());
        }
        [TestMethod()]
        public void ConvertToTest()
        {
            Length length;
            length = new Length(1, MeasureType.km);
            Assert.AreEqual("0,2777777778 м/c.", length.ConvertTo(MeasureType.m).Verbose());

            length = new Length(1, MeasureType.kn);
            Assert.AreEqual("0,514444444444 м/c.", length.ConvertTo(MeasureType.m).Verbose());

            length = new Length(1, MeasureType.M);
            Assert.AreEqual("340 м/c.", length.ConvertTo(MeasureType.m).Verbose());
        }
    }
}