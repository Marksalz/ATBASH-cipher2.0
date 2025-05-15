namespace ATBASH_cipher2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
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
      
        // A method to encrypt a string using the Atbash cipher
        static string Atbash(string input)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] reversedAlphabet = "zyxwvutsrqponmlkjihgfedcba".ToCharArray();
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int index = Array.IndexOf(alphabet, char.ToLower(c));
                    char newChar = reversedAlphabet[index];
                    if (char.IsUpper(c))
                    {
                        newChar = char.ToUpper(newChar);
                    }
                    result.Append(newChar);
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        static int DangerousWords(string message, List<string> dangerousWords)
        {
            int points = 0;
            foreach (string word in dangerousWords)
            {
                if (message.Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    points++;
                }
            }
            return points;
        }

    }
}
