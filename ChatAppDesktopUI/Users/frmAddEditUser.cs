using ChatAppBusiness;
using ChatAppDesktopUI.GlobalClasses;
using ChatAppDesktopUI.Properties;
using Guna.UI2.WinForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace ChatAppDesktopUI.Users
{
    public partial class frmAddEditUser : Form
    {
        public Action<int?> UserIDBack;

        private enum _enMode { AddNew, Update };
        private _enMode _mode = _enMode.AddNew;

        private int? _userID = null;
        private clsUser _user = null;

        public frmAddEditUser()
        {
            InitializeComponent();

            _mode = _enMode.AddNew;
        }

        public frmAddEditUser(int? userID)
        {
            InitializeComponent();

            _userID = userID;
            _mode = _enMode.Update;
        }

        private void _ResetFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            lblUserID.Text = "[????]";
        }

        private void _ResetDefaultValues()
        {
            if (_mode == _enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _user = new clsUser();

                _ResetFields();
            }
            else
            {
                lblTitle.Text = "Update User";
            }

            this.Text = lblTitle.Text;
        }

        private void _FillFieldsWithUserObject()
        {
            lblUserID.Text = _user.UserID.ToString();
            txtUsername.Text = _user.Username;
            txtPassword.Text = _user.Password;
            txtBio.Text = _user.Bio;
            txtConfirmPassword.Text = _user.Password;

            //load person image in case it was set.
            if (_user.ImagePath != null)
            {
                pbUserImage.ImageLocation = _user.ImagePath;
            }

            //hide/show the remove link in case there is no image for the person
            llRemoveImage.Visible = (_user.ImagePath != null);
        }

        private void _LoadData()
        {
            _user = clsUser.Find(_userID);

            if (_user == null)
            {
                clsStandardMessages.ShowMissingDataMessage("user", _userID);

                this.Close();

                return;
            }

            _FillFieldsWithUserObject();

            // in update mode, I show the change password link label to allow the user to change his password
            panelPassword.Visible = false;

            llChangePassword.Visible = true;

            label2.Location = new System.Drawing.Point(58, 138);
            pictureBox4.Location = new System.Drawing.Point(163, 135);
            txtBio.Location = new System.Drawing.Point(211, 132);
        }

        private bool _HandleUserImage()
        {
            // this procedure will handle the User image,
            // it will take care of deleting the old image from the folder
            // in case the image changed, and it will rename the new image with guid and 
            // place it in the images folder.

            // _User.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_user.ImagePath != pbUserImage.ImageLocation)
            {

                if (_user.ImagePath != null)
                {
                    // first we delete the old image from the folder in case there is any.
                    try
                    {
                        File.Delete(_user.ImagePath);
                    }
                    catch (IOException iox)
                    {
                        clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                        loggerToEventViewer.LogError("IO Exception", iox);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                        loggerToEventViewer.LogError("General Exception", ex);
                        return false;
                    }
                }

                if (pbUserImage.ImageLocation != null)
                {
                    // then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbUserImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbUserImage.ImageLocation = SourceImageFile;

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void _FillUserObjectWithFieldsData()
        {
            _user.Username = txtUsername.Text.Trim();
            _user.Bio = string.IsNullOrWhiteSpace(txtBio.Text) ? null : txtBio.Text.Trim();

            if (pbUserImage.ImageLocation != null)
            {
                _user.ImagePath = pbUserImage.ImageLocation;
            }
            else
            {
                _user.ImagePath = null;
            }

            if (_mode == _enMode.AddNew)
            {
                _user.Password = clsGlobal.ComputeHash(txtPassword.Text.Trim());
            }
        }

        private void _SaveUser()
        {
            _FillUserObjectWithFieldsData();

            if (_user.Save())
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;
                lblUserID.Text = _user.UserID.ToString();

                // change form mode to update
                _mode = _enMode.Update;

                clsStandardMessages.ShowSuccess("User");

                // Trigger the event to send data back to the caller form
                UserIDBack?.Invoke(_user.UserID);
            }
            else
            {
                clsStandardMessages.ShowError("User");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_mode == _enMode.Update)
            {
                _LoadData();
            }

            txtBio.BorderRadius = 20;
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }


            if (txtUsername.Text.Trim().ToLower() != _user.Username.ToLower() &&
                clsUser.Exists(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "username is used by another user");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!panelPassword.Visible)
                return;

            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!panelPassword.Visible)
                return;

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

            if ((!string.IsNullOrWhiteSpace(txtConfirmPassword.Text.Trim())
                && !string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
                && (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword,
                    "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtPasswordAndConfirm_TextChanged(object sender, EventArgs e)
        {
            ((Guna2TextBox)sender).UseSystemPasswordChar = true;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbUserImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbUserImage.ImageLocation = null;
            pbUserImage.Image = Resources.default_male;
            llRemoveImage.Visible = false;
        }

        private void llChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsStandardMessages.ShowNotImplementedFeatures();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsStandardMessages.ShowValidationErrorMessage();
                return;
            }

            if (!_HandleUserImage())
            {
                return;
            }

            _SaveUser();
        }
    }
}
