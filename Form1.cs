using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Nr_rozkazu = 1;
        int Krok = 0;

        Rejestr rejestrA = new Rejestr("A");
        Rejestr rejestrB = new Rejestr("B");
        Rejestr rejestrC = new Rejestr("C");
        Rejestr rejestrD = new Rejestr("D");


        private void Rozkaz_Click(object sender, EventArgs e)
        {
            bool RadioButtonsChecked = false, RadioRozkazChecked = false, RadioRejestr1Checked = false, RadioRejestr2Checked = false;

            foreach (RadioButton RadioRozkaz in groupBoxRozkaz.Controls.OfType<RadioButton>())
                if (RadioRozkaz.Checked)
                {
                    RadioRozkazChecked = true;
                    break;
                }

            foreach (RadioButton RadioRejestr1 in groupBoxRejestr1.Controls.OfType<RadioButton>())
                if (RadioRejestr1.Checked)
                {
                    RadioRejestr1Checked = true;
                    break;
                }

            foreach (RadioButton RadioRejestr2 in groupBoxRejestr1.Controls.OfType<RadioButton>())
                if (RadioRejestr2.Checked)
                {
                    RadioRejestr2Checked = true;
                    break;
                }

            if (RadioRozkazChecked && RadioRejestr1Checked && RadioRejestr2Checked)
                RadioButtonsChecked = true;


            if (RadioButtonsChecked)
            {
                string Rozkaz, Rozkaz_0 = "", RozkazRej1 ="", RozkazRej2 = "";
                bool Rej2_digit = false;
                Rozkaz = Nr_rozkazu.ToString();

                if (radioButtonADD.Checked)
                    Rozkaz_0 += "ADD";
                else if (radioButtonMOV.Checked)
                    Rozkaz_0 += "MOV";
                else if (radioButtonSUB.Checked)
                    Rozkaz_0 += "SUB";

                if (ButtonRej1AH.Checked)
                    RozkazRej1 = "rAXH";
                else if (ButtonRej1AL.Checked)
                    RozkazRej1 = "rAXL";
                else if (ButtonRej1BH.Checked)
                    RozkazRej1 = "rBXH";
                else if (ButtonRej1BL.Checked)
                    RozkazRej1 = "rBXL";
                else if (ButtonRej1CH.Checked)
                    RozkazRej1 = "rCXH";
                else if (ButtonRej1CL.Checked)
                    RozkazRej1 = "rCXL";
                else if (ButtonRej1DH.Checked)
                    RozkazRej1 = "rDXH";
                else if (ButtonRej1DL.Checked)
                    RozkazRej1 = "rDXL";

                if (ButtonRej2AH.Checked)
                    RozkazRej2 = "rAXH";
                else if (ButtonRej2AL.Checked)
                    RozkazRej2 = "rAXL";
                else if (ButtonRej2BH.Checked)
                    RozkazRej2 = "rBXH";
                else if (ButtonRej2BL.Checked)
                    RozkazRej2 = "rBXL";
                else if (ButtonRej2CH.Checked)
                    RozkazRej2 = "rCXH";
                else if (ButtonRej2CL.Checked)
                    RozkazRej2 = "rCXL";
                else if (ButtonRej2DH.Checked)
                    RozkazRej2 = "rDXH";
                else if (ButtonRej2DL.Checked)
                    RozkazRej2 = "rDXL";
                else if (ButtonRej2None.Checked)
                {
                    RozkazRej2 = numericUpDownLiczba.Value.ToString() + " ";
                    Rej2_digit = true;
                }


                if (Rozkaz_0 == "MOV" && Rej2_digit == true)
                    Console.WriteLine("Błędny Rozkaz");
                else
                {
                    textBoxKod.Text += Rozkaz + " " + Rozkaz_0 + " " + RozkazRej1 + " " + RozkazRej2 + "\r\n";
                    Nr_rozkazu++;
                }
            }
        }


        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\Users\Kacper Maj\Desktop\Programowanie\C#\1\Lab1\KodProgramu.txt", textBoxKod.Text);
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            rejestrA = new Rejestr("A");
            rejestrB = new Rejestr("B");
            rejestrC = new Rejestr("C");
            rejestrD = new Rejestr("D");
            Krok = 0;

            textBoxRejestr.Text = "";
            textBoxRejestr.Text += "Rejestr " + rejestrA.ZwrocNazwe() + " " + rejestrA.ZwrocWartosc().ToString() + "\r\n"
               + "Rejestr " + rejestrB.ZwrocNazwe() + " " + rejestrB.ZwrocWartosc().ToString() + "\r\n"
               + "Rejestr " + rejestrC.ZwrocNazwe() + " " + rejestrC.ZwrocWartosc().ToString() + "\r\n"
               + "Rejestr " + rejestrD.ZwrocNazwe() + " " + rejestrD.ZwrocWartosc().ToString() + "\r\n";
            textBoxAktualnyKrok.Text = (Krok).ToString();


            textBoxKod.Text = "";
            textBoxKod.Text = System.IO.File.ReadAllText(@"C:\Users\Kacper Maj\Desktop\Programowanie\C#\1\Lab1\KodProgramu.txt");

            Nr_rozkazu = textBoxKod.Text.Split('\n').Length;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool PracaKrok = false;

            if (checkBoxPracaKrokowa.Checked)
                PracaKrok = true;


            Interpreter(Krok, PracaKrok, textBoxKod.Text);
            Krok++;

            textBoxRejestr.Text = "";
            textBoxRejestr.Text += "Rejestr " + rejestrA.ZwrocNazwe() + " " + rejestrA.ZwrocWartosc().ToString() + "\r\n"
               + "Rejestr " + rejestrB.ZwrocNazwe() + " " + rejestrB.ZwrocWartosc().ToString() + "\r\n"
               + "Rejestr " + rejestrC.ZwrocNazwe() + " " + rejestrC.ZwrocWartosc().ToString() + "\r\n"
               + "Rejestr " + rejestrD.ZwrocNazwe() + " " + rejestrD.ZwrocWartosc().ToString() + "\r\n";
        }


        void Interpreter(int krok, bool PracaKrok, string RozkazBox)
        {
            Dictionary<string, Rejestr> Slownik_Rej = new Dictionary<string, Rejestr>();
            Dictionary<string, string> Slownik_Czesci = new Dictionary<string, string>();

            Slownik_Rej.Add("rAXH", rejestrA);
            Slownik_Rej.Add("rAXL", rejestrA);
            Slownik_Rej.Add("rBXH", rejestrB);
            Slownik_Rej.Add("rBXL", rejestrB);
            Slownik_Rej.Add("rCXH", rejestrC);
            Slownik_Rej.Add("rCXL", rejestrC);
            Slownik_Rej.Add("rDXH", rejestrD);
            Slownik_Rej.Add("rDXL", rejestrD);

            Slownik_Czesci.Add("rAXH", "H");
            Slownik_Czesci.Add("rAXL", "L");
            Slownik_Czesci.Add("rBXH", "H");
            Slownik_Czesci.Add("rBXL", "L");
            Slownik_Czesci.Add("rCXH", "H");
            Slownik_Czesci.Add("rCXL", "L");
            Slownik_Czesci.Add("rDXH", "H");
            Slownik_Czesci.Add("rDXL", "L");


            string[] lines = textBoxKod.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length - 1; i++)
            {
                    string Rozkaz_0 = "", Rozkaz_1 = "", Rozkaz_2 = "";
                    int liczba, nr_rozkazu;

                    string[] words = lines[i].Split(' ');

                    nr_rozkazu = int.Parse(words[0]);
                    Rozkaz_0 = words[1];
                    Rozkaz_1 = words[2];
                    Rozkaz_2 = words[3];


                    Rejestr Rejestr1 = Slownik_Rej[Rozkaz_1];
                    string Czesc_Rejestr1 = Slownik_Czesci[Rozkaz_1];


                    try
                    {
                        Rejestr Rejestr2 = Slownik_Rej[Rozkaz_2];
                        string Czesc_Rejestr2 = Slownik_Czesci[Rozkaz_2];
                        liczba = Rejestr2.ZwrocWartosc();
                    }
                    catch (KeyNotFoundException)
                    {
                        liczba = int.Parse(Rozkaz_2);
                    }


                if (PracaKrok == false)
                {
                    if (Rozkaz_0 == "ADD")
                    {
                        Rejestr1.Dodaj(liczba, Czesc_Rejestr1);
                    }
                    else if (Rozkaz_0 == "MOV")
                    {
                        Rejestr1.Przesun(liczba, Czesc_Rejestr1);
                    }
                    else if (Rozkaz_0 == "SUB")
                    {
                        Rejestr1.Odejmij(liczba, Czesc_Rejestr1);
                    }
                    textBoxRejestr.Text = "Rejestr " + Rejestr1.ZwrocNazwe() + " " + Rejestr1.ZwrocWartosc().ToString();
                    textBoxAktualnyKrok.Text = nr_rozkazu.ToString();
                }

                else if (PracaKrok == true && krok == i)
                {
                    if (Rozkaz_0 == "ADD")
                    {
                        Rejestr1.Dodaj(liczba, Czesc_Rejestr1);
                    }
                    else if (Rozkaz_0 == "MOV")
                    {
                        Rejestr1.Przesun(liczba, Czesc_Rejestr1);
                    }
                    else if (Rozkaz_0 == "SUB")
                    {
                        Rejestr1.Odejmij(liczba, Czesc_Rejestr1);
                    }
                    textBoxRejestr.Text = "Rejestr " + Rejestr1.ZwrocNazwe() + " " + Rejestr1.ZwrocWartosc().ToString();
                    textBoxAktualnyKrok.Text = (krok+1).ToString();
                }
            }
        }
    }
}
