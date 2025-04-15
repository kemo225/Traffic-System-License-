namespace DVLDD
{
    partial class FormDetainList
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelnumberpeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseHistoreyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRelease = new System.Windows.Forms.Button();
            this.buttondetainlicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::DVLDD.Resource2.Close_32;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(1253, 600);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(173, 46);
            this.buttonCancel.TabIndex = 58;
            this.buttonCancel.Text = "        Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelnumberpeople
            // 
            this.labelnumberpeople.AutoSize = true;
            this.labelnumberpeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumberpeople.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelnumberpeople.Location = new System.Drawing.Point(164, 610);
            this.labelnumberpeople.Name = "labelnumberpeople";
            this.labelnumberpeople.Size = new System.Drawing.Size(179, 25);
            this.labelnumberpeople.TabIndex = 57;
            this.labelnumberpeople.Text = "number of people";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 56;
            this.label3.Text = "Records :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(194, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 27);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Items.AddRange(new object[] {
            "Detain ID",
            "License ID",
            "Fine Fees",
            "Full Name",
            "Detain Date",
            "National No",
            "ReleaseDate",
            "R.App ID",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(26, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(22, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1414, 360);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDD.Resource2.Detain_64;
            this.pictureBox1.Location = new System.Drawing.Point(644, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(545, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 69);
            this.label1.TabIndex = 51;
            this.label1.Text = "Detain List";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personDetailsToolStripMenuItem,
            this.showLicenseHistoreyToolStripMenuItem,
            this.showLicenseDetailssToolStripMenuItem,
            this.releaseDetainLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 108);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // personDetailsToolStripMenuItem
            // 
            this.personDetailsToolStripMenuItem.Image = global::DVLDD.Resource2.PersonDetails_32;
            this.personDetailsToolStripMenuItem.Name = "personDetailsToolStripMenuItem";
            this.personDetailsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.personDetailsToolStripMenuItem.Text = "Person Details";
            this.personDetailsToolStripMenuItem.Click += new System.EventHandler(this.personDetailsToolStripMenuItem_Click);
            // 
            // showLicenseHistoreyToolStripMenuItem
            // 
            this.showLicenseHistoreyToolStripMenuItem.Image = global::DVLDD.Resource2.PersonLicenseHistory_32;
            this.showLicenseHistoreyToolStripMenuItem.Name = "showLicenseHistoreyToolStripMenuItem";
            this.showLicenseHistoreyToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.showLicenseHistoreyToolStripMenuItem.Text = "Show License Historey";
            this.showLicenseHistoreyToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoreyToolStripMenuItem_Click);
            // 
            // showLicenseDetailssToolStripMenuItem
            // 
            this.showLicenseDetailssToolStripMenuItem.Image = global::DVLDD.Resource2.License_View_32;
            this.showLicenseDetailssToolStripMenuItem.Name = "showLicenseDetailssToolStripMenuItem";
            this.showLicenseDetailssToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.showLicenseDetailssToolStripMenuItem.Text = "show License Detailss";
            this.showLicenseDetailssToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailssToolStripMenuItem_Click);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Image = global::DVLDD.Resource2.Release_Detained_License_32;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detain License";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // buttonRelease
            // 
            this.buttonRelease.Image = global::DVLDD.Resource2.Release_Detained_License_64;
            this.buttonRelease.Location = new System.Drawing.Point(1190, 145);
            this.buttonRelease.Name = "buttonRelease";
            this.buttonRelease.Size = new System.Drawing.Size(109, 75);
            this.buttonRelease.TabIndex = 60;
            this.buttonRelease.UseVisualStyleBackColor = true;
            this.buttonRelease.Click += new System.EventHandler(this.buttonRelease_Click);
            // 
            // buttondetainlicense
            // 
            this.buttondetainlicense.Image = global::DVLDD.Resource2.Detain_64;
            this.buttondetainlicense.Location = new System.Drawing.Point(1317, 145);
            this.buttondetainlicense.Name = "buttondetainlicense";
            this.buttondetainlicense.Size = new System.Drawing.Size(109, 75);
            this.buttondetainlicense.TabIndex = 61;
            this.buttondetainlicense.UseVisualStyleBackColor = true;
            this.buttondetainlicense.Click += new System.EventHandler(this.buttondetainlicense_Click);
            // 
            // FormDetainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 659);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttondetainlicense);
            this.Controls.Add(this.buttonRelease);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelnumberpeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetainList";
            this.ShowIcon = false;
            this.Text = "Detain List";
            this.Load += new System.EventHandler(this.FormDetainList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelnumberpeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistoreyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
        private System.Windows.Forms.Button buttonRelease;
        private System.Windows.Forms.Button buttondetainlicense;
    }
}