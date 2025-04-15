namespace DVLDD
{
    partial class FormHistoreyLicense
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.userControlpersonwuthfilter1 = new DVLDD.UserControlpersonwuthfilter();
            this.usercntlhistoretlicense1 = new DVLDD.Usercntlhistoretlicense();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Image = global::DVLDD.Resource2.Close_32;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(814, 790);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(173, 45);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "        Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // userControlpersonwuthfilter1
            // 
            this.userControlpersonwuthfilter1.Location = new System.Drawing.Point(-27, 60);
            this.userControlpersonwuthfilter1.Name = "userControlpersonwuthfilter1";
            this.userControlpersonwuthfilter1.Person = null;
            this.userControlpersonwuthfilter1.PersonID = 0;
            this.userControlpersonwuthfilter1.Size = new System.Drawing.Size(1034, 403);
            this.userControlpersonwuthfilter1.TabIndex = 1;
            // 
            // usercntlhistoretlicense1
            // 
            this.usercntlhistoretlicense1.Location = new System.Drawing.Point(7, 449);
            this.usercntlhistoretlicense1.Name = "usercntlhistoretlicense1";
            this.usercntlhistoretlicense1.Size = new System.Drawing.Size(989, 386);
            this.usercntlhistoretlicense1.TabIndex = 0;
            this.usercntlhistoretlicense1.Load += new System.EventHandler(this.usercntlhistoretlicense1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(301, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 46);
            this.label1.TabIndex = 51;
            this.label1.Text = "Historey Licenses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDD.Resource2.Local_Driving_License_512;
            this.pictureBox1.Location = new System.Drawing.Point(698, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // FormHistoreyLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(999, 844);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.userControlpersonwuthfilter1);
            this.Controls.Add(this.usercntlhistoretlicense1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistoreyLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historey License";
            this.Load += new System.EventHandler(this.Form26_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Usercntlhistoretlicense usercntlhistoretlicense1;
        private UserControlpersonwuthfilter userControlpersonwuthfilter1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}