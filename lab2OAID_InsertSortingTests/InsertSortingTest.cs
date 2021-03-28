using System;
using NUnit.Framework;
using lab2OAID;

namespace lab2OAID_InsertSortingTests
{
    [TestFixture]
    public class InsertSortingTest
    {
        [Test()]
        public void TestInsertSortingWithUniqueElements()
        {
            //Класс эквивалентности 1
            int[] a = { 1, 2, 9, -4, 5 };
            int[] expected = { -4, 1, 2, 5, 9 };
            int[] actual;
            actual = InsertSorting.InsertionSort(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void TestInsertSortingWithSameElements()
        {
            //Класс эквивалентности 2
            int[] a = { 3, 3, 3 };
            int[] expected = { 3, 3, 3};
            int[] actual;
            actual = InsertSorting.InsertionSort(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void TestInsertSortingWithOneElements()
        {
            //Класс эквивалентности 3
            int[] a = { 1 };
            int[] expected = { 1 };
            int[] actual;
            actual = InsertSorting.InsertionSort(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void TestInsertSortingWithoutElements()
        {
            //Класс эквивалентности 4
            int[] a = null;
            int[] expected = null;
            int[] actual;
            Assert.Throws<ArgumentException>( () => { actual = InsertSorting.InsertionSort(a); } ); ;
        }
        [Test()]
        public void TestInsertSortingWithRepeatedElements()
        {
            //Класс эквивалентности 5
            int[] a = { 1, 2, 1, 2, 1 };
            int[] expected = { 1, 1, 1, 2, 2 };
            int[] actual;
            actual = InsertSorting.InsertionSort(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
