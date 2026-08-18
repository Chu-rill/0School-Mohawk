namespace MyFirstProgram;

public class UserInput
{
   public static void Run()
    {
        Console.Write("What's your name: ");
        String name = Console.ReadLine();
        
        Console.Write("What's your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Hello " + name);
        Console.WriteLine("He is " + age + " years old.");
        
        Console.WriteLine(age.GetType());
    }
}