namespace CarPartsOnlineStore.UI
{
	using CarPartsOnlineStore.Classes;
	using MySql.Data.MySqlClient;
	using System;
	using System.Data;
	using System.Windows.Forms;

	public partial class OrderForm : Form
	{
		private static OrderForm _instance;
		private int productIndex = -1;
		private int userId = -1;

		public static OrderForm Instance
		{
			get
			{
				if (_instance == null)
					_instance = new OrderForm();
				return _instance;
			}
		}

		public OrderForm()
		{
			InitializeComponent();

			this.TopLevel = false;
		}

		public void setUserId(int id)
		{
			{
				userId = id;
			}
		}

		private void OrderForm_Load(object sender, EventArgs e)
		{
			LoadDataInDGV();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			LoadDataInDGV(txtSearch.Text);
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			if (productIndex != -1)
			{
				int productId = Convert.ToInt32(dgvProducts.Rows[productIndex].Cells[0].Value);
				int quantity = Convert.ToInt32(nudStock.Value);
				int stock = Convert.ToInt32(dgvProducts.Rows[productIndex].Cells[3].Value);
				int price = Convert.ToInt32(dgvProducts.Rows[productIndex].Cells[4].Value);

				if (quantity > stock)
				{
					MessageBox.Show("Quantity is greater than stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					try
					{
						MySqlCommand command = new MySqlCommand("INSERT INTO `orders` (customer_id, product_id, quantity, price, order_date) VALUES (@customer_id, @product_id, @quantity, @price, @date); UPDATE product SET stock = stock - @quantity WHERE id = @product_id;", DBConfiguration.Instance.Connection);
						command.Parameters.Add("@customer_id", MySqlDbType.Int32).Value = userId;
						command.Parameters.Add("@product_id", MySqlDbType.Int32).Value = productId;
						command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
						command.Parameters.Add("@price", MySqlDbType.Int32).Value = price;
						command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now.Date;
						command.ExecuteNonQuery();

						MessageBox.Show("Order placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

						txtSearch.Text = "";
						LoadDataInDGV();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a product first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void LoadDataInDGV(string searchedText = "")
		{
			try
			{
				MySqlDataAdapter adapter = new MySqlDataAdapter();
				DataTable table = new DataTable();
				MySqlCommand command = new MySqlCommand("SELECT id, p.name AS `Product Name`, p.description AS `Description`, p.stock AS `Stock`, p.price AS `Price` FROM product p WHERE CONCAT(p.name, p.description, p.stock, p.price) LIKE '%" + searchedText + "%'", DBConfiguration.Instance.Connection);
				adapter.SelectCommand = command;
				adapter.Fill(table);
				dgvProducts.DataSource = table;
				dgvProducts.Columns[0].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void RefreshData()
		{
			txtSearch.Text = "";
			productIndex = -1;
			LoadDataInDGV();
		}

		private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				productIndex = e.RowIndex;
				dgvProducts.Rows[e.RowIndex].Selected = true;
			}
		}
	}
}
