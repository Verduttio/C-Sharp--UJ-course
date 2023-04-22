using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    class Matrix<T>
    {
        protected T[,] _array;
        protected int _rows;
        protected int _columns;
        protected ICalculator<T> _calculator;

        public Matrix(int rows, int columns)
        {
            _array = new T[rows, columns];
            this._rows = rows;
            this._columns = columns;
            _calculator = Calculators.GetInstance<T>();
        }


        public void setElement(int row, int column, T element)
        {
            _array[row, column] = element;
        }

        public Matrix<T> Add(Matrix<T> matrix)
        {
            if((matrix._rows != this._rows) || (matrix._columns != this._columns))
            {
                Console.WriteLine("Nie można wykonać dodawania gdyż macierze nie mają takich samych wymiarów");
                Console.WriteLine("Zostanie zwrócona pierwsza macierz");
                return this;
            }

            Matrix<T> result = new Matrix<T>(_rows, _columns);

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    result._array[i, j] = _calculator.Add(matrix._array[i, j], this._array[i, j]);
                }
            }


            return result;
        }

        public Matrix<T> Multiply(Matrix<T> matrix)
        {
            if(this._columns != matrix._rows)
            {
                Console.WriteLine("Nie można wykonać mnożenia. Liczba kolumn pierwszej macierzy " +
                    "nie równa się liczbie kolumn drugiej macierzy");
                Console.WriteLine("Zostanie zwrócona pierwsza macierz");
                return this;
            }

            Matrix<T> result = new Matrix<T>(this._rows, matrix._columns);
          /*  for (int i = 0; i < result._rows; i++)
                for (int j = 0; j < result._columns; j++)
                    result._array[i, j] = 0;*/

            for(int i = 0; i < result._rows; i++)
            {
                for(int j = 0; j < result._columns; j++)
                {
                    for(int k = 0; k < this._columns; k++)
                    {
                        result._array[i, j] = _calculator.Add(result._array[i, j], _calculator.Multiply(this._array[i, k], matrix._array[k, j]));
                    }
                }  
            }




            return result;

        }

        public T getElement(int row, int column)
        {
            return _array[row, column];
        }

        public void Display()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                    Console.Write($"{_array[i, j]} ");
                Console.WriteLine();
            }

        }
    }


    class SquareMatrix<T> : Matrix<T>
    {
        public SquareMatrix(int size) : base (size, size) { }

        public bool IsDiagonal()
        {
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _columns; j++)
                    if (i != j)
                        if (!_calculator.EqualsZero(_array[i, j]))
                            return false;
            return true;
        }
        
    }

}
