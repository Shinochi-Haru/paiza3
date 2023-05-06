using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(Lcm(nums));
    }

    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int tmp = b;
            b = a % b;
            a = tmp;
        }
        return a;
    }

    static int Lcm(int[] nums)
    {
        int lcm = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int gcd = Gcd(lcm, nums[i]);
            lcm = lcm * nums[i] / gcd;
        }

        return lcm;
    }
}
