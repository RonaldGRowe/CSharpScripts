// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
class PrimeNumbers 
{ 
    static void Main()
    { 
        List<int> factorList = new() { };
        List<int> primeList = new() { 2 };
        int maxNum;
        int n = 0;


        Stopwatch stopWatch = new ();
        Stopwatch stopWatch2 = new();

        Console.Write("Enter Whole Number Greater than 1: ");

        maxNum = Convert.ToInt32(Console.ReadLine());
        stopWatch.Start();
        stopWatch2.Start();

        foreach (int startNum in Enumerable.Range(1,maxNum-2).Select(x => x+2))
        {
            while (n <  primeList.Count)
            {
                if (primeList[n] >= Math.Sqrt(startNum) + 1)
                {
                    break;
                }
                else
                {
                    factorList.Add(primeList[n]);
                    n ++;
                }
            }
            foreach (int f in factorList)
            {
                if (startNum % f == 0)
                {
                    break ;
                }
                else
                {
                    if (f == factorList[^1])
                    {
                        primeList.Add(startNum);
                        break ;
                    }
                }
            }
            if (factorList.Count == 0)
            {
                primeList.Add(startNum);
            }
    
        }

        stopWatch2.Stop();
        using(StreamWriter plistwriter = new(Console.OpenStandardOutput()))
            {
            foreach (int p in primeList)
            {
                // Console.Write(p+", ");
                plistwriter.Write(p + ", ");
            }
        }
        Console.WriteLine("\n"+primeList.Count+" Prime Numbers");

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        TimeSpan ts2 = stopWatch2.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds);
        string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
                    ts2.Hours, ts2.Minutes, ts2.Seconds,
                    ts2.Milliseconds);
        Console.WriteLine(elapsedTime + " seconds");
        Console.WriteLine(elapsedTime2 + " seconds");
    }
}