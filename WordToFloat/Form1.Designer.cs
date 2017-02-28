namespace WordToFloat
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
            this.txtWordHigh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWordLow = new System.Windows.Forms.TextBox();
            this.txtFloatValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWordHigh
            // 
            this.txtWordHigh.Location = new System.Drawing.Point(12, 30);
            this.txtWordHigh.Name = "txtWordHigh";
            this.txtWordHigh.Size = new System.Drawing.Size(62, 20);
            this.txtWordHigh.TabIndex = 0;
            this.txtWordHigh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWordHigh_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word High:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Word Low:";
            // 
            // txtWordLow
            // 
            this.txtWordLow.Location = new System.Drawing.Point(91, 30);
            this.txtWordLow.Name = "txtWordLow";
            this.txtWordLow.Size = new System.Drawing.Size(62, 20);
            this.txtWordLow.TabIndex = 1;
            // 
            // txtFloatValue
            // 
            this.txtFloatValue.Location = new System.Drawing.Point(178, 30);
            this.txtFloatValue.Name = "txtFloatValue";
            this.txtFloatValue.Size = new System.Drawing.Size(99, 20);
            this.txtFloatValue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 82);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFloatValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWordLow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWordHigh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Word To Float...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWordLow;
        private System.Windows.Forms.TextBox txtFloatValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

