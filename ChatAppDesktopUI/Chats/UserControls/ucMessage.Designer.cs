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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblMessageContent = new System.Windows.Forms.Label();
            this.lblMessageTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblMessageContent
            // 
            this.lblMessageContent.AutoEllipsis = true;
            this.lblMessageContent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageContent.ForeColor = System.Drawing.Color.White;
            this.lblMessageContent.Location = new System.Drawing.Point(3, 27);
            this.lblMessageContent.Name = "lblMessageContent";
            this.lblMessageContent.Size = new System.Drawing.Size(100, 23);
            this.lblMessageContent.TabIndex = 0;
            this.lblMessageContent.Text = "label1";
            // 
            // lblMessageTime
            // 
            this.lblMessageTime.AutoSize = true;
            this.lblMessageTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblMessageTime.Location = new System.Drawing.Point(263, 63);
            this.lblMessageTime.Name = "lblMessageTime";
            this.lblMessageTime.Size = new System.Drawing.Size(38, 15);
            this.lblMessageTime.TabIndex = 1;
            this.lblMessageTime.Text = "label2";
            // 
            // ucMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lblMessageTime);
            this.Controls.Add(this.lblMessageContent);
            this.Name = "ucMessage";
            this.Size = new System.Drawing.Size(311, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblMessageTime;
        private System.Windows.Forms.Label lblMessageContent;
    }
}
