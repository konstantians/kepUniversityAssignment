
namespace KEPAssignment
{
    partial class ViewCitizensForm
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
            this.components = new System.ComponentModel.Container();
            this.citizensListLabel = new System.Windows.Forms.Label();
            this.citizensViewPanel = new System.Windows.Forms.Panel();
            this.viewOptionLabel = new System.Windows.Forms.Label();
            this.topMenuFilterPanel = new System.Windows.Forms.Panel();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.extendedFilterMenu = new System.Windows.Forms.Panel();
            this.filterCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.filterMenuButton = new KEPAssignment.CustomButton();
            this.viewOptionCheckBox = new KEPAssignment.CustomElements.CustomCheckBox();
            this.topMenuFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // citizensListLabel
            // 
            this.citizensListLabel.AutoSize = true;
            this.citizensListLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizensListLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.citizensListLabel.Location = new System.Drawing.Point(300, 11);
            this.citizensListLabel.Name = "citizensListLabel";
            this.citizensListLabel.Size = new System.Drawing.Size(112, 26);
            this.citizensListLabel.TabIndex = 14;
            this.citizensListLabel.Text = "Citizens List";
            // 
            // citizensViewPanel
            // 
            this.citizensViewPanel.Location = new System.Drawing.Point(12, 50);
            this.citizensViewPanel.Name = "citizensViewPanel";
            this.citizensViewPanel.Size = new System.Drawing.Size(690, 454);
            this.citizensViewPanel.TabIndex = 15;
            // 
            // viewOptionLabel
            // 
            this.viewOptionLabel.AutoSize = true;
            this.viewOptionLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOptionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewOptionLabel.Location = new System.Drawing.Point(582, 16);
            this.viewOptionLabel.Name = "viewOptionLabel";
            this.viewOptionLabel.Size = new System.Drawing.Size(72, 20);
            this.viewOptionLabel.TabIndex = 16;
            this.viewOptionLabel.Text = "Card View";
            // 
            // topMenuFilterPanel
            // 
            this.topMenuFilterPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topMenuFilterPanel.Controls.Add(this.filtersLabel);
            this.topMenuFilterPanel.Controls.Add(this.filterMenuButton);
            this.topMenuFilterPanel.Location = new System.Drawing.Point(12, 11);
            this.topMenuFilterPanel.Name = "topMenuFilterPanel";
            this.topMenuFilterPanel.Size = new System.Drawing.Size(211, 33);
            this.topMenuFilterPanel.TabIndex = 18;
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filtersLabel.Location = new System.Drawing.Point(3, 5);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(60, 23);
            this.filtersLabel.TabIndex = 15;
            this.filtersLabel.Text = "Filters";
            // 
            // extendedFilterMenu
            // 
            this.extendedFilterMenu.BackColor = System.Drawing.Color.White;
            this.extendedFilterMenu.Location = new System.Drawing.Point(12, 43);
            this.extendedFilterMenu.Name = "extendedFilterMenu";
            this.extendedFilterMenu.Size = new System.Drawing.Size(211, 8);
            this.extendedFilterMenu.TabIndex = 0;
            // 
            // filterCheckTimer
            // 
            this.filterCheckTimer.Enabled = true;
            this.filterCheckTimer.Tick += new System.EventHandler(this.filterCheckTimer_Tick);
            // 
            // filterMenuButton
            // 
            this.filterMenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.filterMenuButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.filterMenuButton.BorderColor = System.Drawing.Color.Black;
            this.filterMenuButton.BorderRadius = 0;
            this.filterMenuButton.BorderSize = 0;
            this.filterMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterMenuButton.FlatAppearance.BorderSize = 0;
            this.filterMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterMenuButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.filterMenuButton.Image = global::KEPAssignment.Properties.Resources.blackMenuIcon;
            this.filterMenuButton.Location = new System.Drawing.Point(170, 2);
            this.filterMenuButton.Name = "filterMenuButton";
            this.filterMenuButton.Size = new System.Drawing.Size(38, 27);
            this.filterMenuButton.TabIndex = 0;
            this.filterMenuButton.TextColor = System.Drawing.Color.RoyalBlue;
            this.filterMenuButton.UseVisualStyleBackColor = false;
            this.filterMenuButton.Click += new System.EventHandler(this.filterMenuButton_Click);
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
            this.viewOptionCheckBox.TabIndex = 17;
            this.viewOptionCheckBox.UseVisualStyleBackColor = true;
            this.viewOptionCheckBox.CheckedChanged += new System.EventHandler(this.viewOptionCheckBox_CheckedChanged);
            // 
            // ViewCitizensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.extendedFilterMenu);
            this.Controls.Add(this.topMenuFilterPanel);
            this.Controls.Add(this.viewOptionCheckBox);
            this.Controls.Add(this.viewOptionLabel);
            this.Controls.Add(this.citizensViewPanel);
            this.Controls.Add(this.citizensListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCitizensForm";
            this.Text = "ViewCitizensForm";
            this.topMenuFilterPanel.ResumeLayout(false);
            this.topMenuFilterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label citizensListLabel;
        private System.Windows.Forms.Panel citizensViewPanel;
        private System.Windows.Forms.Label viewOptionLabel;
        private CustomElements.CustomCheckBox viewOptionCheckBox;
        private System.Windows.Forms.Panel topMenuFilterPanel;
        private CustomButton filterMenuButton;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.Panel extendedFilterMenu;
        private System.Windows.Forms.Timer filterCheckTimer;
    }
}