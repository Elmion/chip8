namespace TestChip
{
    public class TheoryTest
    {
        
        [Fact]
        public void InstructionMask()
        {
           Assert.True((0x8124 & 0xf00f) == 0x8004);
           Assert.False((0x8124 & 0xf00f) == 0x8005);
           Assert.True((0x8124 & 0x0f00) >> 8 == 1);
           Assert.True((0x8124 & 0x00f0) >> 4 == 2);
        }
    }
}