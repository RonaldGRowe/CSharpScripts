using PrimeNumbers;

namespace PrimeNumberTest
{
    public class PrimeNumberTest
    {
        [Fact]
        public void Test1()
        {
            List<int> testList = PrimeNumbers.PrimeNumbers.PrimeNumber(15);
            List<int> expected = new() { 2, 3, 5, 7, 11, 13 };
            Assert.Equal(6, testList.Count);
            Assert.Equal(expected, testList);
        }
        [Fact]
        public void Test2()
        {
            List<int> testList = PrimeNumbers.PrimeNumbers.PrimeNumber(13);
            List<int> expected = new() { 2, 3, 5, 7, 11, 13 };
            Assert.Equal(6, testList.Count);
            Assert.Equal(expected, testList);
        }
        [Fact]
        public void Test3()
        {
            List<int> testList = PrimeNumbers.PrimeNumbers.PrimeNumber(2);
            List<int> expected = new() { 2 };
            Assert.Single(testList);
            Assert.Equal(expected, testList);
        }
    }
}