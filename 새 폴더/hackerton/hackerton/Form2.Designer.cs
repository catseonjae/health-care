namespace hackerton
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.leveltext = new System.Windows.Forms.TextBox();
            this.levelinputbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "자신의 푸쉬업 갯수를 입력하시오.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leveltext
            // 
            this.leveltext.Location = new System.Drawing.Point(219, 203);
            this.leveltext.Name = "leveltext";
            this.leveltext.Size = new System.Drawing.Size(186, 25);
            this.leveltext.TabIndex = 2;
            this.leveltext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // levelinputbutton
            // 
            this.levelinputbutton.Location = new System.Drawing.Point(435, 203);
            this.levelinputbutton.Name = "levelinputbutton";
            this.levelinputbutton.Size = new System.Drawing.Size(47, 29);
            this.levelinputbutton.TabIndex = 3;
            this.levelinputbutton.Text = "입력";
            this.levelinputbutton.UseVisualStyleBackColor = true;
            this.levelinputbutton.Click += new System.EventHandler(this.levelinputbutton_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(695, 405);
            this.Controls.Add(this.levelinputbutton);
            this.Controls.Add(this.leveltext);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox leveltext;
        private System.Windows.Forms.Button levelinputbutton;
    }
}