namespace Assignment04
{
    internal class Program
    {
        public static int ReadFromUser(int Temp)
        {
            while (true)
            {
                Console.WriteLine("Enter The X Direction For This Point");
                bool Flag1 = int.TryParse(Console.ReadLine(), out Temp);

                if (Flag1 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter The Numeric Value For The Direction");
                }
            }

            return Temp;
        }

        static void Main()
        {
            #region First Project

            //// 2 - 
            //_3DPoint P1 = new _3DPoint(10, 10, 10);
            //Console.WriteLine(P1);

            //// 3 - 
            //int X1 = 0;
            //X1 = ReadFromUser(X1);
            //int Y1 = 0;
            //Y1 = ReadFromUser(Y1);
            //int Z1 = 0;
            //Z1 = ReadFromUser(Z1);

            //_3DPoint P2 = new _3DPoint(X1, Y1, Z1);

            //int X2 = 0;
            //X2 = ReadFromUser(X2);
            //int Y2 = 0;
            //Y2 = ReadFromUser(Y2);
            //int Z2 = 0;
            //Z2 = ReadFromUser(Z2);

            //_3DPoint P3 = new _3DPoint(X2, Y2, Z2);

            //Console.WriteLine(P2);
            //Console.WriteLine(P3);

            //// 4 -
            //// If(P1 == P2)   Does it work properly?

            //// When I Not Make A Operator Overloadin For (== & !=)
            //// It Will Compare Ref P1 By Ref P2
            //// But I Can Make Operator Overloading For (== & !=)
            //// It Will Compare Value By Value

            //_3DPoint P4 = new _3DPoint(10, 10, 10);
            //_3DPoint P5 = new _3DPoint(10, 10, 10);

            //bool Reault1 = P4 == P5;  // True
            //bool Reault2 = P4 != P5;  // false

            //// 5 -
            //_3DPoint[] Points = new _3DPoint[3];

            //Points[0] = new _3DPoint(9, 10, 17);
            //Points[1] = new _3DPoint(10, 14, 10);
            //Points[2] = new _3DPoint(15, 10, 30);

            //Array.Sort(Points);

            //for(int i = 0; i < 3; ++i)
            //{
            //    Console.WriteLine(Points[i]);
            //}

            //// 6 - 
            //_3DPoint P6 = new _3DPoint(10, 20, 30);
            //_3DPoint P7 = (_3DPoint) P6.Clone();

            //Console.WriteLine(P6);
            //Console.WriteLine(P7);

            #endregion

            #region Second Project

            //Console.WriteLine(Maths.Add(4, 3));
            //Console.WriteLine(Maths.Subtract(10, 8));
            //Console.WriteLine(Maths.Multiply(2, 4));
            //Console.WriteLine(Maths.Divide(21, 7));

            #endregion

            #region Third Project

            //// 3 -
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);

            //Console.WriteLine("=====");

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2);

            //Console.WriteLine("=====");

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3);

            //Console.WriteLine("=====");

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4);

            //// 4 -
            //// At The Duration Class

            #endregion
        }
    }
}
