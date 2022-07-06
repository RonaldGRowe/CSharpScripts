public class Solution
{
    public int Reverse(int x)
    {
        //Finally a Fast One beating over 90% of entries
        //Memory hog only using less memory than 10% of entries
        //Use a queue to store modulo values
        //Dequeue and multiply by 10 raised to power of queue count

        int quotient = x;
        Queue<int> reverseQueue = new Queue<int>();
        //Load queue
        while (quotient != 0)
        {
            reverseQueue.Enqueue(quotient % 10);
            quotient /= 10;
        }

        //Unload queue
        Int64 xBig = 0;

        //Check for the obviously large ones but not checking for worst case until later
        //Increased efficiency, faster than 95% of entries
        //Memory usage jumped to better than over 40% of entries
        while (reverseQueue.Count > 0)
        {
            if (reverseQueue.Count == 10 && reverseQueue.Peek() > 2)
            {
                return 0;
            }
            Int64 num = reverseQueue.Dequeue();
            xBig += (num * (Int64)Math.Pow(10, reverseQueue.Count));
        }

        if (xBig >= -2147483648 && xBig <= 2147483647)
        {
            x = (int)xBig;
            return x;
        }
        else
        {
            return 0;
        }
    }
}