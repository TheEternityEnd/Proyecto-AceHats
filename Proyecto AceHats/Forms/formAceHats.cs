using Proyecto_AceHats.Forms.AdminForms;
using Proyecto_AceHats.Forms.RegularForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Proyecto_AceHats.Forms
{
    public partial class formAceHats: Form
    {
        public formAceHats()
        {
            InitializeComponent();
        }

        // Radio para redondear las esquinas
        int radius = 30;

        private void RoundPanelCorners(Panel panel, int radio)
        {
            GraphicsPath gp = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

            gp.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            gp.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
            gp.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
            gp.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);

            panel.Region = new Region(gp);
        }

        private void AceHats_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            // Un rectangulo que representa el area del formulario
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Los arcos de las esquinas
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);

            RoundPanelCorners(panelMain, radius);

            // Eliminar bordes de los botones
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;

            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;

            // Actualizacion de etiquetas del usuario que inicio sesion
            lblName.Text = SessionData.name;
            lblUser.Text = SessionData.user;

            // Etiqueta por si el usuario es administrador
            if (SessionData.rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                lblAdmin.Visible = true;
            }
            else
            {
                lblAdmin.Visible = false;
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// ============== DISEÑO DE LOS LABELS (((IGNORAR))) ============== \\\
        /// </summary>
        private void lblDashboard_MouseEnter(object sender, EventArgs e)
        {
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Cursor = Cursors.Hand;
        }

        private void lblDashboard_MouseLeave(object sender, EventArgs e)
        {
            lblDashboard.ForeColor = Color.Gray;
        }

        private void lblInv_MouseEnter(object sender, EventArgs e)
        {
            lblInv.ForeColor = Color.White;
            lblInv.Cursor = Cursors.Hand;
        }

        private void lblInv_MouseLeave(object sender, EventArgs e)
        {
            lblInv.ForeColor = Color.Gray;
        }

        private void lblPriceG_MouseEnter(object sender, EventArgs e)
        {
            lblPriceG.ForeColor = Color.White;
            lblPriceG.Cursor = Cursors.Hand;
        }

        private void lblPriceG_MouseLeave(object sender, EventArgs e)
        {
            lblPriceG.ForeColor = Color.Gray;
        }

        private void lblAside_MouseEnter(object sender, EventArgs e)
        {
            lblAside.ForeColor = Color.White;
            lblAside.Cursor = Cursors.Hand;
        }

        private void lblAside_MouseLeave(object sender, EventArgs e)
        {
            lblAside.ForeColor = Color.Gray;
        }

        private void lblPayments_MouseEnter(object sender, EventArgs e)
        {
            lblPayments.ForeColor = Color.White;
            lblPayments.Cursor = Cursors.Hand;
        }

        private void lblPayments_MouseLeave(object sender, EventArgs e)
        {
            lblPayments.ForeColor = Color.Gray;
        }

        private void lblShipping_MouseEnter(object sender, EventArgs e)
        {
            lblShipping.ForeColor = Color.White;
            lblShipping.Cursor = Cursors.Hand;
        }

        private void lblShipping_MouseLeave(object sender, EventArgs e)
        {
            lblShipping.ForeColor = Color.Gray;
        }

        private void lblSaleReview_MouseEnter(object sender, EventArgs e)
        {
            lblSaleReview.ForeColor = Color.White;
            lblSaleReview.Cursor = Cursors.Hand;
        }

        private void lblSaleReview_MouseLeave(object sender, EventArgs e)
        {
            lblSaleReview.ForeColor = Color.Gray;
        }

        private void lblAdmin_MouseEnter(object sender, EventArgs e)
        {
            lblAdmin.ForeColor = Color.White;
            lblAdmin.Cursor = Cursors.Hand;
        }
        private void lblAdmin_MouseLeave(object sender, EventArgs e)
        {
            lblAdmin.ForeColor = Color.Gray;
        }

        private void lblSignOut_MouseEnter(object sender, EventArgs e)
        {
            lblSignOut.ForeColor = Color.White;
            lblSignOut.Cursor = Cursors.Hand;
        }
        private void lblSignOut_MouseLeave(object sender, EventArgs e)
        {
            lblSignOut.ForeColor = Color.Gray;
        }
        /// <summary>
        /// ============== FIN DISEÑO DE LOS LABELS (((IGNORAR))) ============== \\\
        /// </summary>
        
        private void lblDashboard_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formDashboard formVer = new formDashboard();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }

        private void lblInv_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formInv formVer = new formInv();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }

        private void lblPriceG_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formPriceG formVer = new formPriceG();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }

        private void lblAside_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formAside formVer = new formAside();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }

        private void lblPayments_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formPayments formVer = new formPayments();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }

        private void lblShipping_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formShipping formVer = new formShipping();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }

        private void lblSaleReview_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formSaleReview formVer = new formSaleReview();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }

        // Formulario exclusivo para administradores
        private void lblAdmin_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            formAdmin formVer = new formAdmin();

            // Configuracion del formulario para que se comporte como control
            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelMain.Controls.Add(formVer);
            panelMain.Tag = formVer;

            formVer.Show();
        }
    }
}
