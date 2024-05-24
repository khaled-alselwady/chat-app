namespace ChatAppDesktopUI.Contacts.UserControls
{
    partial class ucSubContactInfo
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
            pbContactImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblContactName = new Label();
            lblLastMessage = new Label();
            lblDateOfTheLastMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pbContactImage).BeginInit();
            SuspendLayout();
            // 
            // pbContactImage
            // 
            pbContactImage.BackColor = Color.Transparent;
            pbContactImage.Cursor = Cursors.Hand;
            pbContactImage.Image = Properties.Resources.default_male;
            pbContactImage.ImageRotate = 0F;
            pbContactImage.Location = new Point(2, 6);
            pbContactImage.Margin = new Padding(4, 3, 4, 3);
            pbContactImage.Name = "pbContactImage";
            pbContactImage.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pbContactImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbContactImage.Size = new Size(50, 50);
            pbContactImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbContactImage.TabIndex = 3;
            pbContactImage.TabStop = false;
            pbContactImage.Click += On_Click;
            pbContactImage.MouseEnter += ucSubContactInfo_MouseEnter;
            pbContactImage.MouseLeave += ucSubContactInfo_MouseLeave;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.BackColor = Color.Transparent;
            lblContactName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactName.ForeColor = Color.White;
            lblContactName.Location = new Point(57, 2);
            lblContactName.Margin = new Padding(4, 0, 4, 0);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(48, 20);
            lblContactName.TabIndex = 4;
            lblContactName.Text = "label1";
            lblContactName.Click += On_Click;
            lblContactName.MouseEnter += ucSubContactInfo_MouseEnter;
            lblContactName.MouseLeave += ucSubContactInfo_MouseLeave;
            // 
            // lblLastMessage
            // 
            lblLastMessage.AutoSize = true;
            lblLastMessage.BackColor = Color.Transparent;
            lblLastMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastMessage.ForeColor = Color.White;
            lblLastMessage.Location = new Point(67, 26);
            lblLastMessage.Margin = new Padding(4, 0, 4, 0);
            lblLastMessage.Name = "lblLastMessage";
            lblLastMessage.Size = new Size(135, 17);
            lblLastMessage.TabIndex = 5;
            lblLastMessage.Text = "This is a last message";
            lblLastMessage.Click += On_Click;
            lblLastMessage.MouseEnter += ucSubContactInfo_MouseEnter;
            lblLastMessage.MouseLeave += ucSubContactInfo_MouseLeave;
            // 
            // lblDateOfTheLastMessage
            // 
            lblDateOfTheLastMessage.AutoSize = true;
            lblDateOfTheLastMessage.BackColor = Color.Transparent;
            lblDateOfTheLastMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfTheLastMessage.ForeColor = Color.White;
            lblDateOfTheLastMessage.Location = new Point(261, 43);
            lblDateOfTheLastMessage.Margin = new Padding(4, 0, 4, 0);
            lblDateOfTheLastMessage.Name = "lblDateOfTheLastMessage";
            lblDateOfTheLastMessage.Size = new Size(55, 15);
            lblDateOfTheLastMessage.TabIndex = 6;
            lblDateOfTheLastMessage.Text = "10:30 PM";
            lblDateOfTheLastMessage.Click += On_Click;
            lblDateOfTheLastMessage.MouseEnter += ucSubContactInfo_MouseEnter;
            lblDateOfTheLastMessage.MouseLeave += ucSubContactInfo_MouseLeave;
            // 
            // ucSubContactInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 58, 76);
            Controls.Add(lblDateOfTheLastMessage);
            Controls.Add(lblLastMessage);
            Controls.Add(lblContactName);
            Controls.Add(pbContactImage);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucSubContactInfo";
            Size = new Size(317, 61);
            Click += On_Click;
            MouseEnter += ucSubContactInfo_MouseEnter;
            MouseLeave += ucSubContactInfo_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pbContactImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbContactImage;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblDateOfTheLastMessage;
    }
}
