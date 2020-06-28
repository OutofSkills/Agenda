namespace Agenda
{
    partial class WrongCredentials
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(3)))), ((int)(((byte)(23)))));
            this.ErrorLabel.Location = new System.Drawing.Point(0, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(382, 153);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "Wrong Username or Password";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WrongCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.ErrorLabel);
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "WrongCredentials";
            this.Text = "WrongCredentials";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
    }
}