// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
List<int> factorList = new() { 2};
List<int> primeList = new() { 2};
int maxNum;

Stopwatch stopWatch = new Stopwatch();


Console.Write("Enter Whole Number Greater than 1: ");

maxNum = Convert.ToInt32(Console.ReadLine());
stopWatch.Start();

foreach (int startNum in Enumerable.Range(1,maxNum-2).Select(x => x+2))
{
    foreach (int p in primeList.Skip(1+primeList.IndexOf(factorList[^1])))
    {
        if (p >= Math.Sqrt(startNum) + 1)
        {
            break;
        }
        else
        {
            factorList.Add(p);
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

foreach (int p in primeList)
{
    Console.Write(p+", ");
}
Console.WriteLine("\n"+primeList.Count+" Prime Numbers");

stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);

Console.WriteLine(elapsedTime + " seconds");