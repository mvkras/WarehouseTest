using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace TestWarehouseProject
{
    public partial class Form1 : Form
    {              
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = TestWarehouse; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            
            
            try
            {
                await connection.OpenAsync();
                string showAllInfo = "EXECUTE Warehouse_Info";               
                SqlDataAdapter adapter = new SqlDataAdapter(showAllInfo, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                MaindataGridView.DataSource = ds.Tables[0];
                MaindataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Полное выделение строки
                MaindataGridView.ReadOnly = true; //только для чтения, чтобы нельзя было изменить данные
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {            
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close(); //закрываем соединение                       
                }
                
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
