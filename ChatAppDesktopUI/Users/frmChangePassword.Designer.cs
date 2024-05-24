namespace ChatAppDesktopUI.Users
{
    partial class frmChangePassword
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ucUserCard2 = new UserControls.ucUserCard();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(41, 58, 76);
            lblTitle.Location = new Point(6, 1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(739, 68);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Change Password";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BorderRadius = 20;
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(0, 0, 50);
            btnSave.FillColor2 = Color.FromArgb(41, 58, 76);
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageAlign = HorizontalAlignment.Left;
            btnSave.ImageSize = new Size(30, 30);
            btnSave.Location = new Point(590, 597);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(9, 0, 0, 0);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(155, 45);
            btnSave.TabIndex = 232;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BorderRadius = 20;
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.FromArgb(0, 0, 50);
            btnClose.FillColor2 = Color.FromArgb(41, 58, 76);
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close_48;
            btnClose.ImageAlign = HorizontalAlignment.Left;
            btnClose.ImageSize = new Size(30, 30);
            btnClose.Location = new Point(429, 597);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(9, 0, 0, 0);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(155, 45);
            btnClose.TabIndex = 231;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(txtConfirmPassword);
            gbFilter.Controls.Add(txtNewPassword);
            gbFilter.Controls.Add(txtCurrentPassword);
            gbFilter.Controls.Add(label2);
            gbFilter.Controls.Add(pictureBox2);
            gbFilter.Controls.Add(label3);
            gbFilter.Controls.Add(label4);
            gbFilter.Controls.Add(pictureBox1);
            gbFilter.Controls.Add(pictureBox3);
            gbFilter.CustomizableEdges = customizableEdges11;
            gbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilter.ForeColor = Color.Black;
            gbFilter.Location = new Point(12, 356);
            gbFilter.Name = "gbFilter";
            gbFilter.ShadowDecoration.CustomizableEdges = customizableEdges12;
            gbFilter.Size = new Size(726, 199);
            gbFilter.TabIndex = 234;
            gbFilter.Text = "User Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.AutoRoundedCorners = true;
            txtConfirmPassword.BorderColor = Color.Gray;
            txtConfirmPassword.BorderRadius = 17;
            txtConfirmPassword.Cursor = Cursors.IBeam;
            txtConfirmPassword.CustomizableEdges = customizableEdges5;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.FocusedState.BorderColor = Color.FromArgb(53, 41, 123);
            txtConfirmPassword.Font = new Font("Segoe UI", 11.25F);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.HoverState.BorderColor = Color.FromArgb(53, 41, 123);
            txtConfirmPassword.Location = new Point(218, 150);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '\0';
            txtConfirmPassword.PlaceholderText = "";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConfirmPassword.Size = new Size(210, 36);
            txtConfirmPassword.TabIndex = 213;
            txtConfirmPassword.TextChanged += _TextBox_TextChanged;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtNewPassword
            // 
            txtNewPassword.AutoRoundedCorners = true;
            txtNewPassword.BorderColor = Color.Gray;
            txtNewPassword.BorderRadius = 17;
            txtNewPassword.Cursor = Cursors.IBeam;
            txtNewPassword.CustomizableEdges = customizableEdges7;
            txtNewPassword.DefaultText = "";
            txtNewPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNewPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNewPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNewPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNewPassword.FocusedState.BorderColor = Color.FromArgb(53, 41, 123);
            txtNewPassword.Font = new Font("Segoe UI", 11.25F);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.HoverState.BorderColor = Color.FromArgb(53, 41, 123);
            txtNewPassword.Location = new Point(218, 105);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '\0';
            txtNewPassword.PlaceholderText = "";
            txtNewPassword.SelectedText = "";
            txtNewPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNewPassword.Size = new Size(210, 36);
            txtNewPassword.TabIndex = 212;
            txtNewPassword.TextChanged += _TextBox_TextChanged;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.AutoRoundedCorners = true;
            txtCurrentPassword.BorderColor = Color.Gray;
            txtCurrentPassword.BorderRadius = 17;
            txtCurrentPassword.Cursor = Cursors.IBeam;
            txtCurrentPassword.CustomizableEdges = customizableEdges9;
            txtCurrentPassword.DefaultText = "";
            txtCurrentPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCurrentPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCurrentPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCurrentPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCurrentPassword.FocusedState.BorderColor = Color.FromArgb(53, 41, 123);
            txtCurrentPassword.Font = new Font("Segoe UI", 11.25F);
            txtCurrentPassword.ForeColor = Color.Black;
            txtCurrentPassword.HoverState.BorderColor = Color.FromArgb(53, 41, 123);
            txtCurrentPassword.Location = new Point(218, 56);
            txtCurrentPassword.Margin = new Padding(3, 4, 3, 4);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '\0';
            txtCurrentPassword.PlaceholderText = "";
            txtCurrentPassword.SelectedText = "";
            txtCurrentPassword.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtCurrentPassword.Size = new Size(210, 36);
            txtCurrentPassword.TabIndex = 211;
            txtCurrentPassword.TextChanged += _TextBox_TextChanged;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 163;
            label2.Text = "Current Password:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password_64;
            pictureBox2.Location = new Point(173, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 164;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 161;
            label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 159;
            label4.Text = "New Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.confirm_password_user;
            pictureBox1.Location = new Point(173, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 162;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_64;
            pictureBox3.Location = new Point(173, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 160;
            pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ucUserCard2
            // 
            ucUserCard2.BackColor = Color.White;
            ucUserCard2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucUserCard2.Location = new Point(12, 87);
            ucUserCard2.Name = "ucUserCard2";
            ucUserCard2.Size = new Size(726, 237);
            ucUserCard2.TabIndex = 235;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(749, 647);
            Controls.Add(ucUserCard2);
            Controls.Add(gbFilter);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Activated += frmChangePassword_Activated;
            Load += frmChangePassword_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private UserControls.ucUserCard ucUserCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControls.ucUserCard ucUserCard2;
    }
}