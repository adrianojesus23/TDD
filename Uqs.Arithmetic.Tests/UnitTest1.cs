namespace Uqs.Arithmetic.Tests
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 1, 2, 3 };
                yield return new object[] { -1, 2, 3 };
            }
        }

        [Fact]
        //[Theory]
        //[InlineData(4)]
        //[MemberData()]
        public void Test1()
        {
            //Arrange --> Mock
            //Act
            //Assert
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 3)]
        public void Test12(int a, int b, int exptResult)
        {
            //Arrange --> Mock
            //Act
            //Assert
        }


        [Theory]
        [MemberData(nameof(TestData))]
        public void Test13(int a, int b, int exptResult)
        {
            //Arrange --> Mock
            //Act
            //Assert
        }
    }
}