namespace Functional
{
    class Functions
    {
        // Function objects must have some type. In C#, we can define either generic functions or strongly typed delegates.
        // Delegates might be recognized as a definition of function prototypes where the method signature is defined.
        // "Instance objects" of delegate types are pointers to functions (static methods, class methods) that have a
        // prototype that matches the delegate definition. An example of a delegate definition is shown in the following code:

        public delegate double MyFunc(double x);


    }
}