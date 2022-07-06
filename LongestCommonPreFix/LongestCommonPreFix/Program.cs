public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {


        //Check if array contains empty string
        if (strs.Contains(""))
        {
            return "";
        }

        var indexer = 0;
        string prefix = "";

        //Use first string as a max length
        while (indexer < strs[0].Length)
        {
            prefix += strs[0][indexer];
            foreach (var s in strs)
            {   //Check if word s is shorter than indexer
                if (s.Length <= indexer)
                { 
                    return prefix[..^1];
                }
                if (s[indexer] != prefix[indexer])
                {                    
                    return prefix[..^1];
                }
            }
            indexer++;
        }
        return prefix;
    }

}