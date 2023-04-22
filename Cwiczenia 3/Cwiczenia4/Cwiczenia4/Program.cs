using System;

namespace Cwiczenia4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1
            Console.WriteLine("Zadanie 1 - Start");
            Rectangle r = new Rectangle();
            r.Height = 2;
            r.Width = 5;
            Console.WriteLine(r.GetArea());

            Square s = new Square();
            s.Height = 7;
            Console.WriteLine(s.GetArea());
            Console.WriteLine("Zadanie 1 - End\n");

            // Zadanie 2
            Console.WriteLine("Zadanie 2 - Start");
            Console.WriteLine("Kolejka przy użyciu dziedziczenia");

            QueueBad qBad = new QueueBad();
            qBad.Enqueue(1);
            qBad.Enqueue(2);
            qBad.Enqueue(3);
            qBad.Enqueue(4);

            Console.WriteLine(qBad.Dequeue());
            Console.WriteLine(qBad.Dequeue());
            Console.WriteLine(qBad.Dequeue());
            Console.WriteLine(qBad.Dequeue());

            Console.WriteLine("\nKolejka przy użyciu kompozycji");
            QueueGood qGood = new QueueGood();
            qGood.Enqueue(1);
            qGood.Enqueue(2);
            qGood.Enqueue(3);
            qGood.Enqueue(4);

            Console.WriteLine(qGood.Dequeue());
            Console.WriteLine(qGood.Dequeue());
            Console.WriteLine(qGood.Dequeue());
            Console.WriteLine(qGood.Dequeue());

            Console.WriteLine("Zadanie 2 - End\n");

            // Zadanie 3
            Console.WriteLine("Zadanie 3 jako komentarz w funkcji Main()\n");
            /* Należy utworzyć tablicę o jakimś rozmiarze zgodnym z potrzebami.
            Musimy ponadto przechowywać indeks pod którym kryje się ostatni element w kolejce.
            W chwili dodania elementu do kolejki automatycznie wędruje on na ostatnie miejsce
            w tablicy i zmienia się indeks ostatniego elementu. Podczas zdejmowania elementu z kolejki
            przesuwamy wszystkie elementy do przodu i tym samym zmieniamy indeks ostatniego elementu.
            W przypadku chęci dodania elementu do już pełnej tablicy musimy utworzyć nową o większym
            rozmiarze i przekopiować wszystkie elementy z poprzedniej tablicy.
            */

            // Zadanie 4
            Console.WriteLine("Zadanie 4 - Start");
            Complex<int> integerComplex = new Complex<int>();
            integerComplex.setRealPart(1);
            integerComplex.setImaginaryPart(2);
            Console.WriteLine($"integerComplex.getRealPart(): {integerComplex.getRealPart()}");
            Console.WriteLine($"integerComplex.getImaginaryPart(): {integerComplex.getImaginaryPart()}");

            Complex<String> stringComplex = new Complex<string>();
            stringComplex.setRealPart("ReAl ParT");
            stringComplex.setImaginaryPart("iMaGInARy PArT");
            Console.WriteLine($"stringComplex.getRealPart(): {stringComplex.getRealPart()}");
            Console.WriteLine($"stringComplex.getImaginaryPart(): {stringComplex.getImaginaryPart()}");
            Console.WriteLine("Zadanie 4 - End\n");

            // Zadanie 5
            Console.WriteLine("Zadanie 5 - Start");

            // Dodawanie
            Matrix<int> intMatrix1 = new Matrix<int>(2,3);
            Console.WriteLine("Matrix1:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    intMatrix1.setElement(i, j, (i+1) * ((j+1)%9) *((i + 1) * (j + 1) % 7) * ((i+1) % 5) * ((j+1) % 8));
            intMatrix1.Display();

            Console.WriteLine();

            Console.WriteLine("Matrix2:");
            Matrix<int> intMatrix2 = new Matrix<int>(2, 3);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    intMatrix2.setElement(i, j, (i + 4) * ((j + 2) % 13) * ((i + 4) * (j + 8) % 12) * ((i + 3) % 7) * ((j + 7) % 5));
            intMatrix2.Display();

            Console.WriteLine();

            Console.WriteLine("Matrix3:");
            Matrix<int> intMatrix3 = new Matrix<int>(3, 2);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                    intMatrix3.setElement(i, j, (i + 2) * ((j + 7) % 13) * ((i + 3) * (j + 7) % 12) * ((i + 9) % 7) * ((j + 1) % 5));
            intMatrix3.Display();


            Console.WriteLine("\nMatrix1 + Matrix2:");
            intMatrix1.Add(intMatrix2).Display();

            Console.WriteLine("\nMatrix1 + Matrix3:");
            intMatrix1.Add(intMatrix3).Display();

            Console.WriteLine();
            // Mnożenie
            Console.WriteLine("\nMatrix1 * Matrix3:");
            intMatrix1.Multiply(intMatrix3).Display();

            Console.WriteLine("\nMatrix1 * Matrix2:");
            intMatrix1.Multiply(intMatrix2).Display();  // Bedzie error, złe wymiary

            Console.WriteLine("\nMatrix4:");
            var intMatrix4 = new SquareMatrix<int>(3);
            intMatrix4.setElement(0, 0, 1);
            intMatrix4.setElement(0, 1, 0);
            intMatrix4.setElement(0, 2, 0);
            intMatrix4.setElement(1, 0, 0);
            intMatrix4.setElement(1, 1, 2);
            intMatrix4.setElement(1, 2, 0);
            intMatrix4.setElement(2, 0, 0);
            intMatrix4.setElement(2, 1, 0);
            intMatrix4.setElement(2, 2, 3);
            intMatrix4.Display();

            Console.WriteLine($"\nCzy matrix4 jest diagonalna? {intMatrix4.IsDiagonal()}");

            Console.WriteLine("Zadanie 5 - End\n");

            // Zadanie 6
            Console.WriteLine("Zadanie 6 - Start\n");
            var complexMatrix = new Matrix<Complex<String>>(2,2);
            complexMatrix.setElement(0, 0, stringComplex);
            complexMatrix.setElement(0, 1, stringComplex);
            complexMatrix.setElement(1, 0, stringComplex);
            complexMatrix.setElement(1, 1, stringComplex);
            complexMatrix.Display();
            Console.WriteLine("\nZadanie 6 - End");


            Console.ReadKey();

        }
    }
}
