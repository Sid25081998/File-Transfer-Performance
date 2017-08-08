namespace Lechat_Server_File
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
            this.logView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // logView
            // 
            this.logView.FormattingEnabled = true;
            this.logView.Location = new System.Drawing.Point(12, 12);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(922, 446);
            this.logView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 465);
            this.Controls.Add(this.logView);
            this.Name = "Form1";
            this.Text = "Server Status";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox logView;
    }
}

