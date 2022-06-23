public class TwoSums
{

    public static void Main()
    {

    }
    public List<int> TwoSum(int[] nums, int target) 
    {
        

        foreach (int n in nums[0..^1])
        {
            foreach (var sn in nums[(Array.IndexOf(nums, n) + 1)..])
            {
                if (n+sn == target)
                {
                    if (n != sn)
                    {

                    }
                }
            }
        }
    } 
}