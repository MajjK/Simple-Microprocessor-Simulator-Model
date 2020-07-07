namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDodaj_Rozkaz = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownLiczba = new System.Windows.Forms.NumericUpDown();
            this.labelLiczba = new System.Windows.Forms.Label();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonWczytaj = new System.Windows.Forms.Button();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.textBoxRejestr = new System.Windows.Forms.TextBox();
            this.labelRejestry = new System.Windows.Forms.Label();
            this.radioButtonMOV = new System.Windows.Forms.RadioButton();
            this.radioButtonSUB = new System.Windows.Forms.RadioButton();
            this.radioButtonADD = new System.Windows.Forms.RadioButton();
            this.groupBoxRozkaz = new System.Windows.Forms.GroupBox();
            this.groupBoxRejestr1 = new System.Windows.Forms.GroupBox();
            this.ButtonRej1DL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1DH = new System.Windows.Forms.RadioButton();
            this.ButtonRej1CL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1CH = new System.Windows.Forms.RadioButton();
            this.ButtonRej1BL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1BH = new System.Windows.Forms.RadioButton();
            this.ButtonRej1AL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1AH = new System.Windows.Forms.RadioButton();
            this.groupBoxRejestr2 = new System.Windows.Forms.GroupBox();
            this.ButtonRej2None = new System.Windows.Forms.RadioButton();
            this.ButtonRej2DL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2DH = new System.Windows.Forms.RadioButton();
            this.ButtonRej2CL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2CH = new System.Windows.Forms.RadioButton();
            this.ButtonRej2BL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2BH = new System.Windows.Forms.RadioButton();
            this.ButtonRej2AL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2AH = new System.Windows.Forms.RadioButton();
            this.textBoxAktualnyKrok = new System.Windows.Forms.TextBox();
            this.labelKrok = new System.Windows.Forms.Label();
            this.checkBoxPracaKrokowa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiczba)).BeginInit();
            this.groupBoxRozkaz.SuspendLayout();
            this.groupBoxRejestr1.SuspendLayout();
            this.groupBoxRejestr2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDodaj_Rozkaz
            // 
            this.buttonDodaj_Rozkaz.Location = new System.Drawing.Point(619, 38);
            this.buttonDodaj_Rozkaz.Name = "buttonDodaj_Rozkaz";
            this.buttonDodaj_Rozkaz.Size = new System.Drawing.Size(158, 58);
            this.buttonDodaj_Rozkaz.TabIndex = 1;
            this.buttonDodaj_Rozkaz.Text = "Dodaj Rozkaz";
            this.buttonDodaj_Rozkaz.UseVisualStyleBackColor = true;
            this.buttonDodaj_Rozkaz.Click += new System.EventHandler(this.Rozkaz_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(640, 349);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 56);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Uruchom Progam";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownLiczba
            // 
            this.numericUpDownLiczba.Location = new System.Drawing.Point(461, 41);
            this.numericUpDownLiczba.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLiczba.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLiczba.Name = "numericUpDownLiczba";
            this.numericUpDownLiczba.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLiczba.TabIndex = 9;
            this.numericUpDownLiczba.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelLiczba
            // 
            this.labelLiczba.AutoSize = true;
            this.labelLiczba.Location = new System.Drawing.Point(490, 19);
            this.labelLiczba.Name = "labelLiczba";
            this.labelLiczba.Size = new System.Drawing.Size(49, 17);
            this.labelLiczba.TabIndex = 10;
            this.labelLiczba.Text = "Liczba";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(511, 171);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(94, 37);
            this.buttonZapisz.TabIndex = 11;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonWczytaj
            // 
            this.buttonWczytaj.Location = new System.Drawing.Point(511, 240);
            this.buttonWczytaj.Name = "buttonWczytaj";
            this.buttonWczytaj.Size = new System.Drawing.Size(94, 35);
            this.buttonWczytaj.TabIndex = 12;
            this.buttonWczytaj.Text = "Wczytaj";
            this.buttonWczytaj.UseVisualStyleBackColor = true;
            this.buttonWczytaj.Click += new System.EventHandler(this.buttonWczytaj_Click);
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(619, 115);
            this.textBoxKod.Multiline = true;
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.ReadOnly = true;
            this.textBoxKod.Size = new System.Drawing.Size(166, 206);
            this.textBoxKod.TabIndex = 13;
            // 
            // textBoxRejestr
            // 
            this.textBoxRejestr.Location = new System.Drawing.Point(26, 240);
            this.textBoxRejestr.Multiline = true;
            this.textBoxRejestr.Name = "textBoxRejestr";
            this.textBoxRejestr.ReadOnly = true;
            this.textBoxRejestr.Size = new System.Drawing.Size(158, 187);
            this.textBoxRejestr.TabIndex = 14;
            // 
            // labelRejestry
            // 
            this.labelRejestry.AutoSize = true;
            this.labelRejestry.Location = new System.Drawing.Point(81, 220);
            this.labelRejestry.Name = "labelRejestry";
            this.labelRejestry.Size = new System.Drawing.Size(60, 17);
            this.labelRejestry.TabIndex = 17;
            this.labelRejestry.Text = "Rejestry";
            // 
            // radioButtonMOV
            // 
            this.radioButtonMOV.AutoSize = true;
            this.radioButtonMOV.Location = new System.Drawing.Point(23, 32);
            this.radioButtonMOV.Name = "radioButtonMOV";
            this.radioButtonMOV.Size = new System.Drawing.Size(60, 21);
            this.radioButtonMOV.TabIndex = 18;
            this.radioButtonMOV.TabStop = true;
            this.radioButtonMOV.Text = "MOV";
            this.radioButtonMOV.UseVisualStyleBackColor = true;
            // 
            // radioButtonSUB
            // 
            this.radioButtonSUB.AutoSize = true;
            this.radioButtonSUB.Location = new System.Drawing.Point(23, 59);
            this.radioButtonSUB.Name = "radioButtonSUB";
            this.radioButtonSUB.Size = new System.Drawing.Size(57, 21);
            this.radioButtonSUB.TabIndex = 19;
            this.radioButtonSUB.TabStop = true;
            this.radioButtonSUB.Text = "SUB";
            this.radioButtonSUB.UseVisualStyleBackColor = true;
            // 
            // radioButtonADD
            // 
            this.radioButtonADD.AutoSize = true;
            this.radioButtonADD.Location = new System.Drawing.Point(22, 86);
            this.radioButtonADD.Name = "radioButtonADD";
            this.radioButtonADD.Size = new System.Drawing.Size(58, 21);
            this.radioButtonADD.TabIndex = 20;
            this.radioButtonADD.TabStop = true;
            this.radioButtonADD.Text = "ADD";
            this.radioButtonADD.UseVisualStyleBackColor = true;
            // 
            // groupBoxRozkaz
            // 
            this.groupBoxRozkaz.Controls.Add(this.radioButtonMOV);
            this.groupBoxRozkaz.Controls.Add(this.radioButtonADD);
            this.groupBoxRozkaz.Controls.Add(this.radioButtonSUB);
            this.groupBoxRozkaz.Location = new System.Drawing.Point(26, 19);
            this.groupBoxRozkaz.Name = "groupBoxRozkaz";
            this.groupBoxRozkaz.Size = new System.Drawing.Size(104, 148);
            this.groupBoxRozkaz.TabIndex = 21;
            this.groupBoxRozkaz.TabStop = false;
            this.groupBoxRozkaz.Text = "Rozkaz";
            // 
            // groupBoxRejestr1
            // 
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1DL);
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1DH);
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1CL);
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1CH);
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1BL);
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1BH);
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1AL);
            this.groupBoxRejestr1.Controls.Add(this.ButtonRej1AH);
            this.groupBoxRejestr1.Location = new System.Drawing.Point(169, 19);
            this.groupBoxRejestr1.Name = "groupBoxRejestr1";
            this.groupBoxRejestr1.Size = new System.Drawing.Size(125, 150);
            this.groupBoxRejestr1.TabIndex = 22;
            this.groupBoxRejestr1.TabStop = false;
            this.groupBoxRejestr1.Text = "Rejestr 1";
            // 
            // ButtonRej1DL
            // 
            this.ButtonRej1DL.AutoSize = true;
            this.ButtonRej1DL.Location = new System.Drawing.Point(61, 111);
            this.ButtonRej1DL.Name = "ButtonRej1DL";
            this.ButtonRej1DL.Size = new System.Drawing.Size(56, 21);
            this.ButtonRej1DL.TabIndex = 7;
            this.ButtonRej1DL.TabStop = true;
            this.ButtonRej1DL.Text = "DXL";
            this.ButtonRej1DL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej1DH
            // 
            this.ButtonRej1DH.AutoSize = true;
            this.ButtonRej1DH.Location = new System.Drawing.Point(6, 111);
            this.ButtonRej1DH.Name = "ButtonRej1DH";
            this.ButtonRej1DH.Size = new System.Drawing.Size(58, 21);
            this.ButtonRej1DH.TabIndex = 6;
            this.ButtonRej1DH.TabStop = true;
            this.ButtonRej1DH.Text = "DXH";
            this.ButtonRej1DH.UseVisualStyleBackColor = true;
            // 
            // ButtonRej1CL
            // 
            this.ButtonRej1CL.AutoSize = true;
            this.ButtonRej1CL.Location = new System.Drawing.Point(62, 84);
            this.ButtonRej1CL.Name = "ButtonRej1CL";
            this.ButtonRej1CL.Size = new System.Drawing.Size(55, 21);
            this.ButtonRej1CL.TabIndex = 5;
            this.ButtonRej1CL.TabStop = true;
            this.ButtonRej1CL.Text = "CXL";
            this.ButtonRej1CL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej1CH
            // 
            this.ButtonRej1CH.AutoSize = true;
            this.ButtonRej1CH.Location = new System.Drawing.Point(6, 84);
            this.ButtonRej1CH.Name = "ButtonRej1CH";
            this.ButtonRej1CH.Size = new System.Drawing.Size(57, 21);
            this.ButtonRej1CH.TabIndex = 4;
            this.ButtonRej1CH.TabStop = true;
            this.ButtonRej1CH.Text = "CXH";
            this.ButtonRej1CH.UseVisualStyleBackColor = true;
            // 
            // ButtonRej1BL
            // 
            this.ButtonRej1BL.AutoSize = true;
            this.ButtonRej1BL.Location = new System.Drawing.Point(62, 57);
            this.ButtonRej1BL.Name = "ButtonRej1BL";
            this.ButtonRej1BL.Size = new System.Drawing.Size(55, 21);
            this.ButtonRej1BL.TabIndex = 3;
            this.ButtonRej1BL.TabStop = true;
            this.ButtonRej1BL.Text = "BXL";
            this.ButtonRej1BL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej1BH
            // 
            this.ButtonRej1BH.AutoSize = true;
            this.ButtonRej1BH.Location = new System.Drawing.Point(6, 57);
            this.ButtonRej1BH.Name = "ButtonRej1BH";
            this.ButtonRej1BH.Size = new System.Drawing.Size(57, 21);
            this.ButtonRej1BH.TabIndex = 2;
            this.ButtonRej1BH.TabStop = true;
            this.ButtonRej1BH.Text = "BXH";
            this.ButtonRej1BH.UseVisualStyleBackColor = true;
            // 
            // ButtonRej1AL
            // 
            this.ButtonRej1AL.AutoSize = true;
            this.ButtonRej1AL.Location = new System.Drawing.Point(61, 30);
            this.ButtonRej1AL.Name = "ButtonRej1AL";
            this.ButtonRej1AL.Size = new System.Drawing.Size(55, 21);
            this.ButtonRej1AL.TabIndex = 1;
            this.ButtonRej1AL.TabStop = true;
            this.ButtonRej1AL.Text = "AXL";
            this.ButtonRej1AL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej1AH
            // 
            this.ButtonRej1AH.AutoSize = true;
            this.ButtonRej1AH.Location = new System.Drawing.Point(6, 30);
            this.ButtonRej1AH.Name = "ButtonRej1AH";
            this.ButtonRej1AH.Size = new System.Drawing.Size(57, 21);
            this.ButtonRej1AH.TabIndex = 0;
            this.ButtonRej1AH.TabStop = true;
            this.ButtonRej1AH.Text = "AXH";
            this.ButtonRej1AH.UseVisualStyleBackColor = true;
            // 
            // groupBoxRejestr2
            // 
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2None);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2DL);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2DH);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2CL);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2CH);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2BL);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2BH);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2AL);
            this.groupBoxRejestr2.Controls.Add(this.ButtonRej2AH);
            this.groupBoxRejestr2.Location = new System.Drawing.Point(313, 19);
            this.groupBoxRejestr2.Name = "groupBoxRejestr2";
            this.groupBoxRejestr2.Size = new System.Drawing.Size(128, 169);
            this.groupBoxRejestr2.TabIndex = 0;
            this.groupBoxRejestr2.TabStop = false;
            this.groupBoxRejestr2.Text = "Rejestr 2";
            // 
            // ButtonRej2None
            // 
            this.ButtonRej2None.AutoSize = true;
            this.ButtonRej2None.Location = new System.Drawing.Point(26, 136);
            this.ButtonRej2None.Name = "ButtonRej2None";
            this.ButtonRej2None.Size = new System.Drawing.Size(63, 21);
            this.ButtonRej2None.TabIndex = 8;
            this.ButtonRej2None.TabStop = true;
            this.ButtonRej2None.Text = "None";
            this.ButtonRej2None.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2DL
            // 
            this.ButtonRej2DL.AutoSize = true;
            this.ButtonRej2DL.Location = new System.Drawing.Point(67, 109);
            this.ButtonRej2DL.Name = "ButtonRej2DL";
            this.ButtonRej2DL.Size = new System.Drawing.Size(56, 21);
            this.ButtonRej2DL.TabIndex = 7;
            this.ButtonRej2DL.TabStop = true;
            this.ButtonRej2DL.Text = "DXL";
            this.ButtonRej2DL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2DH
            // 
            this.ButtonRej2DH.AutoSize = true;
            this.ButtonRej2DH.Location = new System.Drawing.Point(4, 109);
            this.ButtonRej2DH.Name = "ButtonRej2DH";
            this.ButtonRej2DH.Size = new System.Drawing.Size(58, 21);
            this.ButtonRej2DH.TabIndex = 6;
            this.ButtonRej2DH.TabStop = true;
            this.ButtonRej2DH.Text = "DXH";
            this.ButtonRej2DH.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2CL
            // 
            this.ButtonRej2CL.AutoSize = true;
            this.ButtonRej2CL.Location = new System.Drawing.Point(67, 82);
            this.ButtonRej2CL.Name = "ButtonRej2CL";
            this.ButtonRej2CL.Size = new System.Drawing.Size(55, 21);
            this.ButtonRej2CL.TabIndex = 5;
            this.ButtonRej2CL.TabStop = true;
            this.ButtonRej2CL.Text = "CXL";
            this.ButtonRej2CL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2CH
            // 
            this.ButtonRej2CH.AutoSize = true;
            this.ButtonRej2CH.Location = new System.Drawing.Point(6, 82);
            this.ButtonRej2CH.Name = "ButtonRej2CH";
            this.ButtonRej2CH.Size = new System.Drawing.Size(57, 21);
            this.ButtonRej2CH.TabIndex = 4;
            this.ButtonRej2CH.TabStop = true;
            this.ButtonRej2CH.Text = "CXH";
            this.ButtonRej2CH.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2BL
            // 
            this.ButtonRej2BL.AutoSize = true;
            this.ButtonRej2BL.Location = new System.Drawing.Point(67, 55);
            this.ButtonRej2BL.Name = "ButtonRej2BL";
            this.ButtonRej2BL.Size = new System.Drawing.Size(55, 21);
            this.ButtonRej2BL.TabIndex = 3;
            this.ButtonRej2BL.TabStop = true;
            this.ButtonRej2BL.Text = "BXL";
            this.ButtonRej2BL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2BH
            // 
            this.ButtonRej2BH.AutoSize = true;
            this.ButtonRej2BH.Location = new System.Drawing.Point(4, 55);
            this.ButtonRej2BH.Name = "ButtonRej2BH";
            this.ButtonRej2BH.Size = new System.Drawing.Size(57, 21);
            this.ButtonRej2BH.TabIndex = 2;
            this.ButtonRej2BH.TabStop = true;
            this.ButtonRej2BH.Text = "BXH";
            this.ButtonRej2BH.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2AL
            // 
            this.ButtonRej2AL.AutoSize = true;
            this.ButtonRej2AL.Location = new System.Drawing.Point(67, 28);
            this.ButtonRej2AL.Name = "ButtonRej2AL";
            this.ButtonRej2AL.Size = new System.Drawing.Size(55, 21);
            this.ButtonRej2AL.TabIndex = 1;
            this.ButtonRej2AL.TabStop = true;
            this.ButtonRej2AL.Text = "AXL";
            this.ButtonRej2AL.UseVisualStyleBackColor = true;
            // 
            // ButtonRej2AH
            // 
            this.ButtonRej2AH.AutoSize = true;
            this.ButtonRej2AH.Location = new System.Drawing.Point(4, 28);
            this.ButtonRej2AH.Name = "ButtonRej2AH";
            this.ButtonRej2AH.Size = new System.Drawing.Size(57, 21);
            this.ButtonRej2AH.TabIndex = 0;
            this.ButtonRej2AH.TabStop = true;
            this.ButtonRej2AH.Text = "AXH";
            this.ButtonRej2AH.UseVisualStyleBackColor = true;
            // 
            // textBoxAktualnyKrok
            // 
            this.textBoxAktualnyKrok.Location = new System.Drawing.Point(593, 416);
            this.textBoxAktualnyKrok.Name = "textBoxAktualnyKrok";
            this.textBoxAktualnyKrok.ReadOnly = true;
            this.textBoxAktualnyKrok.Size = new System.Drawing.Size(142, 22);
            this.textBoxAktualnyKrok.TabIndex = 23;
            // 
            // labelKrok
            // 
            this.labelKrok.AutoSize = true;
            this.labelKrok.Location = new System.Drawing.Point(492, 419);
            this.labelKrok.Name = "labelKrok";
            this.labelKrok.Size = new System.Drawing.Size(95, 17);
            this.labelKrok.TabIndex = 24;
            this.labelKrok.Text = "Aktualny Krok";
            // 
            // checkBoxPracaKrokowa
            // 
            this.checkBoxPracaKrokowa.AutoSize = true;
            this.checkBoxPracaKrokowa.Location = new System.Drawing.Point(493, 384);
            this.checkBoxPracaKrokowa.Name = "checkBoxPracaKrokowa";
            this.checkBoxPracaKrokowa.Size = new System.Drawing.Size(125, 21);
            this.checkBoxPracaKrokowa.TabIndex = 27;
            this.checkBoxPracaKrokowa.Text = "Praca Krokowa";
            this.checkBoxPracaKrokowa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxPracaKrokowa);
            this.Controls.Add(this.labelKrok);
            this.Controls.Add(this.textBoxAktualnyKrok);
            this.Controls.Add(this.groupBoxRejestr2);
            this.Controls.Add(this.groupBoxRejestr1);
            this.Controls.Add(this.groupBoxRozkaz);
            this.Controls.Add(this.labelRejestry);
            this.Controls.Add(this.textBoxRejestr);
            this.Controls.Add(this.textBoxKod);
            this.Controls.Add(this.buttonWczytaj);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.labelLiczba);
            this.Controls.Add(this.numericUpDownLiczba);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDodaj_Rozkaz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiczba)).EndInit();
            this.groupBoxRozkaz.ResumeLayout(false);
            this.groupBoxRozkaz.PerformLayout();
            this.groupBoxRejestr1.ResumeLayout(false);
            this.groupBoxRejestr1.PerformLayout();
            this.groupBoxRejestr2.ResumeLayout(false);
            this.groupBoxRejestr2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDodaj_Rozkaz;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownLiczba;
        private System.Windows.Forms.Label labelLiczba;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonWczytaj;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.TextBox textBoxRejestr;
        private System.Windows.Forms.Label labelRejestry;
        private System.Windows.Forms.RadioButton radioButtonMOV;
        private System.Windows.Forms.RadioButton radioButtonSUB;
        private System.Windows.Forms.RadioButton radioButtonADD;
        private System.Windows.Forms.GroupBox groupBoxRozkaz;
        private System.Windows.Forms.GroupBox groupBoxRejestr1;
        private System.Windows.Forms.RadioButton ButtonRej1DL;
        private System.Windows.Forms.RadioButton ButtonRej1DH;
        private System.Windows.Forms.RadioButton ButtonRej1CL;
        private System.Windows.Forms.RadioButton ButtonRej1CH;
        private System.Windows.Forms.RadioButton ButtonRej1BL;
        private System.Windows.Forms.RadioButton ButtonRej1BH;
        private System.Windows.Forms.RadioButton ButtonRej1AL;
        private System.Windows.Forms.RadioButton ButtonRej1AH;
        private System.Windows.Forms.GroupBox groupBoxRejestr2;
        private System.Windows.Forms.RadioButton ButtonRej2None;
        private System.Windows.Forms.RadioButton ButtonRej2DL;
        private System.Windows.Forms.RadioButton ButtonRej2DH;
        private System.Windows.Forms.RadioButton ButtonRej2CL;
        private System.Windows.Forms.RadioButton ButtonRej2CH;
        private System.Windows.Forms.RadioButton ButtonRej2BL;
        private System.Windows.Forms.RadioButton ButtonRej2BH;
        private System.Windows.Forms.RadioButton ButtonRej2AL;
        private System.Windows.Forms.RadioButton ButtonRej2AH;
        private System.Windows.Forms.TextBox textBoxAktualnyKrok;
        private System.Windows.Forms.Label labelKrok;
        private System.Windows.Forms.CheckBox checkBoxPracaKrokowa;
    }
}

