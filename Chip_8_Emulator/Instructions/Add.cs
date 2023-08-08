namespace Chip_8_Emulator.Instructions
{
    public class Add : Instruction
    {
        private byte Vx = 0;
        private byte Vy = 0;
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            //V[X] <= (V[X] + V[Y]) & 0xFF;
           // V[F] <= (V[X] + V[Y] >= 256);

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
    public class Call : Instruction
    {
        //6XNN
        //V[X] <= 0xNN
        public override void Execute()
        {
           
        }

        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf000) == 0x6000)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class ADDI : Instruction
    {    //7XNN
        //V[X] <= V[X] + NN
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf000) == 0x7000)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class MOV : Instruction
    {
        //8XY0
        //V[X] <= V[Y]
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf000) == 0x8000)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class SUB : Instruction
    {
        //8XY5
        //Вычитает из регистра под номером X значение регистра Y и если произошло заимствование (прим. перевод Borrow) установить регистр переполнения в 1. И установить регистр переполнения в 0 если заимствование не произошло.
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8005)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class SUBR : Instruction
    {
        //8XY5
        //Вычитает из регистра под номером X значение регистра Y и если произошло заимствование (прим. перевод Borrow) установить регистр переполнения в 1. И установить регистр переполнения в 0 если заимствование не произошло.
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8007)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class AND : Instruction
    {
        //8XY2 
        //Вычитает из регистра под номером X значение регистра Y и если произошло заимствование (прим. перевод Borrow) установить регистр переполнения в 1. И установить регистр переполнения в 0 если заимствование не произошло.
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8002)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class OR : Instruction
    {
        //8XY1 
        //Вычитает из регистра под номером X значение регистра Y и если произошло заимствование (прим. перевод Borrow) установить регистр переполнения в 1. И установить регистр переполнения в 0 если заимствование не произошло.
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8001)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class XOR : Instruction
    {
        //8XY1 
        //Вычитает из регистра под номером X значение регистра Y и если произошло заимствование (прим. перевод Borrow) установить регистр переполнения в 1. И установить регистр переполнения в 0 если заимствование не произошло.
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8003)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class ShiftRight : Instruction
    {
        //8XY6 
        //Вычитает из регистра под номером X значение регистра Y и если произошло заимствование (прим. перевод Borrow) установить регистр переполнения в 1. И установить регистр переполнения в 0 если заимствование не произошло.
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8003)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
    public class ShiftLeft : Instruction
    {
        //8XY6 
        //Вычитает из регистра под номером X значение регистра Y и если произошло заимствование (прим. перевод Borrow) установить регистр переполнения в 1. И установить регистр переполнения в 0 если заимствование не произошло.
        public override void Execute()
        {

        }
        public override bool TryParse(ushort opcode, out Instruction? instruction)
        {
            if ((opcode & 0xf00f) == 0x8003)
            {
                instruction = this;
                return true;
            }
            instruction = null;
            return false;
        }
    }
}
