namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // *******   OOP 04 – Smart Delivery Management System **********
            //    Part 01 : Theoretical Questions   //

            #region  Question 1

            // a)  What is Abstraction in Object - Oriented Programming ?
            // Abstraction is the process of hiding the implementation details and showing
            // only the essential features of an object to the user.


            //  b)  Why is abstraction considered one of the four pillars of OOP?
            // Abstraction is considered one of the four pillars of OOP because it allows developers to create complex systems by breaking them down into simpler components. It helps in reducing complexity, improving code maintainability,
            // and enhancing reusability by focusing on the essential characteristics of objects while hiding unnecessary details.

            #endregion


            #region  Question 2

            // a)  What is the difference between an Abstract Class and an Interface?
            // 1. an Abstract class is used when related classes share common state and behavior,
            // while an Interface defines a contract or capability that different classes can implement .
            // 2. A class can inherit from only one class But can implement multiple interfaces.
            // 3. An abstract class can have both abstract and non-abstract methods,
            // while an interface can only have abstract methods (prior to C# 8.0).


            //  b)  When would you choose an Interface instead of an Abstract Class?
            // You would choose an Interface instead of an Abstract Class when you want to define a contract
            // that multiple unrelated classes can implement. Interfaces are useful for achieving polymorphism and
            // allowing different classes to share common behavior without enforcing a specific class hierarchy.
            // If you need to provide default implementations or share state, an abstract class may be more appropriate.


            // c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // No, a class cannot inherit from multiple abstract classes in C#. C# supports single inheritance for classes.
            // However, a class can implement multiple interfaces.

            #endregion
        }
    }
}
