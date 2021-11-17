namespace oef1
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
            this.txtwords = new System.Windows.Forms.TextBox();
            this.btnsort2 = new System.Windows.Forms.Button();
            this.btnsort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtwords
            // 
            this.txtwords.Location = new System.Drawing.Point(12, 12);
            this.txtwords.Multiline = true;
            this.txtwords.Name = "txtwords";
            this.txtwords.Size = new System.Drawing.Size(138, 140);
            this.txtwords.TabIndex = 0;
            this.txtwords.TextChanged += new System.EventHandler(this.Txtwords_TextChanged);
            // 
            // btnsort2
            // 
            this.btnsort2.Location = new System.Drawing.Point(174, 132);
            this.btnsort2.Name = "btnsort2";
            this.btnsort2.Size = new System.Drawing.Size(107, 20);
            this.btnsort2.TabIndex = 1;
            this.btnsort2.Text = "sort2";
            this.btnsort2.UseVisualStyleBackColor = true;
            this.btnsort2.Click += new System.EventHandler(this.Btnsort2_Click);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(174, 12);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(107, 20);
            this.btnsort.TabIndex = 2;
            this.btnsort.Text = "sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.Btnsort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.btnsort2);
            this.Controls.Add(this.txtwords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwords;
        private System.Windows.Forms.Button btnsort2;
        private System.Windows.Forms.Button btnsort;
    }
}

