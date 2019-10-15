namespace FormsOnFHIR {
  partial class PatientForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.submitPatientInfo = new System.Windows.Forms.Button();
      this.patientFirstNameEntry = new System.Windows.Forms.TextBox();
      this.labelPatientName = new System.Windows.Forms.Label();
      this.patientMiddleInitialEntry = new System.Windows.Forms.TextBox();
      this.patientLastNameEntry = new System.Windows.Forms.TextBox();
      this.labelDOB = new System.Windows.Forms.Label();
      this.patientDOBPicker = new System.Windows.Forms.DateTimePicker();
      this.adminGenderSelector = new System.Windows.Forms.ComboBox();
      this.patientGenderLabel = new System.Windows.Forms.Label();
      this.isDeceased = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.patientPhoneEntry = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // submitPatientInfo
      // 
      this.submitPatientInfo.Location = new System.Drawing.Point(144, 415);
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
      this.labelDOB.Location = new System.Drawing.Point(37, 159);
      this.labelDOB.Name = "labelDOB";
      this.labelDOB.Size = new System.Drawing.Size(69, 13);
      this.labelDOB.TabIndex = 5;
      this.labelDOB.Text = "Patient DOB:";
      // 
      // patientDOBPicker
      // 
      this.patientDOBPicker.Location = new System.Drawing.Point(65, 176);
      this.patientDOBPicker.Name = "patientDOBPicker";
      this.patientDOBPicker.Size = new System.Drawing.Size(196, 20);
      this.patientDOBPicker.TabIndex = 6;
      this.patientDOBPicker.Value = new System.DateTime(2019, 9, 3, 0, 0, 0, 0);
      // 
      // adminGenderSelector
      // 
      this.adminGenderSelector.FormattingEnabled = true;
      this.adminGenderSelector.Location = new System.Drawing.Point(65, 111);
      this.adminGenderSelector.Name = "adminGenderSelector";
      this.adminGenderSelector.Size = new System.Drawing.Size(121, 21);
      this.adminGenderSelector.TabIndex = 7;
      // 
      // patientGenderLabel
      // 
      this.patientGenderLabel.AutoSize = true;
      this.patientGenderLabel.Location = new System.Drawing.Point(37, 95);
      this.patientGenderLabel.Name = "patientGenderLabel";
      this.patientGenderLabel.Size = new System.Drawing.Size(81, 13);
      this.patientGenderLabel.TabIndex = 8;
      this.patientGenderLabel.Text = "Patient Gender:";
      // 
      // isDeceased
      // 
      this.isDeceased.AutoSize = true;
      this.isDeceased.Location = new System.Drawing.Point(65, 203);
      this.isDeceased.Name = "isDeceased";
      this.isDeceased.Size = new System.Drawing.Size(79, 17);
      this.isDeceased.TabIndex = 9;
      this.isDeceased.Text = "deceased?";
      this.isDeceased.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 239);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Patient Phone:";
      // 
      // patientPhoneEntry
      // 
      this.patientPhoneEntry.Location = new System.Drawing.Point(65, 256);
      this.patientPhoneEntry.Name = "patientPhoneEntry";
      this.patientPhoneEntry.Size = new System.Drawing.Size(100, 20);
      this.patientPhoneEntry.TabIndex = 11;
      // 
      // PatientForm
      // 
      this.AcceptButton = this.submitPatientInfo;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(367, 450);
      this.Controls.Add(this.patientPhoneEntry);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.isDeceased);
      this.Controls.Add(this.patientGenderLabel);
      this.Controls.Add(this.adminGenderSelector);
      this.Controls.Add(this.patientDOBPicker);
      this.Controls.Add(this.labelDOB);
      this.Controls.Add(this.patientLastNameEntry);
      this.Controls.Add(this.patientMiddleInitialEntry);
      this.Controls.Add(this.labelPatientName);
      this.Controls.Add(this.patientFirstNameEntry);
      this.Controls.Add(this.submitPatientInfo);
      this.Name = "PatientForm";
      this.Text = "PatientForm";
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
    private System.Windows.Forms.DateTimePicker patientDOBPicker;
    private System.Windows.Forms.ComboBox adminGenderSelector;
    private System.Windows.Forms.Label patientGenderLabel;
    private System.Windows.Forms.CheckBox isDeceased;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox patientPhoneEntry;
  }
}