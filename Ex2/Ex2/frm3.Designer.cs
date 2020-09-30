namespace Ex2
{
    partial class frm3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plainText = new System.Windows.Forms.TextBox();
            this.crypText = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.txbUnCryp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaintext:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vigenere Crypto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CrypText:";
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(146, 72);
            this.plainText.Multiline = true;
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(304, 82);
            this.plainText.TabIndex = 3;
            // 
            // crypText
            // 
            this.crypText.Location = new System.Drawing.Point(146, 284);
            this.crypText.Multiline = true;
            this.crypText.Name = "crypText";
            this.crypText.Size = new System.Drawing.Size(304, 82);
            this.crypText.TabIndex = 4;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(161, 215);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(142, 55);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Key";
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(146, 166);
            this.txbKey.Multiline = true;
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(304, 34);
            this.txbKey.TabIndex = 7;
            // 
            // txbUnCryp
            // 
            this.txbUnCryp.Location = new System.Drawing.Point(146, 394);
            this.txbUnCryp.Multiline = true;
            this.txbUnCryp.Name = "txbUnCryp";
            this.txbUnCryp.Size = new System.Drawing.Size(304, 82);
            this.txbUnCryp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "UncrypText:";
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 512);
            this.Controls.Add(this.txbUnCryp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.crypText);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm3";
            this.Text = "frm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.TextBox crypText;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.TextBox txbUnCryp;
        private System.Windows.Forms.Label label5;
    }
}