using Domain;

namespace CustomDDD.Tests
{
    public class CustomDDDUnitTest
    {
        [Fact]
        public void Test1()
        {
            Pupil pupil = new();
            var result = pupil.AddNumber(1, 3);
            Assert.Equal(6, result);
        }
    }
}