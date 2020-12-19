﻿namespace CovidDetector.Forms
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.patientListButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.activePanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.Controls.Add(this.usernameLabel);
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
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(120, 19);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Welcome Dr. {0}";
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(3, 632);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(222, 41);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(3, 585);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(222, 41);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // newPatientButton
            // 
            this.newPatientButton.FlatAppearance.BorderSize = 0;
            this.newPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPatientButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(3, 208);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(222, 84);
            this.newPatientButton.TabIndex = 1;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // patientListButton
            // 
            this.patientListButton.FlatAppearance.BorderSize = 0;
            this.patientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientListButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListButton.Location = new System.Drawing.Point(3, 118);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(222, 84);
            this.patientListButton.TabIndex = 0;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = true;
            this.patientListButton.Click += new System.EventHandler(this.patientListButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(228, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(994, 118);
            this.headerPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activePanel
            // 
            this.activePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activePanel.Location = new System.Drawing.Point(228, 118);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(994, 563);
            this.activePanel.TabIndex = 2;
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
            this.Text = "Medbot - {0}";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
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
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}