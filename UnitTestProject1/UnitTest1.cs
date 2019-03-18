using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary5;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThreeElements()
        {
            var array = new int[] { 10, 34, 2 };
            Class1.QuickSort(array);

            for (int i = 0; i < array.Length - 1; i++)
                Assert.IsTrue(array[i] <= array[i + 1]);
        }

        [TestMethod]
        public void OneHundredElements()
        {
            var array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 56;
            }

            Class1.QuickSort(array);

            for (int i = 0; i < 99; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }

        [TestMethod]
        public void OneThousandElements()
        {
            var rnd = new Random(56);

            var array = new int[1000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            Class1.QuickSort(array);

            for (int j = 0; j < 10; j++)
            {
                int e, w;

                do
                {
                    e = rnd.Next(0, 999);
                    w = rnd.Next(0, 999);
                } while (e >= w);

                Assert.IsTrue(array[e] < array[w]);
            }
        }


        [TestMethod]
        public void EmptyArray()
        {
            var array = new int[] { };

            Class1.QuickSort(array);
            Assert.AreEqual(0, array.Length);
        }

        [TestMethod]
        public void ManyElements()
        {
            var array = Class1.GenerateArray(150000000);
            Class1.QuickSort(array);

            for (int i = 0; i < 150000000 - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }
    }
}
