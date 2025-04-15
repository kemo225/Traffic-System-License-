namespace DVLDD
{
    partial class Form17
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
            this.usercontrolApplicatiioninfo1 = new DVLDD.usercontrolApplicatiioninfo();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::DVLDD.Resource2.Close_32;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(945, 548);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 49);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "        Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // usercontrolApplicatiioninfo1
            // 
            this.usercontrolApplicatiioninfo1.Location = new System.Drawing.Point(12, 2);
            this.usercontrolApplicatiioninfo1.Name = "usercontrolApplicatiioninfo1";
            this.usercontrolApplicatiioninfo1.Size = new System.Drawing.Size(1088, 540);
            this.usercontrolApplicatiioninfo1.TabIndex = 2;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 609);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.usercontrolApplicatiioninfo1);
            this.Name = "Form17";
            this.Text = "Application Info";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private usercontrolApplicatiioninfo usercontrolApplicatiioninfo1;
        private System.Windows.Forms.Button buttonCancel;
    }
}