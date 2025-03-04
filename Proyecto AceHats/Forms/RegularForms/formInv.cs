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
