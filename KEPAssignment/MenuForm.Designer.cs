
namespace KEPAssignment
{
    partial class MenuForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.accountMenuPanel = new System.Windows.Forms.Panel();
            this.accountMenuButton = new System.Windows.Forms.Button();
            this.petitionMenuPanel = new System.Windows.Forms.Panel();
            this.petitionMenuButton = new System.Windows.Forms.Button();
            this.logOutMenuPanel = new System.Windows.Forms.Panel();
            this.logOutMenuButton = new System.Windows.Forms.Button();
            this.citizenMenuPanel = new System.Windows.Forms.Panel();
            this.citizenMenuButton = new System.Windows.Forms.Button();
            this.homeMenuPanel = new System.Windows.Forms.Panel();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.controlMenuPanel = new System.Windows.Forms.Panel();
            this.menuControlLabel = new System.Windows.Forms.Label();
            this.controlMenuPicturebox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.menuPlaceholderPanel = new System.Windows.Forms.Panel();
            this.staticDataTimer = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.accountMenuPanel.SuspendLayout();
            this.petitionMenuPanel.SuspendLayout();
            this.logOutMenuPanel.SuspendLayout();
            this.citizenMenuPanel.SuspendLayout();
            this.homeMenuPanel.SuspendLayout();
            this.controlMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlMenuPicturebox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuPanel.Controls.Add(this.accountMenuPanel);
            this.menuPanel.Controls.Add(this.petitionMenuPanel);
            this.menuPanel.Controls.Add(this.logOutMenuPanel);
            this.menuPanel.Controls.Add(this.citizenMenuPanel);
            this.menuPanel.Controls.Add(this.homeMenuPanel);
            this.menuPanel.Controls.Add(this.controlMenuPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(170, 626);
            this.menuPanel.TabIndex = 0;
            // 
            // accountMenuPanel
            // 
            this.accountMenuPanel.Controls.Add(this.accountMenuButton);
            this.accountMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountMenuPanel.Location = new System.Drawing.Point(0, 311);
            this.accountMenuPanel.Name = "accountMenuPanel";
            this.accountMenuPanel.Size = new System.Drawing.Size(170, 63);
            this.accountMenuPanel.TabIndex = 10;
            // 
            // accountMenuButton
            // 
            this.accountMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountMenuButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.accountMenuButton.Image = global::KEPAssignment.Properties.Resources.user;
            this.accountMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountMenuButton.Location = new System.Drawing.Point(0, 0);
            this.accountMenuButton.Name = "accountMenuButton";
            this.accountMenuButton.Size = new System.Drawing.Size(170, 63);
            this.accountMenuButton.TabIndex = 4;
            this.accountMenuButton.Text = "                Account";
            this.accountMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountMenuButton.UseVisualStyleBackColor = true;
            this.accountMenuButton.Click += new System.EventHandler(this.accountMenuButton_Click);
            this.accountMenuButton.Enter += new System.EventHandler(this.accountMenuButton_Enter);
            this.accountMenuButton.Leave += new System.EventHandler(this.accountMenuButton_Leave);
            this.accountMenuButton.MouseEnter += new System.EventHandler(this.accountMenuButton_MouseEnter);
            this.accountMenuButton.MouseLeave += new System.EventHandler(this.accountMenuButton_MouseLeave);
            // 
            // petitionMenuPanel
            // 
            this.petitionMenuPanel.Controls.Add(this.petitionMenuButton);
            this.petitionMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.petitionMenuPanel.Location = new System.Drawing.Point(0, 244);
            this.petitionMenuPanel.Name = "petitionMenuPanel";
            this.petitionMenuPanel.Size = new System.Drawing.Size(170, 67);
            this.petitionMenuPanel.TabIndex = 9;
            // 
            // petitionMenuButton
            // 
            this.petitionMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.petitionMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.petitionMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.petitionMenuButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petitionMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.petitionMenuButton.Image = global::KEPAssignment.Properties.Resources.petition;
            this.petitionMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.petitionMenuButton.Location = new System.Drawing.Point(0, 0);
            this.petitionMenuButton.Name = "petitionMenuButton";
            this.petitionMenuButton.Size = new System.Drawing.Size(170, 67);
            this.petitionMenuButton.TabIndex = 3;
            this.petitionMenuButton.Text = "                Petitions";
            this.petitionMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.petitionMenuButton.UseVisualStyleBackColor = true;
            this.petitionMenuButton.Click += new System.EventHandler(this.petitionMenuButton_Click);
            this.petitionMenuButton.Enter += new System.EventHandler(this.petitionMenuButton_Enter);
            this.petitionMenuButton.Leave += new System.EventHandler(this.petitionMenuButton_Leave);
            this.petitionMenuButton.MouseEnter += new System.EventHandler(this.petitionMenuButton_MouseEnter);
            this.petitionMenuButton.MouseLeave += new System.EventHandler(this.petitionMenuButton_MouseLeave);
            // 
            // logOutMenuPanel
            // 
            this.logOutMenuPanel.Controls.Add(this.logOutMenuButton);
            this.logOutMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutMenuPanel.Location = new System.Drawing.Point(0, 559);
            this.logOutMenuPanel.Name = "logOutMenuPanel";
            this.logOutMenuPanel.Size = new System.Drawing.Size(170, 67);
            this.logOutMenuPanel.TabIndex = 9;
            // 
            // logOutMenuButton
            // 
            this.logOutMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutMenuButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutMenuButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logOutMenuButton.Image = global::KEPAssignment.Properties.Resources.logout;
            this.logOutMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutMenuButton.Location = new System.Drawing.Point(0, 0);
            this.logOutMenuButton.Name = "logOutMenuButton";
            this.logOutMenuButton.Size = new System.Drawing.Size(170, 67);
            this.logOutMenuButton.TabIndex = 5;
            this.logOutMenuButton.Text = "                Log Out";
            this.logOutMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutMenuButton.UseVisualStyleBackColor = true;
            this.logOutMenuButton.Click += new System.EventHandler(this.logOutMenuButton_Click);
            this.logOutMenuButton.Enter += new System.EventHandler(this.logOutMenuButton_Enter);
            this.logOutMenuButton.Leave += new System.EventHandler(this.logOutMenuButton_Leave);
            this.logOutMenuButton.MouseEnter += new System.EventHandler(this.logOutMenuButton_MouseEnter);
            this.logOutMenuButton.MouseLeave += new System.EventHandler(this.logOutMenuButton_MouseLeave);
            // 
            // citizenMenuPanel
            // 
            this.citizenMenuPanel.Controls.Add(this.citizenMenuButton);
            this.citizenMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.citizenMenuPanel.Location = new System.Drawing.Point(0, 177);
            this.citizenMenuPanel.Name = "citizenMenuPanel";
            this.citizenMenuPanel.Size = new System.Drawing.Size(170, 67);
            this.citizenMenuPanel.TabIndex = 8;
            // 
            // citizenMenuButton
            // 
            this.citizenMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.citizenMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.citizenMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citizenMenuButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.citizenMenuButton.Image = global::KEPAssignment.Properties.Resources.group;
            this.citizenMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citizenMenuButton.Location = new System.Drawing.Point(0, 0);
            this.citizenMenuButton.Name = "citizenMenuButton";
            this.citizenMenuButton.Size = new System.Drawing.Size(170, 67);
            this.citizenMenuButton.TabIndex = 2;
            this.citizenMenuButton.Text = "                Citizens";
            this.citizenMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citizenMenuButton.UseVisualStyleBackColor = true;
            this.citizenMenuButton.Click += new System.EventHandler(this.citizenMenuButton_Click);
            this.citizenMenuButton.Enter += new System.EventHandler(this.citizenMenuButton_Enter);
            this.citizenMenuButton.Leave += new System.EventHandler(this.citizenMenuButton_Leave);
            this.citizenMenuButton.MouseEnter += new System.EventHandler(this.citizenMenuButton_MouseEnter);
            this.citizenMenuButton.MouseLeave += new System.EventHandler(this.citizenMenuButton_MouseLeave);
            // 
            // homeMenuPanel
            // 
            this.homeMenuPanel.Controls.Add(this.homeMenuButton);
            this.homeMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuPanel.Location = new System.Drawing.Point(0, 110);
            this.homeMenuPanel.Name = "homeMenuPanel";
            this.homeMenuPanel.Size = new System.Drawing.Size(170, 67);
            this.homeMenuPanel.TabIndex = 7;
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.homeMenuButton.Image = global::KEPAssignment.Properties.Resources.home20;
            this.homeMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeMenuButton.Location = new System.Drawing.Point(0, 0);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Size = new System.Drawing.Size(170, 67);
            this.homeMenuButton.TabIndex = 1;
            this.homeMenuButton.Text = "                Home";
            this.homeMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeMenuButton.UseVisualStyleBackColor = true;
            this.homeMenuButton.Click += new System.EventHandler(this.homeMenuButton_Click);
            this.homeMenuButton.Enter += new System.EventHandler(this.homeMenuButton_Enter);
            this.homeMenuButton.Leave += new System.EventHandler(this.homeMenuButton_Leave);
            this.homeMenuButton.MouseEnter += new System.EventHandler(this.homeMenuButton_MouseEnter);
            this.homeMenuButton.MouseLeave += new System.EventHandler(this.homeMenuButton_MouseLeave);
            // 
            // controlMenuPanel
            // 
            this.controlMenuPanel.Controls.Add(this.menuControlLabel);
            this.controlMenuPanel.Controls.Add(this.controlMenuPicturebox);
            this.controlMenuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.controlMenuPanel.Name = "controlMenuPanel";
            this.controlMenuPanel.Size = new System.Drawing.Size(170, 110);
            this.controlMenuPanel.TabIndex = 1;
            this.controlMenuPanel.Click += new System.EventHandler(this.controlMenuPanel_Click);
            this.controlMenuPanel.Enter += new System.EventHandler(this.controlMenuPanel_Enter);
            this.controlMenuPanel.Leave += new System.EventHandler(this.controlMenuPanel_Leave);
            this.controlMenuPanel.MouseEnter += new System.EventHandler(this.controlMenuPanel_MouseEnter);
            this.controlMenuPanel.MouseLeave += new System.EventHandler(this.controlMenuPanel_MouseLeave);
            // 
            // menuControlLabel
            // 
            this.menuControlLabel.AutoSize = true;
            this.menuControlLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuControlLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.menuControlLabel.Location = new System.Drawing.Point(52, 40);
            this.menuControlLabel.Name = "menuControlLabel";
            this.menuControlLabel.Size = new System.Drawing.Size(54, 23);
            this.menuControlLabel.TabIndex = 1;
            this.menuControlLabel.Text = "Menu";
            this.menuControlLabel.Click += new System.EventHandler(this.menuControlLabel_Click);
            this.menuControlLabel.MouseEnter += new System.EventHandler(this.menuControlLabel_MouseEnter);
            // 
            // controlMenuPicturebox
            // 
            this.controlMenuPicturebox.Image = global::KEPAssignment.Properties.Resources.menuIcon;
            this.controlMenuPicturebox.Location = new System.Drawing.Point(3, 37);
            this.controlMenuPicturebox.Name = "controlMenuPicturebox";
            this.controlMenuPicturebox.Size = new System.Drawing.Size(30, 28);
            this.controlMenuPicturebox.TabIndex = 7;
            this.controlMenuPicturebox.TabStop = false;
            this.controlMenuPicturebox.Click += new System.EventHandler(this.pictureBox2_Click);
            this.controlMenuPicturebox.MouseEnter += new System.EventHandler(this.controlMenuPicturebox_MouseEnter);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.logoPictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(170, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(714, 110);
            this.topPanel.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::KEPAssignment.Properties.Resources.Gov_gr_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(296, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(120, 98);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 150;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // menuPlaceholderPanel
            // 
            this.menuPlaceholderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPlaceholderPanel.Location = new System.Drawing.Point(170, 110);
            this.menuPlaceholderPanel.Name = "menuPlaceholderPanel";
            this.menuPlaceholderPanel.Size = new System.Drawing.Size(714, 516);
            this.menuPlaceholderPanel.TabIndex = 2;
            // 
            // staticDataTimer
            // 
            this.staticDataTimer.Enabled = true;
            this.staticDataTimer.Tick += new System.EventHandler(this.staticDataTimer_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(884, 626);
            this.Controls.Add(this.menuPlaceholderPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KEP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.menuPanel.ResumeLayout(false);
            this.accountMenuPanel.ResumeLayout(false);
            this.petitionMenuPanel.ResumeLayout(false);
            this.logOutMenuPanel.ResumeLayout(false);
            this.citizenMenuPanel.ResumeLayout(false);
            this.homeMenuPanel.ResumeLayout(false);
            this.controlMenuPanel.ResumeLayout(false);
            this.controlMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlMenuPicturebox)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel controlMenuPanel;
        private System.Windows.Forms.Panel homeMenuPanel;
        private System.Windows.Forms.Button homeMenuButton;
        private System.Windows.Forms.Panel citizenMenuPanel;
        private System.Windows.Forms.Button citizenMenuButton;
        private System.Windows.Forms.Button petitionMenuButton;
        private System.Windows.Forms.Panel petitionMenuPanel;
        private System.Windows.Forms.Panel logOutMenuPanel;
        private System.Windows.Forms.Button logOutMenuButton;
        private System.Windows.Forms.Panel accountMenuPanel;
        private System.Windows.Forms.Button accountMenuButton;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.PictureBox controlMenuPicturebox;
        private System.Windows.Forms.Label menuControlLabel;
        private System.Windows.Forms.Panel menuPlaceholderPanel;
        private System.Windows.Forms.Timer staticDataTimer;
    }
}

