namespace _9_PalindromeNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindromeWithOutString(346457566));
        Console.ReadLine();
    }

    public static bool IsPalindromeWithOutString(int x)
    {
        if (x < 0) 
            return false;

        int reversed = 0;
        int a = x;
        while (a != 0)
        {
            int ostatok = a % 10;
            reversed = reversed * 10 + ostatok;
            a /= 10;
        }

        return reversed == x;
    }

    public static bool IsPalindromeWithString(int x)
    {
        var stringX = x.ToString();
        char[] digits = stringX.ToCharArray();

        if (digits.SequenceEqual(digits.Reverse()))
            return true;

        return false;
    }
}
