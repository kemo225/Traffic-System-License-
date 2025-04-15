namespace DVLDD
{
    partial class FormIssueLicenseFirsttime
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
            this.usercontrolApplicatiioninfo1 = new DVLDD.usercontrolApplicatiioninfo();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonissue = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // usercontrolApplicatiioninfo1
            // 
            this.usercontrolApplicatiioninfo1.Location = new System.Drawing.Point(3, 1);
            this.usercontrolApplicatiioninfo1.Name = "usercontrolApplicatiioninfo1";
            this.usercontrolApplicatiioninfo1.Size = new System.Drawing.Size(1095, 503);
            this.usercontrolApplicatiioninfo1.TabIndex = 0;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(122, 522);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(964, 141);
            this.textBoxNotes.TabIndex = 1;
            this.textBoxNotes.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNotes_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLDD.Resource2.Notes_32;
            this.pictureBox5.Location = new System.Drawing.Point(82, 505);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 191;
            this.pictureBox5.TabStop = false;
            // 
            // buttonissue
            // 
            this.buttonissue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonissue.FlatAppearance.BorderSize = 2;
            this.buttonissue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonissue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonissue.Image = global::DVLDD.Resource2.IssueDrivingLicense_32;
            this.buttonissue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonissue.Location = new System.Drawing.Point(931, 681);
            this.buttonissue.Name = "buttonissue";
            this.buttonissue.Size = new System.Drawing.Size(155, 43);
            this.buttonissue.TabIndex = 193;
            this.buttonissue.Text = "Issue";
            this.buttonissue.UseVisualStyleBackColor = true;
            this.buttonissue.Click += new System.EventHandler(this.buttonissue_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttoncancel.FlatAppearance.BorderSize = 2;
            this.buttoncancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancel.Image = global::DVLDD.Resource2.Close_32;
            this.buttoncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncancel.Location = new System.Drawing.Point(770, 681);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(155, 43);
            this.buttoncancel.TabIndex = 192;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormIssueLicenseFirsttime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 736);
            this.Controls.Add(this.buttonissue);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.usercontrolApplicatiioninfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIssueLicenseFirsttime";
            this.ShowIcon = false;
            this.Text = "Issue License";
            this.Load += new System.EventHandler(this.Form21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usercontrolApplicatiioninfo usercontrolApplicatiioninfo1;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonissue;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}