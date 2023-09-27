
namespace KEPAssignment
{
    partial class ViewPetitionsForm
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
            this.filterPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.petitionStatusLabel = new System.Windows.Forms.Label();
            this.petitionDatelabel = new System.Windows.Forms.Label();
            this.petitionTypeLabel = new System.Windows.Forms.Label();
            this.searchByIdOrAliasLabel = new System.Windows.Forms.Label();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.petitionsViewPanel = new System.Windows.Forms.Panel();
            this.petitionsListLabel = new System.Windows.Forms.Label();
            this.viewOptionLabel = new System.Windows.Forms.Label();
            this.viewOptionCheckBox = new KEPAssignment.CustomElements.CustomCheckBox();
            this.petitionStartingDateDatePicker = new KEPAssignment.CustomElements.CustomCalendar();
            this.searchOptionCheckBox = new KEPAssignment.CustomElements.CustomCheckBox();
            this.petitionStatusComboBox = new KEPAssignment.CustomComboBox();
            this.applyFiltersButton = new KEPAssignment.CustomButton();
            this.petitionTypeComboBox = new KEPAssignment.CustomComboBox();
            this.searchByIdOrAliasButton = new KEPAssignment.CustomButton();
            this.searchByIdOrAliasTextBox = new KEPAssignment.CustomTextBox();
            this.filterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.filterPanel.Controls.Add(this.panel1);
            this.filterPanel.Location = new System.Drawing.Point(12, 50);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(211, 454);
            this.filterPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.petitionStartingDateDatePicker);
            this.panel1.Controls.Add(this.searchOptionCheckBox);
            this.panel1.Controls.Add(this.petitionStatusComboBox);
            this.panel1.Controls.Add(this.petitionStatusLabel);
            this.panel1.Controls.Add(this.petitionDatelabel);
            this.panel1.Controls.Add(this.applyFiltersButton);
            this.panel1.Controls.Add(this.petitionTypeLabel);
            this.panel1.Controls.Add(this.petitionTypeComboBox);
            this.panel1.Controls.Add(this.searchByIdOrAliasButton);
            this.panel1.Controls.Add(this.searchByIdOrAliasLabel);
            this.panel1.Controls.Add(this.searchByIdOrAliasTextBox);
            this.panel1.Controls.Add(this.filtersLabel);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 434);
            this.panel1.TabIndex = 3;
            // 
            // petitionStatusLabel
            // 
            this.petitionStatusLabel.AutoSize = true;
            this.petitionStatusLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionStatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.petitionStatusLabel.Location = new System.Drawing.Point(3, 290);
            this.petitionStatusLabel.Name = "petitionStatusLabel";
            this.petitionStatusLabel.Size = new System.Drawing.Size(104, 20);
            this.petitionStatusLabel.TabIndex = 13;
            this.petitionStatusLabel.Text = "Petition Status";
            // 
            // petitionDatelabel
            // 
            this.petitionDatelabel.AutoSize = true;
            this.petitionDatelabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionDatelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.petitionDatelabel.Location = new System.Drawing.Point(3, 210);
            this.petitionDatelabel.Name = "petitionDatelabel";
            this.petitionDatelabel.Size = new System.Drawing.Size(157, 20);
            this.petitionDatelabel.TabIndex = 9;
            this.petitionDatelabel.Text = "Petition Date (Starting)";
            // 
            // petitionTypeLabel
            // 
            this.petitionTypeLabel.AutoSize = true;
            this.petitionTypeLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.petitionTypeLabel.Location = new System.Drawing.Point(3, 130);
            this.petitionTypeLabel.Name = "petitionTypeLabel";
            this.petitionTypeLabel.Size = new System.Drawing.Size(92, 20);
            this.petitionTypeLabel.TabIndex = 7;
            this.petitionTypeLabel.Text = "Petition Type";
            // 
            // searchByIdOrAliasLabel
            // 
            this.searchByIdOrAliasLabel.AutoSize = true;
            this.searchByIdOrAliasLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIdOrAliasLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchByIdOrAliasLabel.Location = new System.Drawing.Point(3, 50);
            this.searchByIdOrAliasLabel.Name = "searchByIdOrAliasLabel";
            this.searchByIdOrAliasLabel.Size = new System.Drawing.Size(91, 20);
            this.searchByIdOrAliasLabel.TabIndex = 4;
            this.searchByIdOrAliasLabel.Text = "Search By ID";
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filtersLabel.Location = new System.Drawing.Point(65, 9);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(60, 23);
            this.filtersLabel.TabIndex = 2;
            this.filtersLabel.Text = "Filters";
            // 
            // petitionsViewPanel
            // 
            this.petitionsViewPanel.Location = new System.Drawing.Point(240, 50);
            this.petitionsViewPanel.Name = "petitionsViewPanel";
            this.petitionsViewPanel.Size = new System.Drawing.Size(462, 454);
            this.petitionsViewPanel.TabIndex = 12;
            // 
            // petitionsListLabel
            // 
            this.petitionsListLabel.AutoSize = true;
            this.petitionsListLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionsListLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.petitionsListLabel.Location = new System.Drawing.Point(297, 11);
            this.petitionsListLabel.Name = "petitionsListLabel";
            this.petitionsListLabel.Size = new System.Drawing.Size(121, 26);
            this.petitionsListLabel.TabIndex = 13;
            this.petitionsListLabel.Text = "Petitions List";
            // 
            // viewOptionLabel
            // 
            this.viewOptionLabel.AutoSize = true;
            this.viewOptionLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewOptionLabel.Location = new System.Drawing.Point(582, 16);
            this.viewOptionLabel.Name = "viewOptionLabel";
            this.viewOptionLabel.Size = new System.Drawing.Size(72, 20);
            this.viewOptionLabel.TabIndex = 14;
            this.viewOptionLabel.Text = "Card View";
            // 
            // viewOptionCheckBox
            // 
            this.viewOptionCheckBox.AutoSize = true;
            this.viewOptionCheckBox.Location = new System.Drawing.Point(657, 18);
            this.viewOptionCheckBox.MinimumSize = new System.Drawing.Size(45, 19);
            this.viewOptionCheckBox.Name = "viewOptionCheckBox";
            this.viewOptionCheckBox.OffBackColor = System.Drawing.Color.RoyalBlue;
            this.viewOptionCheckBox.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.viewOptionCheckBox.OnBackColor = System.Drawing.Color.Black;
            this.viewOptionCheckBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.viewOptionCheckBox.Size = new System.Drawing.Size(45, 19);
            this.viewOptionCheckBox.TabIndex = 15;
            this.viewOptionCheckBox.UseVisualStyleBackColor = true;
            this.viewOptionCheckBox.CheckedChanged += new System.EventHandler(this.viewOptionCheckBox_CheckedChanged);
            // 
            // petitionStartingDateDatePicker
            // 
            this.petitionStartingDateDatePicker.BorderColor = System.Drawing.Color.RoyalBlue;
            this.petitionStartingDateDatePicker.BorderSize = 2;
            this.petitionStartingDateDatePicker.CalendarMonthBackground = System.Drawing.Color.RoyalBlue;
            this.petitionStartingDateDatePicker.CustomFormat = "";
            this.petitionStartingDateDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionStartingDateDatePicker.Location = new System.Drawing.Point(7, 242);
            this.petitionStartingDateDatePicker.MinimumSize = new System.Drawing.Size(4, 30);
            this.petitionStartingDateDatePicker.Name = "petitionStartingDateDatePicker";
            this.petitionStartingDateDatePicker.Size = new System.Drawing.Size(167, 30);
            this.petitionStartingDateDatePicker.SkinColor = System.Drawing.Color.White;
            this.petitionStartingDateDatePicker.TabIndex = 17;
            this.petitionStartingDateDatePicker.TextColor = System.Drawing.Color.Black;
            this.petitionStartingDateDatePicker.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.petitionStartingDateDatePicker.Enter += new System.EventHandler(this.petitionStartingDateDatePicker_Enter);
            this.petitionStartingDateDatePicker.Leave += new System.EventHandler(this.petitionStartingDateDatePicker_Leave);
            // 
            // searchOptionCheckBox
            // 
            this.searchOptionCheckBox.AutoSize = true;
            this.searchOptionCheckBox.Location = new System.Drawing.Point(129, 51);
            this.searchOptionCheckBox.MinimumSize = new System.Drawing.Size(45, 19);
            this.searchOptionCheckBox.Name = "searchOptionCheckBox";
            this.searchOptionCheckBox.OffBackColor = System.Drawing.Color.RoyalBlue;
            this.searchOptionCheckBox.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.searchOptionCheckBox.OnBackColor = System.Drawing.Color.Black;
            this.searchOptionCheckBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.searchOptionCheckBox.Size = new System.Drawing.Size(45, 19);
            this.searchOptionCheckBox.TabIndex = 16;
            this.searchOptionCheckBox.UseVisualStyleBackColor = true;
            this.searchOptionCheckBox.CheckedChanged += new System.EventHandler(this.searchOptionCheckBox_CheckedChanged);
            // 
            // petitionStatusComboBox
            // 
            this.petitionStatusComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.petitionStatusComboBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.petitionStatusComboBox.BorderSize = 2;
            this.petitionStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.petitionStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionStatusComboBox.ForeColor = System.Drawing.Color.Black;
            this.petitionStatusComboBox.IconColor = System.Drawing.Color.RoyalBlue;
            this.petitionStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Accepted",
            "Rejected"});
            this.petitionStatusComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.petitionStatusComboBox.ListTextColor = System.Drawing.Color.Black;
            this.petitionStatusComboBox.Location = new System.Drawing.Point(7, 320);
            this.petitionStatusComboBox.MinimumSize = new System.Drawing.Size(100, 30);
            this.petitionStatusComboBox.Name = "petitionStatusComboBox";
            this.petitionStatusComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.petitionStatusComboBox.Size = new System.Drawing.Size(167, 30);
            this.petitionStatusComboBox.TabIndex = 14;
            this.petitionStatusComboBox.Texts = "";
            this.petitionStatusComboBox.Enter += new System.EventHandler(this.petitionStatusComboBox_Enter);
            this.petitionStatusComboBox.Leave += new System.EventHandler(this.petitionStatusComboBox_Leave);
            // 
            // applyFiltersButton
            // 
            this.applyFiltersButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.applyFiltersButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.applyFiltersButton.BorderColor = System.Drawing.Color.Black;
            this.applyFiltersButton.BorderRadius = 10;
            this.applyFiltersButton.BorderSize = 3;
            this.applyFiltersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyFiltersButton.FlatAppearance.BorderSize = 0;
            this.applyFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyFiltersButton.Font = new System.Drawing.Font("Impact", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyFiltersButton.ForeColor = System.Drawing.Color.Black;
            this.applyFiltersButton.Location = new System.Drawing.Point(7, 382);
            this.applyFiltersButton.Name = "applyFiltersButton";
            this.applyFiltersButton.Size = new System.Drawing.Size(167, 40);
            this.applyFiltersButton.TabIndex = 8;
            this.applyFiltersButton.Text = "Apply Filters";
            this.applyFiltersButton.TextColor = System.Drawing.Color.Black;
            this.applyFiltersButton.UseVisualStyleBackColor = false;
            this.applyFiltersButton.Click += new System.EventHandler(this.applyFiltersButton_Click);
            this.applyFiltersButton.Enter += new System.EventHandler(this.applyFiltersButton_Enter);
            this.applyFiltersButton.Leave += new System.EventHandler(this.applyFiltersButton_Leave);
            this.applyFiltersButton.MouseEnter += new System.EventHandler(this.applyFiltersButton_MouseEnter);
            this.applyFiltersButton.MouseLeave += new System.EventHandler(this.applyFiltersButton_MouseLeave);
            // 
            // petitionTypeComboBox
            // 
            this.petitionTypeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.petitionTypeComboBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.petitionTypeComboBox.BorderSize = 2;
            this.petitionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.petitionTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.petitionTypeComboBox.IconColor = System.Drawing.Color.RoyalBlue;
            this.petitionTypeComboBox.Items.AddRange(new object[] {
            "Birth Certificate",
            "Marriage Certificate",
            "School Certificate",
            "Hospital Certificate",
            "Judicial Document",
            "Copy Of ID",
            "Copy Of Passport "});
            this.petitionTypeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.petitionTypeComboBox.ListTextColor = System.Drawing.Color.Black;
            this.petitionTypeComboBox.Location = new System.Drawing.Point(7, 160);
            this.petitionTypeComboBox.MinimumSize = new System.Drawing.Size(100, 30);
            this.petitionTypeComboBox.Name = "petitionTypeComboBox";
            this.petitionTypeComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.petitionTypeComboBox.Size = new System.Drawing.Size(167, 30);
            this.petitionTypeComboBox.TabIndex = 6;
            this.petitionTypeComboBox.Texts = "";
            this.petitionTypeComboBox.Enter += new System.EventHandler(this.petitionTypeComboBox_Enter);
            this.petitionTypeComboBox.Leave += new System.EventHandler(this.petitionTypeComboBox_Leave);
            // 
            // searchByIdOrAliasButton
            // 
            this.searchByIdOrAliasButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchByIdOrAliasButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.searchByIdOrAliasButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchByIdOrAliasButton.BorderRadius = 5;
            this.searchByIdOrAliasButton.BorderSize = 0;
            this.searchByIdOrAliasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchByIdOrAliasButton.FlatAppearance.BorderSize = 0;
            this.searchByIdOrAliasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByIdOrAliasButton.ForeColor = System.Drawing.Color.White;
            this.searchByIdOrAliasButton.Image = global::KEPAssignment.Properties.Resources.search;
            this.searchByIdOrAliasButton.Location = new System.Drawing.Point(7, 78);
            this.searchByIdOrAliasButton.Name = "searchByIdOrAliasButton";
            this.searchByIdOrAliasButton.Size = new System.Drawing.Size(35, 31);
            this.searchByIdOrAliasButton.TabIndex = 5;
            this.searchByIdOrAliasButton.TextColor = System.Drawing.Color.White;
            this.searchByIdOrAliasButton.UseVisualStyleBackColor = false;
            this.searchByIdOrAliasButton.Click += new System.EventHandler(this.searchByIdOrAliasButton_Click);
            // 
            // searchByIdOrAliasTextBox
            // 
            this.searchByIdOrAliasTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchByIdOrAliasTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.searchByIdOrAliasTextBox.BorderFocusColor = System.Drawing.Color.Black;
            this.searchByIdOrAliasTextBox.BorderSize = 2;
            this.searchByIdOrAliasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIdOrAliasTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchByIdOrAliasTextBox.Location = new System.Drawing.Point(49, 80);
            this.searchByIdOrAliasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchByIdOrAliasTextBox.Multiline = false;
            this.searchByIdOrAliasTextBox.Name = "searchByIdOrAliasTextBox";
            this.searchByIdOrAliasTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.searchByIdOrAliasTextBox.PasswordChar = false;
            this.searchByIdOrAliasTextBox.Size = new System.Drawing.Size(125, 29);
            this.searchByIdOrAliasTextBox.TabIndex = 3;
            this.searchByIdOrAliasTextBox.Texts = "";
            this.searchByIdOrAliasTextBox.UnderlinedStyle = false;
            this.searchByIdOrAliasTextBox.Enter += new System.EventHandler(this.searchByIdOrAliasTextBox_Enter);
            this.searchByIdOrAliasTextBox.Leave += new System.EventHandler(this.searchByIdOrAliasTextBox_Leave);
            // 
            // ViewPetitionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.viewOptionCheckBox);
            this.Controls.Add(this.viewOptionLabel);
            this.Controls.Add(this.petitionsListLabel);
            this.Controls.Add(this.petitionsViewPanel);
            this.Controls.Add(this.filterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPetitionsForm";
            this.Text = "ViewPetitionsForm";
            this.filterPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.Panel petitionsViewPanel;
        private System.Windows.Forms.Label petitionsListLabel;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox searchByIdOrAliasTextBox;
        private System.Windows.Forms.Label searchByIdOrAliasLabel;
        private CustomButton searchByIdOrAliasButton;
        private CustomButton applyFiltersButton;
        private System.Windows.Forms.Label petitionTypeLabel;
        private CustomComboBox petitionTypeComboBox;
        private System.Windows.Forms.Label petitionDatelabel;
        private CustomComboBox petitionStatusComboBox;
        private System.Windows.Forms.Label petitionStatusLabel;
        private System.Windows.Forms.Label viewOptionLabel;
        private CustomElements.CustomCheckBox viewOptionCheckBox;
        private CustomElements.CustomCheckBox searchOptionCheckBox;
        private CustomElements.CustomCalendar petitionStartingDateDatePicker;
    }
}