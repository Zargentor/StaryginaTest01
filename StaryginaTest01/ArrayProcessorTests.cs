using ArrayProcessingApp;
using Xunit;

namespace StaryginaTest01
{
    public class ArrayProcessorTests
    {
        [Fact]
        public void ValidPairs()
        {
            var processor = new ArrayProcessor();
            int[] array = { 3, -1, 6, 2, 9, -3 };

            var result = processor.FindPairs(array);

            Assert.Equal(2, result.Length);
            Assert.Equal((0, 3, 1, -1), result[0]);
            Assert.Equal((4, 9, 5, -3), result[1]);
        }

        [Fact]
        public void NoValidPairs()
        {
            var processor = new ArrayProcessor();
            int[] array = { 1, 2, 4, 5 };

            var result = processor.FindPairs(array);

            Assert.Empty(result);
        }

        [Fact]
        public void EmptyArray()
        {
            var processor = new ArrayProcessor();
            int[] array = { };

            var result = processor.FindPairs(array);

            Assert.Empty(result);
        }
    }
}