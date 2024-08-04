using Demo;

namespace Assignment04OOP
{
    internal class Program
    {
        public static void Main()
        {
            #region Abstract Keyword

            // Abstract Class
            // This is A Class Cannot Create Object From It
            // I Can Inherit From It
            // It Contains One Or More Abstract Methods Or Property
            // It Can Contains A Non-Static Methods
            // I Can Create Reference From It But Not Object

            // Abstract Method Or Property ==> When I Cannot Put Implementation For This
            // I Cannot Use Abstract Keyword With Attributes

            //Creature C = new Human();        // Valid
            //// Creature C = new Creature     // InValid

            //C.Move();                     // Move For Human
            //double _Length = C.Length;    // Length For Human

            #endregion

            #region Operatir Overloading

            //Complex C1 = new Complex(2, 3);
            //Complex C2 = new Complex(4, 6);

            //Complex C3 = C1 + C2;
            //Console.WriteLine(C3);

            //Complex C4 = C1 - C2;
            //Console.WriteLine(C4);

            //Complex C5 = new Complex(4, 6);
            //C5++;
            //++C5;
            //Console.WriteLine(C5);

            //Complex C6 = new Complex(9, 5);
            //C6--;
            //--C6;
            //Console.WriteLine(C6);

            //Complex C7 = new Complex(5, 6);
            //Complex C8 = new Complex(4, 3);

            //Console.WriteLine(C7 > C8);
            //Console.WriteLine(C7 < C8);
            //Console.WriteLine(C7 <= C8);
            //Console.WriteLine(C7 <= C8);
            //Console.WriteLine(C7 == C8);
            //Console.WriteLine(C7 != C8);

            //Complex C9 = new Complex(11, 12);
            //int Temp1 = C9;
            //// I Make A Casting Operator Overloading Implicity From Complex To Integer
            //Console.WriteLine(Temp1);

            //Complex C10 = new Complex(14, 12);
            //string Temp2 = (string)C10;
            //// I Make A Casting Operator Overloading Explicity From Complex To String
            //Console.WriteLine(Temp2);

            #endregion

            #region Static Keyword

            //// Static Class
            //// I Cannot Create Object From It
            //// It Cannot Contains A Non-Static Members
            //// It Become A Helper Class
            //// I Access Members By Name Of Class

            //// Static Method
            //// This Is The Function That Not Related To Object From The Class But It Related To The Class
            //// Changing Of Object Not Effect The Static Method Behavior

            //// Static Property Or Attribute
            //// This Is The Property That Not Related To Object From The Class But It Related To The Class
            //// Changing Of Object Not Effect The Static Property Behavior

            //// Static Constructor Called Before The Constructor Of Class Is Called
            //// Static Construcor Called Only Once When The Class Is Loaded At Memory
            //int Result1 = MathHelper.Sumition(5, 6);
            //double Result2 = MathHelper.SQRT(8);
            //double Result3 = MathHelper.PI;

            #endregion

            #region Sealed Keyword

            // Sealed Class
            // This Is Class Cannot Inherit From It

            // Sealed Method 
            // Function To Be Sealed Must Be Override
            // Function I Cannot Override It
            // It Stop The Sequence Override For The Child Classes

            // Sealed Property 
            // Property To Be Sealed Must Be Override
            // Property I Cannot Override It

            #endregion
        }
    }
}