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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdEventNameTextBox = new System.Windows.Forms.TextBox();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.UpdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.UpdTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UpdDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 226);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpdate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUpdate.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUpdate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpdate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.EventName,
            this.EventDate,
            this.EventTime,
            this.EventDescription});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpdate.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUpdate.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.RowHeadersVisible = false;
            this.dataGridViewUpdate.RowHeadersWidth = 51;
            this.dataGridViewUpdate.RowTemplate.Height = 24;
            this.dataGridViewUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpdate.Size = new System.Drawing.Size(862, 226);
            this.dataGridViewUpdate.TabIndex = 1;
            this.dataGridViewUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdate_CellContentClick);
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
            // UpdEventNameTextBox
            // 
            this.UpdEventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdEventNameTextBox.Location = new System.Drawing.Point(406, 37);
            this.UpdEventNameTextBox.Name = "UpdEventNameTextBox";
            this.UpdEventNameTextBox.Size = new System.Drawing.Size(213, 30);
            this.UpdEventNameTextBox.TabIndex = 6;
            this.UpdEventNameTextBox.TextChanged += new System.EventHandler(this.UpdEventNameTextBox_TextChanged);
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.EventNameLabel.Location = new System.Drawing.Point(216, 32);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(169, 35);
            this.EventNameLabel.TabIndex = 5;
            this.EventNameLabel.Text = "Event Name";
            this.EventNameLabel.Click += new System.EventHandler(this.EventNameLabel_Click);
            // 
            // UpdDatePicker
            // 
            this.UpdDatePicker.Location = new System.Drawing.Point(406, 92);
            this.UpdDatePicker.Name = "UpdDatePicker";
            this.UpdDatePicker.Size = new System.Drawing.Size(213, 22);
            this.UpdDatePicker.TabIndex = 8;
            this.UpdDatePicker.ValueChanged += new System.EventHandler(this.UpdDatePicker_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.DateLabel.Location = new System.Drawing.Point(216, 82);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(74, 35);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // UpdTimePicker
            // 
            this.UpdTimePicker.CustomFormat = "";
            this.UpdTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.UpdTimePicker.Location = new System.Drawing.Point(406, 142);
            this.UpdTimePicker.Name = "UpdTimePicker";
            this.UpdTimePicker.ShowUpDown = true;
            this.UpdTimePicker.Size = new System.Drawing.Size(213, 22);
            this.UpdTimePicker.TabIndex = 10;
            this.UpdTimePicker.ValueChanged += new System.EventHandler(this.UpdTimePicker_ValueChanged);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.TimeLabel.Location = new System.Drawing.Point(216, 132);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(79, 35);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // UpdDescriptionTextBox
            // 
            this.UpdDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdDescriptionTextBox.Location = new System.Drawing.Point(406, 191);
            this.UpdDescriptionTextBox.Multiline = true;
            this.UpdDescriptionTextBox.Name = "UpdDescriptionTextBox";
            this.UpdDescriptionTextBox.Size = new System.Drawing.Size(213, 57);
            this.UpdDescriptionTextBox.TabIndex = 12;
            this.UpdDescriptionTextBox.TextChanged += new System.EventHandler(this.UpdDescriptionTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.DescriptionLabel.Location = new System.Drawing.Point(216, 182);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(161, 35);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.Click += new System.EventHandler(this.DescriptionLabel_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(679, 117);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(128, 47);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(42, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 514);
            this.Controls.Add(this.button1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateEventForm";
            this.Text = "Update Event";
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
        private System.Windows.Forms.Button button1;
    }
}