public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        //Merge Sorted Array, quite a bit slower than most, first try
        //Decent memory usage, better than 77%
        //Now Im wondering if working from high to low would have been better???
        var firstPointer = 0;
        var secondPointer = 0;
        var mcount = m;
        var ncount = n;

        //Check to make sure pointer is not past the last number and that second list has values
        while (firstPointer < mcount && ncount != 0)
        {
            if (nums1[firstPointer] <= nums2[secondPointer])
            {//Increment firstPointer if smaller
                firstPointer++;
            }
            else
            {
                for (var i = mcount - 1; i >= firstPointer; i--)
                {//Shift values down
                    nums1[i + 1] = nums1[i];
                }
                nums1[firstPointer] = nums2[secondPointer];//Add new value and increment everything
                ncount--;
                mcount++;
                firstPointer++;
                secondPointer++;
            }
        }
        while (ncount > 0)
        { //Catch the left over values after getting to the end of master list
            nums1[firstPointer] = nums2[secondPointer];
            firstPointer++;
            secondPointer++;
            ncount--;
        }
    }
}
