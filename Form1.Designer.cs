namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// </summary>
        /// <param name="disposing"></param>
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
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd_Order = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.labelValue = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxRejegister = new System.Windows.Forms.TextBox();
            this.labelRegisters = new System.Windows.Forms.Label();
            this.radioButtonMOV = new System.Windows.Forms.RadioButton();
            this.radioButtonSUB = new System.Windows.Forms.RadioButton();
            this.radioButtonADD = new System.Windows.Forms.RadioButton();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.groupBoxRegister1 = new System.Windows.Forms.GroupBox();
            this.ButtonRej1DL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1DH = new System.Windows.Forms.RadioButton();
            this.ButtonRej1CL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1CH = new System.Windows.Forms.RadioButton();
            this.ButtonRej1BL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1BH = new System.Windows.Forms.RadioButton();
            this.ButtonRej1AL = new System.Windows.Forms.RadioButton();
            this.ButtonRej1AH = new System.Windows.Forms.RadioButton();
            this.groupBoxRegister2 = new System.Windows.Forms.GroupBox();
            this.ButtonRej2None = new System.Windows.Forms.RadioButton();
            this.ButtonRej2DL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2DH = new System.Windows.Forms.RadioButton();
            this.ButtonRej2CL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2CH = new System.Windows.Forms.RadioButton();
            this.ButtonRej2BL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2BH = new System.Windows.Forms.RadioButton();
            this.ButtonRej2AL = new System.Windows.Forms.RadioButton();
            this.ButtonRej2AH = new System.Windows.Forms.RadioButton();
            this.textBoxCurrentStep = new System.Windows.Forms.TextBox();
            this.labelStep = new System.Windows.Forms.Label();
            this.checkBoxStepWork = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxRegister1.SuspendLayout();
            this.groupBoxRegister2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd_Order
            // 
            this.buttonAdd_Order.Location = new System.Drawing.Point(619, 38);
            this.buttonAdd_Order.Name = "buttonAdd_Order";
            this.buttonAdd_Order.Size = new System.Drawing.Size(158, 58);
            this.buttonAdd_Order.TabIndex = 1;
            this.buttonAdd_Order.Text = "Add Order";
            this.buttonAdd_Order.UseVisualStyleBackColor = true;
            this.buttonAdd_Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(640, 349);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 56);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Execute Progam";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(461, 41);
            this.numericUpDownValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownValue.TabIndex = 9;
            this.numericUpDownValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(490, 19);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(44, 17);
            this.labelValue.TabIndex = 10;
            this.labelValue.Text = "Value";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(511, 171);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 37);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(511, 240);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(94, 35);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(619, 115);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(166, 206);
            this.textBoxCode.TabIndex = 13;
            // 
            // textBoxRejegister
            // 
            this.textBoxRejegister.Location = new System.Drawing.Point(26, 240);
            this.textBoxRejegister.Multiline = true;
            this.textBoxRejegister.Name = "textBoxRejegister";
            this.textBoxRejegister.ReadOnly = true;
            this.textBoxRejegister.Size = new System.Drawing.Size(158, 187);
            this.textBoxRejegister.TabIndex = 14;
            // 
            // labelRegisters
            // 
            this.labelRegisters.AutoSize = true;
            this.labelRegisters.Location = new System.Drawing.Point(81, 220);
            this.labelRegisters.Name = "labelRegisters";
            this.labelRegisters.Size = new System.Drawing.Size(68, 17);
            this.labelRegisters.TabIndex = 17;
            this.labelRegisters.Text = "Registers";
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
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.radioButtonMOV);
            this.groupBoxOrder.Controls.Add(this.radioButtonADD);
            this.groupBoxOrder.Controls.Add(this.radioButtonSUB);
            this.groupBoxOrder.Location = new System.Drawing.Point(26, 19);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(104, 148);
            this.groupBoxOrder.TabIndex = 21;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Order";
            // 
            // groupBoxRegister1
            // 
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1DL);
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1DH);
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1CL);
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1CH);
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1BL);
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1BH);
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1AL);
            this.groupBoxRegister1.Controls.Add(this.ButtonRej1AH);
            this.groupBoxRegister1.Location = new System.Drawing.Point(169, 19);
            this.groupBoxRegister1.Name = "groupBoxRegister1";
            this.groupBoxRegister1.Size = new System.Drawing.Size(125, 150);
            this.groupBoxRegister1.TabIndex = 22;
            this.groupBoxRegister1.TabStop = false;
            this.groupBoxRegister1.Text = "Register 1";
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
            // groupBoxRegister2
            // 
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2None);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2DL);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2DH);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2CL);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2CH);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2BL);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2BH);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2AL);
            this.groupBoxRegister2.Controls.Add(this.ButtonRej2AH);
            this.groupBoxRegister2.Location = new System.Drawing.Point(313, 19);
            this.groupBoxRegister2.Name = "groupBoxRegister2";
            this.groupBoxRegister2.Size = new System.Drawing.Size(128, 169);
            this.groupBoxRegister2.TabIndex = 0;
            this.groupBoxRegister2.TabStop = false;
            this.groupBoxRegister2.Text = "Register 2";
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
            // textBoxCurrentStep
            // 
            this.textBoxCurrentStep.Location = new System.Drawing.Point(593, 416);
            this.textBoxCurrentStep.Name = "textBoxCurrentStep";
            this.textBoxCurrentStep.ReadOnly = true;
            this.textBoxCurrentStep.Size = new System.Drawing.Size(142, 22);
            this.textBoxCurrentStep.TabIndex = 23;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(492, 419);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(88, 17);
            this.labelStep.TabIndex = 24;
            this.labelStep.Text = "Current Step";
            // 
            // checkBoxStepWork
            // 
            this.checkBoxStepWork.AutoSize = true;
            this.checkBoxStepWork.Location = new System.Drawing.Point(493, 384);
            this.checkBoxStepWork.Name = "checkBoxStepWork";
            this.checkBoxStepWork.Size = new System.Drawing.Size(96, 21);
            this.checkBoxStepWork.TabIndex = 27;
            this.checkBoxStepWork.Text = "Step Work";
            this.checkBoxStepWork.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxStepWork);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.textBoxCurrentStep);
            this.Controls.Add(this.groupBoxRegister2);
            this.Controls.Add(this.groupBoxRegister1);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.labelRegisters);
            this.Controls.Add(this.textBoxRejegister);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAdd_Order);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxRegister1.ResumeLayout(false);
            this.groupBoxRegister1.PerformLayout();
            this.groupBoxRegister2.ResumeLayout(false);
            this.groupBoxRegister2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd_Order;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxRejegister;
        private System.Windows.Forms.Label labelRegisters;
        private System.Windows.Forms.RadioButton radioButtonMOV;
        private System.Windows.Forms.RadioButton radioButtonSUB;
        private System.Windows.Forms.RadioButton radioButtonADD;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.GroupBox groupBoxRegister1;
        private System.Windows.Forms.RadioButton ButtonRej1DL;
        private System.Windows.Forms.RadioButton ButtonRej1DH;
        private System.Windows.Forms.RadioButton ButtonRej1CL;
        private System.Windows.Forms.RadioButton ButtonRej1CH;
        private System.Windows.Forms.RadioButton ButtonRej1BL;
        private System.Windows.Forms.RadioButton ButtonRej1BH;
        private System.Windows.Forms.RadioButton ButtonRej1AL;
        private System.Windows.Forms.RadioButton ButtonRej1AH;
        private System.Windows.Forms.GroupBox groupBoxRegister2;
        private System.Windows.Forms.RadioButton ButtonRej2None;
        private System.Windows.Forms.RadioButton ButtonRej2DL;
        private System.Windows.Forms.RadioButton ButtonRej2DH;
        private System.Windows.Forms.RadioButton ButtonRej2CL;
        private System.Windows.Forms.RadioButton ButtonRej2CH;
        private System.Windows.Forms.RadioButton ButtonRej2BL;
        private System.Windows.Forms.RadioButton ButtonRej2BH;
        private System.Windows.Forms.RadioButton ButtonRej2AL;
        private System.Windows.Forms.RadioButton ButtonRej2AH;
        private System.Windows.Forms.TextBox textBoxCurrentStep;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.CheckBox checkBoxStepWork;
    }
}

