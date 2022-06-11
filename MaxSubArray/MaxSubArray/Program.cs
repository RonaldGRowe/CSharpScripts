class MaxSubArray
{
    public static void Main()
    {
        int[] numlst = { 3, 4, -10, 14, 2, -1 };
        SubArray(numlst);
    }


    public static int SubArray(int[] nums)
    { 
        int maxtotal = nums[0];
        int total;
        int i = 0;
        if (nums.Length == 1)
        {
            Console.WriteLine(maxtotal);
            return maxtotal;
        }
        while (i < nums.Length)
        {
                       
            total = nums[i];
            if (total > maxtotal)
            {
                maxtotal = total;
            }
            foreach (var item in nums[(i+1)..])
            {
                total += item;
                if (total > maxtotal)
                {
                    maxtotal=total;
                }
            }
            i++;
        }
        Console.WriteLine(maxtotal);
        return maxtotal;

    }
}