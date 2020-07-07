using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO; 

namespace Lab1
{
    public partial class Form1 : Form
    {
        int OrderNum = 1;
        int Step = 0;

        Register RegisterA = new Register("A");
        Register RegisterB = new Register("B");
        Register RegisterC = new Register("C");
        Register RegisterD = new Register("D");
        Dictionary<string, Register> Dict_Register = new Dictionary<string, Register>();
        Dictionary<string, string> Dict_Part = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            Dict_Register.Add("rAXH", RegisterA);
            Dict_Register.Add("rAXL", RegisterA);
            Dict_Register.Add("rBXH", RegisterB);
            Dict_Register.Add("rBXL", RegisterB);
            Dict_Register.Add("rCXH", RegisterC);
            Dict_Register.Add("rCXL", RegisterC);
            Dict_Register.Add("rDXH", RegisterD);
            Dict_Register.Add("rDXL", RegisterD);
            Dict_Part.Add("rAXH", "H");
            Dict_Part.Add("rAXL", "L");
            Dict_Part.Add("rBXH", "H");
            Dict_Part.Add("rBXL", "L");
            Dict_Part.Add("rCXH", "H");
            Dict_Part.Add("rCXL", "L");
            Dict_Part.Add("rDXH", "H");
            Dict_Part.Add("rDXL", "L");
        }


        private void Order_Click(object sender, EventArgs e)
        {
            // Main function that translates and writes command to the textbox
            bool RadioButtonsChecked = false, RadioRozkazChecked = false, RadioRejestr1Checked = false, RadioRejestr2Checked = false;

            foreach (RadioButton RadioRozkaz in groupBoxOrder.Controls.OfType<RadioButton>())
                if (RadioRozkaz.Checked)
                {
                    RadioRozkazChecked = true;
                    break;
                }
            foreach (RadioButton RadioRejestr1 in groupBoxRegister1.Controls.OfType<RadioButton>())
                if (RadioRejestr1.Checked)
                {
                    RadioRejestr1Checked = true;
                    break;
                }
            foreach (RadioButton RadioRejestr2 in groupBoxRegister1.Controls.OfType<RadioButton>())
                if (RadioRejestr2.Checked)
                {
                    RadioRejestr2Checked = true;
                    break;
                }


            if (RadioRozkazChecked && RadioRejestr1Checked && RadioRejestr2Checked)
                RadioButtonsChecked = true;

            if (RadioButtonsChecked)
            {
                string Order, Order_0 = "", OrderReg1 ="", OrderReg2 = "";
                bool Rej2_digit = false;
                Order = OrderNum.ToString();

                if (radioButtonADD.Checked)
                    Order_0 += "ADD";
                else if (radioButtonMOV.Checked)
                    Order_0 += "MOV";
                else if (radioButtonSUB.Checked)
                    Order_0 += "SUB";

                if (ButtonRej1AH.Checked)
                    OrderReg1 = "rAXH";
                else if (ButtonRej1AL.Checked)
                    OrderReg1 = "rAXL";
                else if (ButtonRej1BH.Checked)
                    OrderReg1 = "rBXH";
                else if (ButtonRej1BL.Checked)
                    OrderReg1 = "rBXL";
                else if (ButtonRej1CH.Checked)
                    OrderReg1 = "rCXH";
                else if (ButtonRej1CL.Checked)
                    OrderReg1 = "rCXL";
                else if (ButtonRej1DH.Checked)
                    OrderReg1 = "rDXH";
                else if (ButtonRej1DL.Checked)
                    OrderReg1 = "rDXL";

                if (ButtonRej2AH.Checked)
                    OrderReg2 = "rAXH";
                else if (ButtonRej2AL.Checked)
                    OrderReg2 = "rAXL";
                else if (ButtonRej2BH.Checked)
                    OrderReg2 = "rBXH";
                else if (ButtonRej2BL.Checked)
                    OrderReg2 = "rBXL";
                else if (ButtonRej2CH.Checked)
                    OrderReg2 = "rCXH";
                else if (ButtonRej2CL.Checked)
                    OrderReg2 = "rCXL";
                else if (ButtonRej2DH.Checked)
                    OrderReg2 = "rDXH";
                else if (ButtonRej2DL.Checked)
                    OrderReg2 = "rDXL";
                else if (ButtonRej2None.Checked)
                {
                    OrderReg2 = numericUpDownValue.Value.ToString() + " ";
                    Rej2_digit = true;
                }

                if (Order_0 == "MOV" && Rej2_digit == true)
                    Console.WriteLine("Wrong Command !");
                else
                {
                    textBoxCode.Text += Order + " " + Order_0 + " " + OrderReg1 + " " + OrderReg2 + "\r\n";
                    OrderNum++;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Save your program to txt file
            var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.IO.File.WriteAllText(@GetDirectory+"\\ProgramCode.txt", textBoxCode.Text);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //Load your program from txt file
            var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            RegisterA = new Register("A");
            RegisterB = new Register("B");
            RegisterC = new Register("C");
            RegisterD = new Register("D");
            Step = 0;

            textBoxRejegister.Text = "";
            textBoxRejegister.Text += "Register " + RegisterA.ReturnName() + " " + RegisterA.ReturnValue().ToString() + "\r\n"
               + "Register " + RegisterB.ReturnName() + " " + RegisterB.ReturnValue().ToString() + "\r\n"
               + "Register " + RegisterC.ReturnName() + " " + RegisterC.ReturnValue().ToString() + "\r\n"
               + "Register " + RegisterD.ReturnName() + " " + RegisterD.ReturnValue().ToString() + "\r\n";
            textBoxCurrentStep.Text = (Step).ToString();


            textBoxCode.Text = "";
            textBoxCode.Text = System.IO.File.ReadAllText(@GetDirectory+"\\ProgramCode.txt");
            OrderNum = textBoxCode.Text.Split('\n').Length;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Function that starts program execution 

            bool StepWork = false;
            if (checkBoxStepWork.Checked)
                StepWork = true;

            Interpreter(Step, StepWork);
            Step++;

            textBoxRejegister.Text = "";
            textBoxRejegister.Text += "Register " + RegisterA.ReturnName() + " " + RegisterA.ReturnValue().ToString() + "\r\n"
               + "Register " + RegisterB.ReturnName() + " " + RegisterB.ReturnValue().ToString() + "\r\n"
               + "Register " + RegisterC.ReturnName() + " " + RegisterC.ReturnValue().ToString() + "\r\n"
               + "Register " + RegisterD.ReturnName() + " " + RegisterD.ReturnValue().ToString() + "\r\n";
        }


        void Interpreter(int Step, bool StepWork)
        {
            //  Function that first translates and interprets commands from textbox
            //  and then calls the appropriate functions to execute command
            string[] lines = textBoxCode.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length - 1; i++)
            {
                string Order_0 = "", Order_1 = "", Order_2 = "";
                int Number, OrderNum;
                string[] words = lines[i].Split(' ');
                OrderNum = int.Parse(words[0]);
                Order_0 = words[1];
                Order_1 = words[2];
                Order_2 = words[3];

                Register RegisterFirst = Dict_Register[Order_1];
                string RegisterFirstPart = Dict_Part[Order_1];

                try
                {
                    Register RegisterSecond = Dict_Register[Order_2];
                    string RegisterSecondPart = Dict_Part[Order_2];
                    Number = RegisterSecond.ReturnValue();
                }
                catch (KeyNotFoundException)
                {
                    Number = int.Parse(Order_2);
                }


                if (StepWork == false)
                {
                    if (Order_0 == "ADD")
                    {
                        RegisterFirst.Add(Number, RegisterFirstPart);
                    }
                    else if (Order_0 == "MOV")
                    {
                        RegisterFirst.Move(Number, RegisterFirstPart);
                    }
                    else if (Order_0 == "SUB")
                    {
                        RegisterFirst.Substract(Number, RegisterFirstPart);
                    }
                    textBoxRejegister.Text = "Register " + RegisterFirst.ReturnName() + " " + RegisterFirst.ReturnValue().ToString();
                    textBoxCurrentStep.Text = OrderNum.ToString();
                }

                else if (StepWork == true && Step == i)
                {
                    if (Order_0 == "ADD")
                    {
                        RegisterFirst.Add(Number, RegisterFirstPart);
                    }
                    else if (Order_0 == "MOV")
                    {
                        RegisterFirst.Move(Number, RegisterFirstPart);
                    }
                    else if (Order_0 == "SUB")
                    {
                        RegisterFirst.Substract(Number, RegisterFirstPart);
                    }
                    textBoxRejegister.Text = "Register " + RegisterFirst.ReturnName() + " " + RegisterFirst.ReturnValue().ToString();
                    textBoxCurrentStep.Text = (Step+1).ToString();
                }
            }
        }
    }
}
