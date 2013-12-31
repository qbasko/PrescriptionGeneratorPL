namespace Jakub.Skoczen.PrescriptionGenerator
{
    partial class Prescription
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.Location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Permissions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NFZBranch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ChronicDiseases = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrescriptionInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DoctorsId = new System.Windows.Forms.TextBox();
            this.RealizationFromDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PeselErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BirthdateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LocationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NFZBranchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PrescriptionInfoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RealizationFromDateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DoctorsIdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PermissionsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChronicDiseasesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeselErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFZBranchErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionInfoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealizationFromDateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsIdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermissionsErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChronicDiseasesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(88, 37);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            this.Name.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(88, 63);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 2;
            this.LastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data ur.";
            // 
            // BirthDate
            // 
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate.Location = new System.Drawing.Point(88, 116);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(100, 20);
            this.BirthDate.TabIndex = 5;
            this.BirthDate.Validating += new System.ComponentModel.CancelEventHandler(this.BirthDate_Validating);
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(88, 142);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(100, 20);
            this.Location.TabIndex = 6;
            this.Location.Validating += new System.ComponentModel.CancelEventHandler(this.Location_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miejscowość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pesel";
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(88, 90);
            this.Pesel.Mask = "00000000000";
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(100, 20);
            this.Pesel.TabIndex = 10;
            this.Pesel.Validating += new System.ComponentModel.CancelEventHandler(this.Pesel_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Uprawnienia";
            // 
            // Permissions
            // 
            this.Permissions.Location = new System.Drawing.Point(290, 89);
            this.Permissions.Name = "Permissions";
            this.Permissions.Size = new System.Drawing.Size(100, 20);
            this.Permissions.TabIndex = 13;
            this.Permissions.Validating += new System.ComponentModel.CancelEventHandler(this.Permissions_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Oddział NFZ";
            // 
            // NFZBranch
            // 
            this.NFZBranch.Location = new System.Drawing.Point(290, 63);
            this.NFZBranch.Name = "NFZBranch";
            this.NFZBranch.Size = new System.Drawing.Size(100, 20);
            this.NFZBranch.TabIndex = 11;
            this.NFZBranch.Validating += new System.ComponentModel.CancelEventHandler(this.NFZBranch_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ch. przewlekłe";
            // 
            // ChronicDiseases
            // 
            this.ChronicDiseases.Location = new System.Drawing.Point(290, 115);
            this.ChronicDiseases.Name = "ChronicDiseases";
            this.ChronicDiseases.Size = new System.Drawing.Size(100, 20);
            this.ChronicDiseases.TabIndex = 15;
            this.ChronicDiseases.Validating += new System.ComponentModel.CancelEventHandler(this.ChronicDiseases_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Rp.";
            // 
            // PrescriptionInfo
            // 
            this.PrescriptionInfo.Location = new System.Drawing.Point(88, 168);
            this.PrescriptionInfo.Multiline = true;
            this.PrescriptionInfo.Name = "PrescriptionInfo";
            this.PrescriptionInfo.Size = new System.Drawing.Size(302, 87);
            this.PrescriptionInfo.TabIndex = 18;
            this.PrescriptionInfo.Validating += new System.ComponentModel.CancelEventHandler(this.PrescriptionInfo_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dane id. i podpis lekarza";
            // 
            // DoctorsId
            // 
            this.DoctorsId.Location = new System.Drawing.Point(149, 261);
            this.DoctorsId.Name = "DoctorsId";
            this.DoctorsId.Size = new System.Drawing.Size(100, 20);
            this.DoctorsId.TabIndex = 19;
            this.DoctorsId.Validating += new System.ComponentModel.CancelEventHandler(this.DoctorsId_Validating);
            // 
            // RealizationFromDate
            // 
            this.RealizationFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RealizationFromDate.Location = new System.Drawing.Point(149, 287);
            this.RealizationFromDate.Name = "RealizationFromDate";
            this.RealizationFromDate.Size = new System.Drawing.Size(100, 20);
            this.RealizationFromDate.TabIndex = 22;
            this.RealizationFromDate.Validating += new System.ComponentModel.CancelEventHandler(this.RealizationFromDate_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Data realizacji od dnia";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(19, 323);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(371, 39);
            this.PrintBtn.TabIndex = 23;
            this.PrintBtn.Text = "Drukuj";
            this.PrintBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.resetToolStripMenuItem.Text = "Wyczyść dane";
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // LastNameErrorProvider
            // 
            this.LastNameErrorProvider.ContainerControl = this;
            // 
            // PeselErrorProvider
            // 
            this.PeselErrorProvider.ContainerControl = this;
            // 
            // BirthdateErrorProvider
            // 
            this.BirthdateErrorProvider.ContainerControl = this;
            // 
            // LocationErrorProvider
            // 
            this.LocationErrorProvider.ContainerControl = this;
            // 
            // NFZBranchErrorProvider
            // 
            this.NFZBranchErrorProvider.ContainerControl = this;
            // 
            // PrescriptionInfoErrorProvider
            // 
            this.PrescriptionInfoErrorProvider.ContainerControl = this;
            // 
            // RealizationFromDateErrorProvider
            // 
            this.RealizationFromDateErrorProvider.ContainerControl = this;
            // 
            // DoctorsIdErrorProvider
            // 
            this.DoctorsIdErrorProvider.ContainerControl = this;
            // 
            // PermissionsErrorProvider
            // 
            this.PermissionsErrorProvider.ContainerControl = this;
            // 
            // ChronicDiseasesErrorProvider
            // 
            this.ChronicDiseasesErrorProvider.ContainerControl = this;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 373);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.RealizationFromDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DoctorsId);
            this.Controls.Add(this.PrescriptionInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChronicDiseases);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Permissions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NFZBranch);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Prescription";
            this.Text = "Recepta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeselErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFZBranchErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionInfoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealizationFromDateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsIdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermissionsErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChronicDiseasesErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Pesel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Permissions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NFZBranch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ChronicDiseases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrescriptionInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DoctorsId;
        private System.Windows.Forms.DateTimePicker RealizationFromDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider LastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider PeselErrorProvider;
        private System.Windows.Forms.ErrorProvider BirthdateErrorProvider;
        private System.Windows.Forms.ErrorProvider LocationErrorProvider;
        private System.Windows.Forms.ErrorProvider NFZBranchErrorProvider;
        private System.Windows.Forms.ErrorProvider PrescriptionInfoErrorProvider;
        private System.Windows.Forms.ErrorProvider RealizationFromDateErrorProvider;
        private System.Windows.Forms.ErrorProvider DoctorsIdErrorProvider;
        private System.Windows.Forms.ErrorProvider PermissionsErrorProvider;
        private System.Windows.Forms.ErrorProvider ChronicDiseasesErrorProvider;
    }
}

