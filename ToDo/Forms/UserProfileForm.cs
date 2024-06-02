using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ToDo
{
    public partial class UserProfileForm : KryptonForm
    {
        private string newUsernamePlaceholderText = "New username";
        private string newPasswordPlaceholderText = "New password";
        private int loggedUserId;

        public UserProfileForm(int userId)
        {
            loggedUserId = userId;
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            newUsernameTextBox.Enter += newUsernameTextBox_Enter;
            newUsernameTextBox.LostFocus += newUsernameTextBox_LostFocus;
            newPasswordTextBox.Enter += newPasswordTextBox_Enter;
            newPasswordTextBox.LostFocus += newPasswordTextBox_LostFocus;
            newPasswordTextBox.KeyDown += newPasswordTextBox_KeyPressed;
            newUsernameTextBox.KeyDown += newUsernameTextBox_KeyPressed;
            changeButton.Click += changeButton_Click;
            this.FormClosed += closeUserProfileForm;
        }

        //Resets the placeholder text
        private void setPlaceholderText(KryptonTextBox textBox, string placeholderText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
            }
        }

        //Clears the placeholder text
        private void clearPlaceholderText(KryptonTextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = string.Empty;
            }
        }

        //Clears the username placeholder text when the text box is focused
        private void newUsernameTextBox_Enter(object sender, EventArgs e)
        {
            clearPlaceholderText(newUsernameTextBox, newUsernamePlaceholderText);

            if (newPasswordTextBox.Text != newPasswordPlaceholderText)
            {
                newPasswordTextBox.PasswordChar = '*';
            }
        }

        //Resets the username placeholder text when the text box losts focus
        private void newUsernameTextBox_LostFocus(object sender, EventArgs e)
        {
            setPlaceholderText(newUsernameTextBox, newUsernamePlaceholderText);
        }

        //Clears the password placeholder text when the text box is focused
        private void newPasswordTextBox_Enter(object sender, EventArgs e)
        {
            clearPlaceholderText(newPasswordTextBox, newPasswordPlaceholderText);

            if (!string.IsNullOrWhiteSpace(newPasswordPlaceholderText))
            {
                newPasswordTextBox.PasswordChar = '*';
            }
        }

        //Resets the password placeholder text when the text box losts focus
        private void newPasswordTextBox_LostFocus(object sender, EventArgs e)
        {
            setPlaceholderText(newPasswordTextBox, newPasswordPlaceholderText);

            if (!string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
            {
                newPasswordTextBox.PasswordChar = '\0';
            }
        }

        //Unfocus when form starts
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }

        //Focus username text box when pressing Enter key
        private void newUsernameTextBox_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newPasswordTextBox.Focus();
            }
        }

        //Change with Enter key
        private void newPasswordTextBox_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeButton.PerformClick();
            }
        }

        //changeButton
        private void changeButton_Click(object sender, EventArgs e)
        {
            UserAccess ua = new UserAccess();
            bool updated = false;
            
            if (!string.IsNullOrWhiteSpace(newUsernameTextBox.Text) && newUsernameTextBox.Text != ua.getUsername(loggedUserId) && newUsernameTextBox.Text != newUsernamePlaceholderText)
            {
                ua.updateUsername(loggedUserId, newUsernameTextBox.Text);
                updated = true;
            }

            if (!string.IsNullOrWhiteSpace(newPasswordTextBox.Text) && newPasswordTextBox.Text != ua.getPassword(loggedUserId) && newPasswordTextBox.Text != newPasswordPlaceholderText)
            {
                ua.updatePassword(loggedUserId, newPasswordTextBox.Text);
                updated = true;
            }

            if (updated)
            {
                MessageBox.Show("Updated");
                this.Hide();
            }
        }

        //Closes UserProfileForm
        private void closeUserProfileForm(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
