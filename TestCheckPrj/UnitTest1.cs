using Work1RPS;

namespace TestCheckPrj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal x1 = 11, y1 = 11, x2 = -3, y2 = -3, x3 = 4, y3 = 4, x4 = -25, y4 = -25;

            const string RESULT = "Отрезки накладываются друг на друга.";

            Assert.AreEqual(RESULT, AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                 ref x3, ref y3, ref x4, ref y4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            decimal x1 = 6, y1 = 7, x2 = -7, y2 = -6, x3 = 6, y3 = -8, x4 = -10, y4 = 13;

            string RESULT = "Отрезки пересекаются." + Environment.NewLine +
                            "Точка пересечения:" + Environment.NewLine +
                            "x = -0,486, y = 0,514";

            Assert.AreEqual(RESULT, AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                 ref x3, ref y3, ref x4, ref y4));
        }

        [TestMethod]
        public void TestMethod3()
        {
            decimal x1 = 0, y1 = 4, x2 = 4, y2 = 0, x3 = -5, y3 = 0, x4 = 0, y4 = -5;

            const string RESULT = "Отрезки параллельны, точек пересечения нет.";

            Assert.AreEqual(RESULT, AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                 ref x3, ref y3, ref x4, ref y4));
        }

        [TestMethod]
        public void TestMethod4()
        {
            decimal x1 = 31, y1 = 7, x2 = 8, y2 = 25, x3 = 4, y3 = -8, x4 = -27, y4 = -1.5m;

            const string RESULT = "Отрезки не пересекаются.";

            Assert.AreEqual(RESULT, AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                 ref x3, ref y3, ref x4, ref y4));
        }

        [TestMethod]
        public void TestMethod5()
        {
            decimal x1 = 380, y1 = 230, x2 = 6, y2 = 6, x3 = 6, y3 = 6, x4 = -65, y4 = -85;

            string RESULT = "Отрезки пересекаются." + Environment.NewLine +
                            "Точка пересечения:" + Environment.NewLine +
                            "x = 6,000, y = 6,000";

            Assert.AreEqual(RESULT, AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                 ref x3, ref y3, ref x4, ref y4));
        }
    }
}