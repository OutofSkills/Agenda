namespace AgendaForms
{
    partial class DisplayEventsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.EventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dayCheckBox = new System.Windows.Forms.CheckBox();
            this.weekCheckBox = new System.Windows.Forms.CheckBox();
            this.allEventsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventID,
            this.EventName,
            this.EventDate,
            this.EventTime,
            this.EventDescription});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 203);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(800, 247);
            this.dataGridView.TabIndex = 0;
            // 
            // EventID
            // 
            this.EventID.HeaderText = "Event ID";
            this.EventID.MinimumWidth = 6;
            this.EventID.Name = "EventID";
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            // 
            // EventDate
            // 
            this.EventDate.HeaderText = "Event Date";
            this.EventDate.MinimumWidth = 6;
            this.EventDate.Name = "EventDate";
            // 
            // EventTime
            // 
            this.EventTime.HeaderText = "Event Time";
            this.EventTime.MinimumWidth = 6;
            this.EventTime.Name = "EventTime";
            // 
            // EventDescription
            // 
            this.EventDescription.HeaderText = "Event Description";
            this.EventDescription.MinimumWidth = 6;
            this.EventDescription.Name = "EventDescription";
            // 
            // DisplayButton
            // 
            this.DisplayButton.AutoSize = true;
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayButton.Location = new System.Drawing.Point(474, 64);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(121, 41);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(69, 77);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Day/Week events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // dayCheckBox
            // 
            this.dayCheckBox.AutoSize = true;
            this.dayCheckBox.Location = new System.Drawing.Point(294, 81);
            this.dayCheckBox.Name = "dayCheckBox";
            this.dayCheckBox.Size = new System.Drawing.Size(140, 21);
            this.dayCheckBox.TabIndex = 7;
            this.dayCheckBox.Text = "Events of the day";
            this.dayCheckBox.UseVisualStyleBackColor = true;
            // 
            // weekCheckBox
            // 
            this.weekCheckBox.AutoSize = true;
            this.weekCheckBox.Location = new System.Drawing.Point(294, 108);
            this.weekCheckBox.Name = "weekCheckBox";
            this.weekCheckBox.Size = new System.Drawing.Size(153, 21);
            this.weekCheckBox.TabIndex = 8;
            this.weekCheckBox.Text = "Events of the week ";
            this.weekCheckBox.UseVisualStyleBackColor = true;
            // 
            // allEventsCheckBox
            // 
            this.allEventsCheckBox.AutoSize = true;
            this.allEventsCheckBox.Location = new System.Drawing.Point(294, 135);
            this.allEventsCheckBox.Name = "allEventsCheckBox";
            this.allEventsCheckBox.Size = new System.Drawing.Size(91, 21);
            this.allEventsCheckBox.TabIndex = 9;
            this.allEventsCheckBox.Text = "All events";
            this.allEventsCheckBox.UseVisualStyleBackColor = true;
            // 
            // DisplayEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allEventsCheckBox);
            this.Controls.Add(this.weekCheckBox);
            this.Controls.Add(this.dayCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayEventsForm";
            this.Text = "DisplayEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox dayCheckBox;
        private System.Windows.Forms.CheckBox weekCheckBox;
        private System.Windows.Forms.CheckBox allEventsCheckBox;
    }
}