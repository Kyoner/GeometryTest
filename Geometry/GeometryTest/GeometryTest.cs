using Geometry;
namespace GeometryTests
{
    [TestClass]
    public class GeometryTest
    {
        #region Circle Test
        [TestMethod]
        [DataRow(2, 12.57)]
        [DataRow(3.2, 32.17)]
        public void AreaBySides_CircleAreaByRadius_EqualAroundResult(double radius, double result)
        {
            double res = GeometryCounter.AreaBySides(radius);

            Assert.AreEqual(result, Math.Round(res, 2));
        }
        [TestMethod]
        [DataRow(-2)]
        [DataRow(-4.2)]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaBySides_NegativeRadius_ThrowArgEx(double radius)
        {
            double result = GeometryCounter.AreaBySides(radius);
        }
        #endregion

        #region Triange Test
        [TestMethod]
        [DataRow(2, 3, 3, 2.83)]
        [DataRow(3.2, 5.1, 4.9, 7.56)]
        public void AreaBySides_TriangleAreaBySides_ReturnAroundResult(double side1, double side2, double side3, double result)
        {
            double res = GeometryCounter.AreaBySides(side1, side2, side3);

            Assert.AreEqual(result, Math.Round(res, 2));
        }
        [TestMethod]
        [DataRow(5, 3, 4, true)]
        [DataRow(3, 5, 3, false)]
        public void AreaBySides_TriangleRightCheck_OutResult(double side1, double side2, double side3, bool result)
        {
            double res = GeometryCounter.AreaBySides(side1, side2, side3, out bool isRight);

            Assert.AreEqual(result, isRight);
        }
        [TestMethod]
        [DataRow(-2, 3, -3)]
        [DataRow(3.2, -5.1, 4.9)]
        [ExpectedException(typeof(ArgumentException))]

        public void AreaBySides_TriangleAreaByNegativeSides_ThrowAgrEx(double side1, double side2, double side3)
        {
            double res = GeometryCounter.AreaBySides(side1, side2, side3);
        }
        [TestMethod]
        [DataRow(2, 3, 6)]
        [DataRow(9.5, 1.1, 4.9)]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaBySides_TriangleAreaByUnrealSides_ThrowAgrEx(double side1, double side2, double side3)
        {
            double res = GeometryCounter.AreaBySides(side1, side2, side3);
        }
        #endregion
    }
}