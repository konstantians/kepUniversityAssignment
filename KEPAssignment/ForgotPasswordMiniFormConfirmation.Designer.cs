
namespace KEPAssignment
{
    partial class ForgotPasswordMiniFormConfirmation
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
            this.cancelButton = new KEPAssignment.CustomButton();
            this.confirmButton = new KEPAssignment.CustomButton();
            this.enterUsernameLabel = new System.Windows.Forms.Label();
            this.enterUsernameTextBox = new KEPAssignment.CustomTextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.BorderColor = System.Drawing.Color.Black;
            this.cancelButton.BorderRadius = 15;
            this.cancelButton.BorderSize = 3;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(16, 115);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 45);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.Enter += new System.EventHandler(this.cancelButton_Enter);
            this.cancelButton.Leave += new System.EventHandler(this.cancelButton_Leave);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.confirmButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.confirmButton.BorderColor = System.Drawing.Color.Black;
            this.confirmButton.BorderRadius = 15;
            this.confirmButton.BorderSize = 3;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.Location = new System.Drawing.Point(182, 115);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(106, 45);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            this.confirmButton.Enter += new System.EventHandler(this.confirmButton_Enter);
            this.confirmButton.Leave += new System.EventHandler(this.confirmButton_Leave);
            this.confirmButton.MouseEnter += new System.EventHandler(this.confirmButton_MouseEnter);
            this.confirmButton.MouseLeave += new System.EventHandler(this.confirmButton_MouseLeave);
            // 
            // enterUsernameLabel
            // 
            this.enterUsernameLabel.AutoSize = true;
            this.enterUsernameLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUsernameLabel.Location = new System.Drawing.Point(12, 20);
            this.enterUsernameLabel.Name = "enterUsernameLabel";
            this.enterUsernameLabel.Size = new System.Drawing.Size(214, 23);
            this.enterUsernameLabel.TabIndex = 9;
            this.enterUsernameLabel.Text = "Enter Account\'s Username";
            // 
            // enterUsernameTextBox
            // 
            this.enterUsernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.enterUsernameTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.enterUsernameTextBox.BorderFocusColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterUsernameTextBox.BorderSize = 4;
            this.enterUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUsernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.enterUsernameTextBox.Location = new System.Drawing.Point(16, 60);
            this.enterUsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.enterUsernameTextBox.Multiline = false;
            this.enterUsernameTextBox.Name = "enterUsernameTextBox";
            this.enterUsernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.enterUsernameTextBox.PasswordChar = false;
            this.enterUsernameTextBox.Size = new System.Drawing.Size(272, 29);
            this.enterUsernameTextBox.TabIndex = 1;
            this.enterUsernameTextBox.Texts = "";
            this.enterUsernameTextBox.UnderlinedStyle = true;
            this.enterUsernameTextBox.Enter += new System.EventHandler(this.enterUsernameTextBox_Enter);
            this.enterUsernameTextBox.Leave += new System.EventHandler(this.enterUsernameTextBox_Leave);
            // 
            // ForgotPasswordMiniFormConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 178);
            this.Controls.Add(this.enterUsernameTextBox);
            this.Controls.Add(this.enterUsernameLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "ForgotPasswordMiniFormConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordMiniFormConfirmation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPasswordMiniFormConfirmation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton cancelButton;
        private CustomButton confirmButton;
        private System.Windows.Forms.Label enterUsernameLabel;
        private CustomTextBox enterUsernameTextBox;
    }
}