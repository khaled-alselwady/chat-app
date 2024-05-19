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
            this.pbContactImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblDateOfTheLastMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbContactImage
            // 
            this.pbContactImage.BackColor = System.Drawing.Color.Transparent;
            this.pbContactImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbContactImage.Image = global::ChatAppDesktopUI.Properties.Resources.default_male;
            this.pbContactImage.ImageRotate = 0F;
            this.pbContactImage.Location = new System.Drawing.Point(2, 5);
            this.pbContactImage.Name = "pbContactImage";
            this.pbContactImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbContactImage.Size = new System.Drawing.Size(50, 50);
            this.pbContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContactImage.TabIndex = 3;
            this.pbContactImage.TabStop = false;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.BackColor = System.Drawing.Color.Transparent;
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.ForeColor = System.Drawing.Color.White;
            this.lblContactName.Location = new System.Drawing.Point(58, 1);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(50, 20);
            this.lblContactName.TabIndex = 4;
            this.lblContactName.Text = "label1";
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblLastMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMessage.ForeColor = System.Drawing.Color.White;
            this.lblLastMessage.Location = new System.Drawing.Point(67, 26);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(135, 17);
            this.lblLastMessage.TabIndex = 5;
            this.lblLastMessage.Text = "This is a last message";
            // 
            // lblDateOfTheLastMessage
            // 
            this.lblDateOfTheLastMessage.AutoSize = true;
            this.lblDateOfTheLastMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfTheLastMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfTheLastMessage.ForeColor = System.Drawing.Color.White;
            this.lblDateOfTheLastMessage.Location = new System.Drawing.Point(260, 44);
            this.lblDateOfTheLastMessage.Name = "lblDateOfTheLastMessage";
            this.lblDateOfTheLastMessage.Size = new System.Drawing.Size(55, 15);
            this.lblDateOfTheLastMessage.TabIndex = 6;
            this.lblDateOfTheLastMessage.Text = "10:30 PM";
            // 
            // ucSubContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.lblDateOfTheLastMessage);
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.pbContactImage);
            this.Name = "ucSubContactInfo";
            this.Size = new System.Drawing.Size(317, 61);
            ((System.ComponentModel.ISupportInitialize)(this.pbContactImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbContactImage;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblDateOfTheLastMessage;
    }
}
