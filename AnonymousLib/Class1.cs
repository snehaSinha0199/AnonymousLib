namespace AnonymousLib
{
    /*
     * Delegates cant be static
     * Delegates dont have constructors
     * Its a reference types
     * only public and default modifier can be used with delegates
     * it stores object in heap memory
     * delegates are type safe
     * delegates only assigned to those method which has same method signature
     * 
     */
    public delegate int Delegate2(int a, int b);
    public delegate  getName(String aName);

    public class Class1
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public class Class2
        {
            public string Name(string name)
            {
                name = name.ToLower();
            }
        }


        public enum months
        {
            jan, feb, march, april, may, june, july, august, september, october, november, december
        }
    }
}