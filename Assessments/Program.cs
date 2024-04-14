
////single line command

///*
// multiple line command
// */

////datatypes 

//byte b = 50;    //1 byte
//short s = 100;  //2bytes
//int i = 10;     //4 bytes
//long l = 1000;  //8 bytes

//float f = 10.20F; //4 bytes
//double d = 22.33;   //8 bytes
//decimal d1 = 14.22M;    //16 bytes

//string s1 = "Welcome";
//char c1 = 'A';


////printing output

////Console.WriteLine(s1);

////Console.WriteLine("Integer value is:"+i);

////using placeholder
////Console.WriteLine("Integer value is {0} and Float value is {1}",i,f);

////using string interpolation
////Console.WriteLine($"Integer value is {i} and Float value is {f}");

//String s2 = "Rushikesh";
////Console.WriteLine(s2);

////accept input from user

//Console.WriteLine("Enter your name:");
//string name = Console.ReadLine();

//Console.WriteLine("Enter age:");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter  salary:");
//double salary = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine($"Hello {name} , your age is {age} and salary is {salary}");

//using Assessments;

//Employee emp=new Employee();

//emp.Assign();
//emp.CalculateSalary();
//string result = emp.Display();
//Console.WriteLine(result);

//Employee emp2 = new Employee();

//emp2.Accept(2, "Kriti", 10000.64, 5000.36, 1000.00);
//emp2.CalculateSalary();
//Console.WriteLine(emp2.Display());

//using Assessments;

//Student s1 = new Student();
//Console.WriteLine(s1.Display());

//Student s2 = new Student(2, "Kriti");
//Console.WriteLine(s2.Display());

//Date d1 = new Date();
//Date d2 = new Date(13, "April", 2024);

//.WriteLine(d1.Display());
//Console.WriteLine(d2.Display());

//using Assessments;

//Product p1=new Product();
//p1.Code = 101;
//p1.Name = "keyboard";
//p1.Price = 2499;

//Console.WriteLine($"{p1.Code},{p1.Name},{p1.Price}");

//property initializer syntax
//Products p1=new Products();
//p1.Code = 101;
//p1.Name = "Mouse";
//p1.Description = "Elecronic";
//Console.WriteLine($"{p1.Code},{p1.Name},{p1.Description}");

////object intializer syntax

//Products p2 = new Products { Code = 102, Name = "Keyboard", Description = "Elecronic" };
//Console.WriteLine($"{p2.Code},{p2.Name},{p2.Description}");

//using Assessments;

//property initializer syntax
//Book b1=new Book();
//b1.Id = 101;
//b1.Title = "Java";
//b1.Price = 1000;

//Console.WriteLine($"{ b1.Id},{ b1.Title},{ b1.Price}");

////object initializer syntax
//Book b2 = new Book { Id=102,Title="C#",Price=999 };
//Console.WriteLine($"{b2.Id},{b2.Title},{b2.Price}");