namespace Projekti_Siguria_te_dhenave
{
    partial class LetterFrequency
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
            this.btnDekripto = new System.Windows.Forms.Button();
            this.txtEnkriptuar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbETekstiDekriptuar = new System.Windows.Forms.RichTextBox();
            this.rtbATekstiDekriptuar = new System.Windows.Forms.RichTextBox();
            this.rtbITekstiDekriptuar = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDekripto
            // 
            this.btnDekripto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDekripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.Location = new System.Drawing.Point(498, 78);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(149, 44);
            this.btnDekripto.TabIndex = 9;
            this.btnDekripto.Text = "Decript";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // txtEnkriptuar
            // 
            this.txtEnkriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnkriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnkriptuar.Location = new System.Drawing.Point(12, 49);
            this.txtEnkriptuar.Name = "txtEnkriptuar";
            this.txtEnkriptuar.Size = new System.Drawing.Size(635, 23);
            this.txtEnkriptuar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input text";
            // 
            // rtbETekstiDekriptuar
            // 
            this.rtbETekstiDekriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbETekstiDekriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbETekstiDekriptuar.Location = new System.Drawing.Point(12, 128);
            this.rtbETekstiDekriptuar.Name = "rtbETekstiDekriptuar";
            this.rtbETekstiDekriptuar.Size = new System.Drawing.Size(635, 95);
            this.rtbETekstiDekriptuar.TabIndex = 10;
            this.rtbETekstiDekriptuar.Text = "";
            // 
            // rtbATekstiDekriptuar
            // 
            this.rtbATekstiDekriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbATekstiDekriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbATekstiDekriptuar.Location = new System.Drawing.Point(12, 253);
            this.rtbATekstiDekriptuar.Name = "rtbATekstiDekriptuar";
            this.rtbATekstiDekriptuar.Size = new System.Drawing.Size(635, 95);
            this.rtbATekstiDekriptuar.TabIndex = 11;
            this.rtbATekstiDekriptuar.Text = "";
            // 
            // rtbITekstiDekriptuar
            // 
            this.rtbITekstiDekriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbITekstiDekriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbITekstiDekriptuar.Location = new System.Drawing.Point(12, 379);
            this.rtbITekstiDekriptuar.Name = "rtbITekstiDekriptuar";
            this.rtbITekstiDekriptuar.Size = new System.Drawing.Size(635, 95);
            this.rtbITekstiDekriptuar.TabIndex = 12;
            this.rtbITekstiDekriptuar.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Frequency of E";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Frequency of A";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Frequency of I";
            // 
            // LetterFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(659, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbITekstiDekriptuar);
            this.Controls.Add(this.rtbATekstiDekriptuar);
            this.Controls.Add(this.rtbETekstiDekriptuar);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.txtEnkriptuar);
            this.Controls.Add(this.label1);
            this.Name = "LetterFrequency";
            this.Text = "Letter Frequency";
            this.Load += new System.EventHandler(this.LetterFrequency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.TextBox txtEnkriptuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbETekstiDekriptuar;
        private System.Windows.Forms.RichTextBox rtbATekstiDekriptuar;
        private System.Windows.Forms.RichTextBox rtbITekstiDekriptuar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}