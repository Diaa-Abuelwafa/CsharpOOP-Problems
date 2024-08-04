using System.Text;

namespace Demo
{
    internal class Program
    {
        public static void SeriasByTwoFun(ISerias S)
        {
            S.Current = 0;

            for(int i = 0; i < 10; ++i)
            {
                Console.Write($"{S.Current} ");
                S.PlusCurrent();
            }

            S.Reset();
        }
        public static void Main()
        {
            #region Interface

            //// Default Access Modifier Of Interface --> Internal
            //// Default Access Modifier Inside Interface --> Public

            //// Inside Interface Can Write All Access Modifiers Except 'Private'
            //// But I Can Use 'Private' With Default Implemented Method

            //// Name Convension For Interface --> IInterfaceName

            //// What Can Write Inside Interface
            //// 1 - Signature Of Property
            //// 2 - Signture Of Method
            //// 3 - Default Implemented Method


            //IMyType MyType;
            //// CLR Will Allocate 8 or 4 Bytes At STACK For This Reference
            //// This Reference Refer To NULL
            //// This Reference Can Refer To Object From Class Or Struct That Implemented The Interface

            ////MyType.ID          ==> InValid Because Reference Refer To NULL
            ////MyType.Dispaly()   ==> InValid Because Reference Refer To NULL and This Function Not Implemented
            ////MyType.Print       ==> InValid Because Reference Refer To NULL

            //Employee E = new Employee();

            //E.ID = 10;
            //E.Display();
            //// E.Print();        ==> InValid Because I Cannot Access Default Implemented Method By Object From Class That Implement The Interface

            //MyType = new Employee();
            //MyType.ID = 100;
            //MyType.Display();
            //MyType.Test(10);
            //MyType.Print();   // I Can Access Default Implemented Method By Reference Of Interface Refer To The Class That Implement The Interface

            #endregion

            #region Interface Ex01

            //SeriasByTwo S1 = new SeriasByTwo();

            //SeriasByTwoFun(S1);

            //SeriasByFour S2 = new SeriasByFour();

            //SeriasByTwoFun(S2);

            #endregion

            #region Interface Ex02

            //Car C = new Car();
            //C.Backward();
            //C.Left();

            //Airplane A = new Airplane();

            //ImoveGround X = new Airplane();  // When I Need To Access Members Related To Ground
            //IMoveFly Y = new Airplane();     // wHEN I Need To Access Members Related To Fly

            #endregion

            #region Shallow Copy & Deep Copy With Array Of Int

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[3];

            //Console.WriteLine($"Before Shallow Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"Before Shallow Copy {arr2.GetHashCode()}"); // 18643596

            //// Shallow Copy Because I Just Equaled Ref By Ref
            //arr2 = arr1;

            //Console.WriteLine($"After Shallow Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"After Shallow Copy {arr2.GetHashCode()}"); // 54267293

            //// Deep Copy Because I Create New Object And Copy Object State
            //arr2 = (int[])arr1.Clone();

            //Console.WriteLine($"After Deep Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"After Deep Copy {arr2.GetHashCode()}"); // 33574638

            //arr1[0] = 5;

            //Console.WriteLine(arr1[0]); // 5
            //Console.WriteLine(arr2[0]); // 1

            #endregion

            #region Shallow Copy & Deep Copy With Array Of String

            //string[] arr1 = { "Diaa", "Ahmed", "Ali" };
            //string[] arr2 = new string[3];

            //Console.WriteLine($"Before Shallow Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"Before Shallow Copy {arr2.GetHashCode()}"); // 18643596

            //// Shallow Copy
            //arr2 = arr1;

            //Console.WriteLine($"After Shallow Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"After Shallow Copy {arr2.GetHashCode()}"); // 54267293

            //arr1[0] = "Hassan";

            //Console.WriteLine(arr1[0]);  // Hassan
            //Console.WriteLine(arr2[0]);  // Hassan

            //// Deep Copy
            //arr2 = (string[])arr1.Clone();

            //Console.WriteLine($"After Deep Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"After Deep Copy {arr2.GetHashCode()}"); // 33574638

            //arr1[0] = "Mazen";

            //Console.WriteLine(arr1[0]);  // Mazen
            //Console.WriteLine(arr2[0]);  // Hassan


            #endregion

            #region shallow Copy & Deep Copy With Array Of StringBuilder

            //StringBuilder[] arr1 = new StringBuilder[3];
            //arr1[0] = new StringBuilder("Diaa");
            //arr1[1] = new StringBuilder("Ahmed");
            //arr1[2] = new StringBuilder("Ali");
            //StringBuilder[] arr2 = new StringBuilder[3];

            //Console.WriteLine($"Before Shallow Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"Before Shallow Copy {arr2.GetHashCode()}"); // 18643596

            //arr2 = arr1;

            //Console.WriteLine($"After Shallow Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"After Shallow Copy {arr2.GetHashCode()}"); // 54267293

            //arr1[0].Append(" Ehab");

            //Console.WriteLine(arr1[0]);  // Diaa Ehab
            //Console.WriteLine(arr2[0]);  // Diaa Ehab

            //arr2 = (StringBuilder[])arr1.Clone();

            //Console.WriteLine($"After Deep Copy {arr1.GetHashCode()}"); // 54267293
            //Console.WriteLine($"After Deep Copy {arr2.GetHashCode()}"); // 33574638

            //arr2[0].Append(" Abuelwafa");

            //Console.WriteLine(arr1[0]);  // Diaa Ehab Abuelwafa
            //Console.WriteLine(arr2[0]);  // Diaa Ehab Abuelwafa

            #endregion

            #region Clone Using Interface 'IClonable' With String

            //Instructor I1 = new Instructor() { ID = 100, Name = "Diaa", Salary = 18000};

            //Instructor I2 = (Instructor)I1.Clone();

            //Console.WriteLine($"After Deep Copy I1 = {I1.GetHashCode()}"); 
            //Console.WriteLine($"After Deep Copy I2 = {I2.GetHashCode()}"); 

            //I1.Name = "Ahmed";

            //Console.WriteLine(I1.Name);  
            //Console.WriteLine(I2.Name);  

            #endregion

            #region Clone Using Interface 'IClonable' With StringBuilder

            //Instructor I1 = new Instructor { ID = 100, Name = new StringBuilder("Diaa"), Salary = 18000 };
            //Instructor I2 = (Instructor)I1.Clone();

            //I1.Display();
            //I2.Display();

            //I1.Name.Append(" Ehab");

            //I1.Display();   // Diaa Ehab
            //I2.Display();   // Diaa Ehab

            //// Because When I Change StringBuilder No Object Will Created

            #endregion

            #region Clone Using Copy Constructor

            //Instructor I1 = new Instructor() { ID = 100, Name = "Diaa", Salary = 18000 };
            //Instructor I2 = new Instructor(I1);

            //I1.Display();
            //I2.Display();

            //// Or

            //Instructor I3 = new Instructor() { ID = 100, Name = "Diaa", Salary = 18000 };
            //Instructor I4 = new Instructor();

            //I4 = (Instructor)I1.Clone();

            //I1.Display();
            //I2.Display();


            #endregion

            #region Built-In Interface 'IComparable'

            //Instructor[] Arr = new Instructor[3];

            //Arr[0] = new Instructor() { ID = 10, Name = "Diaa", Salary = 18000 };
            //Arr[1] = new Instructor() { ID = 20, Name = "Ahmed", Salary = 17000 };
            //Arr[2] = new Instructor() { ID = 30, Name = "Ali", Salary = 9000 };

            //Array.Sort(Arr);   // Sort Will Use CompareTo Function Which I Implement Ir

            //foreach(Instructor I in Arr)
            //{
            //    Console.WriteLine(I);
            //}

            #endregion

            #region Built-In Interface 'IComparer'

            //Instructor[] Arr = new Instructor[3];

            //Arr[0] = new Instructor() { ID = 10, Name = "Diaa", Salary = 18000 };
            //Arr[1] = new Instructor() { ID = 20, Name = "Ahmed", Salary = 17000 };
            //Arr[2] = new Instructor() { ID = 30, Name = "Ali", Salary = 9000 };

            //Array.Sort(Arr, new CompareInstructorById());

            //foreach(Instructor I in Arr)
            //{
            //    Console.WriteLine(I);
            //}

            #endregion

        }
    }
}