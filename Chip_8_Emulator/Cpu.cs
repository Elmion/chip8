using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip_8_Emulator
{
    public class Cpu
    {
        InstructionFabric _fabric;

        public byte[] Memory { get; set; } = new byte[4096];
        public ushort PC { get; set; } = 0x200;
        public byte[] registers { get; set; } = new byte[16];
        public ushort I { get; set; } = 0;
        public ushort[] stack { get; set; } = new ushort[16];
        public int sp { get; set; } = -1;
        public byte DT { get; set; } = 0;//delay timer
        public byte ST { get; set; } = 0;//sound timer

        public Cpu()
        {
            _fabric = new();
        }

        public void Step()
        {
            var op = GetOP(PC);
            Instruction instruction = _fabric.GetInstruction(op);
            instruction.Execute();
        }
        public void LoadROM()
        {           
            new ROM().Load(Memory);
        }
        private ushort GetOP(ushort PC)
        {
            return (ushort)(Memory[PC] << 8 | Memory[PC + 1]<<0);
        }
    }
}
