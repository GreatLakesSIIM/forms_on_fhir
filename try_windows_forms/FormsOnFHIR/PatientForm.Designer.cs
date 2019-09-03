namespace FormsOnFHIR
{
    partial class PatientForm
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
      this.submitPatientInfo = new System.Windows.Forms.Button();
      this.patientFirstNameEntry = new System.Windows.Forms.TextBox();
      this.labelPatientName = new System.Windows.Forms.Label();
      this.patientMiddleInitialEntry = new System.Windows.Forms.TextBox();
      this.patientLastNameEntry = new System.Windows.Forms.TextBox();
      this.labelDOB = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.SuspendLayout();
      // 
      // submitPatientInfo
      // 
      this.submitPatientInfo.Location = new System.Drawing.Point(99, 314);
      this.submitPatientInfo.Name = "submitPatientInfo";
      this.submitPatientInfo.Size = new System.Drawing.Size(75, 23);
      this.submitPatientInfo.TabIndex = 0;
      this.submitPatientInfo.Text = "Submit";
      this.submitPatientInfo.UseVisualStyleBackColor = true;
      this.submitPatientInfo.Click += new System.EventHandler(this.SubmitPatientInfo_Click);
      // 
      // patientFirstNameEntry
      // 
      this.patientFirstNameEntry.Location = new System.Drawing.Point(65, 55);
      this.patientFirstNameEntry.Name = "patientFirstNameEntry";
      this.patientFirstNameEntry.Size = new System.Drawing.Size(100, 20);
      this.patientFirstNameEntry.TabIndex = 1;
      // 
      // labelPatientName
      // 
      this.labelPatientName.AutoSize = true;
      this.labelPatientName.Location = new System.Drawing.Point(37, 37);
      this.labelPatientName.Name = "labelPatientName";
      this.labelPatientName.Size = new System.Drawing.Size(74, 13);
      this.labelPatientName.TabIndex = 2;
      this.labelPatientName.Text = "Patient Name:";
      // 
      // patientMiddleInitialEntry
      // 
      this.patientMiddleInitialEntry.Location = new System.Drawing.Point(171, 55);
      this.patientMiddleInitialEntry.Name = "patientMiddleInitialEntry";
      this.patientMiddleInitialEntry.Size = new System.Drawing.Size(36, 20);
      this.patientMiddleInitialEntry.TabIndex = 3;
      // 
      // patientLastNameEntry
      // 
      this.patientLastNameEntry.Location = new System.Drawing.Point(213, 55);
      this.patientLastNameEntry.Name = "patientLastNameEntry";
      this.patientLastNameEntry.Size = new System.Drawing.Size(95, 20);
      this.patientLastNameEntry.TabIndex = 4;
      // 
      // labelDOB
      // 
      this.labelDOB.AutoSize = true;
      this.labelDOB.Location = new System.Drawing.Point(37, 98);
      this.labelDOB.Name = "labelDOB";
      this.labelDOB.Size = new System.Drawing.Size(69, 13);
      this.labelDOB.TabIndex = 5;
      this.labelDOB.Text = "Patient DOB:";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(65, 115);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(243, 20);
      this.dateTimePicker1.TabIndex = 6;
      this.dateTimePicker1.Value = new System.DateTime(2019, 9, 3, 0, 0, 0, 0);
      // 
      // PatientForm
      // 
      this.AcceptButton = this.submitPatientInfo;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(367, 450);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.labelDOB);
      this.Controls.Add(this.patientLastNameEntry);
      this.Controls.Add(this.patientMiddleInitialEntry);
      this.Controls.Add(this.labelPatientName);
      this.Controls.Add(this.patientFirstNameEntry);
      this.Controls.Add(this.submitPatientInfo);
      this.Name = "PatientForm";
      this.Text = "PatientForm";
      this.Load += new System.EventHandler(this.PatientForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button submitPatientInfo;
    private System.Windows.Forms.TextBox patientFirstNameEntry;
    private System.Windows.Forms.Label labelPatientName;
    private System.Windows.Forms.TextBox patientMiddleInitialEntry;
    private System.Windows.Forms.TextBox patientLastNameEntry;
    private System.Windows.Forms.Label labelDOB;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
  }
}