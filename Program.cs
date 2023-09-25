using System.Diagnostics;

class Program
{
    public void getData()
    {
        Console.WriteLine("I am inside the method");    
    }


 static void Main(string[] args)
    {
       Program p = new Program();
        p.getData();
        Console.WriteLine("Hello, World!");
        int a = 15;
        Console.WriteLine("The number is " + a);

        String name = "Rahul";
        Console.WriteLine("Name is " + name);
        Console.WriteLine($"Name is {name}");
        // Var is another data type

        var age = "23";
        Console.WriteLine($"age is {age}");
        dynamic height = 13.2;
        Console.WriteLine($"Height is {height}");
        height = "This is to test dynamic data";

        Console.WriteLine("After changing values height " + height);


    }
}