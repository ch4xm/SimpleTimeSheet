namespace SimpleTimeCard
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "asda"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, null);
            this.clockIn = new System.Windows.Forms.Button();
            this.clockOut = new System.Windows.Forms.Button();
            this.timeSheetItems = new System.Windows.Forms.ListView();
            this.finishWork = new System.Windows.Forms.Button();
            this.clearForm = new System.Windows.Forms.Button();
            this.loadForm = new System.Windows.Forms.Button();
            this.addEntry = new System.Windows.Forms.Button();
            this.removeEntry = new System.Windows.Forms.Button();
            this.editEntry = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockIn
            // 
            this.clockIn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.clockIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clockIn.FlatAppearance.BorderSize = 0;
            this.clockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockIn.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clockIn.Location = new System.Drawing.Point(67, 393);
            this.clockIn.Name = "clockIn";
            this.clockIn.Size = new System.Drawing.Size(255, 53);
            this.clockIn.TabIndex = 0;
            this.clockIn.Text = "Clock In";
            this.clockIn.UseVisualStyleBackColor = false;
            // 
            // clockOut
            // 
            this.clockOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clockOut.FlatAppearance.BorderSize = 0;
            this.clockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockOut.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOut.Location = new System.Drawing.Point(67, 452);
            this.clockOut.Name = "clockOut";
            this.clockOut.Size = new System.Drawing.Size(255, 53);
            this.clockOut.TabIndex = 1;
            this.clockOut.Text = "Clock Out";
            this.clockOut.UseVisualStyleBackColor = false;
            // 
            // timeSheetItems
            // 
            this.timeSheetItems.AllowDrop = true;
            this.timeSheetItems.BackColor = System.Drawing.SystemColors.Window;
            this.timeSheetItems.HideSelection = false;
            this.timeSheetItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.timeSheetItems.Location = new System.Drawing.Point(12, 58);
            this.timeSheetItems.Name = "timeSheetItems";
            this.timeSheetItems.Size = new System.Drawing.Size(360, 274);
            this.timeSheetItems.TabIndex = 3;
            this.timeSheetItems.UseCompatibleStateImageBehavior = false;
            this.timeSheetItems.View = System.Windows.Forms.View.Details;
            this.timeSheetItems.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // finishWork
            // 
            this.finishWork.Location = new System.Drawing.Point(12, 515);
            this.finishWork.Name = "finishWork";
            this.finishWork.Size = new System.Drawing.Size(360, 41);
            this.finishWork.TabIndex = 4;
            this.finishWork.Text = "Finish Work";
            this.finishWork.UseVisualStyleBackColor = true;
            this.finishWork.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearForm
            // 
            this.clearForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearForm.AutoSize = true;
            this.clearForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearForm.Location = new System.Drawing.Point(221, 3);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(67, 23);
            this.clearForm.TabIndex = 5;
            this.clearForm.Text = "Clear Form";
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.clearForm_Click);
            // 
            // loadForm
            // 
            this.loadForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadForm.AutoSize = true;
            this.loadForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadForm.Location = new System.Drawing.Point(294, 3);
            this.loadForm.Name = "loadForm";
            this.loadForm.Size = new System.Drawing.Size(67, 23);
            this.loadForm.TabIndex = 6;
            this.loadForm.Text = "Load Form";
            this.loadForm.UseVisualStyleBackColor = true;
            this.loadForm.Click += new System.EventHandler(this.loadForm_Click);
            // 
            // addEntry
            // 
            this.addEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEntry.AutoSize = true;
            this.addEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEntry.Location = new System.Drawing.Point(3, 3);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(63, 23);
            this.addEntry.TabIndex = 7;
            this.addEntry.Text = "Add Entry";
            this.addEntry.UseVisualStyleBackColor = true;
            this.addEntry.Click += new System.EventHandler(this.addEntry_Click);
            // 
            // removeEntry
            // 
            this.removeEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeEntry.AutoSize = true;
            this.removeEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeEntry.Location = new System.Drawing.Point(140, 3);
            this.removeEntry.Name = "removeEntry";
            this.removeEntry.Size = new System.Drawing.Size(75, 23);
            this.removeEntry.TabIndex = 8;
            this.removeEntry.Text = "Delete Entry";
            this.removeEntry.UseVisualStyleBackColor = true;
            // 
            // editEntry
            // 
            this.editEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editEntry.AutoSize = true;
            this.editEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editEntry.Location = new System.Drawing.Point(72, 3);
            this.editEntry.Name = "editEntry";
            this.editEntry.Size = new System.Drawing.Size(62, 23);
            this.editEntry.TabIndex = 9;
            this.editEntry.Text = "Edit Entry";
            this.editEntry.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.addEntry, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearForm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.editEntry, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeEntry, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadForm, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 338);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 29);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.finishWork);
            this.Controls.Add(this.timeSheetItems);
            this.Controls.Add(this.clockOut);
            this.Controls.Add(this.clockIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Sheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clockIn;
        private System.Windows.Forms.Button clockOut;
        private System.Windows.Forms.ListView timeSheetItems;
        private System.Windows.Forms.Button finishWork;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.Button loadForm;
        private System.Windows.Forms.Button addEntry;
        private System.Windows.Forms.Button removeEntry;
        private System.Windows.Forms.Button editEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

