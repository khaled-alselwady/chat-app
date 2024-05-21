namespace ChatAppDesktopUI.Chats.UserControls
{
    partial class ucMessage
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
            components = new System.ComponentModel.Container();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lblMessageTime = new Label();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // lblMessageTime
            // 
            lblMessageTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMessageTime.AutoSize = true;
            lblMessageTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessageTime.ForeColor = Color.LightGray;
            lblMessageTime.Location = new Point(269, 131);
            lblMessageTime.Margin = new Padding(4, 0, 4, 0);
            lblMessageTime.Name = "lblMessageTime";
            lblMessageTime.Size = new Size(38, 15);
            lblMessageTime.TabIndex = 1;
            lblMessageTime.Text = "label2";
            // 
            // ucMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(51, 57, 63);
            Controls.Add(lblMessageTime);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucMessage";
            Size = new Size(330, 156);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblMessageTime;
        private System.Windows.Forms.Label lblMessageContent;
    }
}
