// See https://aka.ms/new-console-template for more information
using D_SCommerceClasses;

//program start
Console.WriteLine("Hello, World!");
//while loop 
while (true)
{
    //for options for user to get input
    Console.WriteLine("You Are Adding:");
    //options for users
    Console.WriteLine("1.Student");
    Console.WriteLine("2.Staff");
    Console.WriteLine("3.List");
    Console.WriteLine("4.Search");
    Console.WriteLine("5.Update");
    Console.WriteLine("6.Course");
    var a = Convert.ToInt32(Console.ReadLine());
    //if...else if 
    if (a == 1)
    {
        //method call
        Student();
    }
    else if (a == 2)
    {
        Teachers();
    }
    else if (a == 3)
    {
        List();
    }
    else if (a == 4)
    {
        Search();
    }
    else if (a == 5)
    {
        Update();  
    }
    else if (a == 6)
    {
        Course();   
    }
    
}
//method
static void Student()
{
    //variable of DbContext
    var SList = new D_SContext();
    //variable of class
    var std = new Students();

    //to get users input
    Console.WriteLine("Enter your Name:");
    std.Name = Console.ReadLine();

    Console.WriteLine("Enter your Class:");
    std.Class = Convert.ToInt32(Console.ReadLine());

    //add users input in database
    SList.Students.Add(std);
    //save changes in database 
    SList.SaveChanges();
}

static void Teachers()
{
    var SList = new D_SContext();
    var std = new Staff();

    Console.WriteLine("Enter your Name:");
    std.Name = Console.ReadLine();

    Console.WriteLine("Enter your Subject:");
    std.Subject = Console.ReadLine();


    Console.WriteLine("Enter your Salary:");
    std.Salary = Convert.ToInt32(Console.ReadLine());


    SList.Staffs.Add(std);
    SList.SaveChanges();
}
//method
static void List()
{
    //variable of Dbcontext
    var SList = new D_SContext();
    // variable of Dbcontext.Class 
    var studentsWithName = SList.Students
                                  .ToList();
    //get input from users
    Console.WriteLine(studentsWithName);
    foreach (var student in studentsWithName)
    {
        Console.WriteLine(student.Name);
    }
}

static void Search()
{
    //Variable of DbContext  
    var SList = new D_SContext();
    //
    Console.WriteLine("Students Name:");
     var Name = Console.ReadLine();
    
    var studentsName = SList.Students
                                      .Where(s => s.Name == Name)
                                      .ToList();
    foreach (var student in studentsName)
    {
        Console.WriteLine(student.Name);  
        Console.WriteLine(student.Class);
    }
}
static void Update()
{
    //variable of Dbcontext
    var SList = new D_SContext();
    //get input from users 
    Console.WriteLine("Student Id:");
    //users input is in string so string is implicitly convert into int
    var Id = Convert.ToInt32(Console.ReadLine());
    //variable of class where is use to find users input in table 
    var std = SList.Students
                            .Where(s => s.Id == Id)
                            .FirstOrDefault();
    //users input for update a name 
    Console.WriteLine("Students Name:");
    std.Name = Console.ReadLine();
    //update in database(table)
    SList.SaveChanges();
}
static void Course()
{
    var SList = new D_SContext();
    var std = new Courses();

    Console.WriteLine("Enter Course Name:");
    std.Name = Console.ReadLine();

    Console.WriteLine("Enter  Course No:");
    std.CourseNo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter  Fees:");
    std.fees = Convert.ToInt32(Console.ReadLine());


    SList.Courses.Add(std);
    SList.SaveChanges();
}
