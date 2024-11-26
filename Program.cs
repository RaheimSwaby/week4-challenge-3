using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace week4_challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "{[(())]}"; // Single string
            bool result = IsValid(s); // Call the static method
            Console.WriteLine($"Is the string '{s}' valid: {result}");

        }

        public static bool IsValid(string s)
        {

            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }

            return s == "";
        }
    }
}
    