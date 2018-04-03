using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Circle
    {

        static float _PI;
        int _radius;
        float _area;

        static Circle()
        {
            _PI = 3.14F;
        }

        public Circle(int Radius)
        {
            this._radius = Radius;
        }

        public float AreaOfCircle()
        {
            return this._area = _PI * this._radius * this._radius;
        }

    }
}
