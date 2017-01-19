using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Behaviour_Editor
{
    public class Vector2
    {
        [XmlAttribute]
        public decimal x;
        [XmlAttribute]
        public decimal y;

        Vector2() : this(decimal.Zero, decimal.Zero) { }
        public Vector2(decimal _x, decimal _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }

    public class Rect
    {
        [XmlAttribute]
        public decimal x;
        [XmlAttribute]
        public decimal y;
        [XmlAttribute]
        public decimal z;
        [XmlAttribute]
        public decimal w;
        [XmlAttribute]
        public decimal h;

        Rect() : this(0, 0, 0, 0, 0) { }
        public Rect(decimal _x, decimal _y, decimal _z, decimal _w, decimal _h)
        {
            x = _x;
            y = _y;
            z = _z;
            w = _w;
            h = _h;
        }
    }

    public class Colour
    {
        [XmlAttribute]
        public int r;
        [XmlAttribute]
        public int g;
        [XmlAttribute]
        public int b;
        [XmlAttribute]
        public int a;

        Colour() : this(0, 0, 0, 0) { }
        public Colour(int _r, int _g, int _b, int _a)
        {
            this.r = _r;
            this.g = _g;
            this.b = _b;
            this.a = _a;
        }
    }
}
