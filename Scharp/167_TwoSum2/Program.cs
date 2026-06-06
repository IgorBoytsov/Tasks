namespace _167_TwoSum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = TwoSum([-1, 0], -1);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int current = numbers[left] + numbers[right];

                if (current == target)
                {
                    return [left + 1, right + 1];
                }
                else if (current < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return [];
        }
    }
}
