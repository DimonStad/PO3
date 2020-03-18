using Xunit;

namespace _1_lab
{
    /// <summary>
    ///Test module
    /// </summary>
    public class UnitTests
    {
        /// <summary>
        ///Fact test
        /// </summary>
        [Fact]
        public void PassingFactReaderTest()
        {
            Reader.CopyFile(@"D:\Works\UnitTest.txt",@"D:\Works\UnitTest_test.txt");
            Reader r1 = new Reader(@"D:\Works\UnitTest.txt");
            Reader r2 = new Reader(@"D:\Works\UnitTest_test.txt");
            Assert.Equal(r1.FileToString(),r2.FileToString());
        }
       /* [Theory]
        public void PassingTheoryReaderTest()
        {

        }*/
    }
}
