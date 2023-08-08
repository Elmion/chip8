using Chip_8_Emulator;
using Chip_8_Emulator.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChip
{
    public class Instructions
    {

        [Fact]
        public void CreateInstructionFabric()
        {
           Assert.NotNull(new InstructionFabric());
        }
        [Fact]
        public void TryParseInstructionAdd()
        {
            InstructionFabric fabric = new ();
            Instruction inst = fabric.GetInstruction(0x8124);
            Assert.Equal(typeof(Add),inst.GetType());
        }
    }
}
