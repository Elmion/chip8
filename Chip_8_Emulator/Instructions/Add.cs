namespace Chip_8_Emulator.Instructions
{
    public class Add : Instruction
    {
        private byte Vx = 0;
        private byte Vy = 0;
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8004)
            {
                Vx = (0x8124 & 0x0f00) >> 8;
                Vy = (0x8124 & 0x00f0) >> 4;
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }

        public override void Execute()
        {

        }
    }

}
