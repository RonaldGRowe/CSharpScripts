public class Solution
{
    public int FirstUniqChar(string s)
    {
        if (s.Length == 1)
        {
            return 0;
        }
        var firstPointer = 0;
        var endPointer = s.Length - 1;
        while (firstPointer < endPointer)
        {

            if (s[firstPointer] == s[endPointer])
            {
                firstPointer++;
                endPointer--;
            }
            else
            {
                var count = (endPointer - firstPointer) - 1;
                foreach (var letter in s[(firstPointer + 1)..endPointer])
                {
                    if (letter == s[firstPointer])
                    {
                        break;
                    }
                    count--;
                }

                if (count == 0)
                {
                    return firstPointer;
                }

                var count2 = (endPointer - firstPointer) - 1;
                foreach (var letter in s[(firstPointer + 1)..endPointer])
                {
                    if (letter == s[endPointer])
                    {
                        break;
                    }
                    count2--;
                }
                if (count2 == 0)
                {
                    return endPointer;
                }
                firstPointer++;
                endPointer--;
            }

        }
        return -1;
    }
}