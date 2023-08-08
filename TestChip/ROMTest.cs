using Chip_8_Emulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChip
{
    public class ROMTest
    {
        [Fact]
        public void CreateRom()
        {
           Assert.NotNull( new ROM());
        }
        [Fact]
        public void LoadRom()
        {
            ROM rom = new();
            rom.Load();

            Assert.True(rom.Data.Count>0);
        }

    }
}
