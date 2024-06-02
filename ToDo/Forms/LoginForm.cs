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

namespace ToDo
{
    public partial class LoginForm : KryptonForm
    {
        private string UsernameKey = "Username";
        private string PasswordKey = "Password";
        private string usernamePlaceholderText = "Username";
        private string passwordPlaceholderText = "Password";
        private Authentication auth = new Authentication();
        private UserAccess ua = new UserAccess();
        private int loggedUserId = 0;

        public LoginForm()
        {
            InitializeComponent();
            loadLogin();
            initialize();
        }

        public int LoggedUserId{
            get { return loggedUserId; }
            set { loggedUserId = value; }
        }

        private void initialize()
        {
            usernameTextBox.Enter += usernameTextBox_Enter;
            usernameTextBox.LostFocus += usernameTextBox_LostFocus;
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.LostFocus += passwordTextBox_LostFocus;
            passwordTextBox.KeyDown += passwordTextBox_KeyPressed;
            usernameTextBox.KeyDown += usernameTextBox_KeyPressed;
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
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            clearPlaceholderText(usernameTextBox, usernameTextBox.Text);

            if (passwordTextBox.Text != passwordPlaceholderText)
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        //Resets the username placeholder text when the text box losts focus
        private void usernameTextBox_LostFocus(object sender, EventArgs e)
        {
            setPlaceholderText(usernameTextBox, usernamePlaceholderText);
        }

        //Clears the password placeholder text when the text box is focused
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            clearPlaceholderText(passwordTextBox, passwordTextBox.Text);

            if (!string.IsNullOrWhiteSpace(passwordPlaceholderText))
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        //Resets the password placeholder text when the text box losts focus
        private void passwordTextBox_LostFocus(object sender, EventArgs e)
        {
            setPlaceholderText(passwordTextBox, passwordPlaceholderText);

            if (!string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
               passwordTextBox.PasswordChar = '\0';
            }
        }

        //Unfocus when form starts
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }

        //Login button
        //Hide LoginForm and show MainForm after login
        private void loginButton_Click(object sender, EventArgs e)
        {
            loggedUserId = auth.getUserId(usernameTextBox.Text, passwordTextBox.Text);
            if (loggedUserId != 0)
            {
                MessageBox.Show("Logged in successfully");
                clearPlaceholderText(usernameTextBox, usernameTextBox.Text);
                clearPlaceholderText(passwordTextBox, passwordTextBox.Text);
                setPlaceholderText(usernameTextBox, usernamePlaceholderText);
                setPlaceholderText(passwordTextBox, passwordPlaceholderText);
                MainForm mainForm = new MainForm(loggedUserId);
                mainForm.Show();
                this.Hide();
            }
            else if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || usernameTextBox.Text == usernamePlaceholderText)
            {
                MessageBox.Show("Username is empty");
                usernameTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordTextBox.Text == passwordPlaceholderText)
            {
                MessageBox.Show("Password is empty");
                passwordTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        //Focus username text box when pressing Enter key
        private void usernameTextBox_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordTextBox.Focus();
            }
        }

        //Log in with Enter key
        private void passwordTextBox_KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        //Register button
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || usernameTextBox.Text == usernamePlaceholderText)
            {
                MessageBox.Show("Username is empty");
                usernameTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordTextBox.Text == passwordPlaceholderText)
            {
                MessageBox.Show("Password is empty");
                passwordTextBox.Focus();
            }
            else
            {
                ua.createUser(usernameTextBox.Text, passwordTextBox.Text);
                clearPlaceholderText(usernameTextBox, usernameTextBox.Text);
                clearPlaceholderText(passwordTextBox, passwordTextBox.Text);
                setPlaceholderText(usernameTextBox, usernamePlaceholderText);
                passwordTextBox.PasswordChar = '\0';
                setPlaceholderText(passwordTextBox, passwordPlaceholderText);
            }
        }

        // Saves login if remember me is checked
        private void saveLogin()
        {
            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default[UsernameKey] = usernameTextBox.Text;
                Properties.Settings.Default[PasswordKey] = passwordTextBox.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default[UsernameKey] = string.Empty;
                Properties.Settings.Default[PasswordKey] = string.Empty;
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
        }

        // Loads saved login
        private void loadLogin()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                usernameTextBox.Text = Properties.Settings.Default[UsernameKey].ToString();
                passwordTextBox.Text = Properties.Settings.Default[PasswordKey].ToString();
                passwordTextBox.PasswordChar = '*';
                rememberMeCheckBox.Checked = true;
            }
            else
            {
                usernameTextBox.Text = usernamePlaceholderText;
                passwordTextBox.Text = passwordPlaceholderText;
            }
        }

        // Remember me checkbox
        private void rememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            saveLogin();
            passwordTextBox.PasswordChar = '*';
        }

        private void offlineButton_Click(object sender, EventArgs e)
        {
            OfflineForm offlineForm = new OfflineForm();
            offlineForm.Show();
            this.Hide();
        }
    }
}
