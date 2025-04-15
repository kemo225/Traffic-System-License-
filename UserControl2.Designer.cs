namespace DVLDD
{
    partial class UserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personInfo1 = new DVLDD.PersonInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelsetUsername = new System.Windows.Forms.Label();
            this.checkBoxisactive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInfo1
            // 
            this.personInfo1.Location = new System.Drawing.Point(12, 32);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.NationalNO = null;
            this.personInfo1.Person = null;
            this.personInfo1.PersonID = 0;
            this.personInfo1.personselected = false;
            this.personInfo1.Size = new System.Drawing.Size(983, 359);
            this.personInfo1.TabIndex = 0;
            this.personInfo1.Load += new System.EventHandler(this.personInfo1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelsetUsername);
            this.panel1.Controls.Add(this.checkBoxisactive);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 50);
            this.panel1.TabIndex = 1;
            // 
            // labelsetUsername
            // 
            this.labelsetUsername.AutoSize = true;
            this.labelsetUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsetUsername.Location = new System.Drawing.Point(185, 13);
            this.labelsetUsername.Name = "labelsetUsername";
            this.labelsetUsername.Size = new System.Drawing.Size(51, 20);
            this.labelsetUsername.TabIndex = 48;
            this.labelsetUsername.Text = "[???]";
            // 
            // checkBoxisactive
            // 
            this.checkBoxisactive.AutoSize = true;
            this.checkBoxisactive.Enabled = false;
            this.checkBoxisactive.Location = new System.Drawing.Point(640, 15);
            this.checkBoxisactive.Name = "checkBoxisactive";
            this.checkBoxisactive.Size = new System.Drawing.Size(18, 17);
            this.checkBoxisactive.TabIndex = 47;
            this.checkBoxisactive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Is Active ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "UserName :";
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personInfo1);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(1001, 450);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfo personInfo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxisactive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelsetUsername;
    }
}
