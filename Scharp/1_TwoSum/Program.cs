namespace _1_TwoSum;

class Program
{
    static void Main(string[] args)
    {
        var result = TwoSum([3,3], 6);

        var builder = "";

        foreach (var item in result)
        {
            builder += $"{item}";
        }

        Console.WriteLine(builder);
        Console.ReadLine();
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> storage = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int find = target - nums[i];

            if (storage.ContainsKey(find))
            {
                return [storage[find], i];
            }

            storage[nums[i]] = i;
        }

        return [];
    }
}
