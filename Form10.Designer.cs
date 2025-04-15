namespace DVLDD
{
    partial class Formchangepass
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
            this.userCard1 = new DVLDD.UserCard();
            this.buttonsave = new System.Windows.Forms.Button();
            this.maskedTextBoxoldpass = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxnewpass = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxconfirmnewpass = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelmatcchpass = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userCard1
            // 
            this.userCard1.Location = new System.Drawing.Point(12, 3);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(997, 455);
            this.userCard1.TabIndex = 0;
            this.userCard1.User = null;
            this.userCard1.UserID = 0;
            this.userCard1.Load += new System.EventHandler(this.userCard1_Load);
            // 
            // buttonsave
            // 
            this.buttonsave.FlatAppearance.BorderSize = 2;
            this.buttonsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsave.Image = global::DVLDD.Resource2.Save_32;
            this.buttonsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsave.Location = new System.Drawing.Point(872, 663);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(122, 50);
            this.buttonsave.TabIndex = 1;
            this.buttonsave.Text = "     Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // maskedTextBoxoldpass
            // 
            this.maskedTextBoxoldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxoldpass.Location = new System.Drawing.Point(297, 482);
            this.maskedTextBoxoldpass.Name = "maskedTextBoxoldpass";
            this.maskedTextBoxoldpass.PasswordChar = '*';
            this.maskedTextBoxoldpass.Size = new System.Drawing.Size(206, 30);
            this.maskedTextBoxoldpass.TabIndex = 3;
            this.maskedTextBoxoldpass.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxoldpass_Validating);
            // 
            // maskedTextBoxnewpass
            // 
            this.maskedTextBoxnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxnewpass.Location = new System.Drawing.Point(297, 546);
            this.maskedTextBoxnewpass.Name = "maskedTextBoxnewpass";
            this.maskedTextBoxnewpass.PasswordChar = '*';
            this.maskedTextBoxnewpass.Size = new System.Drawing.Size(206, 30);
            this.maskedTextBoxnewpass.TabIndex = 4;
            this.maskedTextBoxnewpass.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxnewpass_Validating);
            // 
            // maskedTextBoxconfirmnewpass
            // 
            this.maskedTextBoxconfirmnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxconfirmnewpass.Location = new System.Drawing.Point(297, 615);
            this.maskedTextBoxconfirmnewpass.Name = "maskedTextBoxconfirmnewpass";
            this.maskedTextBoxconfirmnewpass.PasswordChar = '*';
            this.maskedTextBoxconfirmnewpass.Size = new System.Drawing.Size(206, 30);
            this.maskedTextBoxconfirmnewpass.TabIndex = 5;
            this.maskedTextBoxconfirmnewpass.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxconfirmnewpass_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm Password : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDD.Resource2.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(253, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDD.Resource2.Password_32;
            this.pictureBox2.Location = new System.Drawing.Point(253, 544);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLDD.Resource2.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(253, 613);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DVLDD.Resource2.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(732, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "     Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelmatcchpass
            // 
            this.labelmatcchpass.AutoSize = true;
            this.labelmatcchpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelmatcchpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatcchpass.ForeColor = System.Drawing.Color.Silver;
            this.labelmatcchpass.Location = new System.Drawing.Point(56, 673);
            this.labelmatcchpass.Name = "labelmatcchpass";
            this.labelmatcchpass.Size = new System.Drawing.Size(309, 25);
            this.labelmatcchpass.TabIndex = 13;
            this.labelmatcchpass.Text = "New Password is Not Matching";
            this.labelmatcchpass.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formchangepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1006, 725);
            this.Controls.Add(this.labelmatcchpass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxconfirmnewpass);
            this.Controls.Add(this.maskedTextBoxnewpass);
            this.Controls.Add(this.maskedTextBoxoldpass);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.userCard1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formchangepass";
            this.ShowIcon = false;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Formchangepass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserCard userCard1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxoldpass;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxnewpass;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxconfirmnewpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelmatcchpass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}