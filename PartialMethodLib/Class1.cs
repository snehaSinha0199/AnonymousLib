namespace PartialMethodLib
{
    public partial class Class1
    {
        //   public partial int Add(int a, int b);  cant have instance method inside static class
        public partial int Substract(int a, int b);
        public partial int add(int a, int b);

    }

    public partial class Class1
    {
        public partial int Add(int a, int b)
        {
            return a+b;
        }
        public partial int Substract(rint a,int b)
        {
            return a - b;
        }
    }
}