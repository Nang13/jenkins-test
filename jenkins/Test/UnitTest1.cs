using code.Function;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Sum_ReturnCorrecctData()
        {
            Caculator caculator = new Caculator();

            int x = 3; int y = 4;
            int result = caculator.Sum(x, y);
            Assert.Equal(7, result);
        }
    }
}