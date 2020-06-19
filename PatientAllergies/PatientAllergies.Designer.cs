namespace PatientAllergies
{
    partial class FormPatientAllergies
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public int SearchOption { get; set; }

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblEndpoint = new System.Windows.Forms.Label();
            this.txtFHIREndpoint = new System.Windows.Forms.TextBox();
            this.lblTitlePatient = new System.Windows.Forms.Label();
            this.listCandidates = new System.Windows.Forms.ListBox();
            this.btnShowAllergies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listAllergies = new System.Windows.Forms.ListBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.groupSearchOption = new System.Windows.Forms.GroupBox();
            this.radioPatNameDob = new System.Windows.Forms.RadioButton();
            this.radioPatientName = new System.Windows.Forms.RadioButton();
            this.radioPatientID = new System.Windows.Forms.RadioButton();
            this.lblDob = new System.Windows.Forms.Label();
            this.dateTimeDob = new System.Windows.Forms.DateTimePicker();
            this.groupSearchOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Enabled = false;
            this.btnSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatient.Location = new System.Drawing.Point(469, 127);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(109, 59);
            this.btnSearchPatient.TabIndex = 2;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.BtnSearchPatient_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(39, 127);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(83, 20);
            this.lblPatientID.TabIndex = 1;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(15, 158);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(110, 20);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Patient Name";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Enabled = false;
            this.txtPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(135, 125);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(328, 26);
            this.txtPatientID.TabIndex = 0;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(135, 157);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(328, 26);
            this.txtPatientName.TabIndex = 1;
            // 
            // lblEndpoint
            // 
            this.lblEndpoint.AutoSize = true;
            this.lblEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndpoint.Location = new System.Drawing.Point(17, 12);
            this.lblEndpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndpoint.Name = "lblEndpoint";
            this.lblEndpoint.Size = new System.Drawing.Size(125, 20);
            this.lblEndpoint.TabIndex = 5;
            this.lblEndpoint.Text = "FHIR EndPoint:";
            // 
            // txtFHIREndpoint
            // 
            this.txtFHIREndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFHIREndpoint.Location = new System.Drawing.Point(161, 9);
            this.txtFHIREndpoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtFHIREndpoint.Name = "txtFHIREndpoint";
            this.txtFHIREndpoint.Size = new System.Drawing.Size(294, 26);
            this.txtFHIREndpoint.TabIndex = 6;
            this.txtFHIREndpoint.Text = "http://fhir.hl7fundamentals.org/r4";
            // 
            // lblTitlePatient
            // 
            this.lblTitlePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitlePatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitlePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePatient.Location = new System.Drawing.Point(19, 38);
            this.lblTitlePatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitlePatient.Name = "lblTitlePatient";
            this.lblTitlePatient.Size = new System.Drawing.Size(434, 22);
            this.lblTitlePatient.TabIndex = 7;
            this.lblTitlePatient.Text = "SEARCH AND SELECT PATIENT";
            this.lblTitlePatient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listCandidates
            // 
            this.listCandidates.DisplayMember = "Text";
            this.listCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCandidates.FormattingEnabled = true;
            this.listCandidates.HorizontalScrollbar = true;
            this.listCandidates.ItemHeight = 20;
            this.listCandidates.Location = new System.Drawing.Point(20, 234);
            this.listCandidates.Margin = new System.Windows.Forms.Padding(2);
            this.listCandidates.Name = "listCandidates";
            this.listCandidates.ScrollAlwaysVisible = true;
            this.listCandidates.Size = new System.Drawing.Size(434, 104);
            this.listCandidates.TabIndex = 3;
            // 
            // btnShowAllergies
            // 
            this.btnShowAllergies.Enabled = false;
            this.btnShowAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllergies.Location = new System.Drawing.Point(460, 254);
            this.btnShowAllergies.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAllergies.Name = "btnShowAllergies";
            this.btnShowAllergies.Size = new System.Drawing.Size(109, 59);
            this.btnShowAllergies.TabIndex = 4;
            this.btnShowAllergies.Text = "Show Allergies";
            this.btnShowAllergies.UseVisualStyleBackColor = true;
            this.btnShowAllergies.Click += new System.EventHandler(this.BtnShowAllergies_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "PATIENT ALLERGIES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listAllergies
            // 
            this.listAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAllergies.FormattingEnabled = true;
            this.listAllergies.ItemHeight = 20;
            this.listAllergies.Location = new System.Drawing.Point(20, 389);
            this.listAllergies.Margin = new System.Windows.Forms.Padding(2);
            this.listAllergies.Name = "listAllergies";
            this.listAllergies.Size = new System.Drawing.Size(556, 164);
            this.listAllergies.TabIndex = 5;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoEllipsis = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.White;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(20, 555);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(555, 47);
            this.lblErrorMessage.TabIndex = 12;
            this.lblErrorMessage.Text = "lblErrorMessage";
            this.lblErrorMessage.Visible = false;
            this.lblErrorMessage.Click += new System.EventHandler(this.lblErrorMessage_Click);
            // 
            // groupSearchOption
            // 
            this.groupSearchOption.Controls.Add(this.radioPatNameDob);
            this.groupSearchOption.Controls.Add(this.radioPatientName);
            this.groupSearchOption.Controls.Add(this.radioPatientID);
            this.groupSearchOption.Location = new System.Drawing.Point(25, 75);
            this.groupSearchOption.Name = "groupSearchOption";
            this.groupSearchOption.Size = new System.Drawing.Size(534, 40);
            this.groupSearchOption.TabIndex = 13;
            this.groupSearchOption.TabStop = false;
            this.groupSearchOption.Text = "Select Option";
            this.groupSearchOption.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioPatNameDob
            // 
            this.radioPatNameDob.AutoSize = true;
            this.radioPatNameDob.Location = new System.Drawing.Point(337, 17);
            this.radioPatNameDob.Name = "radioPatNameDob";
            this.radioPatNameDob.Size = new System.Drawing.Size(172, 17);
            this.radioPatNameDob.TabIndex = 2;
            this.radioPatNameDob.TabStop = true;
            this.radioPatNameDob.Text = "Patient Name and Date of Birth";
            this.radioPatNameDob.UseVisualStyleBackColor = true;
            this.radioPatNameDob.Click += new System.EventHandler(this.radioPatNameDob_Click);
            // 
            // radioPatientName
            // 
            this.radioPatientName.AutoSize = true;
            this.radioPatientName.Location = new System.Drawing.Point(151, 17);
            this.radioPatientName.Name = "radioPatientName";
            this.radioPatientName.Size = new System.Drawing.Size(89, 17);
            this.radioPatientName.TabIndex = 1;
            this.radioPatientName.TabStop = true;
            this.radioPatientName.Text = "Patient Name";
            this.radioPatientName.UseVisualStyleBackColor = true;
            this.radioPatientName.Click += new System.EventHandler(this.radioPatientName_Click);
            // 
            // radioPatientID
            // 
            this.radioPatientID.AutoSize = true;
            this.radioPatientID.Location = new System.Drawing.Point(19, 17);
            this.radioPatientID.Name = "radioPatientID";
            this.radioPatientID.Size = new System.Drawing.Size(69, 17);
            this.radioPatientID.TabIndex = 0;
            this.radioPatientID.TabStop = true;
            this.radioPatientID.Text = "PatientID";
            this.radioPatientID.UseVisualStyleBackColor = true;
            this.radioPatientID.Click += new System.EventHandler(this.radioPatientID_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(17, 194);
            this.lblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(105, 20);
            this.lblDob.TabIndex = 14;
            this.lblDob.Text = "Date of Birth";
            this.lblDob.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimeDob
            // 
            this.dateTimeDob.Enabled = false;
            this.dateTimeDob.Location = new System.Drawing.Point(135, 194);
            this.dateTimeDob.Name = "dateTimeDob";
            this.dateTimeDob.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDob.TabIndex = 15;
            // 
            // FormPatientAllergies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 703);
            this.Controls.Add(this.dateTimeDob);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.groupSearchOption);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.listAllergies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAllergies);
            this.Controls.Add(this.listCandidates);
            this.Controls.Add(this.lblTitlePatient);
            this.Controls.Add(this.txtFHIREndpoint);
            this.Controls.Add(this.lblEndpoint);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.btnSearchPatient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPatientAllergies";
            this.Text = "HL7 FHIR Intermediate Course - Patient Allergies";
            this.groupSearchOption.ResumeLayout(false);
            this.groupSearchOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblEndpoint;
        private System.Windows.Forms.TextBox txtFHIREndpoint;
        private System.Windows.Forms.Label lblTitlePatient;
        private System.Windows.Forms.ListBox listCandidates;
        private System.Windows.Forms.Button btnShowAllergies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAllergies;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.GroupBox groupSearchOption;
        private System.Windows.Forms.RadioButton radioPatientID;
        private System.Windows.Forms.RadioButton radioPatNameDob;
        private System.Windows.Forms.RadioButton radioPatientName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dateTimeDob;
    }
}

