public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        //Straight forward way to add one to a number broken down into an array
        var lastIndex = digits.Length - 1;
        if (digits[lastIndex] == 9)
        {
            var digit = 9;
            while (digit == 9)
            {
                digit = digits[lastIndex];
                digits[lastIndex] = (digit + 1) % 10;

                if (lastIndex == 0 && digit == 9)
                {
                    //Add new array beginning with one
                    //Handles (9 + 1) in zero index of array, no -1 index to place the rollover 1
                    int[] arr1 = { 1 };
                    arr1 = arr1.Concat(digits).ToArray();
                    return arr1;
                }
                else
                {
                    lastIndex--;
                }
            }
            return digits;
        }
        else
        {
            digits[lastIndex]++;
            return digits;
        }
    }
}