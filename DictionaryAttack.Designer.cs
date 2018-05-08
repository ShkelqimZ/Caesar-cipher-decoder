namespace Projekti_Siguria_te_dhenave
{
    partial class DictionaryAttack
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
            this.rtbTekstiDekriptuar = new System.Windows.Forms.RichTextBox();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.txtEnkriptuar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbTekstiDekriptuar
            // 
            this.rtbTekstiDekriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTekstiDekriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTekstiDekriptuar.Location = new System.Drawing.Point(15, 116);
            this.rtbTekstiDekriptuar.Name = "rtbTekstiDekriptuar";
            this.rtbTekstiDekriptuar.Size = new System.Drawing.Size(629, 349);
            this.rtbTekstiDekriptuar.TabIndex = 14;
            this.rtbTekstiDekriptuar.Text = "";
            this.rtbTekstiDekriptuar.TextChanged += new System.EventHandler(this.rtbTekstiDekriptuar_TextChanged);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDekripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.Location = new System.Drawing.Point(505, 69);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(139, 41);
            this.btnDekripto.TabIndex = 13;
            this.btnDekripto.Text = "Decript";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // txtEnkriptuar
            // 
            this.txtEnkriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnkriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnkriptuar.Location = new System.Drawing.Point(15, 40);
            this.txtEnkriptuar.Name = "txtEnkriptuar";
            this.txtEnkriptuar.Size = new System.Drawing.Size(629, 23);
            this.txtEnkriptuar.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input text";
            // 
            // DictionaryAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(656, 478);
            this.Controls.Add(this.rtbTekstiDekriptuar);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.txtEnkriptuar);
            this.Controls.Add(this.label1);
            this.Name = "DictionaryAttack";
            this.Text = "Word Frequency";
            this.Load += new System.EventHandler(this.DictionaryAttack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTekstiDekriptuar;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.TextBox txtEnkriptuar;
        private System.Windows.Forms.Label label1;
    }
}