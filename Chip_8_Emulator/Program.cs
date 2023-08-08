namespace Chip_8_Emulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cpu cpu = new ();
            cpu.LoadROM();
            while ( 1 == 1)
            {
                cpu.Step();
            }
        }

       

    }
}