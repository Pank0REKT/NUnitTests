using System;
using NUnit.Framework;
using lab2OAID;

namespace lab2OAIDTests
{
    [TestFixture]
    public class ArrayUtilsTest
    {
        [Test()]
        public void MinTestNormalArrayWithUniqueElements()
        {
            //Класс эквивалентности 1
            int[] a = { 1, 2, 9, -4, 5 };
            int expected = -4;
            int actual;
            actual = ArrayUtils.Min(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MinTestNormalArrayWithSameElements()
        {
            //Класс эквивалентности 2
            int[] a = { 2, 2, 2 };
            int expected = 2;
            int actual;
            actual = ArrayUtils.Min(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MinTestNormalArrayWithRepeatedElements()
        {
            //Класс эквивалентности 3
            int[] a = { 1, 2, 2, 2, 1, 4 };
            int expected = 1;
            int actual;
            actual = ArrayUtils.Min(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MinTestArrayWithOneElement()
        {
            //Класс эквивалентности 4
            int[] a = { 3 };
            int expected = 3;
            int actual;
            actual = ArrayUtils.Min(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MinTestEmptyArray()
        {
            //Класс эквивалентности 5 (ошибочный)
            int[] a = null;
            int actual;
            Assert.Throws<ArgumentException>(
            () => { actual = ArrayUtils.Min(a); }
            );
        }
        [Test()]
        public void MaxTestWithUniqueElements()
        {
            //Класс эквивалентности 1
            int[] a = { 2, 4, 3, 10 };
            int expected = 10;
            int actual;
            actual = ArrayUtils.Max(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MaxTestWithSameElements()
        {
            //Класс эквивалентности 2
            int[] a = { 8, 8, 8 };
            int expected = 8;
            int actual;
            actual = ArrayUtils.Max(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MaxTestWithRepeatedElement()
        {
            //Класс эквивалентности 3
            int[] a = { 3, 6, 9, 44, 44, 3 };
            int expected = 44;
            int actual;
            actual = ArrayUtils.Max(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MaxTestArrayWithOneElement()
        {
            //Класс эквивалентности 4
            int[] a = { 3 };
            int expected = 3;
            int actual;
            actual = ArrayUtils.Max(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void MaxTestEmptyArray()
        {
            //Класс эквивалентности 5 (ошибочный)
            int[] a = null;
            int actual;
            Assert.Throws<ArgumentException>(
            () => { actual = ArrayUtils.Max(a); }
            );
        }
    }
}
