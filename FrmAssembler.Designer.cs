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
            this.SuspendLayout();
            // 
            // FlwRam
            // 
            this.FlwRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlwRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FlwRam.Location = new System.Drawing.Point(21, 101);
            this.FlwRam.Name = "FlwRam";
            this.FlwRam.Size = new System.Drawing.Size(514, 514);
            this.FlwRam.TabIndex = 0;
            // 
            // BtnSet32
            // 
            this.BtnSet32.Location = new System.Drawing.Point(185, 36);
            this.BtnSet32.Name = "BtnSet32";
            this.BtnSet32.Size = new System.Drawing.Size(75, 23);
            this.BtnSet32.TabIndex = 1;
            this.BtnSet32.Text = "SET - 32";
            this.BtnSet32.UseVisualStyleBackColor = true;
            this.BtnSet32.Click += new System.EventHandler(this.BtnSet32_Click);
            // 
            // BtnGet32
            // 
            this.BtnGet32.Location = new System.Drawing.Point(357, 36);
            this.BtnGet32.Name = "BtnGet32";
            this.BtnGet32.Size = new System.Drawing.Size(75, 23);
            this.BtnGet32.TabIndex = 2;
            this.BtnGet32.Text = "GET - 32";
            this.BtnGet32.UseVisualStyleBackColor = true;
            this.BtnGet32.Click += new System.EventHandler(this.BtnGet32_Click);
            // 
            // FrmAssembler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 632);
            this.Controls.Add(this.BtnGet32);
            this.Controls.Add(this.BtnSet32);
            this.Controls.Add(this.FlwRam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAssembler";
            this.Text = "Pseudo Eight Bit Assembler   by   Joseph Fischetti";
            this.Load += new System.EventHandler(this.FrmAssembler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlwRam;
        private System.Windows.Forms.Button BtnSet32;
        private System.Windows.Forms.Button BtnGet32;
    }
}

