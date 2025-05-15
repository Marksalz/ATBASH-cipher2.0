namespace ATBASH_cipher2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
    }
}
