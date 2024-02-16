namespace MedicalStore
{
    partial class AddMedicine
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMedName = new System.Windows.Forms.Label();
            this.textBoxMedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGenericName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMedicineType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1328, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "-: ADD MEDICINE :-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1868, 115);
            this.panel1.TabIndex = 2;
            // 
            // labelMedName
            // 
            this.labelMedName.AutoSize = true;
            this.labelMedName.Location = new System.Drawing.Point(401, 23);
            this.labelMedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMedName.Name = "labelMedName";
            this.labelMedName.Size = new System.Drawing.Size(239, 38);
            this.labelMedName.TabIndex = 3;
            this.labelMedName.Text = "Medicine Name :";
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(669, 19);
            this.textBoxMedName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.Size = new System.Drawing.Size(307, 42);
            this.textBoxMedName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generic Name :";
            // 
            // textBoxGenericName
            // 
            this.textBoxGenericName.Location = new System.Drawing.Point(669, 93);
            this.textBoxGenericName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGenericName.Name = "textBoxGenericName";
            this.textBoxGenericName.Size = new System.Drawing.Size(307, 42);
            this.textBoxGenericName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicine Type :";
            // 
            // comboBoxMedicineType
            // 
            this.comboBoxMedicineType.FormattingEnabled = true;
            this.comboBoxMedicineType.Items.AddRange(new object[] {
            "Tablet",
            "Capsule",
            "Syrup",
            "Powder",
            "Gel",
            "Cream"});
            this.comboBoxMedicineType.Location = new System.Drawing.Point(669, 169);
            this.comboBoxMedicineType.Name = "comboBoxMedicineType";
            this.comboBoxMedicineType.Size = new System.Drawing.Size(307, 45);
            this.comboBoxMedicineType.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.labelCompanyName);
            this.panel2.Controls.Add(this.textBoxCompanyName);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelMedName);
            this.panel2.Controls.Add(this.comboBoxMedicineType);
            this.panel2.Controls.Add(this.textBoxGenericName);
            this.panel2.Controls.Add(this.textBoxMedName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1332, 411);
            this.panel2.TabIndex = 9;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(401, 246);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(239, 38);
            this.labelCompanyName.TabIndex = 10;
            this.labelCompanyName.Text = "Medicine Name :";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(669, 249);
            this.textBoxCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(307, 42);
            this.textBoxCompanyName.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(542, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1332, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MinimumSize = new System.Drawing.Size(1350, 720);
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMedName;
        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGenericName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMedicineType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxCompanyName;
    }
}