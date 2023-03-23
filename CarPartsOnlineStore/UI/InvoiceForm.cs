namespace CarPartsOnlineStore.UI
{
	using CarPartsOnlineStore.Classes;
	using MySql.Data.MySqlClient;
	using System;
	using System.Data;
	using System.Windows.Forms;

	public partial class InvoiceForm : Form
	{
		private static InvoiceForm _instance;

		string userType = "";

		public static InvoiceForm Instance
		{
			get
			{
				if (_instance == null)
					_instance = new InvoiceForm();
				return _instance;
			}
		}

		public InvoiceForm()
		{
			InitializeComponent();

			this.TopLevel = false;

			DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
			dgvInvoices.Columns.Add(btn);
			btn.HeaderText = "Details";
			btn.Text = "Details";
			btn.Name = "details";
			btn.UseColumnTextForButtonValue = true;
		}

		public void setUserType(int id)
		{
			try
			{
				MySqlCommand mySql = new MySqlCommand("SELECT user_type FROM `user` WHERE `id` = @id", DBConfiguration.Instance.Connection);
				mySql.Parameters.AddWithValue("@id", id);
				MySqlDataReader reader = mySql.ExecuteReader();

				while (reader.Read())
				{
					userType = reader.GetString("user_type");
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InvoiceForm_Load(object sender, EventArgs e)
		{
			LoadDataInDGV();
		}

		private void LoadDataInDGV(string searchedText = "")
		{
			try
			{
				if (!userType.Equals("admin"))
				{
					MySqlCommand cmd;
					if (userType.Equals("customer"))
					{
						cmd = new MySqlCommand("SELECT cname AS `Customer Name`, p.name AS `Product Name`, p.quantity AS Quantiy, p.price AS Price, p.order_date AS `Order Date`, p.email, p.phone, p.address, p.description FROM (SELECT o.*, p.name, p.description, p.seller_id, c.name AS cname, c.email, c.phone, c.address FROM orders o JOIN customer c ON o.customer_id = c.id JOIN product p ON o.product_id = p.id) p WHERE CONCAT(p.name, p.description, p.price, p.cname, p.email) LIKE '%" + searchedText + "%';", DBConfiguration.Instance.Connection);
					}
					else
					{
						cmd = new MySqlCommand("SELECT cname AS `Customer Name`, p.name AS `Product Name`, p.quantity AS Quantiy, p.price AS Price, p.order_date AS `Order Date`, p.email, p.phone, p.address, p.description FROM (SELECT o.*, p.name, p.description, p.seller_id, c.name AS cname, c.email, c.phone, c.address FROM orders o JOIN seller c ON o.customer_id = c.user_id JOIN product p ON o.product_id = p.id) p WHERE CONCAT(p.name, p.description, p.price, p.cname, p.email) LIKE '%" + searchedText + "%';", DBConfiguration.Instance.Connection);
					}
					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					dgvInvoices.DataSource = dt;
					dgvInvoices.Columns[5].Visible = false;
					dgvInvoices.Columns[6].Visible = false;
					dgvInvoices.Columns[7].Visible = false;
					dgvInvoices.Columns[8].Visible = false;

					dgvInvoices.Columns["details"].Visible = true;
					dgvInvoices.Columns["details"].DisplayIndex = dgvInvoices.Columns.Count - 1;
				}
				else
				{
					MySqlCommand cmd = new MySqlCommand("SELECT p.username, p.name AS `Product Name`, p.quantity AS Quantiy, p.price AS Price, p.order_date AS `Order Date` FROM (SELECT o.*, p.name, p.description, p.seller_id, c.username FROM orders o JOIN user c ON o.customer_id = c.id JOIN product p ON o.product_id = p.id where c.user_type = 'admin') p WHERE CONCAT(p.name, p.description, p.price) LIKE '%" + searchedText + "%';", DBConfiguration.Instance.Connection);
					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					dgvInvoices.DataSource = dt;

					dgvInvoices.Columns["details"].Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void RefreshData()
		{
			txtSearch.Text = "";
			LoadDataInDGV();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadDataInDGV(txtSearch.Text);
		}

		private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (dgvInvoices.Columns[e.ColumnIndex].Name == "details")
				{
					string details = "Customer Name: " + dgvInvoices.Rows[e.RowIndex].Cells[1].Value.ToString() + Environment.NewLine;
					details += "Email: " + dgvInvoices.Rows[e.RowIndex].Cells[6].Value.ToString() + Environment.NewLine;
					details += "Phone: " + dgvInvoices.Rows[e.RowIndex].Cells[7].Value.ToString() + Environment.NewLine;
					details += "Address: " + dgvInvoices.Rows[e.RowIndex].Cells[8].Value.ToString() + Environment.NewLine;
					details += Environment.NewLine;
					details += "Product Name: " + dgvInvoices.Rows[e.RowIndex].Cells[2].Value.ToString() + Environment.NewLine;
					details += "Description: " + dgvInvoices.Rows[e.RowIndex].Cells[9].Value.ToString() + Environment.NewLine;
					details += "Quantity: " + dgvInvoices.Rows[e.RowIndex].Cells[3].Value.ToString() + Environment.NewLine;
					details += Environment.NewLine;
					details += "Total Price: " + dgvInvoices.Rows[e.RowIndex].Cells[4].Value.ToString() + Environment.NewLine;
					details += "Order Date: " + dgvInvoices.Rows[e.RowIndex].Cells[5].Value.ToString();

					MessageBox.Show(details, "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
