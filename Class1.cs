using System;

namespace DLL_File
{
    public class Class1
    {

        private int _num1 = 0;
        private int _num2 = 0;

        public void ClearResults()
        {
            _num1 = 0;
            _num2 = 0;
        }

        public int SetNum1
        {
            set
            {
                _num1 = value;
            }
            get
            {
                return _num1;
            }
        }

        public double Sum(int a, int b)
        {
            _num1 = a;
            _num2 = b;

            return _num1 + _num2;

        }

        public double Sub(int a, int b)
        {
            _num1 = a;
            _num2 = b;

            return _num1 - _num2;

        }


        public double Mul(int a, int b)
        {
            _num1 = a;
            _num2 = b;

            return _num1 * _num2;

        }

        public double Div(int a, int b)
        {
            _num1 = a;
            _num2 = b;

            return _num1 / _num2;

        }

        public double AreaofCircle(int radius)
        {
            double value1 = Math.Pow(radius, 2);
            return 3.14 * value1;

        }


        public double AreaofTriangle(int _base, int _height)
        {
            _num1 = _base;
            _num2 = _height;

            return _num1 * _num2;

        }


        public double AreaofSphere(int radius)
        {
            double value1 = Math.Pow(radius, 2);
            return 4 * 3.14 * value1;

        }

        public double VolumeaofSphere(int radius)
        {
            double value1 = Math.Pow(radius, 2);
            return (4 / 3) * (3.14 * value1);

        }


        public void PrintClassName()
        {

            Console.WriteLine("clsCalculation...Printing");

        }




    }
}


