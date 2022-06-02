
using ConsoleAppSoma;
using Xunit;

namespace WebAppSoma.UnitTests
{
    public class UnitTest1
    {
        private readonly ProgramTeste controller;

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2531, 2533)]
        [InlineData(3, 2531, 2534)]
        [InlineData(4, 1532, 1536)]
        [InlineData(5, 51, 56)]
        [InlineData(6, 2, 8)]
        [InlineData(7, 14, 21)]
        [InlineData(881, 412, 1293)]
        [InlineData(654, 124, 778)]
        public void Soma_ResponseExpectedEqual(int n1, int n2, int expected)
        {
            //int n1 = 1;
            //int n2 = 1;

            int result = ProgramTeste.Soma(n1, n2);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void Soma_ResponseExpectedNotEqual()
        {
            int n1 = 1;
            int n2 = 1;

            int somaNaoEsperada = 3;

            int result = ProgramTeste.Soma(n1, n2);

            Assert.NotEqual(somaNaoEsperada, result);
        }
    }
}
