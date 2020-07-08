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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccesWindow));
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuccesMovePanel = new System.Windows.Forms.Panel();
            this.MinimizeButtonSuccess = new System.Windows.Forms.Button();
            this.ExitButtonSuccess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuccesMovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Font = new System.Drawing.Font("Bell MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SuccessLabel.Location = new System.Drawing.Point(0, 96);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(450, 145);
            this.SuccessLabel.TabIndex = 0;
            this.SuccessLabel.Text = "Success";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SuccesMovePanel
            // 
            this.SuccesMovePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SuccesMovePanel.Controls.Add(this.MinimizeButtonSuccess);
            this.SuccesMovePanel.Controls.Add(this.ExitButtonSuccess);
            this.SuccesMovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SuccesMovePanel.Location = new System.Drawing.Point(0, 0);
            this.SuccesMovePanel.Name = "SuccesMovePanel";
            this.SuccesMovePanel.Size = new System.Drawing.Size(450, 35);
            this.SuccesMovePanel.TabIndex = 2;
            this.SuccesMovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SuccesMovePanel_MouseDown);
            this.SuccesMovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SuccesMovePanel_MouseMove);
            // 
            // MinimizeButtonSuccess
            // 
            this.MinimizeButtonSuccess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimizeButtonSuccess.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButtonSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MinimizeButtonSuccess.Location = new System.Drawing.Point(366, 0);
            this.MinimizeButtonSuccess.Name = "MinimizeButtonSuccess";
            this.MinimizeButtonSuccess.Size = new System.Drawing.Size(42, 35);
            this.MinimizeButtonSuccess.TabIndex = 1;
            this.MinimizeButtonSuccess.Text = " -";
            this.MinimizeButtonSuccess.UseVisualStyleBackColor = false;
            this.MinimizeButtonSuccess.Click += new System.EventHandler(this.MinimizeButtonSuccess_Click);
            // 
            // ExitButtonSuccess
            // 
            this.ExitButtonSuccess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButtonSuccess.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButtonSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtonSuccess.Location = new System.Drawing.Point(408, 0);
            this.ExitButtonSuccess.Name = "ExitButtonSuccess";
            this.ExitButtonSuccess.Size = new System.Drawing.Size(42, 35);
            this.ExitButtonSuccess.TabIndex = 0;
            this.ExitButtonSuccess.Text = "X";
            this.ExitButtonSuccess.UseVisualStyleBackColor = false;
            this.ExitButtonSuccess.Click += new System.EventHandler(this.ExitButtonSuccess_Click);
            // 
            // SuccesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.SuccesMovePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SuccessLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SuccesMovePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SuccesMovePanel;
        private System.Windows.Forms.Button MinimizeButtonSuccess;
        private System.Windows.Forms.Button ExitButtonSuccess;
    }
}