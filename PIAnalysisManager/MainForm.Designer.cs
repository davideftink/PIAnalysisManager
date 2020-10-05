namespace PIAnalysisManager
{
    partial class MainForm
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
            this.piSystemPicker1 = new OSIsoft.AF.UI.PISystemPicker();
            this.afDatabasePicker1 = new OSIsoft.AF.UI.AFDatabasePicker();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelElementName = new System.Windows.Forms.Label();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackfill = new System.Windows.Forms.Button();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnalysisTemplate = new System.Windows.Forms.Label();
            this.txtAnalysisTemplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.radBackfill = new System.Windows.Forms.RadioButton();
            this.radRecalc = new System.Windows.Forms.RadioButton();
            this.btnExportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // piSystemPicker1
            // 
            this.piSystemPicker1.AccessibleDescription = "PI System Picker";
            this.piSystemPicker1.AccessibleName = "PI System Picker";
            this.piSystemPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker1.EnableBegin = false;
            this.piSystemPicker1.EnableDelete = false;
            this.piSystemPicker1.EnableEnd = false;
            this.piSystemPicker1.EnableList = false;
            this.piSystemPicker1.EnableNavigation = false;
            this.piSystemPicker1.EnableNew = false;
            this.piSystemPicker1.EnableNext = false;
            this.piSystemPicker1.EnablePrevious = false;
            this.piSystemPicker1.EnableProperties = false;
            this.piSystemPicker1.Location = new System.Drawing.Point(22, 12);
            this.piSystemPicker1.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker1.Name = "piSystemPicker1";
            this.piSystemPicker1.ShowBegin = false;
            this.piSystemPicker1.ShowDelete = false;
            this.piSystemPicker1.ShowEnd = false;
            this.piSystemPicker1.ShowFind = false;
            this.piSystemPicker1.ShowList = false;
            this.piSystemPicker1.ShowNavigation = false;
            this.piSystemPicker1.ShowNew = false;
            this.piSystemPicker1.ShowNext = false;
            this.piSystemPicker1.ShowPrevious = false;
            this.piSystemPicker1.ShowProperties = false;
            this.piSystemPicker1.Size = new System.Drawing.Size(366, 22);
            this.piSystemPicker1.TabIndex = 0;
            // 
            // afDatabasePicker1
            // 
            this.afDatabasePicker1.AccessibleDescription = "Database Picker";
            this.afDatabasePicker1.AccessibleName = "Database Picker";
            this.afDatabasePicker1.EnableBegin = false;
            this.afDatabasePicker1.EnableDelete = false;
            this.afDatabasePicker1.EnableEnd = false;
            this.afDatabasePicker1.EnableList = false;
            this.afDatabasePicker1.EnableNavigation = false;
            this.afDatabasePicker1.EnableNew = false;
            this.afDatabasePicker1.EnableNext = false;
            this.afDatabasePicker1.EnablePrevious = false;
            this.afDatabasePicker1.EnableProperties = false;
            this.afDatabasePicker1.Location = new System.Drawing.Point(22, 40);
            this.afDatabasePicker1.Name = "afDatabasePicker1";
            this.afDatabasePicker1.ShowBegin = false;
            this.afDatabasePicker1.ShowDelete = false;
            this.afDatabasePicker1.ShowEnd = false;
            this.afDatabasePicker1.ShowFind = false;
            this.afDatabasePicker1.ShowList = false;
            this.afDatabasePicker1.ShowNavigation = false;
            this.afDatabasePicker1.ShowNew = false;
            this.afDatabasePicker1.ShowNext = false;
            this.afDatabasePicker1.ShowPrevious = false;
            this.afDatabasePicker1.ShowProperties = false;
            this.afDatabasePicker1.Size = new System.Drawing.Size(366, 22);
            this.afDatabasePicker1.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(117, 163);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(271, 75);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(287, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Analysis Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelElementName
            // 
            this.labelElementName.AutoSize = true;
            this.labelElementName.Location = new System.Drawing.Point(19, 92);
            this.labelElementName.Name = "labelElementName";
            this.labelElementName.Size = new System.Drawing.Size(92, 13);
            this.labelElementName.TabIndex = 4;
            this.labelElementName.Text = "AF Element Name";
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(117, 89);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(164, 20);
            this.txtElementName.TabIndex = 5;
            this.txtElementName.Text = "*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(940, 485);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnBackfill
            // 
            this.btnBackfill.Enabled = false;
            this.btnBackfill.Location = new System.Drawing.Point(735, 39);
            this.btnBackfill.Name = "btnBackfill";
            this.btnBackfill.Size = new System.Drawing.Size(101, 23);
            this.btnBackfill.TabIndex = 7;
            this.btnBackfill.Text = "Backfill/Recalc";
            this.btnBackfill.UseVisualStyleBackColor = true;
            this.btnBackfill.Click += new System.EventHandler(this.btnBackfill_Click);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(533, 44);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(55, 13);
            this.labelStartTime.TabIndex = 8;
            this.labelStartTime.Text = "Start Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(594, 41);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 9;
            this.txtStartTime.Text = "*-1h";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(533, 74);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(52, 13);
            this.labelEndTime.TabIndex = 10;
            this.labelEndTime.Text = "End Time";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(594, 71);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndTime.TabIndex = 11;
            this.txtEndTime.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // labelAnalysisTemplate
            // 
            this.labelAnalysisTemplate.AutoSize = true;
            this.labelAnalysisTemplate.Location = new System.Drawing.Point(19, 125);
            this.labelAnalysisTemplate.Name = "labelAnalysisTemplate";
            this.labelAnalysisTemplate.Size = new System.Drawing.Size(92, 13);
            this.labelAnalysisTemplate.TabIndex = 13;
            this.labelAnalysisTemplate.Text = "Analysis Template";
            // 
            // txtAnalysisTemplate
            // 
            this.txtAnalysisTemplate.Location = new System.Drawing.Point(117, 122);
            this.txtAnalysisTemplate.Name = "txtAnalysisTemplate";
            this.txtAnalysisTemplate.Size = new System.Drawing.Size(164, 20);
            this.txtAnalysisTemplate.TabIndex = 14;
            this.txtAnalysisTemplate.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Output Message";
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(735, 156);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(101, 23);
            this.btnEnable.TabIndex = 16;
            this.btnEnable.Text = "Enable Selected";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Enabled = false;
            this.btnDisable.Location = new System.Drawing.Point(735, 185);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(101, 23);
            this.btnDisable.TabIndex = 17;
            this.btnDisable.Text = "Disable Selected";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Enabled = false;
            this.chkSelectAll.Location = new System.Drawing.Point(318, 125);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 18;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // radBackfill
            // 
            this.radBackfill.AutoSize = true;
            this.radBackfill.Checked = true;
            this.radBackfill.Location = new System.Drawing.Point(735, 72);
            this.radBackfill.Name = "radBackfill";
            this.radBackfill.Size = new System.Drawing.Size(175, 17);
            this.radBackfill.TabIndex = 19;
            this.radBackfill.TabStop = true;
            this.radBackfill.Text = "Fill gaps and leave existing data";
            this.radBackfill.UseVisualStyleBackColor = true;
            // 
            // radRecalc
            // 
            this.radRecalc.AutoSize = true;
            this.radRecalc.Location = new System.Drawing.Point(735, 95);
            this.radRecalc.Name = "radRecalc";
            this.radRecalc.Size = new System.Drawing.Size(154, 17);
            this.radRecalc.TabIndex = 20;
            this.radRecalc.Text = "Delete and recalcuate data";
            this.radRecalc.UseVisualStyleBackColor = true;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Enabled = false;
            this.btnExportCSV.Location = new System.Drawing.Point(735, 214);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(101, 23);
            this.btnExportCSV.TabIndex = 21;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.radRecalc);
            this.Controls.Add(this.radBackfill);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnalysisTemplate);
            this.Controls.Add(this.labelAnalysisTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.btnBackfill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtElementName);
            this.Controls.Add(this.labelElementName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.afDatabasePicker1);
            this.Controls.Add(this.piSystemPicker1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Text = "PI Analysis Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OSIsoft.AF.UI.PISystemPicker piSystemPicker1;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelElementName;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackfill;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAnalysisTemplate;
        private System.Windows.Forms.TextBox txtAnalysisTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.RadioButton radBackfill;
        private System.Windows.Forms.RadioButton radRecalc;
        private System.Windows.Forms.Button btnExportCSV;
    }
}

