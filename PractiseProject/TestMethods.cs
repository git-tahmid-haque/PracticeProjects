using LunchtimeQuizzes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PractiseProject
{
    [TestClass]
    public class TestMethods
    {
        [TestMethod]
        public void TestMethod1()
        {
            int value = 1;
            Revision.AddOneRef(ref value);
            Console.Write(value);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] newArray = new int[] { 3, 1, 6, 2, 5};
            Assert.AreEqual(ArrayOrganiser.LowestPositiveNumber(newArray), 4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            PrintingNumbersQuiz.PrintingNumbers();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Random random = new Random();
            string[] listOfNames = { "Ben", "Tom", "Billy", "Jake", "Tim" };
            double[] list = new double[5];
            for (int i = 0; i < 5; i++)
            {
                list[i] = random.NextDouble();
            }
            Array.Sort(list, listOfNames);

            Console.WriteLine(listOfNames.ToString());
        }
    }
}
