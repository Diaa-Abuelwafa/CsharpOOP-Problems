namespace Demo
{
    class Program
    {
        public static void Main()
        {
            Point P1;
            // Declared Object From Type "Point" In STACK
            // Allocate #(Size of Attributes) UnInitialized Bytes
            // Attributes In Object Dont Have Default Values

            P1 = new Point();
            // new --> Just Select Constructor
            // Parameterless Constructor Will Intialized Attributes Wirh Default Values

            P1 = new Point(5, 2);
            // I Call The Constructor Which Takes Parameters
            // I Can also Call Default Constructo

            Console.WriteLine(P1); // return name of namespace
            Console.WriteLine(P1.ToString()); // return name of namespace

            // When I Override Into ToString() Function 
            Console.WriteLine(P1); // return That I Write
            Console.WriteLine(P1.ToString()); // return That I Write

            Empolyee E1 = new Empolyee();

            E1.SetId(15);
            Console.WriteLine(E1.GetId());

            E1.SetAge(24);
            Console.WriteLine(E1.GetAge());

            E1.SetSalary(20000);
            Console.WriteLine(E1.GetSalary());

            Student S1 = new Student();

            S1.Id = 100;                 // Full Property As Setter
            Console.WriteLine(S1.Id);    // Full Property As Getter

            S1.Name = "Diaa Ehab";
            Console.WriteLine(S1.Name);

            S1.Salary = 18000;
            Console.WriteLine(S1.Salary);

            Instructor I1 = new Instructor();

            I1.Id = 300;                  // Automatic Property A Setter
            Console.WriteLine(I1.Id);     // Automatic Property A Getter

            I1.Name = "Ahmed Ali";
            Console.WriteLine(I1.Name);

            I1.Salary = 19000;
            Console.WriteLine(I1.Salary);

            PhoneBook P1 = new PhoneBook(3);

            P1[0] = "Diaa";

            P1["Diaa"] = 01204838874;
            Console.WriteLine(P1["Diaa"]);

            Car C1;
            // Declare Ref At Stack
            // Can ref to object from "Car" and Any object of class which inherit from "Car"
            // Intialized Atrributes With Default Values

            C1 = new Car(1, "Mar", 2589936);
            // new --> Allocate #bytes At Heap
            // Car() --> Select Constructor
        }
    }
}