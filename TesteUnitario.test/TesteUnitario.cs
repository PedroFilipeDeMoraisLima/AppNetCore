using System;
using Xunit;

namespace TesteUnitario.test
{
    public class TesteUnitario
    {
        [Fact]
        public void Test1()
        {
            var a = 1;
            var b = 2;

            Assert.Equal(a, b);
        }
    }
}
