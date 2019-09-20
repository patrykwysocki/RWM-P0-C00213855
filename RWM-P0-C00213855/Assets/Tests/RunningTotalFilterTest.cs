using UnityEngine;
using NUnit.Framework;

namespace Tests
{
    public class RunningTotalFilterTest
    {
        [Test]
        public void RunningTotalSimple()
        {
            //Assert.IsTrue(false);

            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = RunningTotalFilter.RunningTotals(input);
            int[] expected = { 4, 6, 14, 17, 26, 30, 40, 45, 56, 62 };

            //foreach (var o in output)
            //{
            //    Debug.Log(o);
            //}

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void RunningTotalComplex()
        {
            //Assert.IsTrue(false);

            int[] input = {0,-11,9999,11};
            int[] output = RunningTotalFilter.RunningTotals(input);
            int[] expected = { 0,-11,9988,9999 };

            //foreach (var o in output)
            //{
            //    Debug.Log(o);
            //}

            CollectionAssert.AreEqual(expected, output);
        }
    }
}