namespace CovidDetector.Forms
{
    partial class MedicUXForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.activePanel = new System.Windows.Forms.Panel();
            this.patientListButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Controls.Add(this.newPatientButton);
            this.menuPanel.Controls.Add(this.patientListButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(228, 681);
            this.menuPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(228, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(994, 118);
            this.headerPanel.TabIndex = 1;
            // 
            // activePanel
            // 
            this.activePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activePanel.Location = new System.Drawing.Point(228, 118);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(994, 563);
            this.activePanel.TabIndex = 2;
            // 
            // patientListButton
            // 
            this.patientListButton.FlatAppearance.BorderSize = 0;
            this.patientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientListButton.Location = new System.Drawing.Point(3, 118);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(222, 84);
            this.patientListButton.TabIndex = 0;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = true;
            // 
            // newPatientButton
            // 
            this.newPatientButton.FlatAppearance.BorderSize = 0;
            this.newPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPatientButton.Location = new System.Drawing.Point(3, 208);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(222, 84);
            this.newPatientButton.TabIndex = 1;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(3, 585);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(222, 41);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Location = new System.Drawing.Point(3, 632);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(222, 41);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // MedicUXForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 681);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MedicUXForm";
            this.Text = "MedicUXForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel activePanel;
    }
}