using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient; // Libreria MySQL.Data en NuGet
using Org.BouncyCastle.Tls;
using System.Security.Cryptography;

namespace Proyecto_AceHats
{
    public partial class formSignIn : Form
    {
        public formSignIn()
        {
            InitializeComponent();
        }

        // Funcion para encriptar la contraseña usando SHA256
        private string EncryptPass(string pass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            // Redondear bordes
            RedondearBoton(btnRegister, 50);

            // Eliminar bordes :skull:
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;

            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;

            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
        }

        private void RedondearBoton(Button btn, int radio) // Funcion para redonear los bordes de los botones [as]
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);

            // No tengo ni la mas minima idea de porque carajos esto funciona, supongo que simplemete lo hace. NO LO TOQUES
            // radio, radio, radio, radio, radio
            // radio, radio, radio, radio, radio
            // radio, radio, radio, radio, radio
            // radio, radio, radio, radio, radio
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.Cursor = Cursors.Hand;
        }

        private void lblAddUser_MouseEnter(object sender, EventArgs e)
        {
            lblReturn.ForeColor = Color.Black;
            lblReturn.Cursor = Cursors.Hand;
        }

        private void lblAddUser_MouseLeave(object sender, EventArgs e)
        {
            lblReturn.ForeColor = Color.Gray;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string name = txtName.Text.Trim();
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;
            string confirmPass = txtConfirmPass.Text;
            string rol = rbAdmin.Checked ? "Administrador" : "Cajero";

            // Validar que los campos no esten vacios
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(confirmPass) || !rbAdmin.Checked && !rbCashier.Checked)
            {
                MessageBox.Show("Porfavor, llene todos los campos requeridos.", "Error: 004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar las contraseñas
            if (pass != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error: 001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Encriptar la contraseña
            string encryptedPass = EncryptPass(pass);

            // Conexion a MySQL
            string connectionString = "server=192.168.1.3; database=proyecto_acehats; uid=newuser; pwd=Taddei98"; // LaPecerda
            // string connectionString = "server=localhost; database=proyecto_acehats; uid=root; pwd=admin"; // LaMaleducada
        
            // Prevencion de inyeccion SQL
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar si el usuario existe
                    string verification = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
                    using (MySqlCommand cmdVerification = new MySqlCommand(verification, connection))
                    {
                        cmdVerification.Parameters.AddWithValue("@usuario", user);
                        int count = Convert.ToInt32(cmdVerification.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("El usuario ya existe, favor de elegir otro.", "Error: 003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Si el usuario esta disponible ahora si se ejecuta esto
                    string query = "INSERT INTO usuarios (nombre, usuario, contraseña, rol) VALUES (@nombre, @usuario, @contraseña, @rol)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", name);
                        cmd.Parameters.AddWithValue("@usuario", user);
                        cmd.Parameters.AddWithValue("@contraseña", encryptedPass);
                        cmd.Parameters.AddWithValue("@rol", rol);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error: 002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogIn signin = new formLogIn();
            signin.FormClosed += (a, args) => Application.Exit();
            signin.Show();
        }
    }
}
