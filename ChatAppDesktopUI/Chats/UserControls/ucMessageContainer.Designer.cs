namespace ChatAppDesktopUI.Chats.UserControls
{
    partial class ucMessageContainer
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnBlockContact = new Guna.UI2.WinForms.Guna2CircleButton();
            btnDeleteContact = new Guna.UI2.WinForms.Guna2CircleButton();
            btnContactInfo = new Guna.UI2.WinForms.Guna2CircleButton();
            lblContactName = new Label();
            pbContactImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel2 = new Panel();
            txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            btnSendMessage = new Guna.UI2.WinForms.Guna2CircleButton();
            panelMessageContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbContactImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 46, 51);
            panel1.Controls.Add(btnBlockContact);
            panel1.Controls.Add(btnDeleteContact);
            panel1.Controls.Add(btnContactInfo);
            panel1.Controls.Add(lblContactName);
            panel1.Controls.Add(pbContactImage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 66);
            panel1.TabIndex = 0;
            // 
            // btnBlockContact
            // 
            btnBlockContact.BackColor = Color.Transparent;
            btnBlockContact.CheckedState.FillColor = Color.Transparent;
            btnBlockContact.Cursor = Cursors.Hand;
            btnBlockContact.DisabledState.BorderColor = Color.DarkGray;
            btnBlockContact.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBlockContact.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBlockContact.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBlockContact.FillColor = Color.Transparent;
            btnBlockContact.Font = new Font("Segoe UI", 9F);
            btnBlockContact.ForeColor = Color.White;
            btnBlockContact.HoverState.FillColor = Color.Transparent;
            btnBlockContact.Image = Properties.Resources.block_contact;
            btnBlockContact.ImageSize = new Size(45, 45);
            btnBlockContact.Location = new Point(687, 7);
            btnBlockContact.Margin = new Padding(4, 3, 4, 3);
            btnBlockContact.Name = "btnBlockContact";
            btnBlockContact.PressedColor = Color.Transparent;
            btnBlockContact.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnBlockContact.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnBlockContact.Size = new Size(66, 49);
            btnBlockContact.TabIndex = 8;
            btnBlockContact.Click += btnBlockContact_Click;
            // 
            // btnDeleteContact
            // 
            btnDeleteContact.BackColor = Color.Transparent;
            btnDeleteContact.CheckedState.FillColor = Color.Transparent;
            btnDeleteContact.Cursor = Cursors.Hand;
            btnDeleteContact.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteContact.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteContact.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteContact.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteContact.FillColor = Color.Transparent;
            btnDeleteContact.Font = new Font("Segoe UI", 9F);
            btnDeleteContact.ForeColor = Color.White;
            btnDeleteContact.HoverState.FillColor = Color.Transparent;
            btnDeleteContact.Image = Properties.Resources.delete_contact;
            btnDeleteContact.ImageSize = new Size(42, 42);
            btnDeleteContact.Location = new Point(760, 7);
            btnDeleteContact.Margin = new Padding(4, 3, 4, 3);
            btnDeleteContact.Name = "btnDeleteContact";
            btnDeleteContact.PressedColor = Color.Transparent;
            btnDeleteContact.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeleteContact.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDeleteContact.Size = new Size(66, 49);
            btnDeleteContact.TabIndex = 7;
            btnDeleteContact.Click += btnDeleteContact_Click;
            // 
            // btnContactInfo
            // 
            btnContactInfo.BackColor = Color.Transparent;
            btnContactInfo.CheckedState.FillColor = Color.Transparent;
            btnContactInfo.Cursor = Cursors.Hand;
            btnContactInfo.DisabledState.BorderColor = Color.DarkGray;
            btnContactInfo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnContactInfo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnContactInfo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnContactInfo.FillColor = Color.Transparent;
            btnContactInfo.Font = new Font("Segoe UI", 9F);
            btnContactInfo.ForeColor = Color.White;
            btnContactInfo.HoverState.FillColor = Color.Transparent;
            btnContactInfo.Image = Properties.Resources.contact_info;
            btnContactInfo.ImageSize = new Size(45, 45);
            btnContactInfo.Location = new Point(833, 7);
            btnContactInfo.Margin = new Padding(4, 3, 4, 3);
            btnContactInfo.Name = "btnContactInfo";
            btnContactInfo.PressedColor = Color.Transparent;
            btnContactInfo.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnContactInfo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnContactInfo.Size = new Size(66, 49);
            btnContactInfo.TabIndex = 6;
            btnContactInfo.Click += btnContactInfo_Click;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.BackColor = Color.Transparent;
            lblContactName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactName.ForeColor = Color.White;
            lblContactName.Location = new Point(78, 19);
            lblContactName.Margin = new Padding(4, 0, 4, 0);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(61, 25);
            lblContactName.TabIndex = 5;
            lblContactName.Text = "label1";
            // 
            // pbContactImage
            // 
            pbContactImage.BackColor = Color.Transparent;
            pbContactImage.Cursor = Cursors.Hand;
            pbContactImage.Image = Properties.Resources.default_male;
            pbContactImage.ImageRotate = 0F;
            pbContactImage.Location = new Point(15, 6);
            pbContactImage.Margin = new Padding(4, 3, 4, 3);
            pbContactImage.Name = "pbContactImage";
            pbContactImage.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pbContactImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbContactImage.Size = new Size(50, 50);
            pbContactImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbContactImage.TabIndex = 4;
            pbContactImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtMessage);
            panel2.Controls.Add(btnSendMessage);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 589);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 58);
            panel2.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.BorderThickness = 0;
            txtMessage.Cursor = Cursors.IBeam;
            txtMessage.CustomizableEdges = customizableEdges5;
            txtMessage.DefaultText = "";
            txtMessage.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMessage.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMessage.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMessage.Dock = DockStyle.Fill;
            txtMessage.FillColor = Color.FromArgb(40, 46, 51);
            txtMessage.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Font = new Font("Segoe UI", 14.25F);
            txtMessage.ForeColor = Color.White;
            txtMessage.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMessage.Location = new Point(0, 0);
            txtMessage.Margin = new Padding(6);
            txtMessage.Name = "txtMessage";
            txtMessage.PasswordChar = '\0';
            txtMessage.PlaceholderText = "Write a message...";
            txtMessage.SelectedText = "";
            txtMessage.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMessage.Size = new Size(831, 58);
            txtMessage.TabIndex = 8;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.FromArgb(40, 46, 51);
            btnSendMessage.CheckedState.FillColor = Color.Transparent;
            btnSendMessage.Cursor = Cursors.Hand;
            btnSendMessage.DisabledState.BorderColor = Color.DarkGray;
            btnSendMessage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSendMessage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSendMessage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSendMessage.Dock = DockStyle.Right;
            btnSendMessage.FillColor = Color.Transparent;
            btnSendMessage.Font = new Font("Segoe UI", 9F);
            btnSendMessage.ForeColor = Color.White;
            btnSendMessage.HoverState.FillColor = Color.Transparent;
            btnSendMessage.Image = Properties.Resources.send_message;
            btnSendMessage.ImageSize = new Size(30, 30);
            btnSendMessage.Location = new Point(831, 0);
            btnSendMessage.Margin = new Padding(4, 3, 4, 3);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.PressedColor = Color.Transparent;
            btnSendMessage.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnSendMessage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnSendMessage.Size = new Size(77, 58);
            btnSendMessage.TabIndex = 7;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // panelMessageContainer
            // 
            panelMessageContainer.AutoScroll = true;
            panelMessageContainer.BackColor = Color.Transparent;
            panelMessageContainer.BackgroundImage = Properties.Resources.chat_background;
            panelMessageContainer.Dock = DockStyle.Fill;
            panelMessageContainer.Location = new Point(0, 66);
            panelMessageContainer.Margin = new Padding(4, 3, 4, 3);
            panelMessageContainer.Name = "panelMessageContainer";
            panelMessageContainer.Size = new Size(908, 523);
            panelMessageContainer.TabIndex = 2;
            // 
            // ucMessageContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMessageContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucMessageContainer";
            Size = new Size(908, 647);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbContactImage).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbContactImage;
        private System.Windows.Forms.Label lblContactName;
        private Guna.UI2.WinForms.Guna2CircleButton btnBlockContact;
        private Guna.UI2.WinForms.Guna2CircleButton btnDeleteContact;
        private Guna.UI2.WinForms.Guna2CircleButton btnContactInfo;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnSendMessage;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.Panel panelMessageContainer;
    }
}
