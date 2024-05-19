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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlockContact = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDeleteContact = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnContactInfo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblContactName = new System.Windows.Forms.Label();
            this.pbContactImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSendMessage = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnBlockContact);
            this.panel1.Controls.Add(this.btnDeleteContact);
            this.panel1.Controls.Add(this.btnContactInfo);
            this.panel1.Controls.Add(this.lblContactName);
            this.panel1.Controls.Add(this.pbContactImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnBlockContact
            // 
            this.btnBlockContact.BackColor = System.Drawing.Color.Transparent;
            this.btnBlockContact.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnBlockContact.CheckedState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnBlockContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockContact.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBlockContact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBlockContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBlockContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBlockContact.FillColor = System.Drawing.Color.Transparent;
            this.btnBlockContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBlockContact.ForeColor = System.Drawing.Color.White;
            this.btnBlockContact.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnBlockContact.HoverState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnBlockContact.Image = global::ChatAppDesktopUI.Properties.Resources.block_contact;
            this.btnBlockContact.ImageSize = new System.Drawing.Size(45, 45);
            this.btnBlockContact.Location = new System.Drawing.Point(695, 9);
            this.btnBlockContact.Name = "btnBlockContact";
            this.btnBlockContact.PressedColor = System.Drawing.Color.Transparent;
            this.btnBlockContact.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBlockContact.Size = new System.Drawing.Size(66, 58);
            this.btnBlockContact.TabIndex = 8;
            this.btnBlockContact.Click += new System.EventHandler(this.btnBlockContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.CheckedState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnDeleteContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteContact.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteContact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteContact.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteContact.ForeColor = System.Drawing.Color.White;
            this.btnDeleteContact.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.HoverState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnDeleteContact.Image = global::ChatAppDesktopUI.Properties.Resources.delete_contact;
            this.btnDeleteContact.ImageSize = new System.Drawing.Size(42, 42);
            this.btnDeleteContact.Location = new System.Drawing.Point(767, 9);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.PressedColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDeleteContact.Size = new System.Drawing.Size(66, 58);
            this.btnDeleteContact.TabIndex = 7;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnContactInfo
            // 
            this.btnContactInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnContactInfo.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnContactInfo.CheckedState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnContactInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContactInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContactInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContactInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContactInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContactInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnContactInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnContactInfo.ForeColor = System.Drawing.Color.White;
            this.btnContactInfo.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnContactInfo.HoverState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnContactInfo.Image = global::ChatAppDesktopUI.Properties.Resources.contact_info;
            this.btnContactInfo.ImageSize = new System.Drawing.Size(45, 45);
            this.btnContactInfo.Location = new System.Drawing.Point(839, 9);
            this.btnContactInfo.Name = "btnContactInfo";
            this.btnContactInfo.PressedColor = System.Drawing.Color.Transparent;
            this.btnContactInfo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnContactInfo.Size = new System.Drawing.Size(66, 58);
            this.btnContactInfo.TabIndex = 6;
            this.btnContactInfo.Click += new System.EventHandler(this.btnContactInfo_Click);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.BackColor = System.Drawing.Color.Transparent;
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.ForeColor = System.Drawing.Color.White;
            this.lblContactName.Location = new System.Drawing.Point(71, 25);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(61, 25);
            this.lblContactName.TabIndex = 5;
            this.lblContactName.Text = "label1";
            // 
            // pbContactImage
            // 
            this.pbContactImage.BackColor = System.Drawing.Color.Transparent;
            this.pbContactImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbContactImage.Image = global::ChatAppDesktopUI.Properties.Resources.default_male;
            this.pbContactImage.ImageRotate = 0F;
            this.pbContactImage.Location = new System.Drawing.Point(15, 12);
            this.pbContactImage.Name = "pbContactImage";
            this.pbContactImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbContactImage.Size = new System.Drawing.Size(50, 50);
            this.pbContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContactImage.TabIndex = 4;
            this.pbContactImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.btnSendMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 597);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnSendMessage.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnSendMessage.CheckedState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendMessage.FillColor = System.Drawing.Color.Transparent;
            this.btnSendMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSendMessage.HoverState.Image = global::ChatAppDesktopUI.Properties.Resources.add_content_blue_64;
            this.btnSendMessage.Image = global::ChatAppDesktopUI.Properties.Resources.send_message;
            this.btnSendMessage.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSendMessage.Location = new System.Drawing.Point(842, 0);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.PressedColor = System.Drawing.Color.Transparent;
            this.btnSendMessage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSendMessage.Size = new System.Drawing.Size(66, 50);
            this.btnSendMessage.TabIndex = 7;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderThickness = 0;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderText = "Write a message...";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(842, 50);
            this.txtMessage.TabIndex = 8;
            // 
            // ucMessageContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChatAppDesktopUI.Properties.Resources.chat_background2;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucMessageContainer";
            this.Size = new System.Drawing.Size(908, 647);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}
