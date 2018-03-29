namespace ClassEditor
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
            this.LabelMain = new System.Windows.Forms.Label();
            this.LabelNameClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Location = new System.Drawing.Point(12, 18);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(71, 13);
            this.LabelMain.TabIndex = 0;
            this.LabelMain.Text = "Имя класса:";
            // 
            // LabelNameClass
            // 
            this.LabelNameClass.AutoSize = true;
            this.LabelNameClass.Location = new System.Drawing.Point(90, 18);
            this.LabelNameClass.Name = "LabelNameClass";
            this.LabelNameClass.Size = new System.Drawing.Size(86, 13);
            this.LabelNameClass.TabIndex = 1;
            this.LabelNameClass.Text = "LabelNameClass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 477);
            this.Controls.Add(this.LabelNameClass);
            this.Controls.Add(this.LabelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Label LabelNameClass;
    }
}

