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
using System.Security.Cryptography;
using System.Xml.Linq;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using Proyecto_AceHats.Forms;

namespace Proyecto_AceHats
{
    public partial class formLogIn : Form
    {
        public formLogIn()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // Redondear bordes
            RedondearBoton(btnLogin, 50);

            // Eliminar bordes :skull:
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;

            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
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
            btnLogin.Cursor = Cursors.Hand;
        }

        private void lblAddUser_MouseEnter(object sender, EventArgs e)
        {
            lblAddUser.ForeColor = Color.Black;
            lblAddUser.Cursor = Cursors.Hand;
        }

        private void lblAddUser_MouseLeave(object sender, EventArgs e)
        {
            lblAddUser.ForeColor = Color.Gray;
        }

        private void lblAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSignIn login = new formSignIn();
            login.FormClosed += (a, args) => Application.Exit();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener y validad los campos
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Porfavor, llene todos los campos requeridos.", "Error: 004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ecriptar la contraseña igresada
            string encryptedPass = EncryptPass(pass);

            // Conexion a MySQL
            string connectionString = "server=192.168.1.3; database=proyecto_acehats; uid=newuser; pwd=Taddei98"; // LaPecerda
            // string connectionString = "server=localhost; database=proyecto_acehats; uid=root; pwd=admin"; // LaMaleducada

            // Prevencion de inyeccion SQL
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrir conexion
                    connection.Open(); // IMPORTANTE!!! PERDI 2 HORAS TRATANDO DE AVERIGUAR PORQUE 
                    //PUTAS MADRES LA APLICACION NO SE CONECTABA A LA BASE DE DATOS Y AL FINAL ERA QUE HABIA 
                    //BORRADO ESTA JODIDA LINEA DE MIERDAAAAAAAAAAA

                    // Consulta para verificar credenciales
                    string query = "SELECT id_usuario, nombre, usuario, rol FROM usuarios WHERE usuario = @usuario AND contraseña = @contraseña LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", user);
                        cmd.Parameters.AddWithValue("@contraseña", encryptedPass);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Guardar los datos del usuario en SessionData
                                SessionData.idUser = reader.GetInt32("id_usuario");
                                SessionData.name = reader.GetString("nombre");
                                SessionData.user = reader.GetString("usuario");
                                SessionData.rol = reader.GetString("rol");

                                // Abrir el formulario principal
                                formAceHats main = new formAceHats();
                                main.Show();

                                //Ocultar el formulario actual
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Credenciales incorrectas. Verifica los datos ingresados.", "Error: 006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesion: " + ex.Message, "Error: 002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
