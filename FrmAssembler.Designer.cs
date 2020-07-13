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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FrmAssembler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlwRam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAssembler";
            this.Text = "Pseudo Eight Bit Assembler   by   Joseph Fischetti";
            this.Load += new System.EventHandler(this.FrmAssembler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlwRam;
        private System.Windows.Forms.Label label1;
    }
}

