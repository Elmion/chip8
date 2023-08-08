using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip_8_Emulator
{
    public class ROM
    {
        public ROM() {
           
        }
        public void Load(Cpu cpu)
        {
            byte[] rrr = File.ReadAllBytes(@"C:\Users\Evgenii\source\repos\Chip_8_Emulator\Chip_8_Emulator\MAZE.ch8");
            for (int i = 0; i< rrr.Length;i++) {
                cpu.Memory[cpu.PC+i] = (byte)rrr[i];
            }
        }
    }
}
