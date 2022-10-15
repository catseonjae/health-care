namespace hackerton
{
    partial class Form3
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
            this.Dumbbell = new System.Windows.Forms.CheckBox();
            this.armcurlmachine = new System.Windows.Forms.CheckBox();
            this.metalpole = new System.Windows.Forms.CheckBox();
            this.Declinebench = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "자신이 사용가능한 운동기구를 모두 선택하시오.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dumbbell
            // 
            this.Dumbbell.AutoSize = true;
            this.Dumbbell.Location = new System.Drawing.Point(181, 175);
            this.Dumbbell.Name = "Dumbbell";
            this.Dumbbell.Size = new System.Drawing.Size(59, 19);
            this.Dumbbell.TabIndex = 1;
            this.Dumbbell.Text = "덤벨";
            this.Dumbbell.UseVisualStyleBackColor = true;
            this.Dumbbell.CheckedChanged += new System.EventHandler(this.Dumbbell_CheckedChanged);
            // 
            // armcurlmachine
            // 
            this.armcurlmachine.AutoSize = true;
            this.armcurlmachine.Location = new System.Drawing.Point(181, 221);
            this.armcurlmachine.Name = "armcurlmachine";
            this.armcurlmachine.Size = new System.Drawing.Size(94, 19);
            this.armcurlmachine.TabIndex = 2;
            this.armcurlmachine.Text = "암컬 머신";
            this.armcurlmachine.UseVisualStyleBackColor = true;
            this.armcurlmachine.CheckedChanged += new System.EventHandler(this.armcurlmachine_CheckedChanged);
            // 
            // metalpole
            // 
            this.metalpole.AutoSize = true;
            this.metalpole.Location = new System.Drawing.Point(393, 175);
            this.metalpole.Name = "metalpole";
            this.metalpole.Size = new System.Drawing.Size(59, 19);
            this.metalpole.TabIndex = 3;
            this.metalpole.Text = "철봉";
            this.metalpole.UseVisualStyleBackColor = true;
            this.metalpole.CheckedChanged += new System.EventHandler(this.metalpole_CheckedChanged);
            // 
            // Declinebench
            // 
            this.Declinebench.AutoSize = true;
            this.Declinebench.Location = new System.Drawing.Point(393, 221);
            this.Declinebench.Name = "Declinebench";
            this.Declinebench.Size = new System.Drawing.Size(119, 19);
            this.Declinebench.TabIndex = 4;
            this.Declinebench.Text = "디클라인벤치";
            this.Declinebench.UseVisualStyleBackColor = true;
            this.Declinebench.CheckedChanged += new System.EventHandler(this.Declinebench_CheckedChanged);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(695, 405);
            this.Controls.Add(this.Declinebench);
            this.Controls.Add(this.metalpole);
            this.Controls.Add(this.armcurlmachine);
            this.Controls.Add(this.Dumbbell);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Dumbbell;
        private System.Windows.Forms.CheckBox armcurlmachine;
        private System.Windows.Forms.CheckBox metalpole;
        private System.Windows.Forms.CheckBox Declinebench;
    }
}