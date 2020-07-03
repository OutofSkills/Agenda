namespace AgendaForms
{
    partial class AgendaMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.MoveMenuPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.MoveMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.DisplayButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 449);
            this.panel1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(40, 350);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(176, 54);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete Event";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(40, 50);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(176, 54);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create Event";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(40, 250);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(176, 54);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update Event";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayButton.Location = new System.Drawing.Point(40, 150);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(176, 54);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "Display Event";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // MoveMenuPanel
            // 
            this.MoveMenuPanel.Controls.Add(this.MinimizeButton);
            this.MoveMenuPanel.Controls.Add(this.ExitButton);
            this.MoveMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveMenuPanel.Location = new System.Drawing.Point(253, 0);
            this.MoveMenuPanel.Name = "MoveMenuPanel";
            this.MoveMenuPanel.Size = new System.Drawing.Size(542, 35);
            this.MoveMenuPanel.TabIndex = 1;
            this.MoveMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgendaMenu_MouseDown);
            this.MoveMenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AgendaMenu_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.Location = new System.Drawing.Point(458, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(42, 35);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = " -";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.Location = new System.Drawing.Point(500, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 35);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(253, 35);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(542, 414);
            this.panelChildForm.TabIndex = 2;
            // 
            // AgendaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(795, 449);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.MoveMenuPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaMenu";
            this.Text = "AgendaMenu";
            this.panel1.ResumeLayout(false);
            this.MoveMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Panel MoveMenuPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panelChildForm;
    }
}