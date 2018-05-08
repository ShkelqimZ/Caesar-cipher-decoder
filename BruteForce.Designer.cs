namespace Projekti_Siguria_te_dhenave
{
    partial class BruteForce
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnkriptuar = new System.Windows.Forms.TextBox();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.rtxtRastet = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input text";
            // 
            // txtEnkriptuar
            // 
            this.txtEnkriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnkriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnkriptuar.Location = new System.Drawing.Point(15, 48);
            this.txtEnkriptuar.Name = "txtEnkriptuar";
            this.txtEnkriptuar.Size = new System.Drawing.Size(632, 23);
            this.txtEnkriptuar.TabIndex = 1;
            // 
            // btnDekripto
            // 
            this.btnDekripto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDekripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.Location = new System.Drawing.Point(526, 77);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(121, 43);
            this.btnDekripto.TabIndex = 2;
            this.btnDekripto.Text = "Decript";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // rtxtRastet
            // 
            this.rtxtRastet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtRastet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtRastet.Location = new System.Drawing.Point(12, 126);
            this.rtxtRastet.Name = "rtxtRastet";
            this.rtxtRastet.Size = new System.Drawing.Size(635, 346);
            this.rtxtRastet.TabIndex = 3;
            this.rtxtRastet.Text = "";
            // 
            // BruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(659, 484);
            this.Controls.Add(this.rtxtRastet);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.txtEnkriptuar);
            this.Controls.Add(this.label1);
            this.Name = "BruteForce";
            this.Text = "BruteForce";
            this.Load += new System.EventHandler(this.BruteForce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnkriptuar;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.RichTextBox rtxtRastet;
    }
}