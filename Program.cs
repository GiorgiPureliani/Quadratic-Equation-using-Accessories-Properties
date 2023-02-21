namespace Project6
{
    internal class Program
    {
        static void Main()
        {
            QuadraticEquation gantoleba = new QuadraticEquation();

            Console.Write("a = ");
            gantoleba.A = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            gantoleba.B = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            gantoleba.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"D = {gantoleba.D}");

            Console.WriteLine($"X1, X2 = {gantoleba.GetRoots()}");
        }
    }
    class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get
            {
                if (_a == 0)
                {
                    throw new Exception("a can not be set to zero");
                }
                else
                {
                    return _a;
                }
            }
            set
            {
                if (_a == 0)
                {
                    throw new Exception("a can not be set to zero");
                }
                else
                {
                    _a = value;
                }
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
            }
        }
        public double D
        {
            get
            {
                if (D < 0)
                {
                    throw new Exception("D can not be negative number");
                }
                else
                {
                    return Math.Pow(B, 2) - (4 * A * C);
                }
            }
        }
        public double? X1
        {
            get
            {
                return -B + Math.Sqrt(D) / (2 * A);
            }
        }
        public double? X2
        {
            get
            {
                return -B - Math.Sqrt(D) / (2 * A);
            }
        }
        public (double?, double?) GetRoots()
        {
            if (D >= 0 & X1 > X2)
            {
                return (X1, X2);
            }
            else
            {
                return (null, null);
            }
        }
    }
}

