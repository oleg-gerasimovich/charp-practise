using System;
namespace Figurs
{
    public class BaseClass
    {
        public int Circle { get; set; }

        public int Square { get; set; }

        public int Triangle { get; set; }


        public virtual void Area()
        {
            double Area = default;
        }


    }

    class Circle : BaseClass
    {
        public int _radius { get; set; }

        public double areaC { get; set; }

        public override double AreaOfCircle(double areaC)
        {
            base.Area();

            areaC = _radius * _radius * Math.PI;

            return areaC;
        }


    }

    class Square : BaseClass
    {
        private int side { get; set; }
        public int areaS = default;

        public int AreaOfSquare (int areaS)
        {
            base.Area();
            areaS = side * side;

            return areaS;
        }
    }

    class Triangle  : BaseClass
    {
        private int side { get; set; }
        public int areaT = default;

        public int AreaOfSquare(int areaT)
        {
            base.Area();
            areaT = side * side;

            return areaT;
        }
    }

}
