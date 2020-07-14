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
            this.LblA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.PnlRegisters.Controls.Add(this.label10);
            this.PnlRegisters.Controls.Add(this.label11);
            this.PnlRegisters.Controls.Add(this.label12);
            this.PnlRegisters.Controls.Add(this.label13);
            this.PnlRegisters.Controls.Add(this.label14);
            this.PnlRegisters.Controls.Add(this.label15);
            this.PnlRegisters.Controls.Add(this.label16);
            this.PnlRegisters.Controls.Add(this.label17);
            this.PnlRegisters.Controls.Add(this.label18);
            this.PnlRegisters.Controls.Add(this.label8);
            this.PnlRegisters.Controls.Add(this.label9);
            this.PnlRegisters.Controls.Add(this.label7);
            this.PnlRegisters.Controls.Add(this.label5);
            this.PnlRegisters.Controls.Add(this.label6);
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
            this.PnlRegisterValues.Controls.Add(this.LblA);
            this.PnlRegisterValues.Location = new System.Drawing.Point(20, 38);
            this.PnlRegisterValues.Name = "PnlRegisterValues";
            this.PnlRegisterValues.Size = new System.Drawing.Size(474, 38);
            this.PnlRegisterValues.TabIndex = 0;
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(103, -85);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(22, 16);
            this.LblA.TabIndex = 0;
            this.LblA.Text = "00";
            this.LblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "00";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(245, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(193, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(297, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "00";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(453, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "00";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(401, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "00";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(349, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "00";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PnlRegisterValues.PerformLayout();
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
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

