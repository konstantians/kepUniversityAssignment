
namespace KEPAssignment
{
    partial class HomeForm
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
            this.allPetitionsPanel = new System.Windows.Forms.Panel();
            this.rejectedPetitionsLabel = new System.Windows.Forms.Label();
            this.viewPetitionsButton = new KEPAssignment.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acceptedPetitionsLabel = new System.Windows.Forms.Label();
            this.pendingPetitionsLabel = new System.Windows.Forms.Label();
            this.totalPetitionsLabel = new System.Windows.Forms.Label();
            this.addNewPetitionPanel = new System.Windows.Forms.Panel();
            this.newPetitionsTodayLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.addPetitionButton = new KEPAssignment.CustomButton();
            this.addNewPetitionLabel = new System.Windows.Forms.Label();
            this.allPetitionsLabel = new System.Windows.Forms.Label();
            this.allAppliedCitizensPanel = new System.Windows.Forms.Panel();
            this.viewCitizensButton = new KEPAssignment.CustomButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nativeCitizensLabel = new System.Windows.Forms.Label();
            this.underageCitizensLabel = new System.Windows.Forms.Label();
            this.totalAppliedCitizensLabel = new System.Windows.Forms.Label();
            this.allAppliedCitizensLabel = new System.Windows.Forms.Label();
            this.applyNewCitizenPanel = new System.Windows.Forms.Panel();
            this.newAppliedCitizensLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.applyCitizenButton = new KEPAssignment.CustomButton();
            this.applyNewCitizenLabel = new System.Windows.Forms.Label();
            this.allPetitionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addNewPetitionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.allAppliedCitizensPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.applyNewCitizenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // allPetitionsPanel
            // 
            this.allPetitionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(84)))));
            this.allPetitionsPanel.Controls.Add(this.rejectedPetitionsLabel);
            this.allPetitionsPanel.Controls.Add(this.viewPetitionsButton);
            this.allPetitionsPanel.Controls.Add(this.pictureBox1);
            this.allPetitionsPanel.Controls.Add(this.acceptedPetitionsLabel);
            this.allPetitionsPanel.Controls.Add(this.pendingPetitionsLabel);
            this.allPetitionsPanel.Controls.Add(this.totalPetitionsLabel);
            this.allPetitionsPanel.Controls.Add(this.addNewPetitionPanel);
            this.allPetitionsPanel.Controls.Add(this.allPetitionsLabel);
            this.allPetitionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.allPetitionsPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allPetitionsPanel.Location = new System.Drawing.Point(0, 0);
            this.allPetitionsPanel.Name = "allPetitionsPanel";
            this.allPetitionsPanel.Size = new System.Drawing.Size(357, 516);
            this.allPetitionsPanel.TabIndex = 3;
            // 
            // rejectedPetitionsLabel
            // 
            this.rejectedPetitionsLabel.AutoSize = true;
            this.rejectedPetitionsLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedPetitionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.rejectedPetitionsLabel.Location = new System.Drawing.Point(23, 170);
            this.rejectedPetitionsLabel.Name = "rejectedPetitionsLabel";
            this.rejectedPetitionsLabel.Size = new System.Drawing.Size(138, 20);
            this.rejectedPetitionsLabel.TabIndex = 15;
            this.rejectedPetitionsLabel.Text = "X Rejected Petitions";
            // 
            // viewPetitionsButton
            // 
            this.viewPetitionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewPetitionsButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewPetitionsButton.BorderColor = System.Drawing.SystemColors.Control;
            this.viewPetitionsButton.BorderRadius = 20;
            this.viewPetitionsButton.BorderSize = 2;
            this.viewPetitionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPetitionsButton.FlatAppearance.BorderSize = 0;
            this.viewPetitionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPetitionsButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPetitionsButton.ForeColor = System.Drawing.Color.White;
            this.viewPetitionsButton.Location = new System.Drawing.Point(119, 205);
            this.viewPetitionsButton.Name = "viewPetitionsButton";
            this.viewPetitionsButton.Size = new System.Drawing.Size(117, 43);
            this.viewPetitionsButton.TabIndex = 1;
            this.viewPetitionsButton.Text = "View Petitions";
            this.viewPetitionsButton.TextColor = System.Drawing.Color.White;
            this.viewPetitionsButton.UseVisualStyleBackColor = false;
            this.viewPetitionsButton.Click += new System.EventHandler(this.viewPetitionsButton_Click);
            this.viewPetitionsButton.Enter += new System.EventHandler(this.viewPetitionsButton_Enter);
            this.viewPetitionsButton.Leave += new System.EventHandler(this.viewPetitionsButton_Leave);
            this.viewPetitionsButton.MouseEnter += new System.EventHandler(this.viewPetitionsButton_MouseEnter);
            this.viewPetitionsButton.MouseLeave += new System.EventHandler(this.viewPetitionsButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(232, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 123);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // acceptedPetitionsLabel
            // 
            this.acceptedPetitionsLabel.AutoSize = true;
            this.acceptedPetitionsLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedPetitionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.acceptedPetitionsLabel.Location = new System.Drawing.Point(23, 134);
            this.acceptedPetitionsLabel.Name = "acceptedPetitionsLabel";
            this.acceptedPetitionsLabel.Size = new System.Drawing.Size(140, 20);
            this.acceptedPetitionsLabel.TabIndex = 11;
            this.acceptedPetitionsLabel.Text = "X Accepted Petitions";
            // 
            // pendingPetitionsLabel
            // 
            this.pendingPetitionsLabel.AutoSize = true;
            this.pendingPetitionsLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingPetitionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pendingPetitionsLabel.Location = new System.Drawing.Point(23, 100);
            this.pendingPetitionsLabel.Name = "pendingPetitionsLabel";
            this.pendingPetitionsLabel.Size = new System.Drawing.Size(132, 20);
            this.pendingPetitionsLabel.TabIndex = 10;
            this.pendingPetitionsLabel.Text = "X Pending Petitions";
            // 
            // totalPetitionsLabel
            // 
            this.totalPetitionsLabel.AutoSize = true;
            this.totalPetitionsLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPetitionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalPetitionsLabel.Location = new System.Drawing.Point(23, 67);
            this.totalPetitionsLabel.Name = "totalPetitionsLabel";
            this.totalPetitionsLabel.Size = new System.Drawing.Size(112, 20);
            this.totalPetitionsLabel.TabIndex = 9;
            this.totalPetitionsLabel.Text = "X Total Petitions";
            // 
            // addNewPetitionPanel
            // 
            this.addNewPetitionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.addNewPetitionPanel.Controls.Add(this.newPetitionsTodayLabel);
            this.addNewPetitionPanel.Controls.Add(this.pictureBox4);
            this.addNewPetitionPanel.Controls.Add(this.addPetitionButton);
            this.addNewPetitionPanel.Controls.Add(this.addNewPetitionLabel);
            this.addNewPetitionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addNewPetitionPanel.Location = new System.Drawing.Point(0, 258);
            this.addNewPetitionPanel.Name = "addNewPetitionPanel";
            this.addNewPetitionPanel.Size = new System.Drawing.Size(357, 258);
            this.addNewPetitionPanel.TabIndex = 8;
            // 
            // newPetitionsTodayLabel
            // 
            this.newPetitionsTodayLabel.AutoSize = true;
            this.newPetitionsTodayLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPetitionsTodayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newPetitionsTodayLabel.Location = new System.Drawing.Point(23, 72);
            this.newPetitionsTodayLabel.Name = "newPetitionsTodayLabel";
            this.newPetitionsTodayLabel.Size = new System.Drawing.Size(148, 20);
            this.newPetitionsTodayLabel.TabIndex = 18;
            this.newPetitionsTodayLabel.Text = "X New Petitions Today";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(232, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(92, 123);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // addPetitionButton
            // 
            this.addPetitionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addPetitionButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addPetitionButton.BorderColor = System.Drawing.SystemColors.Control;
            this.addPetitionButton.BorderRadius = 20;
            this.addPetitionButton.BorderSize = 2;
            this.addPetitionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPetitionButton.FlatAppearance.BorderSize = 0;
            this.addPetitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPetitionButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPetitionButton.ForeColor = System.Drawing.Color.White;
            this.addPetitionButton.Location = new System.Drawing.Point(119, 205);
            this.addPetitionButton.Name = "addPetitionButton";
            this.addPetitionButton.Size = new System.Drawing.Size(117, 43);
            this.addPetitionButton.TabIndex = 3;
            this.addPetitionButton.Text = "Add Petition";
            this.addPetitionButton.TextColor = System.Drawing.Color.White;
            this.addPetitionButton.UseVisualStyleBackColor = false;
            this.addPetitionButton.Click += new System.EventHandler(this.addPetitionButton_Click);
            this.addPetitionButton.Enter += new System.EventHandler(this.addPetitionButton_Enter);
            this.addPetitionButton.Leave += new System.EventHandler(this.addPetitionButton_Leave);
            this.addPetitionButton.MouseEnter += new System.EventHandler(this.addPetitionButton_MouseEnter);
            this.addPetitionButton.MouseLeave += new System.EventHandler(this.addPetitionButton_MouseLeave);
            // 
            // addNewPetitionLabel
            // 
            this.addNewPetitionLabel.AutoSize = true;
            this.addNewPetitionLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPetitionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewPetitionLabel.Location = new System.Drawing.Point(102, 23);
            this.addNewPetitionLabel.Name = "addNewPetitionLabel";
            this.addNewPetitionLabel.Size = new System.Drawing.Size(153, 26);
            this.addNewPetitionLabel.TabIndex = 1;
            this.addNewPetitionLabel.Text = "Add New Petition";
            // 
            // allPetitionsLabel
            // 
            this.allPetitionsLabel.AutoSize = true;
            this.allPetitionsLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPetitionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.allPetitionsLabel.Location = new System.Drawing.Point(121, 18);
            this.allPetitionsLabel.Name = "allPetitionsLabel";
            this.allPetitionsLabel.Size = new System.Drawing.Size(112, 26);
            this.allPetitionsLabel.TabIndex = 0;
            this.allPetitionsLabel.Text = "All Petitions";
            // 
            // allAppliedCitizensPanel
            // 
            this.allAppliedCitizensPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.allAppliedCitizensPanel.Controls.Add(this.viewCitizensButton);
            this.allAppliedCitizensPanel.Controls.Add(this.pictureBox2);
            this.allAppliedCitizensPanel.Controls.Add(this.nativeCitizensLabel);
            this.allAppliedCitizensPanel.Controls.Add(this.underageCitizensLabel);
            this.allAppliedCitizensPanel.Controls.Add(this.totalAppliedCitizensLabel);
            this.allAppliedCitizensPanel.Controls.Add(this.allAppliedCitizensLabel);
            this.allAppliedCitizensPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.allAppliedCitizensPanel.Location = new System.Drawing.Point(357, 0);
            this.allAppliedCitizensPanel.Name = "allAppliedCitizensPanel";
            this.allAppliedCitizensPanel.Size = new System.Drawing.Size(357, 258);
            this.allAppliedCitizensPanel.TabIndex = 10;
            // 
            // viewCitizensButton
            // 
            this.viewCitizensButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewCitizensButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewCitizensButton.BorderColor = System.Drawing.SystemColors.Control;
            this.viewCitizensButton.BorderRadius = 20;
            this.viewCitizensButton.BorderSize = 2;
            this.viewCitizensButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCitizensButton.FlatAppearance.BorderSize = 0;
            this.viewCitizensButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCitizensButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCitizensButton.ForeColor = System.Drawing.Color.White;
            this.viewCitizensButton.Location = new System.Drawing.Point(119, 205);
            this.viewCitizensButton.Name = "viewCitizensButton";
            this.viewCitizensButton.Size = new System.Drawing.Size(117, 43);
            this.viewCitizensButton.TabIndex = 2;
            this.viewCitizensButton.Text = "View Citizens";
            this.viewCitizensButton.TextColor = System.Drawing.Color.White;
            this.viewCitizensButton.UseVisualStyleBackColor = false;
            this.viewCitizensButton.Click += new System.EventHandler(this.viewCitizensButton_Click);
            this.viewCitizensButton.Enter += new System.EventHandler(this.viewCitizensButton_Enter);
            this.viewCitizensButton.Leave += new System.EventHandler(this.viewCitizensButton_Leave);
            this.viewCitizensButton.MouseEnter += new System.EventHandler(this.viewCitizensButton_MouseEnter);
            this.viewCitizensButton.MouseLeave += new System.EventHandler(this.viewCitizensButton_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(232, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 123);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // nativeCitizensLabel
            // 
            this.nativeCitizensLabel.AutoSize = true;
            this.nativeCitizensLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nativeCitizensLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nativeCitizensLabel.Location = new System.Drawing.Point(23, 134);
            this.nativeCitizensLabel.Name = "nativeCitizensLabel";
            this.nativeCitizensLabel.Size = new System.Drawing.Size(166, 20);
            this.nativeCitizensLabel.TabIndex = 12;
            this.nativeCitizensLabel.Text = "X Applied Native Citizens";
            // 
            // underageCitizensLabel
            // 
            this.underageCitizensLabel.AutoSize = true;
            this.underageCitizensLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underageCitizensLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.underageCitizensLabel.Location = new System.Drawing.Point(23, 100);
            this.underageCitizensLabel.Name = "underageCitizensLabel";
            this.underageCitizensLabel.Size = new System.Drawing.Size(187, 20);
            this.underageCitizensLabel.TabIndex = 11;
            this.underageCitizensLabel.Text = "X Applied Underage Citizens";
            // 
            // totalAppliedCitizensLabel
            // 
            this.totalAppliedCitizensLabel.AutoSize = true;
            this.totalAppliedCitizensLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAppliedCitizensLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAppliedCitizensLabel.Location = new System.Drawing.Point(23, 67);
            this.totalAppliedCitizensLabel.Name = "totalAppliedCitizensLabel";
            this.totalAppliedCitizensLabel.Size = new System.Drawing.Size(156, 20);
            this.totalAppliedCitizensLabel.TabIndex = 10;
            this.totalAppliedCitizensLabel.Text = "X Total Applied Citizens";
            // 
            // allAppliedCitizensLabel
            // 
            this.allAppliedCitizensLabel.AutoSize = true;
            this.allAppliedCitizensLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allAppliedCitizensLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allAppliedCitizensLabel.Location = new System.Drawing.Point(92, 18);
            this.allAppliedCitizensLabel.Name = "allAppliedCitizensLabel";
            this.allAppliedCitizensLabel.Size = new System.Drawing.Size(171, 26);
            this.allAppliedCitizensLabel.TabIndex = 1;
            this.allAppliedCitizensLabel.Text = "All Applied Citizens";
            // 
            // applyNewCitizenPanel
            // 
            this.applyNewCitizenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(40)))), ((int)(((byte)(84)))));
            this.applyNewCitizenPanel.Controls.Add(this.newAppliedCitizensLabel);
            this.applyNewCitizenPanel.Controls.Add(this.pictureBox5);
            this.applyNewCitizenPanel.Controls.Add(this.applyCitizenButton);
            this.applyNewCitizenPanel.Controls.Add(this.applyNewCitizenLabel);
            this.applyNewCitizenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applyNewCitizenPanel.Location = new System.Drawing.Point(357, 258);
            this.applyNewCitizenPanel.Name = "applyNewCitizenPanel";
            this.applyNewCitizenPanel.Size = new System.Drawing.Size(357, 258);
            this.applyNewCitizenPanel.TabIndex = 11;
            // 
            // newAppliedCitizensLabel
            // 
            this.newAppliedCitizensLabel.AutoSize = true;
            this.newAppliedCitizensLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppliedCitizensLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.newAppliedCitizensLabel.Location = new System.Drawing.Point(23, 72);
            this.newAppliedCitizensLabel.Name = "newAppliedCitizensLabel";
            this.newAppliedCitizensLabel.Size = new System.Drawing.Size(192, 20);
            this.newAppliedCitizensLabel.TabIndex = 17;
            this.newAppliedCitizensLabel.Text = "X New Applied Citizens Today";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(232, 67);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(92, 123);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // applyCitizenButton
            // 
            this.applyCitizenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.applyCitizenButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.applyCitizenButton.BorderColor = System.Drawing.SystemColors.Control;
            this.applyCitizenButton.BorderRadius = 20;
            this.applyCitizenButton.BorderSize = 2;
            this.applyCitizenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyCitizenButton.FlatAppearance.BorderSize = 0;
            this.applyCitizenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyCitizenButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyCitizenButton.ForeColor = System.Drawing.Color.White;
            this.applyCitizenButton.Location = new System.Drawing.Point(119, 205);
            this.applyCitizenButton.Name = "applyCitizenButton";
            this.applyCitizenButton.Size = new System.Drawing.Size(117, 43);
            this.applyCitizenButton.TabIndex = 4;
            this.applyCitizenButton.Text = "Apply Citizen";
            this.applyCitizenButton.TextColor = System.Drawing.Color.White;
            this.applyCitizenButton.UseVisualStyleBackColor = false;
            this.applyCitizenButton.Click += new System.EventHandler(this.applyCitizenButton_Click);
            this.applyCitizenButton.Enter += new System.EventHandler(this.applyCitizenButton_Enter);
            this.applyCitizenButton.Leave += new System.EventHandler(this.applyCitizenButton_Leave);
            this.applyCitizenButton.MouseEnter += new System.EventHandler(this.applyCitizenButton_MouseEnter);
            this.applyCitizenButton.MouseLeave += new System.EventHandler(this.applyCitizenButton_MouseLeave);
            // 
            // applyNewCitizenLabel
            // 
            this.applyNewCitizenLabel.AutoSize = true;
            this.applyNewCitizenLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyNewCitizenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.applyNewCitizenLabel.Location = new System.Drawing.Point(98, 23);
            this.applyNewCitizenLabel.Name = "applyNewCitizenLabel";
            this.applyNewCitizenLabel.Size = new System.Drawing.Size(158, 26);
            this.applyNewCitizenLabel.TabIndex = 1;
            this.applyNewCitizenLabel.Text = "Apply New Citizen";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.applyNewCitizenPanel);
            this.Controls.Add(this.allAppliedCitizensPanel);
            this.Controls.Add(this.allPetitionsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.allPetitionsPanel.ResumeLayout(false);
            this.allPetitionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addNewPetitionPanel.ResumeLayout(false);
            this.addNewPetitionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.allAppliedCitizensPanel.ResumeLayout(false);
            this.allAppliedCitizensPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.applyNewCitizenPanel.ResumeLayout(false);
            this.applyNewCitizenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allPetitionsPanel;
        private CustomButton viewPetitionsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label acceptedPetitionsLabel;
        private System.Windows.Forms.Label pendingPetitionsLabel;
        private System.Windows.Forms.Label totalPetitionsLabel;
        private System.Windows.Forms.Panel addNewPetitionPanel;
        private CustomButton addPetitionButton;
        private System.Windows.Forms.Label addNewPetitionLabel;
        private System.Windows.Forms.Label allPetitionsLabel;
        private System.Windows.Forms.Panel allAppliedCitizensPanel;
        private CustomButton viewCitizensButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nativeCitizensLabel;
        private System.Windows.Forms.Label underageCitizensLabel;
        private System.Windows.Forms.Label totalAppliedCitizensLabel;
        private System.Windows.Forms.Label allAppliedCitizensLabel;
        private System.Windows.Forms.Panel applyNewCitizenPanel;
        private CustomButton applyCitizenButton;
        private System.Windows.Forms.Label applyNewCitizenLabel;
        private System.Windows.Forms.Label rejectedPetitionsLabel;
        private System.Windows.Forms.Label newPetitionsTodayLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label newAppliedCitizensLabel;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}