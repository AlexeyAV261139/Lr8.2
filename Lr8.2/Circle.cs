using System;

namespace Lr8._2
{
    internal class Circle
    {
		private double radius;

		public double Radius
		{
			get { return radius; }
			set { radius = Math.Abs(value); }
		}

		public Circle(double radius) { Radius = radius; }

		public virtual double Square()
		{
			return Math.PI * Math.Pow(radius, 2);		
		}

		public double CircleLenght()
		{
			return 2 * Math.PI * radius;
		}

		public virtual bool PointAffiliation(double x, double y)
		{
			if (radius - Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)) > 0.01) return true ;
			else return false ;
		}
	}
}
