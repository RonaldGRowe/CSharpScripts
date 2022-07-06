public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        //Terrible run time, should have checked for multiple occurring integers then shifted

        var indexer = 0;
        var count = nums.Length;
        var k = count;


        while (indexer < (k - 1))
        {
            if (nums[indexer] == nums[(indexer + 1)])
            {
                k--;
                for (var n = (indexer + 1); n < k; n++)
                {
                    nums[n] = nums[n + 1];
                }
            }
            else
            {
                indexer++;
            }

        }
        return k;
    }
}