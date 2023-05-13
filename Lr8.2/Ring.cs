using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr8._2
{
    internal class Ring : Circle
    {
        private double externalRadius;

        public double ExternalRadius
        {
            get { return externalRadius; }
            set { externalRadius = value; }
        }

        public Ring(double radius, double externalRadius) : base(radius) { ExternalRadius = externalRadius; }

        public override double Square()
        {
            return (Math.PI * Math.Pow(externalRadius,2)) - base.Square() ;
        }
        public override bool PointAffiliation(double x, double y)
        {            
            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) - Radius > 0.0000001 &
                externalRadius - Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 0.0000001) return true;
            else return false;
        }
        
    }
}
