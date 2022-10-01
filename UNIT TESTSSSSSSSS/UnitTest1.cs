 using NUnit.Framework;
using Unit_Tests;

namespace UNIT_TESTSSSSSSSS
{
    public class Tests : Cu_cu_lator
    {
        [Test]
        public void Sum_test()
        {
            Cu_cu_lator cu_cu_lator = new Cu_cu_lator();
            int first = 2;
            int second = 2;
            double xpen = 4;

            sum();
            Assert.AreEqual(answ, xpen);
        }
        [Test]
        public void Min_test()
        {
            Cu_cu_lator cu_cu_lator = new Cu_cu_lator();
            int first = 2;
            int second = 1;
            int xpen = 1;

            min();
            Assert.AreEqual(answ, xpen);
        }
        [Test]
        public void Umn_test()
        {
            Cu_cu_lator cu_cu_lator = new Cu_cu_lator();
            int first = 2;
            int second = 2;
            int xpen = 4;

            umn();
            Assert.AreEqual(answ, xpen);
        }
        [Test]
        public void Del_test()
        {
            Cu_cu_lator cu_cu_lator = new Cu_cu_lator();
            int first = 4;
            int second = 2;
            int xpen = 2;

            del();
            Assert.AreEqual(answ, xpen);
        }
        [Test]
        public void Step_test()
        {
            Cu_cu_lator cu_cu_lator = new Cu_cu_lator();
            int first = 3;
            int second = 2;
            int xpen = 9;

            step();
            Assert.AreEqual(answ, xpen);

        }


    }
}