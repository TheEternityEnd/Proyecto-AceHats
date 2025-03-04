using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Proyecto_AceHats.Forms.RegularForms.subForms
{
    public partial class formAddGoods: Form
    {

        private string connectionString = "server=192.168.1.3; database=proyecto_acehats; uid=newuser; pwd=Taddei98";
        private string relativeImageRute = null;

        public formAddGoods()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar Imagen",
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                relativeImageRute = SaveImageInLocalFolder(openFileDialog.FileName);
                pbImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarCode.Text) ||
                string.IsNullOrWhiteSpace(txtBuyPrice.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtRetailPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtWholesalePrice.Text) ||
                string.IsNullOrWhiteSpace(txtDesc.Text) ||
                string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Porfavor llena todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO productos (nombre, descripcion, codigo_barras, categoria, precio_compra, precio_menudeo, precio_mayoreo, stock, imagen) " +
                                   "VALUES (@nombre, @descripcion, @codigo_barras, @categoria, @precio_compra, @precio_menudeo, @precio_mayoreo, @stock, @imagen)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtName.Text);
                        cmd.Parameters.AddWithValue("@descripcion", txtDesc.Text);
                        cmd.Parameters.AddWithValue("@codigo_barras", txtBarCode.Text);
                        cmd.Parameters.AddWithValue("@categoria", cbCategory.Text);
                        cmd.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(txtBuyPrice.Text));
                        cmd.Parameters.AddWithValue("@precio_menudeo", Convert.ToDecimal(txtRetailPrice.Text));
                        cmd.Parameters.AddWithValue("@precio_mayoreo", Convert.ToDecimal(txtWholesalePrice.Text));
                        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                        cmd.Parameters.AddWithValue("@imagen", relativeImageRute ?? DBNull.Value.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Producto registrado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error: 007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SaveImageInLocalFolder(string ogRute)
        {
            try
            {
                string imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");

                if (!Directory.Exists(imageDirectory))
                {
                    Directory.CreateDirectory(imageDirectory);
                }

                string fileName = Path.GetFileName(ogRute);
                string goalRute = Path.Combine(imageDirectory, fileName);

                if (!File.Exists(goalRute))
                {
                    File.Copy(ogRute, goalRute);
                }

                // Retorna la ruta relativa a la carpeta del proyecto
                return Path.Combine("images", fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error: 008", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void CleanForm()
        {
            txtBarCode.Clear();
            txtBuyPrice.Clear();
            txtDesc.Clear();
            txtName.Clear();
            txtRetailPrice.Clear();
            txtStock.Clear();
            txtWholesalePrice.Clear();
            pbImage.Image = null;
            relativeImageRute = null;
        }
    }
}
