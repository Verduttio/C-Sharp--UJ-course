using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    class Square
    {
        public virtual int Height { get; set; }

        public virtual int GetArea()
        {
            return Height * Height;
        }
    }


    class Rectangle : Square
    {
        public virtual int Width { get; set; }

        public override int GetArea()
        {
            return Height * Width;
        }

    }




}
