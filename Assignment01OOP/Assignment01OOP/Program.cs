namespace Assignment01
{
    internal class Program
    {
        static void Main()
        {
            #region Part01

            // 1 - Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point2D P1 = new Point2D();
            //P1.X = int.Parse(Console.ReadLine());
            //P1.Y = int.Parse(Console.ReadLine());

            //Point2D P2 = new Point2D();
            //P2.X = int.Parse(Console.ReadLine());
            //P2.Y = int.Parse(Console.ReadLine());

            //int Distance = Math.Abs(P1.X - P2.X);

            //Console.WriteLine(Distance);

            // 2 - Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person P1 = new Person();

            //P1.Name = Console.ReadLine();
            //P1.Age = int.Parse(Console.ReadLine());

            //Person P2 = new Person();

            //P2.Name = Console.ReadLine();
            //P2.Age = int.Parse(Console.ReadLine());

            //Person P3 = new Person();

            //P3.Name = Console.ReadLine();
            //P3.Age = int.Parse(Console.ReadLine());

            //int OldAge = Math.Max(P1.Age, Math.Max(P2.Age, P3.Age));

            //if (OldAge == P1.Age)
            //{
            //    Console.WriteLine(P1.Name);
            //    Console.WriteLine(P1.Age);
            //}
            //else if (OldAge == P2.Age)
            //{
            //    Console.WriteLine(P2.Name);
            //    Console.WriteLine(P2.Age);
            //}
            //else if (OldAge == P3.Age)
            //{
            //    Console.WriteLine(P3.Name);
            //    Console.WriteLine(P3.Age);
            //}

            #endregion

            #region Part02

            // 1 - Design and implement a Class for the employees in a company

            // In Empolyee Class File

            // 2 - Develop a Class to represent the Hiring Date Data

            // In HireDate Class File

            // 3 - Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions

            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, 18000, "Diaa", DateOnly.Parse("2024-10-26"));
            EmpArr[1] = new Employee(2, 20000, "Ahmed", DateOnly.Parse("2019-10-26"));
            EmpArr[2] = new Employee(3, 7000, "Ali", DateOnly.Parse("2024-9-26"));

            int Temp = EmpArr[0].HireDate.CompareTo(EmpArr[1].HireDate);

            Console.WriteLine(Temp);

            if(Temp == 0)
            {
                // Date 1 is before Date 2
            }


            if(Temp == 1)
            {
                // Date 1 is After Date 2
            }
            #endregion
        }
    }
}
