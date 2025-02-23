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

namespace Proyecto_AceHats
{
    public partial class singIn : Form
    {
        public singIn()
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

        private void lblForgotPass_MouseEnter(object sender, EventArgs e)
        {
            lblForgotPass.ForeColor = Color.Black;
            lblForgotPass.Cursor = Cursors.Hand;
        }

        private void lblForgotPass_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPass.ForeColor = Color.Gray;
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

        }
    }
}
