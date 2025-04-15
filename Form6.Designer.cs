namespace DVLDD
{
    partial class FormUserInfromation
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
            this.buttoncancel = new System.Windows.Forms.Button();
            this.userCard1 = new DVLDD.UserCard();
            this.SuspendLayout();
            // 
            // buttoncancel
            // 
            this.buttoncancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttoncancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.buttoncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancel.Image = global::DVLDD.Resource2.Close_32;
            this.buttoncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoncancel.Location = new System.Drawing.Point(888, 465);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(135, 52);
            this.buttoncancel.TabIndex = 1;
            this.buttoncancel.Text = "      Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // userCard1
            // 
            this.userCard1.Location = new System.Drawing.Point(12, 9);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(1026, 450);
            this.userCard1.TabIndex = 0;
            this.userCard1.User = null;
            this.userCard1.UserID = 0;
            this.userCard1.Load += new System.EventHandler(this.userCard1_Load);
            // 
            // FormUserInfromation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 529);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.userCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserInfromation";
            this.ShowIcon = false;
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserCard userCard1;
        private System.Windows.Forms.Button buttoncancel;
    }
}