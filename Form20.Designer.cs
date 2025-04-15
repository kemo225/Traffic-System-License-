namespace DVLDD
{
    partial class Form20
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
            this.sheduletest1 = new DVLDD.Sheduletest();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.radiosuccess = new System.Windows.Forms.RadioButton();
            this.radiofailure = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonsave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sheduletest1
            // 
            this.sheduletest1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sheduletest1.Location = new System.Drawing.Point(12, 3);
            this.sheduletest1.Name = "sheduletest1";
            this.sheduletest1.Size = new System.Drawing.Size(535, 558);
            this.sheduletest1.TabIndex = 0;
            this.sheduletest1.TestTypeID = BussinessLayerDVLD.ClsTestAppoinment.enTestType.VisionTest;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.radiosuccess);
            this.groupBox1.Controls.Add(this.radiofailure);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 586);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 182;
            this.label1.Text = "Note:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 92);
            this.textBox1.TabIndex = 181;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLDD.Resource2.Test_32;
            this.pictureBox9.Location = new System.Drawing.Point(160, 27);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 180;
            this.pictureBox9.TabStop = false;
            // 
            // radiosuccess
            // 
            this.radiosuccess.AutoSize = true;
            this.radiosuccess.Location = new System.Drawing.Point(211, 30);
            this.radiosuccess.Name = "radiosuccess";
            this.radiosuccess.Size = new System.Drawing.Size(80, 20);
            this.radiosuccess.TabIndex = 172;
            this.radiosuccess.TabStop = true;
            this.radiosuccess.Text = "Success";
            this.radiosuccess.UseVisualStyleBackColor = true;
            this.radiosuccess.Validating += new System.ComponentModel.CancelEventHandler(this.radiosuccess_Validating);
            // 
            // radiofailure
            // 
            this.radiofailure.AutoSize = true;
            this.radiofailure.Location = new System.Drawing.Point(329, 30);
            this.radiofailure.Name = "radiofailure";
            this.radiofailure.Size = new System.Drawing.Size(69, 20);
            this.radiofailure.TabIndex = 171;
            this.radiofailure.TabStop = true;
            this.radiofailure.Text = "Failure";
            this.radiofailure.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 170;
            this.label8.Text = "Result Test:";
            // 
            // buttonsave
            // 
            this.buttonsave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.buttonsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsave.Image = global::DVLDD.Resource2.Save_32;
            this.buttonsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsave.Location = new System.Drawing.Point(417, 790);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(134, 39);
            this.buttonsave.TabIndex = 2;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DVLDD.Resource2.Close_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(278, 790);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Camcel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 841);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sheduletest1);
            this.Name = "Form20";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.Form20_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sheduletest sheduletest1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiosuccess;
        private System.Windows.Forms.RadioButton radiofailure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}