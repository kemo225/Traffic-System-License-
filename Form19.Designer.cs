namespace DVLDD
{
    partial class Form19
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
            this.button1 = new System.Windows.Forms.Button();
            this.sheduletest1 = new DVLDD.Sheduletest();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::DVLDD.Resource2.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(211, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sheduletest1
            // 
            this.sheduletest1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sheduletest1.Location = new System.Drawing.Point(1, -1);
            this.sheduletest1.Name = "sheduletest1";
            this.sheduletest1.Size = new System.Drawing.Size(564, 752);
            this.sheduletest1.TabIndex = 0;
            this.sheduletest1.TestTypeID = BussinessLayerDVLD.ClsTestAppoinment.enTestType.VisionTest;
            this.sheduletest1.Load += new System.EventHandler(this.sheduletest1_Load);
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 794);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sheduletest1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form19";
            this.ShowIcon = false;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.Form19_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sheduletest sheduletest1;
        private System.Windows.Forms.Button button1;
    }
}