namespace Ex2
{
    partial class frm1
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnTranfer = new System.Windows.Forms.Button();
            this.txb16 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb8 = new System.Windows.Forms.TextBox();
            this.txb10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ 16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ 8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hệ 10";
            // 
            // btnTranfer
            // 
            this.btnTranfer.Location = new System.Drawing.Point(263, 105);
            this.btnTranfer.Name = "btnTranfer";
            this.btnTranfer.Size = new System.Drawing.Size(155, 47);
            this.btnTranfer.TabIndex = 4;
            this.btnTranfer.Text = "Tranfering";
            this.btnTranfer.UseVisualStyleBackColor = true;
            this.btnTranfer.Click += new System.EventHandler(this.btnTranfer_Click);
            // 
            // txb16
            // 
            this.txb16.Location = new System.Drawing.Point(188, 37);
            this.txb16.Multiline = true;
            this.txb16.Name = "txb16";
            this.txb16.Size = new System.Drawing.Size(451, 39);
            this.txb16.TabIndex = 5;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(188, 188);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(451, 39);
            this.txb2.TabIndex = 6;
            // 
            // txb8
            // 
            this.txb8.Location = new System.Drawing.Point(188, 275);
            this.txb8.Multiline = true;
            this.txb8.Name = "txb8";
            this.txb8.Size = new System.Drawing.Size(451, 39);
            this.txb8.TabIndex = 7;
            // 
            // txb10
            // 
            this.txb10.Location = new System.Drawing.Point(188, 358);
            this.txb10.Multiline = true;
            this.txb10.Name = "txb10";
            this.txb10.Size = new System.Drawing.Size(451, 39);
            this.txb10.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.txb10);
            this.Controls.Add(this.txb8);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb16);
            this.Controls.Add(this.btnTranfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.TextBox txb16;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb8;
        private System.Windows.Forms.TextBox txb10;
    }
}

