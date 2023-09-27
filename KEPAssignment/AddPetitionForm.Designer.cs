
namespace KEPAssignment
{
    partial class AddPetitionForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.petitionTypeMandatoryMarkerLabel = new System.Windows.Forms.Label();
            this.citizenAFMMandatoryMarkerLabel = new System.Windows.Forms.Label();
            this.petitionDescriptionTextBox = new KEPAssignment.CustomTextBox();
            this.petitionDescriptionLabel = new System.Windows.Forms.Label();
            this.petitionTypeComboBox = new KEPAssignment.CustomComboBox();
            this.createPetitionButton = new KEPAssignment.CustomButton();
            this.petitionTypeLabel = new System.Windows.Forms.Label();
            this.petitionAliasTextBox = new KEPAssignment.CustomTextBox();
            this.petitionAliasLabel = new System.Windows.Forms.Label();
            this.citizenAFMTextBox = new KEPAssignment.CustomTextBox();
            this.citizenAFMLabel = new System.Windows.Forms.Label();
            this.petitionsFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(481, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "are mandatory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "Fields with";
            // 
            // petitionTypeMandatoryMarkerLabel
            // 
            this.petitionTypeMandatoryMarkerLabel.AutoSize = true;
            this.petitionTypeMandatoryMarkerLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionTypeMandatoryMarkerLabel.ForeColor = System.Drawing.Color.Red;
            this.petitionTypeMandatoryMarkerLabel.Location = new System.Drawing.Point(146, 262);
            this.petitionTypeMandatoryMarkerLabel.Name = "petitionTypeMandatoryMarkerLabel";
            this.petitionTypeMandatoryMarkerLabel.Size = new System.Drawing.Size(15, 23);
            this.petitionTypeMandatoryMarkerLabel.TabIndex = 84;
            this.petitionTypeMandatoryMarkerLabel.Text = "*";
            // 
            // citizenAFMMandatoryMarkerLabel
            // 
            this.citizenAFMMandatoryMarkerLabel.AutoSize = true;
            this.citizenAFMMandatoryMarkerLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenAFMMandatoryMarkerLabel.ForeColor = System.Drawing.Color.Red;
            this.citizenAFMMandatoryMarkerLabel.Location = new System.Drawing.Point(145, 162);
            this.citizenAFMMandatoryMarkerLabel.Name = "citizenAFMMandatoryMarkerLabel";
            this.citizenAFMMandatoryMarkerLabel.Size = new System.Drawing.Size(15, 23);
            this.citizenAFMMandatoryMarkerLabel.TabIndex = 83;
            this.citizenAFMMandatoryMarkerLabel.Text = "*";
            // 
            // petitionDescriptionTextBox
            // 
            this.petitionDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.petitionDescriptionTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.petitionDescriptionTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.petitionDescriptionTextBox.BorderSize = 2;
            this.petitionDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionDescriptionTextBox.ForeColor = System.Drawing.Color.Black;
            this.petitionDescriptionTextBox.Location = new System.Drawing.Point(406, 102);
            this.petitionDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.petitionDescriptionTextBox.Multiline = true;
            this.petitionDescriptionTextBox.Name = "petitionDescriptionTextBox";
            this.petitionDescriptionTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.petitionDescriptionTextBox.PasswordChar = false;
            this.petitionDescriptionTextBox.Size = new System.Drawing.Size(269, 230);
            this.petitionDescriptionTextBox.TabIndex = 76;
            this.petitionDescriptionTextBox.Texts = "";
            this.petitionDescriptionTextBox.UnderlinedStyle = false;
            this.petitionDescriptionTextBox.Enter += new System.EventHandler(this.petitionDescriptionTextBox_Enter);
            this.petitionDescriptionTextBox.Leave += new System.EventHandler(this.petitionDescriptionTextBox_Leave);
            // 
            // petitionDescriptionLabel
            // 
            this.petitionDescriptionLabel.AutoSize = true;
            this.petitionDescriptionLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionDescriptionLabel.Location = new System.Drawing.Point(454, 62);
            this.petitionDescriptionLabel.Name = "petitionDescriptionLabel";
            this.petitionDescriptionLabel.Size = new System.Drawing.Size(167, 23);
            this.petitionDescriptionLabel.TabIndex = 82;
            this.petitionDescriptionLabel.Text = "Petition Description";
            // 
            // petitionTypeComboBox
            // 
            this.petitionTypeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.petitionTypeComboBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.petitionTypeComboBox.BorderSize = 2;
            this.petitionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.petitionTypeComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.petitionTypeComboBox.IconColor = System.Drawing.Color.RoyalBlue;
            this.petitionTypeComboBox.Items.AddRange(new object[] {
            "Select One Of The Following",
            "Birth Certificate",
            "Marriage Certificate",
            "School Certificate",
            "Hospital Certificate",
            "Judicial Document",
            "Copy Of ID",
            "Copy Of Passport "});
            this.petitionTypeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.petitionTypeComboBox.ListTextColor = System.Drawing.Color.Black;
            this.petitionTypeComboBox.Location = new System.Drawing.Point(44, 302);
            this.petitionTypeComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.petitionTypeComboBox.Name = "petitionTypeComboBox";
            this.petitionTypeComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.petitionTypeComboBox.Size = new System.Drawing.Size(269, 30);
            this.petitionTypeComboBox.TabIndex = 75;
            this.petitionTypeComboBox.Texts = "";
            this.petitionTypeComboBox.Enter += new System.EventHandler(this.petitionTypeComboBox_Enter);
            this.petitionTypeComboBox.Leave += new System.EventHandler(this.petitionTypeComboBox_Leave);
            // 
            // createPetitionButton
            // 
            this.createPetitionButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createPetitionButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.createPetitionButton.BorderColor = System.Drawing.Color.Black;
            this.createPetitionButton.BorderRadius = 15;
            this.createPetitionButton.BorderSize = 3;
            this.createPetitionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPetitionButton.FlatAppearance.BorderSize = 0;
            this.createPetitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPetitionButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPetitionButton.ForeColor = System.Drawing.Color.Black;
            this.createPetitionButton.Location = new System.Drawing.Point(256, 459);
            this.createPetitionButton.Name = "createPetitionButton";
            this.createPetitionButton.Size = new System.Drawing.Size(213, 45);
            this.createPetitionButton.TabIndex = 77;
            this.createPetitionButton.Text = "Create Petition";
            this.createPetitionButton.TextColor = System.Drawing.Color.Black;
            this.createPetitionButton.UseVisualStyleBackColor = false;
            this.createPetitionButton.Click += new System.EventHandler(this.createPetitionButton_Click);
            // 
            // petitionTypeLabel
            // 
            this.petitionTypeLabel.AutoSize = true;
            this.petitionTypeLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionTypeLabel.Location = new System.Drawing.Point(40, 262);
            this.petitionTypeLabel.Name = "petitionTypeLabel";
            this.petitionTypeLabel.Size = new System.Drawing.Size(113, 23);
            this.petitionTypeLabel.TabIndex = 81;
            this.petitionTypeLabel.Text = "Petition Type";
            // 
            // petitionAliasTextBox
            // 
            this.petitionAliasTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.petitionAliasTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.petitionAliasTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.petitionAliasTextBox.BorderSize = 4;
            this.petitionAliasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionAliasTextBox.ForeColor = System.Drawing.Color.Black;
            this.petitionAliasTextBox.Location = new System.Drawing.Point(44, 102);
            this.petitionAliasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.petitionAliasTextBox.Multiline = false;
            this.petitionAliasTextBox.Name = "petitionAliasTextBox";
            this.petitionAliasTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.petitionAliasTextBox.PasswordChar = false;
            this.petitionAliasTextBox.Size = new System.Drawing.Size(269, 29);
            this.petitionAliasTextBox.TabIndex = 73;
            this.petitionAliasTextBox.Texts = "";
            this.petitionAliasTextBox.UnderlinedStyle = true;
            this.petitionAliasTextBox.Enter += new System.EventHandler(this.petitionAliasTextBox_Enter);
            this.petitionAliasTextBox.Leave += new System.EventHandler(this.petitionAliasTextBox_Leave);
            // 
            // petitionAliasLabel
            // 
            this.petitionAliasLabel.AutoSize = true;
            this.petitionAliasLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionAliasLabel.Location = new System.Drawing.Point(40, 62);
            this.petitionAliasLabel.Name = "petitionAliasLabel";
            this.petitionAliasLabel.Size = new System.Drawing.Size(113, 23);
            this.petitionAliasLabel.TabIndex = 80;
            this.petitionAliasLabel.Text = "Petition Alias";
            // 
            // citizenAFMTextBox
            // 
            this.citizenAFMTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.citizenAFMTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.citizenAFMTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.citizenAFMTextBox.BorderSize = 4;
            this.citizenAFMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenAFMTextBox.ForeColor = System.Drawing.Color.Black;
            this.citizenAFMTextBox.Location = new System.Drawing.Point(44, 202);
            this.citizenAFMTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.citizenAFMTextBox.Multiline = false;
            this.citizenAFMTextBox.Name = "citizenAFMTextBox";
            this.citizenAFMTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.citizenAFMTextBox.PasswordChar = false;
            this.citizenAFMTextBox.Size = new System.Drawing.Size(269, 29);
            this.citizenAFMTextBox.TabIndex = 74;
            this.citizenAFMTextBox.Texts = "";
            this.citizenAFMTextBox.UnderlinedStyle = true;
            this.citizenAFMTextBox.Enter += new System.EventHandler(this.citizenAFMTextBox_Enter);
            this.citizenAFMTextBox.Leave += new System.EventHandler(this.citizenAFMTextBox_Leave);
            // 
            // citizenAFMLabel
            // 
            this.citizenAFMLabel.AutoSize = true;
            this.citizenAFMLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenAFMLabel.Location = new System.Drawing.Point(40, 162);
            this.citizenAFMLabel.Name = "citizenAFMLabel";
            this.citizenAFMLabel.Size = new System.Drawing.Size(111, 23);
            this.citizenAFMLabel.TabIndex = 79;
            this.citizenAFMLabel.Text = "Citizen\'s AFM";
            // 
            // petitionsFormLabel
            // 
            this.petitionsFormLabel.AutoSize = true;
            this.petitionsFormLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionsFormLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.petitionsFormLabel.Location = new System.Drawing.Point(296, 13);
            this.petitionsFormLabel.Name = "petitionsFormLabel";
            this.petitionsFormLabel.Size = new System.Drawing.Size(134, 26);
            this.petitionsFormLabel.TabIndex = 78;
            this.petitionsFormLabel.Text = "Petitions Form";
            // 
            // AddPetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.petitionTypeMandatoryMarkerLabel);
            this.Controls.Add(this.citizenAFMMandatoryMarkerLabel);
            this.Controls.Add(this.petitionDescriptionTextBox);
            this.Controls.Add(this.petitionDescriptionLabel);
            this.Controls.Add(this.petitionTypeComboBox);
            this.Controls.Add(this.createPetitionButton);
            this.Controls.Add(this.petitionTypeLabel);
            this.Controls.Add(this.petitionAliasTextBox);
            this.Controls.Add(this.petitionAliasLabel);
            this.Controls.Add(this.citizenAFMTextBox);
            this.Controls.Add(this.citizenAFMLabel);
            this.Controls.Add(this.petitionsFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPetitionForm";
            this.Text = "AddPetitionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label petitionTypeMandatoryMarkerLabel;
        private System.Windows.Forms.Label citizenAFMMandatoryMarkerLabel;
        private CustomTextBox petitionDescriptionTextBox;
        private System.Windows.Forms.Label petitionDescriptionLabel;
        private CustomComboBox petitionTypeComboBox;
        private CustomButton createPetitionButton;
        private System.Windows.Forms.Label petitionTypeLabel;
        private CustomTextBox petitionAliasTextBox;
        private System.Windows.Forms.Label petitionAliasLabel;
        private CustomTextBox citizenAFMTextBox;
        private System.Windows.Forms.Label citizenAFMLabel;
        private System.Windows.Forms.Label petitionsFormLabel;
    }
}