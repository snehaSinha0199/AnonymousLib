using AnonymousLib;

Delegate2 del = delegate(int a,int b){
    return a + b;
};
int result = del.Invoke(10, 20);
Console.WriteLine(result);

Console.WriteLine("The number of the month " + (int)(months.jan+1));
Console.WriteLine("The number of the month " + (int)(months.october + 1));
Console.WriteLine("The number of the month " + (int)(months.december + 1));
Console.WriteLine("The number of the month " + (int)(months.august + 1));