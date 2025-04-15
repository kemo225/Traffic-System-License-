namespace DVLDD
{
    partial class FormPersonCard
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
            this.personInfo1 = new DVLDD.PersonInfo();
            this.SuspendLayout();
            // 
            // personInfo1
            // 
            this.personInfo1.Location = new System.Drawing.Point(10, 6);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.NationalNO = null;
            this.personInfo1.Person = null;
            this.personInfo1.personselected = false;
            this.personInfo1.Size = new System.Drawing.Size(982, 368);
            this.personInfo1.TabIndex = 0;
            // 
            // FormPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 377);
            this.Controls.Add(this.personInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPersonCard";
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.FormPersonCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfo personInfo1;
    }
}