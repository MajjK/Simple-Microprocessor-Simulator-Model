using System;

namespace Lab1
{
    public class Register
    {
        private int Value;
        private int ValueL;
        private string Name;

        public Register(string name)
        {
            Name = name;
            Value = 0;
        }

        public int ReturnValue()
        {
            return Value;
        }

        public void ZeroValue()
        {
            Value = 0;
            ValueL = 0;
        }

        public string ReturnName()
        {
            return Name;
        }

        public void Substract(int Val, string Part)
        {
            // Function to substract Val from older or younger Part of register
            int liczba;
            if (Part == "H")
                liczba = ChangeOlderPart(Val);
            else
            {
                ValueL = Val;
                liczba = Val;
            }
            Value -= liczba;
            if (Value < 0)
                Value = Math.Abs(Value);
        }

        public void Move(int Val, string Part)
        {
            // Function to move Val to older or younger Part of register
            Value -= ValueL;
            if (Part == "L")
            {
                ValueL = Val;
                Value += ValueL;
            }
            else
                Value = Val;
        }

        public void Add(int Val, string Part)
        {
            // Function to add Val to older or younger Part of register
            if (Part == "L")
            {
                ValueL += Val;
                if (ValueL > 255)
                    ValueL = ValueL % 255;
                Value = Value + Val;
            }
            else if (Part == "H")
            {
                int liczba = ChangeOlderPart(Val);
                Value += liczba;
            }
            if (Value > 65535)
                Value = Math.Abs(65535 - Value);
        }

        int ChangeOlderPart(int Val)
        {
            //Function that calculates value of older part of register 
            string binary = Convert.ToString(Val, 2) + "00000000";
            int Number = Convert.ToInt32(binary, 2);
            return Number;
        }
    }

  
}
