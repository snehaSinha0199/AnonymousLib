using ExceptionalHandling;

Class1 c1 = new Class1();
c1 = null;
int x = int.Parse(Console.ReadLine());

int y = int.Parse(Console.ReadLine());

try
{
    /* try
     {
         c1.add(x,y);
     }
     catch (NullReferenceException e)
     {
         Console.WriteLine("its a null reference exception &" + e.Message);
     }*/
    Class1.divide(10, 0);
    Console.WriteLine("Exception raised");
}
catch (ArithmeticException ex)
{
Console.WriteLine(" its arithmetic exception &"+ex.Message);
    
    
}

finally
{
    Console.WriteLine("The finally block executed");
}