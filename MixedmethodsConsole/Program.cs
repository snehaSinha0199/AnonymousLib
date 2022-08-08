using MixedMethodLib;
Class1 c2 = new Class1("Sneha sinha",1023);
Class1 c3 = new Class1("Vaibhav Bhatnagar",1245);
Console.WriteLine(c2.Name +" "+ c2.Id+" "+Class1.CompanyName+" "+ Class1.Trainer);
Console.WriteLine(c3.Name+ " "+ c3.Id+" "+ Class1.CompanyName+" "+ Class1.Trainer);

int[] arr = {1,2,3,4,5 };

int CalculateArray=c3.AccessArray(arr);
Console.WriteLine("Arrays length "+CalculateArray);

Console.WriteLine("ReadOnlymethod is accessible "+Class2.ReadOnlyMethod);

string printString=Class2.ConvertIntToString(10);
Console.WriteLine("Successfully converting Int to string "+printString);


int printInt=Class2.ConvertIntToString("23");
Console.WriteLine("Converting String to Int "+printInt);

int message=Class2.ConvertIntToString("Test");
Console.WriteLine(message);

Console.Write("printing the int parameter of sum overloaded method");
Class2.sum(10, 20);

Class3 partialClass = new Class3();
    double d=partialClass.findCircumference(2);
Console.WriteLine("printing findCircumference method of partial class"+d);

/*InheritedClass childClass = new InheritedClass();
childClass.sounds("Bark");*/
