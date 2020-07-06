namespace AgendaForms
{
    partial class UpdateEventForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.UpdEventNameTextBox = new System.Windows.Forms.TextBox();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.UpdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.UpdTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UpdDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 226);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpdate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUpdate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpdate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.EventName,
            this.EventDate,
            this.EventTime,
            this.EventDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUpdate.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.RowHeadersVisible = false;
            this.dataGridViewUpdate.RowHeadersWidth = 51;
            this.dataGridViewUpdate.RowTemplate.Height = 24;
            this.dataGridViewUpdate.Size = new System.Drawing.Size(809, 226);
            this.dataGridViewUpdate.TabIndex = 1;
            this.dataGridViewUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdate_CellContentClick);
            // 
            // UpdEventNameTextBox
            // 
            this.UpdEventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdEventNameTextBox.Location = new System.Drawing.Point(237, 28);
            this.UpdEventNameTextBox.Name = "UpdEventNameTextBox";
            this.UpdEventNameTextBox.Size = new System.Drawing.Size(213, 30);
            this.UpdEventNameTextBox.TabIndex = 6;
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameLabel.Location = new System.Drawing.Point(25, 28);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(180, 32);
            this.EventNameLabel.TabIndex = 5;
            this.EventNameLabel.Text = "Event Name";
            // 
            // UpdDatePicker
            // 
            this.UpdDatePicker.Location = new System.Drawing.Point(237, 86);
            this.UpdDatePicker.Name = "UpdDatePicker";
            this.UpdDatePicker.Size = new System.Drawing.Size(213, 22);
            this.UpdDatePicker.TabIndex = 8;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(25, 76);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(79, 32);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Date";
            // 
            // UpdTimePicker
            // 
            this.UpdTimePicker.CustomFormat = "";
            this.UpdTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.UpdTimePicker.Location = new System.Drawing.Point(237, 124);
            this.UpdTimePicker.Name = "UpdTimePicker";
            this.UpdTimePicker.ShowUpDown = true;
            this.UpdTimePicker.Size = new System.Drawing.Size(213, 22);
            this.UpdTimePicker.TabIndex = 10;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(25, 124);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(82, 32);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "Time";
            // 
            // UpdDescriptionTextBox
            // 
            this.UpdDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdDescriptionTextBox.Location = new System.Drawing.Point(237, 163);
            this.UpdDescriptionTextBox.Multiline = true;
            this.UpdDescriptionTextBox.Name = "UpdDescriptionTextBox";
            this.UpdDescriptionTextBox.Size = new System.Drawing.Size(213, 57);
            this.UpdDescriptionTextBox.TabIndex = 12;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(25, 163);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(169, 32);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Description";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(494, 104);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(118, 42);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // EventID
            // 
            this.EventID.FillWeight = 80.21387F;
            this.EventID.HeaderText = "Event ID";
            this.EventID.MinimumWidth = 6;
            this.EventID.Name = "EventID";
            // 
            // EventName
            // 
            this.EventName.FillWeight = 95.97646F;
            this.EventName.HeaderText = "Event Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            // 
            // EventDate
            // 
            this.EventDate.FillWeight = 95.97646F;
            this.EventDate.HeaderText = "Event Date";
            this.EventDate.MinimumWidth = 6;
            this.EventDate.Name = "EventDate";
            // 
            // EventTime
            // 
            this.EventTime.FillWeight = 95.97646F;
            this.EventTime.HeaderText = "Event Time";
            this.EventTime.MinimumWidth = 6;
            this.EventTime.Name = "EventTime";
            // 
            // EventDescription
            // 
            this.EventDescription.FillWeight = 131.8566F;
            this.EventDescription.HeaderText = "Event Description";
            this.EventDescription.MinimumWidth = 10;
            this.EventDescription.Name = "EventDescription";
            // 
            // UpdateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 492);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdDescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.UpdTimePicker);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.UpdDatePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.UpdEventNameTextBox);
            this.Controls.Add(this.EventNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateEventForm";
            this.Text = "ЙЙ";
            this.Load += new System.EventHandler(this.UpdateEventForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewUpdate;
        private System.Windows.Forms.TextBox UpdEventNameTextBox;
        private System.Windows.Forms.Label EventNameLabel;
        private System.Windows.Forms.DateTimePicker UpdDatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker UpdTimePicker;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox UpdDescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDescription;
    }
}