namespace CarPartsOnlineStore.UI
{
	using CarPartsOnlineStore.Classes;
	using MySql.Data.MySqlClient;
	using System.Windows.Forms;
	using System;
	using Timer = System.Windows.Forms.Timer;

	public partial class LoginForm : Form
	{
		private const int LoginTimeout = 30; // Timeout in seconds

		private int _secondsRemaining = LoginTimeout;
		private Timer _timer;

		public LoginForm()
		{
			InitializeComponent();

			// Setup timer
			_timer = new Timer();
			_timer.Interval = 1000; // 1 second
			_timer.Tick += Timer_Tick;
			_timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			_secondsRemaining--;

			// Update label with remaining time
			lblLoginTime.Text = $"{_secondsRemaining} seconds";

			if (_secondsRemaining <= 0)
			{
				_timer.Stop();
				MessageBox.Show("Login session timed out. Exiting program.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			// Perform validation of fields
			if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
				string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Check if login is for admin or user
			bool isAdmin = cbIsAdmin.Checked;

			// Perform server-side validation
			int id;
			try
			{
				id = ValidateLogin(txtUsername.Text, txtPassword.Text, isAdmin);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Connection failed, Please try again later.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (id != -1)
			{
				// Stop timer and open main form
				_timer.Stop();
				FormSwitch.Switch(this, new MainForm(isAdmin, id));
			}
			else
			{
				MessageBox.Show("Incorrect username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private int ValidateLogin(string text1, string text2, bool isAdmin)
		{
			int id = -1;
			MySqlDataReader reader = null;

			try
			{
				// Create connection
				MySqlConnection connection = DBConfiguration.Instance.Connection;

				// Create command
				MySqlCommand command = connection.CreateCommand();

				// Create query
				string query;
				if (isAdmin)
				{
					query = "SELECT * FROM user WHERE username = @username AND password = @password AND user_type = 'admin'";
				}
				else
				{
					query = "SELECT * FROM user WHERE username = @username AND password = @password AND user_type != 'admin'";
				}

				command.CommandText = query;

				// Add parameters
				command.Parameters.AddWithValue("@username", text1);
				command.Parameters.AddWithValue("@password", text2);

				// Execute query
				reader = command.ExecuteReader();

				// Check if there is a result
				if (reader.Read())
				{
					// Get the user id
					id = reader.GetInt32("id");
				}

				// Close reader
				reader.Close();
			}
			catch (Exception)
			{
				if (reader != null && !reader.IsClosed)
				{
					reader.Close();
				}
				throw;
			}

			return id;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			// Stop timer and exit program
			_timer.Stop();
			Application.Exit();
		}

		private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (cbShowPassword.Checked)
			{
				txtPassword.UseSystemPasswordChar = false; // Show password
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true; // Hide password
			}
		}
	}
}
