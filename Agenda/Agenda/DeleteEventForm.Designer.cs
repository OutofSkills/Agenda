namespace AgendaForms
{
    partial class DeleteEventForm
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
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DeleteNameTextBox = new System.Windows.Forms.TextBox();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 225);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDelete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDelete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDelete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDelete.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.RowHeadersVisible = false;
            this.dataGridViewDelete.RowHeadersWidth = 51;
            this.dataGridViewDelete.RowTemplate.Height = 24;
            this.dataGridViewDelete.Size = new System.Drawing.Size(800, 225);
            this.dataGridViewDelete.TabIndex = 1;
            // 
            // EventID
            // 
            this.EventID.FillWeight = 74.37768F;
            this.EventID.HeaderText = "Event ID";
            this.EventID.MinimumWidth = 6;
            this.EventID.Name = "EventID";
            // 
            // EventName
            // 
            this.EventName.FillWeight = 97.31081F;
            this.EventName.HeaderText = "Event Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            // 
            // EventDate
            // 
            this.EventDate.FillWeight = 97.31081F;
            this.EventDate.HeaderText = "Event Date";
            this.EventDate.MinimumWidth = 6;
            this.EventDate.Name = "EventDate";
            // 
            // EventTime
            // 
            this.EventTime.FillWeight = 97.31081F;
            this.EventTime.HeaderText = "Event Time";
            this.EventTime.MinimumWidth = 6;
            this.EventTime.Name = "EventTime";
            // 
            // EventDescription
            // 
            this.EventDescription.FillWeight = 133.6898F;
            this.EventDescription.HeaderText = "Event Description";
            this.EventDescription.MinimumWidth = 10;
            this.EventDescription.Name = "EventDescription";
            // 
            // DeleteDatePicker
            // 
            this.DeleteDatePicker.Location = new System.Drawing.Point(240, 89);
            this.DeleteDatePicker.Name = "DeleteDatePicker";
            this.DeleteDatePicker.Size = new System.Drawing.Size(213, 22);
            this.DeleteDatePicker.TabIndex = 12;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(28, 79);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(79, 32);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Date";
            // 
            // DeleteNameTextBox
            // 
            this.DeleteNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteNameTextBox.Location = new System.Drawing.Point(240, 31);
            this.DeleteNameTextBox.Name = "DeleteNameTextBox";
            this.DeleteNameTextBox.Size = new System.Drawing.Size(213, 30);
            this.DeleteNameTextBox.TabIndex = 10;
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameLabel.Location = new System.Drawing.Point(28, 31);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(180, 32);
            this.EventNameLabel.TabIndex = 9;
            this.EventNameLabel.Text = "Event Name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(515, 54);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 43);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete Event";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeleteDatePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DeleteNameTextBox);
            this.Controls.Add(this.EventNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteEventForm";
            this.Text = "DeleteEventForm";
            this.Load += new System.EventHandler(this.DeleteEventForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDescription;
        private System.Windows.Forms.DateTimePicker DeleteDatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DeleteNameTextBox;
        private System.Windows.Forms.Label EventNameLabel;
        private System.Windows.Forms.Button DeleteButton;
    }
}