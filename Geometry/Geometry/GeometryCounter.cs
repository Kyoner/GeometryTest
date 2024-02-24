namespace Geometry
{
    static class GeometryCounter
    {
        ///<summary>
        ///Count area of circle by <paramref name="radius"/>.
        ///</summary>
        public static double AreaBySides(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Raius cannot be below zero!");
            return Math.PI * Math.Pow(radius, 2);
        }
        ///<summary>
        ///Count area of circle by three sides.
        ///</summary>
        public static double AreaBySides(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Triangle sides cannot be zero or below!");
            double p = (side1 + side2 + side3) / 2;
            var preSqrtRes = p * (p - side1) * (p - side2) * (p - side3);
            if (preSqrtRes < 0)
                throw new ArgumentException("Unreal triange sides!");
            return Math.Sqrt(preSqrtRes);
        }
        ///<summary>
        ///Count area of circle by three sides, also <paramref name="isRight"/> returns true if triangle is right.
        ///</summary>
        public static double AreaBySides(double side1, double side2, double side3, out bool isRight)
        {
            var res = AreaBySides(side1, side2, side3);
            double[] tempArr = [side1, side2, side3];
            isRight = false;
            foreach (var side in tempArr)
            {
                var query = tempArr.Where(x => x != side);
                var angle = Math.Pow(query.First(), 2) + Math.Pow(query.Last(), 2) - Math.Pow(side, 2);
                if (angle == 0)
                    isRight = true;
            }
            return res;
        }
    }
}