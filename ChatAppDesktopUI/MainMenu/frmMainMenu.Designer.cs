namespace ChatAppDesktopUI.MainMenu
{
    partial class frmMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChats = new System.Windows.Forms.Panel();
            this.panelNoLContentsExist = new System.Windows.Forms.Panel();
            this.btnAddNewContent2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChatWord = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbUserProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAddNewContent = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelMassages = new System.Windows.Forms.Panel();
            this.panelNoSelectedMessageText = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoSelectedMessageText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelChats.SuspendLayout();
            this.panelNoLContentsExist.SuspendLayout();
            this.panelChatWord.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).BeginInit();
            this.panelMassages.SuspendLayout();
            this.panelNoSelectedMessageText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panelChats);
            this.panel1.Controls.Add(this.panelChatWord);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 647);
            this.panel1.TabIndex = 0;
            // 
            // panelChats
            // 
            this.panelChats.Controls.Add(this.panelNoLContentsExist);
            this.panelChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChats.Location = new System.Drawing.Point(0, 152);
            this.panelChats.Name = "panelChats";
            this.panelChats.Size = new System.Drawing.Size(317, 495);
            this.panelChats.TabIndex = 2;
            // 
            // panelNoLContentsExist
            // 
            this.panelNoLContentsExist.Controls.Add(this.btnAddNewContent2);
            this.panelNoLContentsExist.Controls.Add(this.label2);
            this.panelNoLContentsExist.Location = new System.Drawing.Point(24, 146);
            this.panelNoLContentsExist.Name = "panelNoLContentsExist";
            this.panelNoLContentsExist.Size = new System.Drawing.Size(271, 117);
            this.panelNoLContentsExist.TabIndex = 0;
            // 
            // btnAddNewContent2
            // 
            this.btnAddNewContent2.BorderRadius = 22;
            this.btnAddNewContent2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewContent2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewContent2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewContent2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewContent2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewContent2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewContent2.ForeColor = System.Drawing.Color.White;
            this.btnAddNewContent2.Location = new System.Drawing.Point(51, 58);
            this.btnAddNewContent2.Name = "btnAddNewContent2";
            this.btnAddNewContent2.Size = new System.Drawing.Size(159, 45);
            this.btnAddNewContent2.TabIndex = 2;
            this.btnAddNewContent2.Text = "Add Content";
            this.btnAddNewContent2.Click += new System.EventHandler(this.btnAddNewContent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Contents Exist";
            // 
            // panelChatWord
            // 
            this.panelChatWord.Controls.Add(this.label1);
            this.panelChatWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatWord.Location = new System.Drawing.Point(0, 91);
            this.panelChatWord.Name = "panelChatWord";
            this.panelChatWord.Size = new System.Drawing.Size(317, 61);
            this.panelChatWord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chats";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbUserProfile);
            this.panel2.Controls.Add(this.btnAddNewContent);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 91);
            this.panel2.TabIndex = 0;
            // 
            // pbUserProfile
            // 
            this.pbUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserProfile.Image = global::ChatAppDesktopUI.Properties.Resources.default_male;
            this.pbUserProfile.ImageRotate = 0F;
            this.pbUserProfile.Location = new System.Drawing.Point(233, 12);
            this.pbUserProfile.Name = "pbUserProfile";
            this.pbUserProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserProfile.Size = new System.Drawing.Size(50, 50);
            this.pbUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserProfile.TabIndex = 2;
            this.pbUserProfile.TabStop = false;
            this.pbUserProfile.Click += new System.EventHandler(this.pbUserProfile_Click);
            // 
            // btnAddNewContent
            // 
            this.btnAddNewContent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewContent.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewContent.CheckedState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnAddNewContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewContent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewContent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewContent.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewContent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewContent.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewContent.HoverState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnAddNewContent.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_gray_64;
            this.btnAddNewContent.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewContent.Location = new System.Drawing.Point(121, 12);
            this.btnAddNewContent.Name = "btnAddNewContent";
            this.btnAddNewContent.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddNewContent.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddNewContent.Size = new System.Drawing.Size(66, 58);
            this.btnAddNewContent.TabIndex = 1;
            this.btnAddNewContent.Click += new System.EventHandler(this.btnAddNewContent_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.CheckedState.Image = global::ChatAppDesktopUI.Properties.Resources.log_out_blue_64;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.HoverState.Image = global::ChatAppDesktopUI.Properties.Resources.log_out_blue_64;
            this.btnLogOut.Image = global::ChatAppDesktopUI.Properties.Resources.log_out_gray_64;
            this.btnLogOut.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogOut.Location = new System.Drawing.Point(9, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.Transparent;
            this.btnLogOut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogOut.Size = new System.Drawing.Size(66, 58);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelMassages
            // 
            this.panelMassages.BackgroundImage = global::ChatAppDesktopUI.Properties.Resources.chat_background2;
            this.panelMassages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMassages.Controls.Add(this.panelNoSelectedMessageText);
            this.panelMassages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMassages.Location = new System.Drawing.Point(317, 0);
            this.panelMassages.Name = "panelMassages";
            this.panelMassages.Size = new System.Drawing.Size(908, 647);
            this.panelMassages.TabIndex = 1;
            // 
            // panelNoSelectedMessageText
            // 
            this.panelNoSelectedMessageText.BackColor = System.Drawing.Color.Transparent;
            this.panelNoSelectedMessageText.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.panelNoSelectedMessageText.BorderRadius = 25;
            this.panelNoSelectedMessageText.BorderThickness = 2;
            this.panelNoSelectedMessageText.Controls.Add(this.lblNoSelectedMessageText);
            this.panelNoSelectedMessageText.Location = new System.Drawing.Point(293, 298);
            this.panelNoSelectedMessageText.Name = "panelNoSelectedMessageText";
            this.panelNoSelectedMessageText.ShadowDecoration.Depth = 4;
            this.panelNoSelectedMessageText.ShadowDecoration.Enabled = true;
            this.panelNoSelectedMessageText.Size = new System.Drawing.Size(345, 54);
            this.panelNoSelectedMessageText.TabIndex = 0;
            // 
            // lblNoSelectedMessageText
            // 
            this.lblNoSelectedMessageText.AutoSize = true;
            this.lblNoSelectedMessageText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSelectedMessageText.ForeColor = System.Drawing.Color.White;
            this.lblNoSelectedMessageText.Location = new System.Drawing.Point(19, 10);
            this.lblNoSelectedMessageText.Name = "lblNoSelectedMessageText";
            this.lblNoSelectedMessageText.Size = new System.Drawing.Size(308, 30);
            this.lblNoSelectedMessageText.TabIndex = 0;
            this.lblNoSelectedMessageText.Text = "Select a chat to start messaging";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 647);
            this.Controls.Add(this.panelMassages);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panelChats.ResumeLayout(false);
            this.panelNoLContentsExist.ResumeLayout(false);
            this.panelNoLContentsExist.PerformLayout();
            this.panelChatWord.ResumeLayout(false);
            this.panelChatWord.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).EndInit();
            this.panelMassages.ResumeLayout(false);
            this.panelNoSelectedMessageText.ResumeLayout(false);
            this.panelNoSelectedMessageText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogOut;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddNewContent;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserProfile;
        private System.Windows.Forms.Panel panelMassages;
        private Guna.UI2.WinForms.Guna2Panel panelNoSelectedMessageText;
        private System.Windows.Forms.Label lblNoSelectedMessageText;
        private System.Windows.Forms.Panel panelChatWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChats;
        private System.Windows.Forms.Panel panelNoLContentsExist;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNewContent2;
        private System.Windows.Forms.Label label2;
    }
}