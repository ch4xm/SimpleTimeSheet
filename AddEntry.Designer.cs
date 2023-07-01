namespace SimpleTimeCard
{
    partial class AddEntry
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
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.clockIn = new System.Windows.Forms.RadioButton();
            this.clockOut = new System.Windows.Forms.RadioButton();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.currentTime = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(32, 183);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 0;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(113, 183);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(12, 107);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(197, 72);
            this.noteTextBox.TabIndex = 2;
            // 
            // clockIn
            // 
            this.clockIn.AutoSize = true;
            this.clockIn.Location = new System.Drawing.Point(12, 43);
            this.clockIn.Name = "clockIn";
            this.clockIn.Size = new System.Drawing.Size(64, 17);
            this.clockIn.TabIndex = 3;
            this.clockIn.TabStop = true;
            this.clockIn.Text = "Clock In";
            this.clockIn.UseVisualStyleBackColor = true;
            // 
            // clockOut
            // 
            this.clockOut.AutoSize = true;
            this.clockOut.Location = new System.Drawing.Point(12, 66);
            this.clockOut.Name = "clockOut";
            this.clockOut.Size = new System.Drawing.Size(72, 17);
            this.clockOut.TabIndex = 4;
            this.clockOut.TabStop = true;
            this.clockOut.Text = "Clock Out";
            this.clockOut.UseVisualStyleBackColor = true;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(10, 15);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(104, 20);
            this.timePicker.TabIndex = 5;
            this.timePicker.Value = new System.DateTime(2023, 7, 1, 13, 57, 0, 0);
            // 
            // currentTime
            // 
            this.currentTime.Location = new System.Drawing.Point(126, 15);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(77, 20);
            this.currentTime.TabIndex = 6;
            this.currentTime.Text = "Current Time";
            this.currentTime.UseVisualStyleBackColor = true;
            this.currentTime.Click += new System.EventHandler(this.button3_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(12, 91);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(30, 13);
            this.noteLabel.TabIndex = 7;
            this.noteLabel.Text = "Note";
            this.noteLabel.Click += new System.EventHandler(this.noteLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(10, 2);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Time";
            // 
            // AddEntry
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(221, 211);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.clockOut);
            this.Controls.Add(this.clockIn);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEntry";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.RadioButton clockIn;
        private System.Windows.Forms.RadioButton clockOut;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button currentTime;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}