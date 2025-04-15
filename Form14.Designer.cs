namespace DVLDD
{
    partial class FormLocalDrivingApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelnumberpeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applicationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.updateAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cancelAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueLiecenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(393, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Driving License Application";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(1, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1414, 360);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 27);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Items.AddRange(new object[] {
            "App ID",
            "National No",
            "Full Name",
            "Class Name",
            "Test Passed",
            "UserName",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(88, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filter By";
            // 
            // labelnumberpeople
            // 
            this.labelnumberpeople.AutoSize = true;
            this.labelnumberpeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumberpeople.Location = new System.Drawing.Point(243, 626);
            this.labelnumberpeople.Name = "labelnumberpeople";
            this.labelnumberpeople.Size = new System.Drawing.Size(128, 16);
            this.labelnumberpeople.TabIndex = 20;
            this.labelnumberpeople.Text = "number of people";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Number Of Application";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationInfoToolStripMenuItem,
            this.cancelAppToolStripMenuItem,
            this.updateAppToolStripMenuItem,
            this.deleteAppToolStripMenuItem,
            this.cancelAppToolStripMenuItem1,
            this.deleteAppToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.scheduleTestToolStripMenuItem,
            this.issueLiecenseFirstTimeToolStripMenuItem,
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 204);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // applicationInfoToolStripMenuItem
            // 
            this.applicationInfoToolStripMenuItem.Image = global::DVLDD.Resource2.PersonDetails_32;
            this.applicationInfoToolStripMenuItem.Name = "applicationInfoToolStripMenuItem";
            this.applicationInfoToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.applicationInfoToolStripMenuItem.Text = "Application Details";
            this.applicationInfoToolStripMenuItem.Click += new System.EventHandler(this.applicationInfoToolStripMenuItem_Click);
            // 
            // cancelAppToolStripMenuItem
            // 
            this.cancelAppToolStripMenuItem.Name = "cancelAppToolStripMenuItem";
            this.cancelAppToolStripMenuItem.Size = new System.Drawing.Size(245, 6);
            // 
            // updateAppToolStripMenuItem
            // 
            this.updateAppToolStripMenuItem.Image = global::DVLDD.Resource2.edit_32;
            this.updateAppToolStripMenuItem.Name = "updateAppToolStripMenuItem";
            this.updateAppToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.updateAppToolStripMenuItem.Text = "Update App";
            this.updateAppToolStripMenuItem.Click += new System.EventHandler(this.updateAppToolStripMenuItem_Click);
            // 
            // deleteAppToolStripMenuItem
            // 
            this.deleteAppToolStripMenuItem.Name = "deleteAppToolStripMenuItem";
            this.deleteAppToolStripMenuItem.Size = new System.Drawing.Size(245, 6);
            // 
            // cancelAppToolStripMenuItem1
            // 
            this.cancelAppToolStripMenuItem1.Image = global::DVLDD.Resource2.Delete_32;
            this.cancelAppToolStripMenuItem1.Name = "cancelAppToolStripMenuItem1";
            this.cancelAppToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.cancelAppToolStripMenuItem1.Text = "Cancel  App";
            this.cancelAppToolStripMenuItem1.Click += new System.EventHandler(this.cancelAppToolStripMenuItem1_Click);
            // 
            // deleteAppToolStripMenuItem1
            // 
            this.deleteAppToolStripMenuItem1.Image = global::DVLDD.Resource2.Delete_32_2;
            this.deleteAppToolStripMenuItem1.Name = "deleteAppToolStripMenuItem1";
            this.deleteAppToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.deleteAppToolStripMenuItem1.Text = "Delete App";
            this.deleteAppToolStripMenuItem1.Click += new System.EventHandler(this.deleteAppToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.drivingTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = global::DVLDD.Resource2.Schedule_Test_32;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
            this.scheduleTestToolStripMenuItem.DropDownOpened += new System.EventHandler(this.scheduleTestToolStripMenuItem_DropDownOpened);
            this.scheduleTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleTestToolStripMenuItem_Click);
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Image = global::DVLDD.Resource2.Vision_Test_32;
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writtenTestToolStripMenuItem
            // 
            this.writtenTestToolStripMenuItem.Image = global::DVLDD.Resource2.Written_Test_32;
            this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.writtenTestToolStripMenuItem.Text = "Written Test";
            this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
            // 
            // drivingTestToolStripMenuItem
            // 
            this.drivingTestToolStripMenuItem.Image = global::DVLDD.Resource2.driving_test_512;
            this.drivingTestToolStripMenuItem.Name = "drivingTestToolStripMenuItem";
            this.drivingTestToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.drivingTestToolStripMenuItem.Text = "Driving Test";
            this.drivingTestToolStripMenuItem.Click += new System.EventHandler(this.drivingTestToolStripMenuItem_Click);
            // 
            // issueLiecenseFirstTimeToolStripMenuItem
            // 
            this.issueLiecenseFirstTimeToolStripMenuItem.Enabled = false;
            this.issueLiecenseFirstTimeToolStripMenuItem.Image = global::DVLDD.Resource2.IssueDrivingLicense_32;
            this.issueLiecenseFirstTimeToolStripMenuItem.Name = "issueLiecenseFirstTimeToolStripMenuItem";
            this.issueLiecenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.issueLiecenseFirstTimeToolStripMenuItem.Text = "Issue Liecense(First Time)";
            this.issueLiecenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueLiecenseFirstTimeToolStripMenuItem_Click);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Enabled = false;
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLDD.Resource2.LicenseView_400;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.AutoSize = true;
            this.buttonadd.Image = global::DVLDD.Resource2.New_Application_64;
            this.buttonadd.Location = new System.Drawing.Point(1311, 148);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 71);
            this.buttonadd.TabIndex = 50;
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::DVLDD.Resource2.Close_32;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(1232, 611);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(173, 46);
            this.buttonCancel.TabIndex = 49;
            this.buttonCancel.Text = "        Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDD.Resource2.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(624, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormLocalDrivingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1417, 666);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelnumberpeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLocalDrivingApp";
            this.ShowIcon = false;
            this.Text = "Local Driving License Application";
            this.Load += new System.EventHandler(this.FormLocalDrivingApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelnumberpeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationInfoToolStripMenuItem;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.ToolStripMenuItem updateAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator cancelAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator deleteAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAppToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueLiecenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}