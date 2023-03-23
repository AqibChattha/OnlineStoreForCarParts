namespace CarPartsOnlineStore.UI
{
	using CarPartsOnlineStore.Classes;
	using MySql.Data.MySqlClient;
	using System;
	using System.Data;
	using System.Windows.Forms;

	public partial class InsertProductForm : Form
	{
		private int sellerId = -1;
		private static InsertProductForm _instance;

		public static InsertProductForm Instance
		{
			get
			{
				if (_instance == null)
					_instance = new InsertProductForm();
				return _instance;
			}
		}

		public InsertProductForm()
		{
			InitializeComponent();

			this.TopLevel = false;
			dgvSeller.ClearSelection();
		}

		private void InsertProductForm_Load(object sender, EventArgs e)
		{
			LoadDataInDGV();
		}

		private void LoadDataInDGV(string searchedText = "")
		{
			try
			{
				MySqlDataAdapter adapter = new MySqlDataAdapter();
				DataTable table = new DataTable();
				MySqlCommand command = new MySqlCommand("SELECT id, name AS Name, email AS Email, phone AS Telephone FROM `seller` WHERE CONCAT(`name`, `email`, `phone`) LIKE '%" + searchedText + "%'", DBConfiguration.Instance.Connection);
				adapter.SelectCommand = command;
				adapter.Fill(table);
				dgvSeller.DataSource = table;
				dgvSeller.Columns[0].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadDataInDGV(txtSearch.Text);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// check if the seller is selected
			if (sellerId != -1)
			{
				// check if the price name and description is not empty
				if (txtPrice.Text != "" && txtName.Text != "" && txtDescription.Text != "")
				{
					// check if the price is decimal
					if (decimal.TryParse(txtPrice.Text, out decimal price))
					{

						try
						{
							MySqlCommand cmd = new MySqlCommand("INSERT INTO product (name, description, stock, price, seller_id) VALUES (@name, @description, @stock, @price, @seller_id)", DBConfiguration.Instance.Connection);
							cmd.Parameters.AddWithValue("@name", txtName.Text);
							cmd.Parameters.AddWithValue("@stock", (int)nudStock.Value);
							cmd.Parameters.AddWithValue("@description", txtDescription.Text);
							cmd.Parameters.AddWithValue("@price", price);
							cmd.Parameters.AddWithValue("@seller_id", sellerId);
							cmd.ExecuteNonQuery();
							MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtName.Text = "";
							txtDescription.Text = "";
							txtPrice.Text = "";
							txtSearch.Text = "";
							sellerId = -1;
							dgvSeller.ClearSelection();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Price must be a decimal", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else
				{
					MessageBox.Show("Please fill all the fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Please select a seller first", "Select Seller", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void RefreshData()
		{
			txtSearch.Text = "";
			txtName.Text = "";
			txtDescription.Text = "";
			txtPrice.Text = "";
			nudStock.Value = 1;
			sellerId = -1;
			LoadDataInDGV();
			dgvSeller.ClearSelection();
		}

		private void dgvSeller_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				sellerId = Convert.ToInt32(dgvSeller.Rows[e.RowIndex].Cells[0].Value.ToString());
				dgvSeller.Rows[e.RowIndex].Selected = true;
			}
		}
	}
}
