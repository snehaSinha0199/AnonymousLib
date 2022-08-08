using ExtensionMethod;

int i = 10;
double pi = 3.14;

string str = "Ananya";
string str1 = "diksha";
String str2 = "";

bool result1 = str.Stringvowel();
Console.WriteLine(result1);

bool result2 = str1.Stringvowel();
Console.WriteLine(result2);

bool result3 = str2.Stringvowel();
Console.WriteLine(result3);

string str3 = "It is my batch..they are doing pretty well..";
int print = str3.StringCount();
Console.WriteLine(print);

int a = 10;
int b = 9;
a.EvenOddNumber();
b.EvenOddNumber();


/*bool print=i.Equal(10);
Console.WriteLine(print);

double result=pi.PiMultiply(20);
Console.WriteLine(result);

int sum=i.Add(10, 20);
Console.WriteLine(sum); */

