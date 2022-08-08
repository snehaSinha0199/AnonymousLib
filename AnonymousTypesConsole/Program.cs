// possible values for the var keyword object
//try to create simple anonymous type object
//try to create another anonymous type object and create dynamic properties inside {}
//try to create nested types
//try to create anonymous type array
//try to create anonymous type array with nested types.
namespace AnonymousTypes
{
    public class AnonymousClass
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Student(int IdParam, string NameParam)
            {
                this.Id = IdParam;
                this.Name = NameParam;
            }
        }
        public class AnimalClass
        {
            //field
            public string Name { get; set; }
            //nested class
            public class AnimalType
            {
                public string Type { get; set; }
            }
            //nested class
            public class AnimalColor
            {
                public string Color { get; set; }
            }
        }
        public static void Main()
        {
            int i = 0;
            //var ii; we need to initialise it otherwise compiler wont understand that what is the type of ii

            var intType = 0;
            var doubleType = 12.3;
            var floatType = 12.3f;
            var shortType = 5;
            var byteType = 127;
            var stringType = "";
            var boolType = true;
            var charType = 'S';
            Console.WriteLine(intType.GetType().ToString());
            Console.WriteLine(doubleType.GetType().ToString());
            Console.WriteLine(shortType.GetType().ToString());
            Console.WriteLine(byteType.GetType().ToString());
            Console.WriteLine(floatType.GetType().ToString());
            Console.WriteLine(stringType.GetType().ToString());
            Console.WriteLine(charType.GetType().ToString());
            Console.WriteLine(boolType.GetType().ToString());

            Student s = new Student(123, "Sneha");
            Console.WriteLine("calling with constructor "+s.Id + " " + s.Name);

        //if we are making the parametrized ctor of student class then we need to initialize it here.
            var studentVariableType = new Student(129, "palak") { Id = 124, Name = "vaibhav" };
            var studentVariableType2 = new { };// anonymous object without class name

           Console.WriteLine( "Calling it with Var type & name "+studentVariableType.Id +" "+ studentVariableType.Name);
           


            var dynamicAnonymous = new { Id = 1245, Name = "subash" };
            Console.WriteLine(dynamicAnonymous.Id + " " + dynamicAnonymous.Name);

            AnimalClass animal = new AnimalClass();
            AnimalClass.AnimalType animalType = new AnimalClass.AnimalType();
            AnimalClass.AnimalColor animalColor = new AnimalClass.AnimalColor();
            animal.Name = "dog";
            animalType.Type = "labrador";
            animalColor.Color = "Brown";
            Console.WriteLine(animal.Name);
            Console.WriteLine(animalType.Type);
            Console.WriteLine(animalColor.Color);

            var dynamicAnonymous2 = new
            {
                Name = "dog",
                 animalType =new{ Type = "husky" },

                 animalColor=new { Color = "white" }

            };

            Console.WriteLine(dynamicAnonymous2.Name +" " +dynamicAnonymous2.animalColor +" "+dynamicAnonymous2.animalType);


            var AnonymousTypeArray = new[]
            {
                new{
            Name ="cat",
            animalType=new {Type="persian cat"},
            animalColor=new {Color="Grey"}
            }
            ,
            new
            {
                Name="cat",
                animalType = new {Type="british cat"},
                animalColor=new {Color="greyish black"}
            }
            };
            Console.WriteLine(AnonymousTypeArray.Length);
            Console.WriteLine(AnonymousTypeArray[0]);
            Console.WriteLine(AnonymousTypeArray[1]);



        }
    }
}




