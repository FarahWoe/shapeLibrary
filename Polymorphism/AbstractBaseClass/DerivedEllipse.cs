using System;
using System.Collections.Generic;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.AbstractBaseClass
{
    class DerivedEllipse : AbstractShape
    {
        private int _brennpkt1;
        private int _brennpkt2;

        public DerivedEllipse(int brennpkt1, int brennpkt2, int x, int y) : base(x,y) {
            this._brennpkt1 = brennpkt1;
            this._brennpkt2 = brennpkt2;
            }
    }
}
