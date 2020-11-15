namespace mycalculate
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.NumericUpDown();
            this.txtnumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnbxplus = new System.Windows.Forms.Button();
            this.btnbxmulitple = new System.Windows.Forms.Button();
            this.btnbxdivide = new System.Windows.Forms.Button();
            this.btnbxminus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(461, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(49, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "عدد اول :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(461, 62);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(49, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "عدد دوم :";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(12, 19);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnumber1.Size = new System.Drawing.Size(433, 20);
            this.txtnumber1.TabIndex = 2;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(12, 60);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnumber2.Size = new System.Drawing.Size(433, 20);
            this.txtnumber2.TabIndex = 3;
            // 
            // btnbxplus
            // 
            this.btnbxplus.Location = new System.Drawing.Point(30, 96);
            this.btnbxplus.Name = "btnbxplus";
            this.btnbxplus.Size = new System.Drawing.Size(45, 23);
            this.btnbxplus.TabIndex = 4;
            this.btnbxplus.Text = "+";
            this.btnbxplus.UseVisualStyleBackColor = true;
            this.btnbxplus.Click += new System.EventHandler(this.Btnbxplus_Click);
            // 
            // btnbxmulitple
            // 
            this.btnbxmulitple.Location = new System.Drawing.Point(258, 96);
            this.btnbxmulitple.Name = "btnbxmulitple";
            this.btnbxmulitple.Size = new System.Drawing.Size(45, 23);
            this.btnbxmulitple.TabIndex = 5;
            this.btnbxmulitple.Text = "*";
            this.btnbxmulitple.UseVisualStyleBackColor = true;
            this.btnbxmulitple.Click += new System.EventHandler(this.Btnbxmulitple_Click);
            // 
            // btnbxdivide
            // 
            this.btnbxdivide.Location = new System.Drawing.Point(366, 96);
            this.btnbxdivide.Name = "btnbxdivide";
            this.btnbxdivide.Size = new System.Drawing.Size(45, 23);
            this.btnbxdivide.TabIndex = 6;
            this.btnbxdivide.Text = "/";
            this.btnbxdivide.UseVisualStyleBackColor = true;
            this.btnbxdivide.Click += new System.EventHandler(this.Btnbxdivide_Click);
            // 
            // btnbxminus
            // 
            this.btnbxminus.Location = new System.Drawing.Point(132, 96);
            this.btnbxminus.Name = "btnbxminus";
            this.btnbxminus.Size = new System.Drawing.Size(45, 23);
            this.btnbxminus.TabIndex = 7;
            this.btnbxminus.Text = "-";
            this.btnbxminus.UseVisualStyleBackColor = true;
            this.btnbxminus.Click += new System.EventHandler(this.Btnbxminus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 133);
            this.Controls.Add(this.btnbxminus);
            this.Controls.Add(this.btnbxdivide);
            this.Controls.Add(this.btnbxmulitple);
            this.Controls.Add(this.btnbxplus);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ماشین حساب من";
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown txtnumber1;
        private System.Windows.Forms.NumericUpDown txtnumber2;
        private System.Windows.Forms.Button btnbxplus;
        private System.Windows.Forms.Button btnbxmulitple;
        private System.Windows.Forms.Button btnbxdivide;
        private System.Windows.Forms.Button btnbxminus;
    }
}

