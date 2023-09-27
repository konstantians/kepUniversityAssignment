
namespace KEPAssignment
{
    partial class ResetPasswordForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.recoveryQuestionLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.repeatNewPasswordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new KEPAssignment.CustomTextBox();
            this.confirmButton = new KEPAssignment.CustomButton();
            this.cancelButton = new KEPAssignment.CustomButton();
            this.repeatNewPasswordTextBox = new KEPAssignment.CustomTextBox();
            this.newPasswordTextBox = new KEPAssignment.CustomTextBox();
            this.recoveryAnswerTextBox = new KEPAssignment.CustomTextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.logoPictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(439, 110);
            this.topPanel.TabIndex = 3;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::KEPAssignment.Properties.Resources.Gov_gr_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(158, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(120, 98);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // recoveryQuestionLabel
            // 
            this.recoveryQuestionLabel.AutoSize = true;
            this.recoveryQuestionLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryQuestionLabel.Location = new System.Drawing.Point(60, 230);
            this.recoveryQuestionLabel.Name = "recoveryQuestionLabel";
            this.recoveryQuestionLabel.Size = new System.Drawing.Size(155, 23);
            this.recoveryQuestionLabel.TabIndex = 17;
            this.recoveryQuestionLabel.Text = "Recovery Question";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(60, 330);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(168, 23);
            this.newPasswordLabel.TabIndex = 19;
            this.newPasswordLabel.Text = "Enter New Password";
            // 
            // repeatNewPasswordLabel
            // 
            this.repeatNewPasswordLabel.AutoSize = true;
            this.repeatNewPasswordLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatNewPasswordLabel.Location = new System.Drawing.Point(60, 430);
            this.repeatNewPasswordLabel.Name = "repeatNewPasswordLabel";
            this.repeatNewPasswordLabel.Size = new System.Drawing.Size(183, 23);
            this.repeatNewPasswordLabel.TabIndex = 21;
            this.repeatNewPasswordLabel.Text = "Repeat New Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(60, 130);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 23);
            this.usernameLabel.TabIndex = 25;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTextBox.BorderSize = 4;
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.Location = new System.Drawing.Point(64, 170);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.Size = new System.Drawing.Size(310, 29);
            this.usernameTextBox.TabIndex = 26;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = true;
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
            this.confirmButton.Location = new System.Drawing.Point(239, 540);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(135, 45);
            this.confirmButton.TabIndex = 24;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            this.confirmButton.Enter += new System.EventHandler(this.confirmButton_Enter);
            this.confirmButton.Leave += new System.EventHandler(this.confirmButton_Leave);
            this.confirmButton.MouseEnter += new System.EventHandler(this.confirmButton_MouseEnter);
            this.confirmButton.MouseLeave += new System.EventHandler(this.confirmButton_MouseLeave);
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
            this.cancelButton.Location = new System.Drawing.Point(57, 540);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 45);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.Enter += new System.EventHandler(this.cancelButton_Enter);
            this.cancelButton.Leave += new System.EventHandler(this.cancelButton_Leave);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            // 
            // repeatNewPasswordTextBox
            // 
            this.repeatNewPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.repeatNewPasswordTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.repeatNewPasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.repeatNewPasswordTextBox.BorderSize = 4;
            this.repeatNewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatNewPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.repeatNewPasswordTextBox.Location = new System.Drawing.Point(64, 470);
            this.repeatNewPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.repeatNewPasswordTextBox.Multiline = false;
            this.repeatNewPasswordTextBox.Name = "repeatNewPasswordTextBox";
            this.repeatNewPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.repeatNewPasswordTextBox.PasswordChar = true;
            this.repeatNewPasswordTextBox.Size = new System.Drawing.Size(310, 29);
            this.repeatNewPasswordTextBox.TabIndex = 22;
            this.repeatNewPasswordTextBox.Texts = "";
            this.repeatNewPasswordTextBox.UnderlinedStyle = true;
            this.repeatNewPasswordTextBox.Enter += new System.EventHandler(this.repeatNewPasswordTextBox_Enter);
            this.repeatNewPasswordTextBox.Leave += new System.EventHandler(this.repeatNewPasswordTextBox_Leave);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.newPasswordTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.newPasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.newPasswordTextBox.BorderSize = 4;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.newPasswordTextBox.Location = new System.Drawing.Point(64, 370);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordTextBox.Multiline = false;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.newPasswordTextBox.PasswordChar = true;
            this.newPasswordTextBox.Size = new System.Drawing.Size(310, 29);
            this.newPasswordTextBox.TabIndex = 20;
            this.newPasswordTextBox.Texts = "";
            this.newPasswordTextBox.UnderlinedStyle = true;
            this.newPasswordTextBox.Enter += new System.EventHandler(this.newPasswordTextBox_Enter);
            this.newPasswordTextBox.Leave += new System.EventHandler(this.newPasswordTextBox_Leave);
            // 
            // recoveryAnswerTextBox
            // 
            this.recoveryAnswerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.recoveryAnswerTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.recoveryAnswerTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.recoveryAnswerTextBox.BorderSize = 4;
            this.recoveryAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryAnswerTextBox.ForeColor = System.Drawing.Color.Black;
            this.recoveryAnswerTextBox.Location = new System.Drawing.Point(64, 270);
            this.recoveryAnswerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.recoveryAnswerTextBox.Multiline = false;
            this.recoveryAnswerTextBox.Name = "recoveryAnswerTextBox";
            this.recoveryAnswerTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.recoveryAnswerTextBox.PasswordChar = false;
            this.recoveryAnswerTextBox.Size = new System.Drawing.Size(310, 29);
            this.recoveryAnswerTextBox.TabIndex = 18;
            this.recoveryAnswerTextBox.Texts = "";
            this.recoveryAnswerTextBox.UnderlinedStyle = true;
            this.recoveryAnswerTextBox.Enter += new System.EventHandler(this.recoveryAnswerTextBox_Enter);
            this.recoveryAnswerTextBox.Leave += new System.EventHandler(this.recoveryAnswerTextBox_Leave);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 611);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.repeatNewPasswordTextBox);
            this.Controls.Add(this.repeatNewPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.recoveryAnswerTextBox);
            this.Controls.Add(this.recoveryQuestionLabel);
            this.Controls.Add(this.topPanel);
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResetPasswordForm_FormClosed);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label recoveryQuestionLabel;
        private CustomTextBox recoveryAnswerTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private CustomTextBox newPasswordTextBox;
        private System.Windows.Forms.Label repeatNewPasswordLabel;
        private CustomTextBox repeatNewPasswordTextBox;
        private CustomButton cancelButton;
        private CustomButton confirmButton;
        private System.Windows.Forms.Label usernameLabel;
        private CustomTextBox usernameTextBox;
    }
}