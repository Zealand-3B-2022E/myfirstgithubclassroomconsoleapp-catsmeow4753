using MyFirstGitHubClassRoomConsoleApp60;

internal class Program
{
    private static void Main(string[] args)
    {
        Demo demo_1 = new Demo(0, "Bob");
        Demo demo_2 = new Demo(1, "Joe");

        Console.WriteLine($"{demo_1}\n{demo_2}");
    }
}