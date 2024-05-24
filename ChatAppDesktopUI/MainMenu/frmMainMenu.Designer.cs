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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            panel1 = new Panel();
            flowLayoutChatsPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            pbUserProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btnAddNewContent = new Guna.UI2.WinForms.Guna2CircleButton();
            btnLogOut = new Guna.UI2.WinForms.Guna2CircleButton();
            panelChatWord = new Panel();
            label1 = new Label();
            panelToIncludeNoLContentsExistPanel = new Panel();
            panelNoLContentsExist = new Panel();
            btnAddNewContent2 = new Guna.UI2.WinForms.Guna2GradientButton();
            label2 = new Label();
            panelMassages = new Panel();
            panelNoSelectedMessageText = new Guna.UI2.WinForms.Guna2Panel();
            lblNoSelectedMessageText = new Label();
            panel1.SuspendLayout();
            flowLayoutChatsPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserProfile).BeginInit();
            panelChatWord.SuspendLayout();
            panelToIncludeNoLContentsExistPanel.SuspendLayout();
            panelNoLContentsExist.SuspendLayout();
            panelMassages.SuspendLayout();
            panelNoSelectedMessageText.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 58, 76);
            panel1.Controls.Add(flowLayoutChatsPanel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 647);
            panel1.TabIndex = 0;
            // 
            // flowLayoutChatsPanel
            // 
            flowLayoutChatsPanel.Controls.Add(panel2);
            flowLayoutChatsPanel.Controls.Add(panelChatWord);
            flowLayoutChatsPanel.Controls.Add(panelToIncludeNoLContentsExistPanel);
            flowLayoutChatsPanel.Dock = DockStyle.Fill;
            flowLayoutChatsPanel.Location = new Point(0, 0);
            flowLayoutChatsPanel.Name = "flowLayoutChatsPanel";
            flowLayoutChatsPanel.Size = new Size(317, 647);
            flowLayoutChatsPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbUserProfile);
            panel2.Controls.Add(btnAddNewContent);
            panel2.Controls.Add(btnLogOut);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 91);
            panel2.TabIndex = 0;
            // 
            // pbUserProfile
            // 
            pbUserProfile.BackColor = Color.Transparent;
            pbUserProfile.Cursor = Cursors.Hand;
            pbUserProfile.Image = Properties.Resources.default_male;
            pbUserProfile.ImageRotate = 0F;
            pbUserProfile.Location = new Point(233, 12);
            pbUserProfile.Name = "pbUserProfile";
            pbUserProfile.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pbUserProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbUserProfile.Size = new Size(50, 50);
            pbUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserProfile.TabIndex = 2;
            pbUserProfile.TabStop = false;
            pbUserProfile.Click += pbUserProfile_Click;
            // 
            // btnAddNewContent
            // 
            btnAddNewContent.BackColor = Color.Transparent;
            btnAddNewContent.CheckedState.FillColor = Color.Transparent;
            btnAddNewContent.CheckedState.Image = Properties.Resources.add_content_blue_64;
            btnAddNewContent.Cursor = Cursors.Hand;
            btnAddNewContent.DisabledState.BorderColor = Color.DarkGray;
            btnAddNewContent.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNewContent.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNewContent.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNewContent.FillColor = Color.Transparent;
            btnAddNewContent.Font = new Font("Segoe UI", 9F);
            btnAddNewContent.ForeColor = Color.White;
            btnAddNewContent.HoverState.FillColor = Color.Transparent;
            btnAddNewContent.HoverState.Image = Properties.Resources.add_content_blue_64;
            btnAddNewContent.Image = Properties.Resources.add_content_gray_64;
            btnAddNewContent.ImageSize = new Size(50, 50);
            btnAddNewContent.Location = new Point(121, 12);
            btnAddNewContent.Name = "btnAddNewContent";
            btnAddNewContent.PressedColor = Color.Transparent;
            btnAddNewContent.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddNewContent.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAddNewContent.Size = new Size(66, 58);
            btnAddNewContent.TabIndex = 1;
            btnAddNewContent.Click += btnAddNewContent_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.CheckedState.FillColor = Color.Transparent;
            btnLogOut.CheckedState.Image = Properties.Resources.log_out_blue_64;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.DisabledState.BorderColor = Color.DarkGray;
            btnLogOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogOut.FillColor = Color.Transparent;
            btnLogOut.Font = new Font("Segoe UI", 9F);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.HoverState.FillColor = Color.Transparent;
            btnLogOut.HoverState.Image = Properties.Resources.log_out_blue_64;
            btnLogOut.Image = Properties.Resources.log_out_gray_64;
            btnLogOut.ImageSize = new Size(50, 50);
            btnLogOut.Location = new Point(9, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.PressedColor = Color.Transparent;
            btnLogOut.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnLogOut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnLogOut.Size = new Size(66, 58);
            btnLogOut.TabIndex = 0;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panelChatWord
            // 
            panelChatWord.Controls.Add(label1);
            panelChatWord.Location = new Point(3, 100);
            panelChatWord.Name = "panelChatWord";
            panelChatWord.Size = new Size(317, 61);
            panelChatWord.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(102, 45);
            label1.TabIndex = 1;
            label1.Text = "Chats";
            // 
            // panelToIncludeNoLContentsExistPanel
            // 
            panelToIncludeNoLContentsExistPanel.Controls.Add(panelNoLContentsExist);
            panelToIncludeNoLContentsExistPanel.Location = new Point(3, 167);
            panelToIncludeNoLContentsExistPanel.Name = "panelToIncludeNoLContentsExistPanel";
            panelToIncludeNoLContentsExistPanel.Size = new Size(308, 413);
            panelToIncludeNoLContentsExistPanel.TabIndex = 2;
            // 
            // panelNoLContentsExist
            // 
            panelNoLContentsExist.Controls.Add(btnAddNewContent2);
            panelNoLContentsExist.Controls.Add(label2);
            panelNoLContentsExist.Location = new Point(17, 114);
            panelNoLContentsExist.Name = "panelNoLContentsExist";
            panelNoLContentsExist.Size = new Size(271, 117);
            panelNoLContentsExist.TabIndex = 0;
            // 
            // btnAddNewContent2
            // 
            btnAddNewContent2.BorderRadius = 22;
            btnAddNewContent2.CustomizableEdges = customizableEdges4;
            btnAddNewContent2.DisabledState.BorderColor = Color.DarkGray;
            btnAddNewContent2.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNewContent2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNewContent2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAddNewContent2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNewContent2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewContent2.ForeColor = Color.White;
            btnAddNewContent2.Location = new Point(51, 58);
            btnAddNewContent2.Name = "btnAddNewContent2";
            btnAddNewContent2.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAddNewContent2.Size = new Size(159, 45);
            btnAddNewContent2.TabIndex = 2;
            btnAddNewContent2.Text = "Add Content";
            btnAddNewContent2.Click += btnAddNewContent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 6);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 1;
            label2.Text = "No Contents Exist";
            // 
            // panelMassages
            // 
            panelMassages.BackgroundImage = Properties.Resources.chat_background;
            panelMassages.Controls.Add(panelNoSelectedMessageText);
            panelMassages.Dock = DockStyle.Fill;
            panelMassages.Location = new Point(317, 0);
            panelMassages.Name = "panelMassages";
            panelMassages.Size = new Size(908, 647);
            panelMassages.TabIndex = 1;
            // 
            // panelNoSelectedMessageText
            // 
            panelNoSelectedMessageText.BackColor = Color.Transparent;
            panelNoSelectedMessageText.BorderColor = SystemColors.WindowFrame;
            panelNoSelectedMessageText.BorderRadius = 25;
            panelNoSelectedMessageText.BorderThickness = 2;
            panelNoSelectedMessageText.Controls.Add(lblNoSelectedMessageText);
            panelNoSelectedMessageText.CustomizableEdges = customizableEdges6;
            panelNoSelectedMessageText.Location = new Point(293, 298);
            panelNoSelectedMessageText.Name = "panelNoSelectedMessageText";
            panelNoSelectedMessageText.ShadowDecoration.CustomizableEdges = customizableEdges7;
            panelNoSelectedMessageText.ShadowDecoration.Depth = 4;
            panelNoSelectedMessageText.ShadowDecoration.Enabled = true;
            panelNoSelectedMessageText.Size = new Size(345, 54);
            panelNoSelectedMessageText.TabIndex = 0;
            // 
            // lblNoSelectedMessageText
            // 
            lblNoSelectedMessageText.AutoSize = true;
            lblNoSelectedMessageText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoSelectedMessageText.ForeColor = Color.White;
            lblNoSelectedMessageText.Location = new Point(19, 10);
            lblNoSelectedMessageText.Name = "lblNoSelectedMessageText";
            lblNoSelectedMessageText.Size = new Size(308, 30);
            lblNoSelectedMessageText.TabIndex = 0;
            lblNoSelectedMessageText.Text = "Select a chat to start messaging";
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1225, 647);
            Controls.Add(panelMassages);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat App";
            FormClosing += frmMainMenu_FormClosing;
            Load += frmMainMenu_Load;
            panel1.ResumeLayout(false);
            flowLayoutChatsPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserProfile).EndInit();
            panelChatWord.ResumeLayout(false);
            panelChatWord.PerformLayout();
            panelToIncludeNoLContentsExistPanel.ResumeLayout(false);
            panelNoLContentsExist.ResumeLayout(false);
            panelNoLContentsExist.PerformLayout();
            panelMassages.ResumeLayout(false);
            panelNoSelectedMessageText.ResumeLayout(false);
            panelNoSelectedMessageText.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelToIncludeNoLContentsExistPanel;
        private System.Windows.Forms.Panel panelNoLContentsExist;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNewContent2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutChatsPanel;
    }
}