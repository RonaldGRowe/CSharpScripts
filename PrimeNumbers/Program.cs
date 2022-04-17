// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

List<int> primeList = new List<int> {2};
int maxNum;
int startNum = 3;

Stopwatch stopWatch = new Stopwatch();


Console.Write("Enter Whole Number Greater than 1: ");

maxNum = Convert.ToInt32(Console.ReadLine());
stopWatch.Start();

while (startNum < maxNum)
{
    int z = 0;
    foreach (int d in primeList)
    {
        if (startNum % d == 0)
        {
            startNum += 2;
            break;
        }
        else
        {
            z++;
        }
    }
    if (z == primeList.Count)
    {
        primeList.Add(startNum);
        startNum += 2;
    }
}

foreach (int p in primeList)
{
    Console.Write(p+", ");
}
Console.WriteLine("\n"+primeList.Count+"Prime Numbers");

stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000000000}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);

Console.WriteLine(elapsedTime + " seconds");