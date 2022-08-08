namespace ExtensionMethod
{
    

    public static class ExtensionClass //extension methods Classes must have static class
    {
     //  static int i = null; cannot assign null
       static int? l = null; //nullable the value types 

     static   Object o = l;
     static   int k = (int)o;
        public static int Add(this int a,int b,int c) //must have static methods
        {
            return a + b + c;
        }
        public static double PiMultiply(this double pi, int b)
        {
            return pi*b;
        }
        public static bool Equal(this int a, int b)
        {
            return a == b;
        }
         public static bool Stringvowel(this string str)
        {
            bool result=false;
            
           
            if (str.Length == 0 )
            {
                Console.WriteLine("Empty String");
            }
           else if (str.StartsWith('a') || str.StartsWith('A'))
            {
                result = true;
            }
            else  {
                result = false;
            }
            return result;
       
        }
        public static int StringCount(this string str)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string lowerCase = str.ToLower();
                    if (str[i] == 'a')
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }
        public static void EvenOddNumber(this int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} "+" is even number",a);
            }
            else
            {
                Console.WriteLine("{0} " +" is odd number",a);
            }
        }
    }
}

