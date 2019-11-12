namespace FormsOnFHIR {
  partial class OrganizationForm {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.orgNameEntry = new System.Windows.Forms.TextBox();
      this.orgNameLabel = new System.Windows.Forms.Label();
      this.orgTypeLabel = new System.Windows.Forms.Label();
      this.orgTypeSelector = new System.Windows.Forms.ComboBox();
      this.orgFormLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // orgNameEntry
      // 
      this.orgNameEntry.Location = new System.Drawing.Point(123, 56);
      this.orgNameEntry.Name = "orgNameEntry";
      this.orgNameEntry.Size = new System.Drawing.Size(118, 20);
      this.orgNameEntry.TabIndex = 0;
      // 
      // orgNameLabel
      // 
      this.orgNameLabel.AutoSize = true;
      this.orgNameLabel.Location = new System.Drawing.Point(17, 59);
      this.orgNameLabel.Name = "orgNameLabel";
      this.orgNameLabel.Size = new System.Drawing.Size(100, 13);
      this.orgNameLabel.TabIndex = 1;
      this.orgNameLabel.Text = "Organization Name:";
      // 
      // orgTypeLabel
      // 
      this.orgTypeLabel.AutoSize = true;
      this.orgTypeLabel.Location = new System.Drawing.Point(17, 95);
      this.orgTypeLabel.Name = "orgTypeLabel";
      this.orgTypeLabel.Size = new System.Drawing.Size(96, 13);
      this.orgTypeLabel.TabIndex = 3;
      this.orgTypeLabel.Text = "Organization Type:";
      // 
      // orgTypeSelector
      // 
      this.orgTypeSelector.FormattingEnabled = true;
      this.orgTypeSelector.Location = new System.Drawing.Point(120, 95);
      this.orgTypeSelector.Name = "orgTypeSelector";
      this.orgTypeSelector.Size = new System.Drawing.Size(121, 21);
      this.orgTypeSelector.TabIndex = 4;
      // 
      // orgFormLabel
      // 
      this.orgFormLabel.AutoSize = true;
      this.orgFormLabel.Location = new System.Drawing.Point(17, 18);
      this.orgFormLabel.Name = "orgFormLabel";
      this.orgFormLabel.Size = new System.Drawing.Size(89, 13);
      this.orgFormLabel.TabIndex = 5;
      this.orgFormLabel.Text = "ORGANIZATION";
      // 
      // OrganizationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.orgFormLabel);
      this.Controls.Add(this.orgTypeSelector);
      this.Controls.Add(this.orgTypeLabel);
      this.Controls.Add(this.orgNameLabel);
      this.Controls.Add(this.orgNameEntry);
      this.Name = "OrganizationForm";
      this.Size = new System.Drawing.Size(506, 335);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox orgNameEntry;
    private System.Windows.Forms.Label orgNameLabel;
    private System.Windows.Forms.Label orgTypeLabel;
    private System.Windows.Forms.ComboBox orgTypeSelector;
    private System.Windows.Forms.Label orgFormLabel;
  }
}
