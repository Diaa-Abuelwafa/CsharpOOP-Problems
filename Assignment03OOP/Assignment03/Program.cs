namespace Assignment03
{
    internal class Program
    {
        static void Main()
        {
            #region Part 01

            // 1 - What is the primary purpose of an interface in C#?

            // Ans : b) To define a blueprint for a class

            // 2 - Which of the following is NOT a valid access modifier for interface members in C#?

            // Ans : a) private

            // 3 - Can an interface contain fields in C#?

            // Ans : b) No

            // 4 - In C#, can an interface inherit from another interface?

            // Ans : b) Yes, interfaces can inherit from multiple interfaces

            // 5 - Which keyword is used to implement an interface in a class in C#?

            // Ans : d) implements

            // 6 - Can an interface contain static methods in C#?

            // Ans : b) No

            // 7 - In C#, can an interface have explicit access modifiers for its members?

            // Ans : b) No, all members are implicitly public

            // 8 - What is the purpose of an explicit interface implementation in C#?

            // Ans : b) To provide a clear separation between interface and class members

            // 9 - In C#, can an interface have a constructor?

            // Ans : b) No, interfaces cannot have constructors

            // 10 - How can a C# class implement multiple interfaces?

            // Ans : c) By separating interface names with commas

            #endregion

            #region Part 02

            #region Q1

            // Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

            //Circle C = new Circle() { Area = 14.9 };
            //Rectangle R = new Rectangle() { Area = 17.3 };

            //C.DisplayShapeInfo();

            //Console.WriteLine("======================");

            //R.DisplayShapeInfo();

            #endregion

            #region Q2

            // Q2

            //IAuthenticationService AuthService = new BasicAuthenticationService("Diaa", 123, "HR");

            //Console.WriteLine(AuthService.AuthenticateUser("Diaa", 1478));
            //Console.WriteLine(AuthService.AuthorizeUser("Diaa", "HR"));

            #endregion

            #region Q3

            // Q3

            //EmailNotificationService E = new EmailNotificationService();
            //SmsNotificationService S = new SmsNotificationService();
            //PushNotificationService P = new PushNotificationService();

            //E.SendNotification("Diaa", "Iam Comming");
            //S.SendNotification("Diaa", "Iam Comming");
            //P.SendNotification("Diaa", "Iam Comming");

            #endregion

            #endregion

            #region Task Required

            // Q : Why Function Clone Make Shallow Copy

            // Ans:
            // Because If The Array Has Objects And This Objects Has A References
            // The Clone Function Will Copy The References So It Called A Shallow Copy

            #endregion
        }
    }
}
