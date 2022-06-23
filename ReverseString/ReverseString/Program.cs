public class Solution
{


    //Two pointer method with temp variable
    //Slow but good memory usage.
    public void ReverseString(char[] s)
    {
        var frontPointer = 0;
        var rearPointer = s.Length - 1;
        char tempPointer;

        //When pointers cross or become same number loop cancels
        while (frontPointer < rearPointer)
        {
            tempPointer = s[frontPointer]; //use tempPointer to store first value to be replaced.
            s[frontPointer] = s[rearPointer];
            s[rearPointer] = tempPointer;
            frontPointer++;
            rearPointer--;
        }

    }
}