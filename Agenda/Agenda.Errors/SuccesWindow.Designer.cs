namespace AgendaErrors
{
    partial class SuccesWindow
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
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuccessLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccessLabel.Location = new System.Drawing.Point(0, 0);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(552, 212);
            this.SuccessLabel.TabIndex = 0;
            this.SuccessLabel.Text = "Success";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuccesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 212);
            this.Controls.Add(this.SuccessLabel);
            this.Name = "SuccesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccesWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SuccessLabel;
    }
}