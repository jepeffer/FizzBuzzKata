using System;
using System.Collections.Generic;
using FizzBuzzaKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKataTests
{
    /// <summary>
    /// These are the test cases specified by the Kata website, including a few of my own
    /// </summary>
    [TestClass]
    public class FizzBuzzUnitTests
    {
        /*
         * Begin FizzBuzzStandard tests
         */
        [TestMethod]
        public void NormalNumbersReturnSameNumber()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(0);
            Assert.AreEqual("1", fizz.GetAnswer(1));
            Assert.AreEqual("2", fizz.GetAnswer(2));
            Assert.AreEqual("4", fizz.GetAnswer(4));
            Assert.AreEqual("7", fizz.GetAnswer(7));
        }

        [TestMethod]
        public void MultiplesOfThreeReturnFizz()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(0);
            Assert.AreEqual("fizz", fizz.GetAnswer(3));
            Assert.AreEqual("fizz", fizz.GetAnswer(9));
            Assert.AreEqual("fizz", fizz.GetAnswer(123));
            Assert.AreEqual("fizz", fizz.GetAnswer(1419));
        }

        [TestMethod]
        public void MultiplesOfFiveReturnBuzz()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(0);
            Assert.AreEqual("buzz", fizz.GetAnswer(5));
            Assert.AreEqual("buzz", fizz.GetAnswer(20));
            Assert.AreEqual("buzz", fizz.GetAnswer(200));
            Assert.AreEqual("buzz", fizz.GetAnswer(10000));
        }

        [TestMethod]
        public void MultiplesThreeAndFiveReturnFizzBuzz()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(0);
            Assert.AreEqual("fizz buzz", fizz.GetAnswer(15));
            Assert.AreEqual("fizz buzz", fizz.GetAnswer(45));
            Assert.AreEqual("fizz buzz", fizz.GetAnswer(315));
            Assert.AreEqual("fizz buzz", fizz.GetAnswer(675));
        }

        /*
         * Begin FizzBuzzPop tests
         */

        [TestMethod]
        public void MultiplesOfSevenReturnPop()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(1);
            Assert.AreEqual("pop", fizz.GetAnswer(7));
            Assert.AreEqual("pop", fizz.GetAnswer(28));
            Assert.AreEqual("pop", fizz.GetAnswer(77));
        }

        [TestMethod]
        public void MultiplesOfThreeAndSevenReturnFizzPop()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(1);
            Assert.AreEqual("fizz pop", fizz.GetAnswer(21));
            Assert.AreEqual("fizz pop", fizz.GetAnswer(63));
            Assert.AreEqual("fizz pop", fizz.GetAnswer(126));
        }

        [TestMethod]
        public void MultiplesOfFiveAndSevenReturnBuzzPop()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(1);
            Assert.AreEqual("buzz pop", fizz.GetAnswer(35));
            Assert.AreEqual("buzz pop", fizz.GetAnswer(70));
            Assert.AreEqual("buzz pop", fizz.GetAnswer(140));
        }

        [TestMethod]
        public void MultiplesOfThreeFiveAndSevenReturnFizzBuzzPop()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(1);
            Assert.AreEqual("fizz buzz pop", fizz.GetAnswer(105));
            Assert.AreEqual("fizz buzz pop", fizz.GetAnswer(210));
            Assert.AreEqual("fizz buzz pop", fizz.GetAnswer(315));
        }

        /*
         * Begin FizzBuzz Variation tests
         */

        [TestMethod]
        public void UsingACustomSubstitution()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(2);
            fizz.AddSubstitution(2, "fuzz");
            Assert.AreEqual("1", fizz.GetAnswer(1));
            Assert.AreEqual("fuzz", fizz.GetAnswer(2));
            Assert.AreEqual("fuzz", fizz.GetAnswer(8));
        }

        [TestMethod]
        public void UsingACustomSubstitutionOverloaded()
        {
            FizzBuzz fizz = new FizzBuzz();
            SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();
            dictionary.Add(2, "fuzz");
            fizz.SetGameType(2);
            fizz.AddSubstitution(dictionary);
            Assert.AreEqual("1", fizz.GetAnswer(1));
            Assert.AreEqual("fuzz", fizz.GetAnswer(2));
            Assert.AreEqual("fuzz", fizz.GetAnswer(8));
        }

        [TestMethod]
        public void LinkingTogetherCustomSubstitutions()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(2);
            fizz.AddSubstitution(2, "fuzz");
            fizz.AddSubstitution(3, "bizz");
            Assert.AreEqual("fuzz", fizz.GetAnswer(4));
            Assert.AreEqual("bizz", fizz.GetAnswer(9));
            Assert.AreEqual("fuzz bizz", fizz.GetAnswer(12));
        }

        [TestMethod]
        public void LinkingTogetherCustomSubstitutionsSortingTest()
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.SetGameType(2);
            fizz.AddSubstitution(3, "bizz");
            fizz.AddSubstitution(2, "fuzz");
            Assert.AreEqual("fuzz", fizz.GetAnswer(4));
            Assert.AreEqual("bizz", fizz.GetAnswer(9));
            Assert.AreEqual("fuzz bizz", fizz.GetAnswer(12));
        }

        [TestMethod]
        public void LinkingTogetherCustomSubstitutionsOverloaded()
        {
            FizzBuzz fizz = new FizzBuzz();
            SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();
            dictionary.Add(2, "fuzz");
            dictionary.Add(3, "bizz");
            fizz.SetGameType(2);
            fizz.AddSubstitution(dictionary);
            Assert.AreEqual("1", fizz.GetAnswer(1));
            Assert.AreEqual("fuzz", fizz.GetAnswer(2));
            Assert.AreEqual("fuzz", fizz.GetAnswer(8));
        }
    }
}
