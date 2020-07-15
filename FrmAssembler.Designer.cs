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
            this.BtnSet = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            this.LblRamTitle = new System.Windows.Forms.Label();
            this.PnlRegisters = new System.Windows.Forms.Panel();
            this.LblValveB = new System.Windows.Forms.Label();
            this.LblValveA = new System.Windows.Forms.Label();
            this.LblValveC = new System.Windows.Forms.Label();
            this.LblValveIP = new System.Windows.Forms.Label();
            this.LblValveD = new System.Windows.Forms.Label();
            this.LblValveSP = new System.Windows.Forms.Label();
            this.LblFlagF = new System.Windows.Forms.Label();
            this.LblFlagZ = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlRegisterValues = new System.Windows.Forms.Panel();
            this.LblFlagC = new System.Windows.Forms.Label();
            this.LblRegistersTitle = new System.Windows.Forms.Label();
            this.TxtSetAddress = new System.Windows.Forms.TextBox();
            this.TxtSetValue = new System.Windows.Forms.TextBox();
            this.TxtGetValue = new System.Windows.Forms.TextBox();
            this.TxtGetAddress = new System.Windows.Forms.TextBox();
            this.LblCodeTitle = new System.Windows.Forms.Label();
            this.PnlCode = new System.Windows.Forms.Panel();
            this.LbxCode = new System.Windows.Forms.ListBox();
            this.BtnAddRow = new System.Windows.Forms.Button();
            this.PnlRegisters.SuspendLayout();
            this.PnlRegisterValues.SuspendLayout();
            this.PnlCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlwRam
            // 
            this.FlwRam.BackColor = System.Drawing.SystemColors.Control;
            this.FlwRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlwRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlwRam.Location = new System.Drawing.Point(597, 179);
            this.FlwRam.Name = "FlwRam";
            this.FlwRam.Size = new System.Drawing.Size(514, 514);
            this.FlwRam.TabIndex = 0;
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(542, 198);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(46, 23);
            this.BtnSet.TabIndex = 1;
            this.BtnSet.Text = "SET";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.Location = new System.Drawing.Point(542, 345);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(46, 23);
            this.BtnGet.TabIndex = 2;
            this.BtnGet.Text = "GET";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // LblRamTitle
            // 
            this.LblRamTitle.AutoSize = true;
            this.LblRamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRamTitle.Location = new System.Drawing.Point(602, 169);
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
            this.PnlRegisters.Location = new System.Drawing.Point(597, 69);
            this.PnlRegisters.Name = "PnlRegisters";
            this.PnlRegisters.Size = new System.Drawing.Size(514, 90);
            this.PnlRegisters.TabIndex = 4;
            // 
            // LblValveB
            // 
            this.LblValveB.AutoSize = true;
            this.LblValveB.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValveB.Location = new System.Drawing.Point(78, 49);
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
            this.LblValveA.Location = new System.Drawing.Point(30, 49);
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
            this.LblValveC.Location = new System.Drawing.Point(126, 49);
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
            this.LblValveIP.Location = new System.Drawing.Point(220, 49);
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
            this.LblValveD.Location = new System.Drawing.Point(174, 49);
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
            this.LblValveSP.Location = new System.Drawing.Point(272, 49);
            this.LblValveSP.Name = "LblValveSP";
            this.LblValveSP.Size = new System.Drawing.Size(32, 21);
            this.LblValveSP.TabIndex = 19;
            this.LblValveSP.Text = "00";
            this.LblValveSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFlagF
            // 
            this.LblFlagF.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlagF.Location = new System.Drawing.Point(435, 45);
            this.LblFlagF.Name = "LblFlagF";
            this.LblFlagF.Size = new System.Drawing.Size(65, 27);
            this.LblFlagF.TabIndex = 13;
            this.LblFlagF.Text = "False";
            this.LblFlagF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFlagZ
            // 
            this.LblFlagZ.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlagZ.Location = new System.Drawing.Point(315, 46);
            this.LblFlagZ.Name = "LblFlagZ";
            this.LblFlagZ.Size = new System.Drawing.Size(65, 27);
            this.LblFlagZ.TabIndex = 11;
            this.LblFlagZ.Text = "False";
            this.LblFlagZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblB.Location = new System.Drawing.Point(84, 15);
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
            this.LblA.Location = new System.Drawing.Point(36, 15);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(21, 23);
            this.LblA.TabIndex = 9;
            this.LblA.Text = "A";
            this.LblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC.Location = new System.Drawing.Point(132, 15);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(21, 23);
            this.LblC.TabIndex = 7;
            this.LblC.Text = "C";
            this.LblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 15);
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
            this.LblD.Location = new System.Drawing.Point(180, 15);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(21, 23);
            this.LblD.TabIndex = 6;
            this.LblD.Text = "D";
            this.LblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "SP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Z";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // LblFlagC
            // 
            this.LblFlagC.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlagC.Location = new System.Drawing.Point(353, 6);
            this.LblFlagC.Name = "LblFlagC";
            this.LblFlagC.Size = new System.Drawing.Size(65, 27);
            this.LblFlagC.TabIndex = 14;
            this.LblFlagC.Text = "False";
            this.LblFlagC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRegistersTitle
            // 
            this.LblRegistersTitle.AutoSize = true;
            this.LblRegistersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistersTitle.Location = new System.Drawing.Point(602, 59);
            this.LblRegistersTitle.Name = "LblRegistersTitle";
            this.LblRegistersTitle.Size = new System.Drawing.Size(110, 16);
            this.LblRegistersTitle.TabIndex = 5;
            this.LblRegistersTitle.Text = "Registers / Flags";
            // 
            // TxtSetAddress
            // 
            this.TxtSetAddress.Location = new System.Drawing.Point(542, 226);
            this.TxtSetAddress.Name = "TxtSetAddress";
            this.TxtSetAddress.Size = new System.Drawing.Size(46, 22);
            this.TxtSetAddress.TabIndex = 6;
            this.TxtSetAddress.Text = "55";
            this.TxtSetAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSetValue
            // 
            this.TxtSetValue.Location = new System.Drawing.Point(542, 253);
            this.TxtSetValue.Name = "TxtSetValue";
            this.TxtSetValue.Size = new System.Drawing.Size(46, 22);
            this.TxtSetValue.TabIndex = 7;
            this.TxtSetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtGetValue
            // 
            this.TxtGetValue.Location = new System.Drawing.Point(542, 401);
            this.TxtGetValue.Name = "TxtGetValue";
            this.TxtGetValue.ReadOnly = true;
            this.TxtGetValue.Size = new System.Drawing.Size(46, 22);
            this.TxtGetValue.TabIndex = 9;
            this.TxtGetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtGetAddress
            // 
            this.TxtGetAddress.Location = new System.Drawing.Point(542, 374);
            this.TxtGetAddress.Name = "TxtGetAddress";
            this.TxtGetAddress.Size = new System.Drawing.Size(46, 22);
            this.TxtGetAddress.TabIndex = 8;
            this.TxtGetAddress.Text = "55";
            this.TxtGetAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCodeTitle
            // 
            this.LblCodeTitle.AutoSize = true;
            this.LblCodeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodeTitle.Location = new System.Drawing.Point(24, 169);
            this.LblCodeTitle.Name = "LblCodeTitle";
            this.LblCodeTitle.Size = new System.Drawing.Size(41, 16);
            this.LblCodeTitle.TabIndex = 11;
            this.LblCodeTitle.Text = "Code";
            // 
            // PnlCode
            // 
            this.PnlCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCode.Controls.Add(this.LbxCode);
            this.PnlCode.Location = new System.Drawing.Point(17, 179);
            this.PnlCode.Name = "PnlCode";
            this.PnlCode.Size = new System.Drawing.Size(514, 514);
            this.PnlCode.TabIndex = 12;
            // 
            // LbxCode
            // 
            this.LbxCode.BackColor = System.Drawing.SystemColors.Control;
            this.LbxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbxCode.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxCode.FormattingEnabled = true;
            this.LbxCode.ItemHeight = 21;
            this.LbxCode.Location = new System.Drawing.Point(-1, 8);
            this.LbxCode.Name = "LbxCode";
            this.LbxCode.Size = new System.Drawing.Size(510, 504);
            this.LbxCode.TabIndex = 0;
            // 
            // BtnAddRow
            // 
            this.BtnAddRow.Location = new System.Drawing.Point(171, 67);
            this.BtnAddRow.Name = "BtnAddRow";
            this.BtnAddRow.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRow.TabIndex = 13;
            this.BtnAddRow.Text = "Add Row";
            this.BtnAddRow.UseVisualStyleBackColor = true;
            this.BtnAddRow.Click += new System.EventHandler(this.BtnAddRow_Click);
            // 
            // FrmAssembler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 712);
            this.Controls.Add(this.BtnAddRow);
            this.Controls.Add(this.LblCodeTitle);
            this.Controls.Add(this.TxtGetValue);
            this.Controls.Add(this.TxtGetAddress);
            this.Controls.Add(this.TxtSetValue);
            this.Controls.Add(this.TxtSetAddress);
            this.Controls.Add(this.LblRegistersTitle);
            this.Controls.Add(this.PnlRegisters);
            this.Controls.Add(this.LblRamTitle);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.FlwRam);
            this.Controls.Add(this.PnlCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAssembler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pseudo Eight Bit Assembler   by   Joseph Fischetti";
            this.Load += new System.EventHandler(this.FrmAssembler_Load);
            this.PnlRegisters.ResumeLayout(false);
            this.PnlRegisters.PerformLayout();
            this.PnlRegisterValues.ResumeLayout(false);
            this.PnlCode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlwRam;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.Button BtnGet;
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
        private System.Windows.Forms.TextBox TxtSetAddress;
        private System.Windows.Forms.TextBox TxtSetValue;
        private System.Windows.Forms.TextBox TxtGetValue;
        private System.Windows.Forms.TextBox TxtGetAddress;
        private System.Windows.Forms.Label LblCodeTitle;
        private System.Windows.Forms.Panel PnlCode;
        private System.Windows.Forms.ListBox LbxCode;
        private System.Windows.Forms.Button BtnAddRow;
    }
}

