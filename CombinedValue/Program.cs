internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter four numbers:");
        if (int.TryParse(Console.ReadLine(), out int num1) &&
            int.TryParse(Console.ReadLine(), out int num2) &&
            int.TryParse(Console.ReadLine(), out int num3) &&
            int.TryParse(Console.ReadLine(), out int num4))
        {
            int formedNumber = num1 * 1000 + num2 * 100 + num3 * 10 + num4;
            Console.WriteLine($"Formed number: {formedNumber}");
        }
        else
        {
            Console.WriteLine("Error: Invalid input.");
        }
    }
}