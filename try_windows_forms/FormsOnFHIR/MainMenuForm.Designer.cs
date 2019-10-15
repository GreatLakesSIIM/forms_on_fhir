namespace FormsOnFHIR
{
    partial class MainMenuForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.practitionerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.careTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.healthcareServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.cmdChooseFiles = new System.Windows.Forms.Button();
      this.resourceTypeLabel = new System.Windows.Forms.Label();
      this.resourceTypeDisplayLabel = new System.Windows.Forms.Label();
      this.cmdUploadFiles = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.searchToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.practitionerToolStripMenuItem,
            this.careTeamToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.organizationToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.healthcareServiceToolStripMenuItem});
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.newToolStripMenuItem.Text = "New...";
      // 
      // patientToolStripMenuItem
      // 
      this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
      this.patientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.patientToolStripMenuItem.Text = "Patient";
      this.patientToolStripMenuItem.Click += new System.EventHandler(this.NewPatientToolStripMenuItem_Click);
      // 
      // practitionerToolStripMenuItem
      // 
      this.practitionerToolStripMenuItem.Name = "practitionerToolStripMenuItem";
      this.practitionerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.practitionerToolStripMenuItem.Text = "Practitioner";
      // 
      // careTeamToolStripMenuItem
      // 
      this.careTeamToolStripMenuItem.Name = "careTeamToolStripMenuItem";
      this.careTeamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.careTeamToolStripMenuItem.Text = "CareTeam";
      // 
      // deviceToolStripMenuItem
      // 
      this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
      this.deviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.deviceToolStripMenuItem.Text = "Device";
      // 
      // organizationToolStripMenuItem
      // 
      this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
      this.organizationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.organizationToolStripMenuItem.Text = "Organization";
      // 
      // locationToolStripMenuItem
      // 
      this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
      this.locationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.locationToolStripMenuItem.Text = "Location";
      // 
      // healthcareServiceToolStripMenuItem
      // 
      this.healthcareServiceToolStripMenuItem.Name = "healthcareServiceToolStripMenuItem";
      this.healthcareServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.healthcareServiceToolStripMenuItem.Text = "Healthcare Service";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem1});
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.searchToolStripMenuItem.Text = "Search...";
      // 
      // patientToolStripMenuItem1
      // 
      this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
      this.patientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
      this.patientToolStripMenuItem1.Text = "Patient";
      this.patientToolStripMenuItem1.Click += new System.EventHandler(this.SearchForPatientToolStripMenuItem_Click);
      // 
      // cmdChooseFiles
      // 
      this.cmdChooseFiles.Location = new System.Drawing.Point(66, 87);
      this.cmdChooseFiles.Name = "cmdChooseFiles";
      this.cmdChooseFiles.Size = new System.Drawing.Size(75, 23);
      this.cmdChooseFiles.TabIndex = 1;
      this.cmdChooseFiles.Text = "Choose Files";
      this.cmdChooseFiles.UseVisualStyleBackColor = true;
      this.cmdChooseFiles.Click += new System.EventHandler(this.ChooseSyntheaGeneratedFilesBtn_Click);
      // 
      // resourceTypeLabel
      // 
      this.resourceTypeLabel.AutoSize = true;
      this.resourceTypeLabel.Location = new System.Drawing.Point(66, 156);
      this.resourceTypeLabel.Name = "resourceTypeLabel";
      this.resourceTypeLabel.Size = new System.Drawing.Size(80, 13);
      this.resourceTypeLabel.TabIndex = 2;
      this.resourceTypeLabel.Text = "ResourceType:";
      // 
      // resourceTypeDisplayLabel
      // 
      this.resourceTypeDisplayLabel.AutoSize = true;
      this.resourceTypeDisplayLabel.Location = new System.Drawing.Point(152, 156);
      this.resourceTypeDisplayLabel.Name = "resourceTypeDisplayLabel";
      this.resourceTypeDisplayLabel.Size = new System.Drawing.Size(84, 13);
      this.resourceTypeDisplayLabel.TabIndex = 3;
      this.resourceTypeDisplayLabel.Text = "<resourceType>";
      // 
      // cmdUploadFiles
      // 
      this.cmdUploadFiles.Location = new System.Drawing.Point(66, 252);
      this.cmdUploadFiles.Name = "cmdUploadFiles";
      this.cmdUploadFiles.Size = new System.Drawing.Size(75, 23);
      this.cmdUploadFiles.TabIndex = 4;
      this.cmdUploadFiles.Text = "Upload Files";
      this.cmdUploadFiles.UseVisualStyleBackColor = true;
      this.cmdUploadFiles.Click += new System.EventHandler(this.CmdUploadFiles_Click);
      // 
      // MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.cmdUploadFiles);
      this.Controls.Add(this.resourceTypeDisplayLabel);
      this.Controls.Add(this.resourceTypeLabel);
      this.Controls.Add(this.cmdChooseFiles);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainMenuForm";
      this.Text = "Main Menu";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practitionerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem careTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthcareServiceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
    private System.Windows.Forms.Button cmdChooseFiles;
    private System.Windows.Forms.Label resourceTypeLabel;
    private System.Windows.Forms.Label resourceTypeDisplayLabel;
    private System.Windows.Forms.Button cmdUploadFiles;
  }
}

