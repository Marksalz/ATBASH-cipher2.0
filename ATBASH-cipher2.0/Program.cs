namespace ATBASH_cipher2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void PrintFinalMessage(string message, int points)
        {
            string warning = "";
            if (points >= 1 && points <= 5)
            {
                warning = "WARNING";
            }
            else if (points >= 6 && points <= 10)
            {
                warning = "DANGER!";
            }
            else if (points >= 11 && points <= 15)
            {
                warning = "ULTRA ALERT!";
            }
            Console.WriteLine($"Decrypted Message: {message}");
            Console.WriteLine($"Warning: {warning}");
            Console.WriteLine($"Total Points: {points}");
        }
    }
}
