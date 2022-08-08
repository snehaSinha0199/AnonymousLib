namespace MixedMethodLib
{
    //Class1
    public class Class1 //instance class
    {
        public static int[] arr; //its s static field but we can access in instance class.

        public int AccessArray(int[] arr)
        {
            return arr.Length;
        }
        public string Name;
        public int Id;
        public const string CompanyName = "Global Logic"; //constatnts cannot be marked as static
        public const string Trainer = "Rajeev sir";
        public Class1(String name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public Class1(int[] arr)
        {
            //static members cannot be instantiated inside Constructors. 

        }
        public Class1() { }

    }
    //Class2
    public static class Class2 { //static class
        //  public string getName { get; }  cannot declare instance member in static class

        public static string getName { get; set; } // we can make read and write only both

        public static readonly int ReadOnlyMethod;

        // public  static  Class2(){ } cant have public access modifier with static constructor
        //static Class2(int a) { } static constructors cant have parameters
        static Class2()
        {
            ReadOnlyMethod = 0;
        }
        // static Class2(int a) { } cant override the static constructors because it cant take parameters and we
        //can overload the constructors on the basis of order type and numnber of parameters
        public static string ConvertIntToString(int a)
        {
            string result = a.ToString();
            return result;
        }
        public static int ConvertIntToString(string str) // static methods overloading is possible
        {
            int result = 0;
            
               try
               {

                result = Int32.Parse(str);
            }
               catch(Exception e)
               {
                Console.WriteLine("Dont pass string!! Plz give the numbers so that can be converted into integers.");
               }
            return result;
        }
        /*  public static sealed double ConvertIntToString(int a, int b)
          {
              double d = a + b;
              return double;
          }
         sealed methods cant be applied with overloading as sealed methods breaks the inheritance chain so it goes
        with method overriding.
        */

        //  public virtual static void animal() { Console.WriteLine("Sounds of animals") }
        //  static member cannot be virtual

        public static void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void sum(long a, long b)
        {
            Console.WriteLine(a * b);
        }
    }


   public partial class Class3{
        public const double pi = 3.14;
        public virtual partial double findCircumference(int radius); //partial methods
      
}
public partial class Class3
    {
        //here i am using virtual as well because its a partial class so
        // here all the methods is inside the class due to partial keyword so i cant override these virtual
        //methods inside the class itself
        public virtual partial double findCircumference(int radius) {
            return 2 * pi* radius * radius; //here pi is accessible because its a single class ultimately
        }
}
    public class Class4 : Class3
    {
        public override double findCircumference(int radius)
        {
            return base.findCircumference(radius);
        }
        //that why inheriting the class and overriding it here
    }
      
    public abstract class AbstractClass
    {
        public abstract void sounds(string sound);
        public string animal()
        {
            return "Animal sounds";
        }
    }
    public class InheritedClass : AbstractClass
    {
        public override void sounds(string sound)
        {
            Console.WriteLine(this.animal()+ sound);
        }
         
    }
}