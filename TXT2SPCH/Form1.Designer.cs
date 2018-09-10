namespace TXT2SPCH
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnspeak = new System.Windows.Forms.Button();
            this.btnresume = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(511, 288);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnspeak
            // 
            this.btnspeak.Location = new System.Drawing.Point(102, 306);
            this.btnspeak.Name = "btnspeak";
            this.btnspeak.Size = new System.Drawing.Size(75, 23);
            this.btnspeak.TabIndex = 1;
            this.btnspeak.Text = "Speak";
            this.btnspeak.UseVisualStyleBackColor = true;
            this.btnspeak.Click += new System.EventHandler(this.btnspeak_Click);
            // 
            // btnresume
            // 
            this.btnresume.Location = new System.Drawing.Point(183, 306);
            this.btnresume.Name = "btnresume";
            this.btnresume.Size = new System.Drawing.Size(75, 23);
            this.btnresume.TabIndex = 2;
            this.btnresume.Text = "Resume";
            this.btnresume.UseVisualStyleBackColor = true;
            this.btnresume.Click += new System.EventHandler(this.btnresume_Click);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(264, 306);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(75, 23);
            this.btnpause.TabIndex = 3;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(345, 306);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 341);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnresume);
            this.Controls.Add(this.btnspeak);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "TXT To Speech";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnspeak;
        private System.Windows.Forms.Button btnresume;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnstop;
    }
}

