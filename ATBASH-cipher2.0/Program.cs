namespace ATBASH_cipher2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
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
