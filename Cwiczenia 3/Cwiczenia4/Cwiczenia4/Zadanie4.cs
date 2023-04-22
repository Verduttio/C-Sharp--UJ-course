using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    class Complex<T>
    {
        private T _realPart;
        private T _imaginaryPart;

        public void setRealPart(T realPart)
        {
            this._realPart = realPart;
        }

        public void setImaginaryPart(T imaginaryPart)
        {
            this._imaginaryPart = imaginaryPart;
        }

        public T getRealPart()
        {
            return _realPart;
        }

        public T getImaginaryPart()
        {
            return _imaginaryPart;
        }
    }
}
