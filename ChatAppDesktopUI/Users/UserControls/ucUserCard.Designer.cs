namespace ChatAppDesktopUI.Users.UserControls
{
    partial class ucUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            llEditUserInfo = new LinkLabel();
            pbUserImage = new PictureBox();
            lblBio = new Label();
            lblUsername = new Label();
            lblUserID = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(llEditUserInfo);
            guna2GroupBox1.Controls.Add(pbUserImage);
            guna2GroupBox1.Controls.Add(lblBio);
            guna2GroupBox1.Controls.Add(lblUsername);
            guna2GroupBox1.Controls.Add(lblUserID);
            guna2GroupBox1.Controls.Add(pictureBox3);
            guna2GroupBox1.Controls.Add(label3);
            guna2GroupBox1.Controls.Add(pictureBox2);
            guna2GroupBox1.Controls.Add(label2);
            guna2GroupBox1.Controls.Add(pictureBox1);
            guna2GroupBox1.Controls.Add(label1);
            guna2GroupBox1.CustomizableEdges = customizableEdges1;
            guna2GroupBox1.Dock = DockStyle.Fill;
            guna2GroupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GroupBox1.ForeColor = Color.Black;
            guna2GroupBox1.Location = new Point(0, 0);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GroupBox1.Size = new Size(726, 237);
            guna2GroupBox1.TabIndex = 169;
            guna2GroupBox1.Text = "User Information";
            // 
            // llEditUserInfo
            // 
            llEditUserInfo.AutoSize = true;
            llEditUserInfo.Enabled = false;
            llEditUserInfo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llEditUserInfo.Location = new Point(568, 48);
            llEditUserInfo.Name = "llEditUserInfo";
            llEditUserInfo.Size = new Size(128, 25);
            llEditUserInfo.TabIndex = 179;
            llEditUserInfo.TabStop = true;
            llEditUserInfo.Text = "Edit User Info";
            llEditUserInfo.LinkClicked += llEditUserInfo_LinkClicked;
            // 
            // pbUserImage
            // 
            pbUserImage.BorderStyle = BorderStyle.FixedSingle;
            pbUserImage.Image = Properties.Resources.default_male;
            pbUserImage.Location = new Point(553, 85);
            pbUserImage.Name = "pbUserImage";
            pbUserImage.Size = new Size(156, 138);
            pbUserImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserImage.TabIndex = 178;
            pbUserImage.TabStop = false;
            // 
            // lblBio
            // 
            lblBio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBio.ForeColor = Color.Black;
            lblBio.Location = new Point(148, 170);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(379, 52);
            lblBio.TabIndex = 177;
            lblBio.Text = "[????]";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Firebrick;
            lblUsername.Location = new Point(148, 119);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 21);
            lblUsername.TabIndex = 176;
            lblUsername.Text = "[????]";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(148, 68);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(50, 21);
            lblUserID.TabIndex = 175;
            lblUserID.Text = "[????]";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.edit_reservation32;
            pictureBox3.Location = new Point(98, 167);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 174;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 170);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 173;
            label3.Text = "Bio:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.name;
            pictureBox2.Location = new Point(98, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 172;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 171;
            label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.id;
            pictureBox1.Location = new Point(98, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 170;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 68);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 169;
            label1.Text = "User ID:";
            // 
            // ucUserCard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2GroupBox1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ucUserCard";
            Size = new Size(726, 237);
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.LinkLabel llEditUserInfo;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
