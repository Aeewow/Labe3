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
            Assert.AreEqual(new Length(3, MeasureType.m), length);
        }
        /*[TestMethod()]*/
        /*public void MulNumberTest()
        {
            var length = new Length(2, MeasureType.m);
            length = length * 2;
            Assert.AreEqual("4 м/c.", length.Verbose());
        }*/
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
        [TestMethod()]
        public void AddSubKmMetersTest()
        {
            
            Length Test1 = new Length(10, MeasureType.km);
            Length Test2 = new Length(2, MeasureType.m);
            Length Test3 = Test1 + Test2;


            /*Assert.AreEqual("10,5555555556 м/c.", (m + km).Verbose());*/
            Assert.AreEqual(new Length(5, MeasureType.km), Test3);

            /*Assert.AreEqual("-34 км/ч.", (km - m).Verbose());
            Assert.AreEqual("9,4444444444 м/c.", (m - km).Verbose());*/
        }
    }
}