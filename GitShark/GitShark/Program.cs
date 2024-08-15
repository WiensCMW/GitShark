using Spectre.Console;

namespace GitShark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.Write(new FigletText("GitShark!").Centered());
            AnsiConsole.Write(new Rule("Git with Teeth (not really)").Centered());

            Console.ReadKey();
        }
    }
}
