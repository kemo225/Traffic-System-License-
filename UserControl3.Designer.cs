namespace DVLDD
{
    partial class UserControlpersonwuthfilter
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
            this.groupBoxfilter = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonfind = new System.Windows.Forms.Button();
            this.comboBoxfilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personInfo1 = new DVLDD.PersonInfo();
            this.groupBoxfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxfilter
            // 
            this.groupBoxfilter.Controls.Add(this.maskedTextBox1);
            this.groupBoxfilter.Controls.Add(this.buttonadd);
            this.groupBoxfilter.Controls.Add(this.buttonfind);
            this.groupBoxfilter.Controls.Add(this.comboBoxfilter);
            this.groupBoxfilter.Controls.Add(this.label2);
            this.groupBoxfilter.Location = new System.Drawing.Point(37, 12);
            this.groupBoxfilter.Name = "groupBoxfilter";
            this.groupBoxfilter.Size = new System.Drawing.Size(986, 48);
            this.groupBoxfilter.TabIndex = 1;
            this.groupBoxfilter.TabStop = false;
            this.groupBoxfilter.Text = "Filter";
            this.groupBoxfilter.Enter += new System.EventHandler(this.groupBoxfilter_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(271, 18);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(159, 27);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // buttonadd
            // 
            this.buttonadd.Image = global::DVLDD.Resource2.Add_Person_40;
            this.buttonadd.Location = new System.Drawing.Point(503, 16);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(43, 32);
            this.buttonadd.TabIndex = 11;
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonfind
            // 
            this.buttonfind.Image = global::DVLDD.Resource2.SearchPerson;
            this.buttonfind.Location = new System.Drawing.Point(454, 16);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(43, 32);
            this.buttonfind.TabIndex = 10;
            this.buttonfind.UseVisualStyleBackColor = true;
            this.buttonfind.Click += new System.EventHandler(this.buttonfind_Click);
            // 
            // comboBoxfilter
            // 
            this.comboBoxfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxfilter.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.comboBoxfilter.Location = new System.Drawing.Point(103, 18);
            this.comboBoxfilter.Name = "comboBoxfilter";
            this.comboBoxfilter.Size = new System.Drawing.Size(153, 24);
            this.comboBoxfilter.TabIndex = 8;
            this.comboBoxfilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxfilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter By";
            // 
            // personInfo1
            // 
            this.personInfo1.Location = new System.Drawing.Point(37, 66);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.NationalNO = null;
            this.personInfo1.Person = null;
            this.personInfo1.PersonID = 0;
            this.personInfo1.personselected = false;
            this.personInfo1.Size = new System.Drawing.Size(986, 351);
            this.personInfo1.TabIndex = 0;
            // 
            // UserControlpersonwuthfilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxfilter);
            this.Controls.Add(this.personInfo1);
            this.Name = "UserControlpersonwuthfilter";
            this.Size = new System.Drawing.Size(1032, 449);
            this.Load += new System.EventHandler(this.UserControlpersonwuthfilter_Load);
            this.groupBoxfilter.ResumeLayout(false);
            this.groupBoxfilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfo personInfo1;
        private System.Windows.Forms.GroupBox groupBoxfilter;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.ComboBox comboBoxfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
