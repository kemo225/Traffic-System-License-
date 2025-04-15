namespace DVLDD
{
    partial class Forminternationalinfo
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
            this.userControlInternational1 = new DVLDD.UserControlInternational();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::DVLDD.Resource2.Close_32;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(816, 357);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 46);
            this.buttonCancel.TabIndex = 60;
            this.buttonCancel.Text = "        Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // userControlInternational1
            // 
            this.userControlInternational1.internationalID = 0;
            this.userControlInternational1.InterNationalLicense = null;
            this.userControlInternational1.Location = new System.Drawing.Point(12, 12);
            this.userControlInternational1.Name = "userControlInternational1";
            this.userControlInternational1.Size = new System.Drawing.Size(949, 339);
            this.userControlInternational1.TabIndex = 61;
            // 
            // Forminternationalinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 415);
            this.Controls.Add(this.userControlInternational1);
            this.Controls.Add(this.buttonCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forminternationalinfo";
            this.ShowIcon = false;
            this.Text = "International License";
            this.Load += new System.EventHandler(this.Forminternationalinfo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private UserControlInternational userControlInternational1;
    }
}