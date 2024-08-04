namespace Demo
{
    internal class Program
    {
        public static void MoveAndDoThings(Creature C)
        {
            C.Move();
        }
        public static void Main()
        {
            #region Realationships And Inheritance
            //// Relationships Between Classes
            //// 1 - Association --> ClassA Use Object From ClassB
            //// 2 - Aggregation --> ClassA Contains Object From ClassB
            //// 3 - Composition --> ClassA Consists Of Object From ClassB
            //// 4 - Inheritance --> Is A Relationship

            //// 1 - Association
            //Board B = new Board();
            //// Here I create Object From 'Board' Without Need To Create Object From 'Marker'
            //// So This Relationship Is [Association]

            //// 2 - Aggregation
            //Room R = new Room();
            //Chair Ch = new Chair();
            //R.Ch = Ch;
            //// Here I Use Object From 'Chair' In Class Room As Attribute
            //// So This Relationship Is More Strong Than Association
            //// But Class Room Can Created Without Need To Create Class Chair
            //// So This Relationship Is [Aggregation]

            //// 3 - Composition
            //Book Book = new Book();
            //// Here Class Book Consists Of Class Page 
            //// Object From Class Page Is A Main Component Of Class Book
            //// Creation Object From Class Page Accour At Class Book
            //// Class Book Must Consists Of Object From Class Page
            //// So This Relationship Is [Composition]

            //// 4 - Inheritance
            //// ClassB Inherit From ClassA
            //// This Mean ClassB Contain All Public Members Of ClassA
            //// ClassB Access Public Members Of ClassA Only
            //// Object From ClassB Access Public Members Of ClassA Only
            //// Protected Access Modifier : Can Access In The Same Class
            ////                           : Can Access In The Inherited Class
            //// When I Create Object From Child Class Compiler Will Created Object From
            //// Parent Class And Hidden Ref From Parent Class 
            //// Called [Base] Refer To This Object Of Parent Class
            //Creature C = new Creature();
            //C.Move();
            //Human H = new Human();
            //H.Move();
            //Animal A = new Animal();
            //A.Move(); 
            #endregion

            #region Polymorphism

            //Creature C = new Creature();
            //C = new Human();
            //// Here I See This Object As Creature Not Human
            //// So I Can Access Only The Creature Members

            //// When I Make Function 'Move' At Creature --> Virtual
            //// And Override It At Human Or Animal
            //// So When I Make Binding I Call Function Based On Type Of Object
            //C.Move();  // Execute The Function 'Move' At Human 

            //Creature C1 = new Creature();  // Binding
            //Creature C2 = new Human();     // Binding
            //Creature C3 = new Animal();    // Binding

            //MoveAndDoThings(C1);   // Valid And Execute Based On Type Of Object 
            //MoveAndDoThings(C2);   // Valid And Execute Based On Type Of Object
            //MoveAndDoThings(C3);   // Valid And Execute Based On Type Of Object

            //Creature C4 = new Employee();
            //C4.Move();
            // When Function 'Move' At Creature Is Virtual
            // So Call The Override Function At Empolyee
            // IF At Empolyee Not Override
            // So Will Call The Closer Function --> At Human

            //TypeA TypeA1 = new TypeA(1);                // Binding
            //TypeA TypeA2 = new TypeB(1, 2);             // Binding
            //TypeA TypeA3 = new TypeC(1, 2, 3);          // Binding
            //TypeA TypeA4 = new TypeD(1, 2, 3, 4);       // Binding

            //TypeA1.Fun01();    // Early Binding [Using New] Based On Reference Type At Compilation Time
            //TypeA1.Fun02();    // Late Binding  [Using Override] Based On Type Of Object At Run Time

            #endregion

            #region Protected & Internal Protected & Private Protected

            // Protected
            // Access At The Same class or Classes derived from Parent Class.

            // Internal Protected
            // Access At Any Class At The Same Project or types derived from the containing class.

            // Private Protected
            // Access In The Same Class or types derived from the containing class within the current Project
        #endregion
    }
    }
}