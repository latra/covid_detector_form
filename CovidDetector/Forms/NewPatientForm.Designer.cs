﻿namespace CovidDetector.Forms
{
    partial class NewPatientForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.genderSelector = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.symPanel = new System.Windows.Forms.Panel();
            this.sympthomsSelector = new System.Windows.Forms.CheckedListBox();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.firstSelector = new System.Windows.Forms.CheckedListBox();
            this.pathPanel = new System.Windows.Forms.Panel();
            this.pathologiesSelector = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.serp_positive_field = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.seromethodSelector = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.serotypeSelector = new System.Windows.Forms.ListBox();
            this.uciField = new System.Windows.Forms.CheckBox();
            this.admisionField = new System.Windows.Forms.CheckBox();
            this.feverdayField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maxfeverField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bloodfield = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.feverField = new System.Windows.Forms.CheckBox();
            this.vaccinesField = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.symPanel.SuspendLayout();
            this.firstPanel.SuspendLayout();
            this.pathPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(17, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ID";
            // 
            // genderSelector
            // 
            this.genderSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderSelector.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderSelector.FormattingEnabled = true;
            this.genderSelector.ItemHeight = 18;
            this.genderSelector.Items.AddRange(new object[] {
            "man",
            "woman"});
            this.genderSelector.Location = new System.Drawing.Point(351, 12);
            this.genderSelector.Name = "genderSelector";
            this.genderSelector.Size = new System.Drawing.Size(176, 40);
            this.genderSelector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Symptoms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pathologies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select all that apply";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select all that apply";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select all that apply";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender";
            // 
            // symPanel
            // 
            this.symPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.symPanel.Controls.Add(this.sympthomsSelector);
            this.symPanel.Controls.Add(this.label1);
            this.symPanel.Controls.Add(this.label4);
            this.symPanel.Location = new System.Drawing.Point(17, 75);
            this.symPanel.Name = "symPanel";
            this.symPanel.Size = new System.Drawing.Size(365, 571);
            this.symPanel.TabIndex = 12;
            // 
            // sympthomsSelector
            // 
            this.sympthomsSelector.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sympthomsSelector.FormattingEnabled = true;
            this.sympthomsSelector.Items.AddRange(new object[] {
            "wheezing",
            "vomiting",
            "tos",
            "taste_smell",
            "tachypnea",
            "splenomegaly",
            "smell",
            "shock",
            "seizures",
            "resp",
            "rash",
            "peripheral_paralysis",
            "other_symptomatology_mialgies",
            "other_symptomatology_dolor_toracic",
            "other_symptomatology_artritis",
            "other_symptomatology_artralgies",
            "odynophagia",
            "ocular_pain",
            "nuchal_stiffness",
            "neuro",
            "nasal_congestion",
            "irritability",
            "inflammation",
            "hepato",
            "hemorrhagies",
            "gi_symptoms",
            "fever",
            "fatiga",
            "dysphonia",
            "dyarrea",
            "dermatologic",
            "crup",
            "crackles",
            "conjuntivitis",
            "confusion",
            "ausc_resp",
            "adenopathies",
            "abdominal_pain",
            "inflam_periferic",
            "inflam_oral"});
            this.sympthomsSelector.Location = new System.Drawing.Point(20, 67);
            this.sympthomsSelector.Name = "sympthomsSelector";
            this.sympthomsSelector.Size = new System.Drawing.Size(326, 484);
            this.sympthomsSelector.TabIndex = 18;
            // 
            // firstPanel
            // 
            this.firstPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstPanel.Controls.Add(this.firstSelector);
            this.firstPanel.Controls.Add(this.label5);
            this.firstPanel.Controls.Add(this.label2);
            this.firstPanel.Location = new System.Drawing.Point(388, 249);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(365, 397);
            this.firstPanel.TabIndex = 13;
            // 
            // firstSelector
            // 
            this.firstSelector.Font = new System.Drawing.Font("Consolas", 11F);
            this.firstSelector.FormattingEnabled = true;
            this.firstSelector.Items.AddRange(new object[] {
            "taste_first",
            "tachypnea_first",
            "spleno_first",
            "smell_first",
            "skin_first",
            "shock_first",
            "odynophagia_first",
            "ocular_first",
            "neuro_first",
            "nasal_first",
            "lymph_first",
            "irritability_first",
            "hepato_first",
            "hemorr_first",
            "headache_first",
            "gi_first",
            "fatigue_first",
            "dyspnea_first",
            "disfonia_first",
            "crup_first",
            "cough_first",
            "conj_first",
            "cardiopathy",
            "auscult_first"});
            this.firstSelector.Location = new System.Drawing.Point(15, 61);
            this.firstSelector.Name = "firstSelector";
            this.firstSelector.Size = new System.Drawing.Size(332, 324);
            this.firstSelector.TabIndex = 10;
            // 
            // pathPanel
            // 
            this.pathPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pathPanel.Controls.Add(this.pathologiesSelector);
            this.pathPanel.Controls.Add(this.label3);
            this.pathPanel.Controls.Add(this.label6);
            this.pathPanel.Location = new System.Drawing.Point(759, 249);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(365, 397);
            this.pathPanel.TabIndex = 14;
            // 
            // pathologiesSelector
            // 
            this.pathologiesSelector.Font = new System.Drawing.Font("Consolas", 11F);
            this.pathologiesSelector.FormattingEnabled = true;
            this.pathologiesSelector.Items.AddRange(new object[] {
            "pulmonar_disease",
            "tuberculosi",
            "vih_others",
            "obesity",
            "neurologic",
            "nephrology",
            "neoplasia",
            "kawasaki",
            "hypertension",
            "idp",
            "hepatic",
            "diabetes",
            "asma",
            "hypotonia"});
            this.pathologiesSelector.Location = new System.Drawing.Point(16, 61);
            this.pathologiesSelector.Name = "pathologiesSelector";
            this.pathologiesSelector.Size = new System.Drawing.Size(332, 324);
            this.pathologiesSelector.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.serp_positive_field);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.seromethodSelector);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.serotypeSelector);
            this.panel4.Controls.Add(this.uciField);
            this.panel4.Controls.Add(this.admisionField);
            this.panel4.Controls.Add(this.feverdayField);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.maxfeverField);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.bloodfield);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.feverField);
            this.panel4.Location = new System.Drawing.Point(388, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 168);
            this.panel4.TabIndex = 15;
            // 
            // serp_positive_field
            // 
            this.serp_positive_field.AutoSize = true;
            this.serp_positive_field.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serp_positive_field.Location = new System.Drawing.Point(326, 127);
            this.serp_positive_field.Name = "serp_positive_field";
            this.serp_positive_field.Size = new System.Drawing.Size(178, 23);
            this.serp_positive_field.TabIndex = 22;
            this.serp_positive_field.Text = "Sero result is positive";
            this.serp_positive_field.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(475, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "Seromethod (if applies)";
            // 
            // seromethodSelector
            // 
            this.seromethodSelector.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seromethodSelector.FormattingEnabled = true;
            this.seromethodSelector.ItemHeight = 18;
            this.seromethodSelector.Items.AddRange(new object[] {
            "ELISA",
            "CLIA",
            "Test ràpid",
            "Altres",
            "Unknown"});
            this.seromethodSelector.Location = new System.Drawing.Point(479, 27);
            this.seromethodSelector.Name = "seromethodSelector";
            this.seromethodSelector.Size = new System.Drawing.Size(120, 94);
            this.seromethodSelector.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(322, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "Serotype (if applies)";
            // 
            // serotypeSelector
            // 
            this.serotypeSelector.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serotypeSelector.FormattingEnabled = true;
            this.serotypeSelector.ItemHeight = 18;
            this.serotypeSelector.Items.AddRange(new object[] {
            "IgG",
            "IgM",
            "IgG + IgM",
            "Ac totals",
            "Unknown"});
            this.serotypeSelector.Location = new System.Drawing.Point(326, 27);
            this.serotypeSelector.Name = "serotypeSelector";
            this.serotypeSelector.Size = new System.Drawing.Size(120, 94);
            this.serotypeSelector.TabIndex = 18;
            // 
            // uciField
            // 
            this.uciField.AutoSize = true;
            this.uciField.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uciField.Location = new System.Drawing.Point(15, 37);
            this.uciField.Name = "uciField";
            this.uciField.Size = new System.Drawing.Size(52, 23);
            this.uciField.TabIndex = 17;
            this.uciField.Text = "UCI";
            this.uciField.UseVisualStyleBackColor = true;
            // 
            // admisionField
            // 
            this.admisionField.AutoSize = true;
            this.admisionField.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admisionField.Location = new System.Drawing.Point(16, 12);
            this.admisionField.Name = "admisionField";
            this.admisionField.Size = new System.Drawing.Size(95, 23);
            this.admisionField.TabIndex = 16;
            this.admisionField.Text = "Admision";
            this.admisionField.UseVisualStyleBackColor = true;
            // 
            // feverdayField
            // 
            this.feverdayField.Location = new System.Drawing.Point(168, 103);
            this.feverdayField.Name = "feverdayField";
            this.feverdayField.Size = new System.Drawing.Size(54, 20);
            this.feverdayField.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(228, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Days";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(164, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Days with fever";
            // 
            // maxfeverField
            // 
            this.maxfeverField.Location = new System.Drawing.Point(168, 56);
            this.maxfeverField.Name = "maxfeverField";
            this.maxfeverField.Size = new System.Drawing.Size(54, 20);
            this.maxfeverField.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(228, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "ºC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(164, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Highest fever";
            // 
            // bloodfield
            // 
            this.bloodfield.Location = new System.Drawing.Point(16, 103);
            this.bloodfield.Name = "bloodfield";
            this.bloodfield.Size = new System.Drawing.Size(54, 20);
            this.bloodfield.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Blood Saturation";
            // 
            // feverField
            // 
            this.feverField.AutoSize = true;
            this.feverField.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feverField.Location = new System.Drawing.Point(168, 9);
            this.feverField.Name = "feverField";
            this.feverField.Size = new System.Drawing.Size(66, 23);
            this.feverField.TabIndex = 1;
            this.feverField.Text = "Fever";
            this.feverField.UseVisualStyleBackColor = true;
            // 
            // vaccinesField
            // 
            this.vaccinesField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vaccinesField.AutoSize = true;
            this.vaccinesField.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinesField.Location = new System.Drawing.Point(556, 13);
            this.vaccinesField.Name = "vaccinesField";
            this.vaccinesField.Size = new System.Drawing.Size(92, 23);
            this.vaccinesField.TabIndex = 0;
            this.vaccinesField.Text = "Vaccines";
            this.vaccinesField.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(17, 653);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(1107, 59);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Ask to Medbot";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1212, 724);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pathPanel);
            this.Controls.Add(this.firstPanel);
            this.Controls.Add(this.symPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderSelector);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vaccinesField);
            this.Name = "NewPatientForm";
            this.Text = "NewPatientForm";
            this.symPanel.ResumeLayout(false);
            this.symPanel.PerformLayout();
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            this.pathPanel.ResumeLayout(false);
            this.pathPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox genderSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel symPanel;
        private System.Windows.Forms.Panel firstPanel;
        private System.Windows.Forms.Panel pathPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bloodfield;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox feverField;
        private System.Windows.Forms.CheckBox vaccinesField;
        private System.Windows.Forms.TextBox feverdayField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox maxfeverField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox sympthomsSelector;
        private System.Windows.Forms.CheckedListBox firstSelector;
        private System.Windows.Forms.CheckedListBox pathologiesSelector;
        private System.Windows.Forms.CheckBox serp_positive_field;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox seromethodSelector;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox serotypeSelector;
        private System.Windows.Forms.CheckBox uciField;
        private System.Windows.Forms.CheckBox admisionField;
        private System.Windows.Forms.Button submitButton;
    }
}