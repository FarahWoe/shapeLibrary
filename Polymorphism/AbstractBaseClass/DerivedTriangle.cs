using System;
using System.Collections.Generic;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass
{
    class DerivedTriangle: AbstractShape
    {
        private int _pointX;
        private int _pointY;
        DerivedTriangle(int pointX, int pointY, int x, int y):base(x, y) {
            this._pointX = pointX;
            this._pointY = pointY;
        }

        public override double GetPerimeter()
        {
            return 23.98;
        }

        public override double GetArea()
        {
            return 45.2;
        }

        public override void PrintShapeType()
        {
            Console.WriteLine("Hi There I'm a Triangle");
        }
    }
}
