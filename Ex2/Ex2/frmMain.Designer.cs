namespace Ex2
{
    partial class frmMain
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
            this.btn_a = new System.Windows.Forms.Button();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercise 2 - NCSC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // btn_a
            // 
            this.btn_a.Location = new System.Drawing.Point(111, 109);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(245, 45);
            this.btn_a.TabIndex = 5;
            this.btn_a.Text = "Transfer 16 to 2,8,10";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // btn_b
            // 
            this.btn_b.Location = new System.Drawing.Point(111, 190);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(245, 45);
            this.btn_b.TabIndex = 6;
            this.btn_b.Text = "Encode and Decode";
            this.btn_b.UseVisualStyleBackColor = true;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(111, 275);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(245, 45);
            this.btn_c.TabIndex = 7;
            this.btn_c.Text = "Vigenere Cipher";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 364);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_c;
    }
}