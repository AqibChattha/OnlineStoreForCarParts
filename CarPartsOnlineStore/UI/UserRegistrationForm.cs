namespace CarPartsOnlineStore.UI
{
	using CarPartsOnlineStore.Classes;
	using MySql.Data.MySqlClient;
	using System;
	using System.Text.RegularExpressions;
	using System.Windows.Forms;

	public partial class UserRegistrationForm : Form
	{
		private static UserRegistrationForm _instance;

		public static UserRegistrationForm Instance
		{
			get
			{
				if (_instance == null)
					_instance = new UserRegistrationForm();
				return _instance;
			}
		}


		public UserRegistrationForm()
		{
			InitializeComponent();
			this.TopLevel = false;
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelephone.Text) || string.IsNullOrEmpty(txtAddress.Text))
			{
				MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM user WHERE username = @Username", DBConfiguration.Instance.Connection);
				command.Parameters.AddWithValue("@Username", txtUsername.Text);

				int count = (int)Convert.ToInt64(command.ExecuteScalar().ToString());

				if (count > 0)
				{
					Console.WriteLine("Username is already taken. Please choose a different username.");
				}
				else
				{
					if (txtPassword.TextLength >= 8)
					{
						string userType = "";
						if (rbCustomer.Checked)
						{
							userType = "customer";
						}
						else if (rbSeller.Checked)
						{
							userType = "seller";
						}
						else
						{
							MessageBox.Show("Please select a user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						if (IsValidEmail(txtEmail.Text))
						{
							if (IsValidMobileNumber(txtTelephone.Text))
							{
								try
								{

									MySqlCommand cmd = new MySqlCommand("INSERT INTO user (username, password, user_type) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + userType + "'); INSERT INTO " + userType + " (name, email, phone, address, user_id) VALUES ('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtTelephone.Text + "', '" + txtAddress.Text + "', LAST_INSERT_ID());", DBConfiguration.Instance.Connection);
									cmd.ExecuteNonQuery();
									MessageBox.Show("User registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
									RefreshData();
								}
								catch (Exception)
								{
									MessageBox.Show("Error while registering user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
							else
							{
								MessageBox.Show("Please enter a valid mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
						else
						{
							MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					else
					{
						MessageBox.Show("Password must be at least 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				var match = Regex.Match(email.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

				return match.Success;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		private bool IsValidMobileNumber(string mobileNumber)
		{
			try
			{
				var match = Regex.Match(mobileNumber.Trim(), @"^[+]?[0-9]{1,3}[-\s\.]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");

				return match.Success;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		public void RefreshData()
		{
			txtAddress.Text = "";
			txtEmail.Text = "";
			txtName.Text = "";
			txtPassword.Text = "";
			txtTelephone.Text = "";
			txtUsername.Text = "";
		}

	}
}
