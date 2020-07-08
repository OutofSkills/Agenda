namespace AgendaErrors
{
    public partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorMovePanel = new System.Windows.Forms.Panel();
            this.MinimizeButtonError = new System.Windows.Forms.Button();
            this.ExitButtonError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ErrorMovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Bell MT", 25.8F, System.Drawing.FontStyle.Bold);
            this.ErrorLabel.Location = new System.Drawing.Point(0, 98);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(450, 143);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorMovePanel
            // 
            this.ErrorMovePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ErrorMovePanel.Controls.Add(this.MinimizeButtonError);
            this.ErrorMovePanel.Controls.Add(this.ExitButtonError);
            this.ErrorMovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorMovePanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorMovePanel.Name = "ErrorMovePanel";
            this.ErrorMovePanel.Size = new System.Drawing.Size(450, 35);
            this.ErrorMovePanel.TabIndex = 2;
            this.ErrorMovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ErrorMovePanel_MouseDown);
            this.ErrorMovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ErrorMovePanel_MouseMove);
            // 
            // MinimizeButtonError
            // 
            this.MinimizeButtonError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimizeButtonError.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButtonError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MinimizeButtonError.Location = new System.Drawing.Point(366, 0);
            this.MinimizeButtonError.Name = "MinimizeButtonError";
            this.MinimizeButtonError.Size = new System.Drawing.Size(42, 35);
            this.MinimizeButtonError.TabIndex = 1;
            this.MinimizeButtonError.Text = " -";
            this.MinimizeButtonError.UseVisualStyleBackColor = false;
            this.MinimizeButtonError.Click += new System.EventHandler(this.MinimizeButtonError_Click);
            // 
            // ExitButtonError
            // 
            this.ExitButtonError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButtonError.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButtonError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.ExitButtonError.Location = new System.Drawing.Point(408, 0);
            this.ExitButtonError.Name = "ExitButtonError";
            this.ExitButtonError.Size = new System.Drawing.Size(42, 35);
            this.ExitButtonError.TabIndex = 0;
            this.ExitButtonError.Text = "X";
            this.ExitButtonError.UseVisualStyleBackColor = false;
            this.ExitButtonError.Click += new System.EventHandler(this.ExitButtonError_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.ErrorMovePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ErrorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ErrorMovePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ErrorMovePanel;
        private System.Windows.Forms.Button MinimizeButtonError;
        private System.Windows.Forms.Button ExitButtonError;
    }
}