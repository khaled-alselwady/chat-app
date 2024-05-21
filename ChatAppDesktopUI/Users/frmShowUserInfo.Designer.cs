namespace ChatAppDesktopUI.Users
{
    partial class frmShowUserInfo
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
            label1 = new Label();
            ucUserCard1 = new UserControls.ucUserCard();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 58, 76);
            label1.Location = new Point(1, 2);
            label1.Name = "label1";
            label1.Size = new Size(747, 68);
            label1.TabIndex = 0;
            label1.Text = "User Info";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucUserCard1
            // 
            ucUserCard1.BackColor = Color.White;
            ucUserCard1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucUserCard1.Location = new Point(12, 116);
            ucUserCard1.Name = "ucUserCard1";
            ucUserCard1.Size = new Size(726, 237);
            ucUserCard1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BorderRadius = 20;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.FromArgb(0, 0, 50);
            btnClose.FillColor2 = Color.FromArgb(41, 58, 76);
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = ChatAppDesktopUI.Properties.Resources.close_48;
            btnClose.ImageAlign = HorizontalAlignment.Left;
            btnClose.ImageSize = new Size(30, 30);
            btnClose.Location = new Point(584, 366);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(9, 0, 0, 0);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(155, 45);
            btnClose.TabIndex = 199;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // frmShowUserInfo
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(749, 414);
            Controls.Add(btnClose);
            Controls.Add(ucUserCard1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmShowUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show User Info";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UserControls.ucUserCard ucUserCard1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}