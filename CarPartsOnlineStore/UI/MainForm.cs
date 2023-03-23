namespace CarPartsOnlineStore.UI
{
	using CarPartsOnlineStore.Classes;
	using System.Windows.Forms;
	using System;

	public partial class MainForm : Form
	{
		private int userId = -1;

		public MainForm(bool isAdmin, int userId)
		{
			InitializeComponent();

			if (!isAdmin)
			{
				pnlSubMenuAddProducts.Hide();
				btnRegisterUsers.Hide();
			}

			this.userId = userId;

			pnlShowCliked.Height = btnHome.Height;
			pnlShowCliked.Top = btnHome.Top;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			pnlShowCliked.Height = btnLogout.Height;
			pnlShowCliked.Top = btnLogout.Top;
			FormSwitch.Switch(this, new LoginForm());
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			pnlShowCliked.Height = btnProducts.Height;
			pnlShowCliked.Top = btnProducts.Top;
			if (!pnlContant.Controls.Contains(ProductsForm.Instance))
			{
				pnlContant.Controls.Add(ProductsForm.Instance);
				ProductsForm.Instance.Dock = DockStyle.Fill;
				ProductsForm.Instance.BringToFront();
				ProductsForm.Instance.Show();
			}
			else
			{
				ProductsForm.Instance.RefreshData();
				ProductsForm.Instance.BringToFront();
			}
		}

		private void btnInsertProducts_Click(object sender, EventArgs e)
		{
			pnlShowCliked.Height = pnlSubMenuAddProducts.Height;
			pnlShowCliked.Top = pnlSubMenuAddProducts.Top;
			if (!pnlContant.Controls.Contains(InsertProductForm.Instance))
			{
				pnlContant.Controls.Add(InsertProductForm.Instance);
				InsertProductForm.Instance.Dock = DockStyle.Fill;
				InsertProductForm.Instance.BringToFront();
				InsertProductForm.Instance.Show();
			}
			else
			{
				InsertProductForm.Instance.RefreshData();
				InsertProductForm.Instance.BringToFront();
			}
		}

		private void btnInvoiceProducts_Click(object sender, EventArgs e)
		{
			pnlShowCliked.Height = btnInvoiceProducts.Height;
			pnlShowCliked.Top = btnInvoiceProducts.Top;
			if (!pnlContant.Controls.Contains(InvoiceForm.Instance))
			{
				pnlContant.Controls.Add(InvoiceForm.Instance);
				InvoiceForm.Instance.Dock = DockStyle.Fill;
				InvoiceForm.Instance.setUserType(userId);
				InvoiceForm.Instance.RefreshData();
				InvoiceForm.Instance.BringToFront();
				InvoiceForm.Instance.Show();
			}
			else
			{
				InvoiceForm.Instance.setUserType(userId);
				InvoiceForm.Instance.RefreshData();
				InvoiceForm.Instance.BringToFront();
			}
		}

		private void btnOrderProducts_Click(object sender, EventArgs e)
		{
			pnlShowCliked.Height = btnOrderProducts.Height;
			pnlShowCliked.Top = btnOrderProducts.Top;
			if (!pnlContant.Controls.Contains(OrderForm.Instance))
			{
				pnlContant.Controls.Add(OrderForm.Instance);
				OrderForm.Instance.Dock = DockStyle.Fill;
				OrderForm.Instance.setUserId(userId);
				OrderForm.Instance.BringToFront();
				OrderForm.Instance.Show();
			}
			else
			{
				OrderForm.Instance.setUserId(userId);
				OrderForm.Instance.RefreshData();
				OrderForm.Instance.BringToFront();
			}
		}

		private void btnRegisterUsers_Click(object sender, EventArgs e)
		{
			pnlShowCliked.Height = btnRegisterUsers.Height;
			pnlShowCliked.Top = btnRegisterUsers.Top;
			if (!pnlContant.Controls.Contains(UserRegistrationForm.Instance))
			{
				pnlContant.Controls.Add(UserRegistrationForm.Instance);
				UserRegistrationForm.Instance.Dock = DockStyle.Fill;
				UserRegistrationForm.Instance.BringToFront();
				UserRegistrationForm.Instance.Show();
			}
			else
			{
				UserRegistrationForm.Instance.RefreshData();
				UserRegistrationForm.Instance.BringToFront();
			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			pnlShowCliked.Height = btnHome.Height;
			pnlShowCliked.Top = btnHome.Top;
			pnlHome.BringToFront();
		}
	}
}
