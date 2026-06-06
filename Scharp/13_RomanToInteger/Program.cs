namespace _13_RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV")); 
            Console.WriteLine(RomanToInt("LVIII")); 
            Console.WriteLine(RomanToInt("III")); 
            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanNumbers = new()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
            };
            
            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int currentNum = romanNumbers[s[i]];

                if (i < s.Length - 1 && currentNum < romanNumbers[s[i+1]])
                {
                    total -= currentNum;
                }
                else
                {
                    total += currentNum;
                }
            }

            return total;
        }
    }
}
