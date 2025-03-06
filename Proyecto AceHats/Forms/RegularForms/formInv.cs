using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_AceHats.Forms.RegularForms.subForms;
using MySql.Data.MySqlClient;
using Proyecto_AceHats.Classes;



namespace Proyecto_AceHats.Forms.RegularForms
{
    public partial class formInv: Form
    {
        private string placeHolderText = "Buscar por Nombre o Categoria"; // Cabiar el texto del placeholder de la barra de busqueda
        private formAceHats formMain;

        public formInv(formAceHats main)
        {
            InitializeComponent();

            // Configurar el placeholder al cargar el formulario
            txtSearch.Text = placeHolderText;
            txtSearch.ForeColor = Color.Gray;
            formMain = main;

            LoadProducts();
            ConfigureDGV();
        }

        private void ConfigureDGV()
        {
            // Agregar la columna de la imagen al DGV
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "Imagen";
            imgColumn.Name = "imagen_columna";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvInv.Columns.Add(imgColumn);
        }

        private void LoadProducts()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.connectionString))
                {
                    connection.Open();
                    string query = "SELECT nombre, codigo_barras, categoria, precio_compra, stock, imagen FROM productos";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using(MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvInv.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos." + ex.Message, "Error: 009", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            // Si al entrar el texto es el placeholder se elimina
            if (txtSearch.Text == placeHolderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            // Si al salir la barra de busqueda esta vacia, se coloca el placeholder
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeHolderText;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            formMain.OpenFormInPanel(new formAddGoods());
        }
    }
}
