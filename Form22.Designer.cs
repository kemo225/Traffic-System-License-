namespace DVLDD
{
    partial class formLicenseInfo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.userControlLicenseinfo1 = new DVLDD.UserControlLicenseinfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(354, 158);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 47);
            this.lblTitle.TabIndex = 155;
            this.lblTitle.Text = "License Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTestTypeImage.Image = global::DVLDD.Resource2.LicenseView_400;
            this.pbTestTypeImage.InitialImage = null;
            this.pbTestTypeImage.Location = new System.Drawing.Point(375, 21);
            this.pbTestTypeImage.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(225, 125);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTypeImage.TabIndex = 154;
            this.pbTestTypeImage.TabStop = false;
            // 
            // buttoncancel
            // 
            this.buttoncancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttoncancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.buttoncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancel.Location = new System.Drawing.Point(808, 635);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(148, 51);
            this.buttoncancel.TabIndex = 156;
            this.buttoncancel.Text = "Close";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // userControlLicenseinfo1
            // 
            this.userControlLicenseinfo1.Location = new System.Drawing.Point(8, 196);
            this.userControlLicenseinfo1.Name = "userControlLicenseinfo1";
            this.userControlLicenseinfo1.Size = new System.Drawing.Size(959, 411);
            this.userControlLicenseinfo1.TabIndex = 157;
            // 
            // formLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 698);
            this.Controls.Add(this.userControlLicenseinfo1);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbTestTypeImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLicenseInfo";
            this.ShowIcon = false;
            this.Text = "License Info";
            this.Load += new System.EventHandler(this.LicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.Button buttoncancel;
        private UserControlLicenseinfo userControlLicenseinfo1;
    }
}