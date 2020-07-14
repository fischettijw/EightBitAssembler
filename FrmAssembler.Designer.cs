namespace EightBitAssembler
{
    partial class FrmAssembler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlwRam = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSet32 = new System.Windows.Forms.Button();
            this.BtnGet32 = new System.Windows.Forms.Button();
            this.LblRamTitle = new System.Windows.Forms.Label();
            this.PnlRegisters = new System.Windows.Forms.Panel();
            this.LblRegistersTitle = new System.Windows.Forms.Label();
            this.PnlRegisterValues = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblValveB = new System.Windows.Forms.Label();
            this.LblValveA = new System.Windows.Forms.Label();
            this.LblValveC = new System.Windows.Forms.Label();
            this.LblValveIP = new System.Windows.Forms.Label();
            this.LblValveD = new System.Windows.Forms.Label();
            this.LblValveSP = new System.Windows.Forms.Label();
            this.LblFlagF = new System.Windows.Forms.Label();
            this.LblFlagZ = new System.Windows.Forms.Label();
            this.LblFlagC = new System.Windows.Forms.Label();
            this.PnlRegisters.SuspendLayout();
            this.PnlRegisterValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlwRam
            // 
            this.FlwRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlwRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlwRam.Location = new System.Drawing.Point(20, 174);
            this.FlwRam.Name = "FlwRam";
            this.FlwRam.Size = new System.Drawing.Size(514, 514);
            this.FlwRam.TabIndex = 0;
            // 
            // BtnSet32
            // 
            this.BtnSet32.Location = new System.Drawing.Point(192, 6);
            this.BtnSet32.Name = "BtnSet32";
            this.BtnSet32.Size = new System.Drawing.Size(75, 23);
            this.BtnSet32.TabIndex = 1;
            this.BtnSet32.Text = "SET - 32";
            this.BtnSet32.UseVisualStyleBackColor = true;
            this.BtnSet32.Click += new System.EventHandler(this.BtnSet32_Click);
            // 
            // BtnGet32
            // 
            this.BtnGet32.Location = new System.Drawing.Point(355, 3);
            this.BtnGet32.Name = "BtnGet32";
            this.BtnGet32.Size = new System.Drawing.Size(75, 23);
            this.BtnGet32.TabIndex = 2;
            this.BtnGet32.Text = "GET - 32";
            this.BtnGet32.UseVisualStyleBackColor = true;
            this.BtnGet32.Click += new System.EventHandler(this.BtnGet32_Click);
            // 
            // LblRamTitle
            // 
            this.LblRamTitle.AutoSize = true;
            this.LblRamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRamTitle.Location = new System.Drawing.Point(25, 164);
            this.LblRamTitle.Name = "LblRamTitle";
            this.LblRamTitle.Size = new System.Drawing.Size(37, 16);
            this.LblRamTitle.TabIndex = 3;
            this.LblRamTitle.Text = "Ram";
            // 
            // PnlRegisters
            // 
            this.PnlRegisters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlRegisters.Controls.Add(this.LblValveB);
            this.PnlRegisters.Controls.Add(this.LblValveA);
            this.PnlRegisters.Controls.Add(this.LblValveC);
            this.PnlRegisters.Controls.Add(this.LblValveIP);
            this.PnlRegisters.Controls.Add(this.LblValveD);
            this.PnlRegisters.Controls.Add(this.LblValveSP);
            this.PnlRegisters.Controls.Add(this.LblFlagF);
            this.PnlRegisters.Controls.Add(this.LblFlagZ);
            this.PnlRegisters.Controls.Add(this.LblB);
            this.PnlRegisters.Controls.Add(this.LblA);
            this.PnlRegisters.Controls.Add(this.LblC);
            this.PnlRegisters.Controls.Add(this.label5);
            this.PnlRegisters.Controls.Add(this.LblD);
            this.PnlRegisters.Controls.Add(this.label1);
            this.PnlRegisters.Controls.Add(this.label4);
            this.PnlRegisters.Controls.Add(this.label3);
            this.PnlRegisters.Controls.Add(this.label2);
            this.PnlRegisters.Controls.Add(this.PnlRegisterValues);
            this.PnlRegisters.Location = new System.Drawing.Point(20, 64);
            this.PnlRegisters.Name = "PnlRegisters";
            this.PnlRegisters.Size = new System.Drawing.Size(514, 90);
            this.PnlRegisters.TabIndex = 4;
            // 
            // LblRegistersTitle
            // 
            this.LblRegistersTitle.AutoSize = true;
            this.LblRegistersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistersTitle.Location = new System.Drawing.Point(25, 54);
            this.LblRegistersTitle.Name = "LblRegistersTitle";
            this.LblRegistersTitle.Size = new System.Drawing.Size(110, 16);
            this.LblRegistersTitle.TabIndex = 5;
            this.LblRegistersTitle.Text = "Registers / Flags";
            // 
            // PnlRegisterValues
            // 
            this.PnlRegisterValues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlRegisterValues.Controls.Add(this.LblFlagC);
            this.PnlRegisterValues.Location = new System.Drawing.Point(20, 38);
            this.PnlRegisterValues.Name = "PnlRegisterValues";
            this.PnlRegisterValues.Size = new System.Drawing.Size(474, 38);
            this.PnlRegisterValues.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Z";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "F";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "IP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblD.Location = new System.Drawing.Point(188, 15);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(21, 23);
            this.LblD.TabIndex = 6;
            this.LblD.Text = "D";
            this.LblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC.Location = new System.Drawing.Point(140, 15);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(21, 23);
            this.LblC.TabIndex = 7;
            this.LblC.Text = "C";
            this.LblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblB.Location = new System.Drawing.Point(92, 15);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(21, 23);
            this.LblB.TabIndex = 8;
            this.LblB.Text = "B";
            this.LblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA.Location = new System.Drawing.Point(44, 15);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(21, 23);
            this.LblA.TabIndex = 9;
            this.LblA.Text = "A";
            this.LblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "SP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValveB
            // 
            this.LblValveB.AutoSize = true;
            this.LblValveB.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValveB.Location = new System.Drawing.Point(90, 49);
            this.LblValveB.Name = "LblValveB";
            this.LblValveB.Size = new System.Drawing.Size(32, 21);
            this.LblValveB.TabIndex = 17;
            this.LblValveB.Text = "00";
            this.LblValveB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValveA
            // 
            this.LblValveA.AutoSize = true;
            this.LblValveA.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValveA.Location = new System.Drawing.Point(38, 49);
            this.LblValveA.Name = "LblValveA";
            this.LblValveA.Size = new System.Drawing.Size(32, 21);
            this.LblValveA.TabIndex = 18;
            this.LblValveA.Text = "00";
            this.LblValveA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValveC
            // 
            this.LblValveC.AutoSize = true;
            this.LblValveC.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValveC.Location = new System.Drawing.Point(142, 49);
            this.LblValveC.Name = "LblValveC";
            this.LblValveC.Size = new System.Drawing.Size(32, 21);
            this.LblValveC.TabIndex = 16;
            this.LblValveC.Text = "00";
            this.LblValveC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValveIP
            // 
            this.LblValveIP.AutoSize = true;
            this.LblValveIP.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValveIP.Location = new System.Drawing.Point(235, 49);
            this.LblValveIP.Name = "LblValveIP";
            this.LblValveIP.Size = new System.Drawing.Size(32, 21);
            this.LblValveIP.TabIndex = 14;
            this.LblValveIP.Text = "00";
            this.LblValveIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValveD
            // 
            this.LblValveD.AutoSize = true;
            this.LblValveD.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValveD.Location = new System.Drawing.Point(184, 49);
            this.LblValveD.Name = "LblValveD";
            this.LblValveD.Size = new System.Drawing.Size(32, 21);
            this.LblValveD.TabIndex = 15;
            this.LblValveD.Text = "00";
            this.LblValveD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValveSP
            // 
            this.LblValveSP.AutoSize = true;
            this.LblValveSP.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValveSP.Location = new System.Drawing.Point(287, 49);
            this.LblValveSP.Name = "LblValveSP";
            this.LblValveSP.Size = new System.Drawing.Size(32, 21);
            this.LblValveSP.TabIndex = 19;
            this.LblValveSP.Text = "00";
            this.LblValveSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFlagF
            // 
            this.LblFlagF.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlagF.Location = new System.Drawing.Point(440, 45);
            this.LblFlagF.Name = "LblFlagF";
            this.LblFlagF.Size = new System.Drawing.Size(55, 27);
            this.LblFlagF.TabIndex = 13;
            this.LblFlagF.Text = "True";
            this.LblFlagF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFlagZ
            // 
            this.LblFlagZ.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlagZ.Location = new System.Drawing.Point(330, 46);
            this.LblFlagZ.Name = "LblFlagZ";
            this.LblFlagZ.Size = new System.Drawing.Size(55, 27);
            this.LblFlagZ.TabIndex = 11;
            this.LblFlagZ.Text = "True";
            this.LblFlagZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFlagC
            // 
            this.LblFlagC.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlagC.Location = new System.Drawing.Point(363, 6);
            this.LblFlagC.Name = "LblFlagC";
            this.LblFlagC.Size = new System.Drawing.Size(55, 27);
            this.LblFlagC.TabIndex = 14;
            this.LblFlagC.Text = "True";
            this.LblFlagC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAssembler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 712);
            this.Controls.Add(this.LblRegistersTitle);
            this.Controls.Add(this.PnlRegisters);
            this.Controls.Add(this.LblRamTitle);
            this.Controls.Add(this.BtnGet32);
            this.Controls.Add(this.BtnSet32);
            this.Controls.Add(this.FlwRam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAssembler";
            this.Text = "Pseudo Eight Bit Assembler   by   Joseph Fischetti";
            this.Load += new System.EventHandler(this.FrmAssembler_Load);
            this.PnlRegisters.ResumeLayout(false);
            this.PnlRegisters.PerformLayout();
            this.PnlRegisterValues.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlwRam;
        private System.Windows.Forms.Button BtnSet32;
        private System.Windows.Forms.Button BtnGet32;
        private System.Windows.Forms.Label LblRamTitle;
        private System.Windows.Forms.Panel PnlRegisters;
        private System.Windows.Forms.Label LblRegistersTitle;
        private System.Windows.Forms.Panel PnlRegisterValues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblValveB;
        private System.Windows.Forms.Label LblValveA;
        private System.Windows.Forms.Label LblValveC;
        private System.Windows.Forms.Label LblValveIP;
        private System.Windows.Forms.Label LblValveD;
        private System.Windows.Forms.Label LblValveSP;
        private System.Windows.Forms.Label LblFlagF;
        private System.Windows.Forms.Label LblFlagZ;
        private System.Windows.Forms.Label LblFlagC;
    }
}

