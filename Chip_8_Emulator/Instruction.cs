using Chip_8_Emulator.Instructions;

namespace Chip_8_Emulator
{
    public class InstructionFabric
    {
        private List<Instruction> InstructionsPool;

        public InstructionFabric()
        {
            InstructionsPool = new()
            {
                new Add()
            };
        }
         public Instruction GetInstruction(ushort opcode)
        {
            foreach (Instruction instruction in InstructionsPool)
            {
                if(instruction.TryParse(opcode,out Instruction outputInstruction))
                {
                    return outputInstruction;
                }
            }
            throw new Exception("Not found command");
        }
    }
    public  abstract class Instruction
    {
         public abstract void Execute();
         public abstract bool TryParse(ushort opcode, out Instruction? instruction);
    }
    
}
