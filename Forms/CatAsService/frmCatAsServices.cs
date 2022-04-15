using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsAsServices.Forms.CatAsService
{
    public partial class frmCatAsServices : Form
    {
        public frmCatAsServices()
        {
            InitializeComponent();
        }

        private void frmCatAsServices_Load(object sender, EventArgs e)
        {

        }
        private void btnRacas_Click(object sender, EventArgs e)
        {
            frmBuscarRaca abrirFormBuscarRaca = new frmBuscarRaca();
            abrirFormBuscarRaca.ShowDialog();
        }

        private void btnMeusFavoritos_Click(object sender, EventArgs e)
        {
            frmMeusFavoritos abrirFrmMeusFavoritos = new frmMeusFavoritos();
            abrirFrmMeusFavoritos.ShowDialog();
        }

        private void btnMenuBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarRaca abrirFormBuscarRaca = new frmBuscarRaca();
            abrirFormBuscarRaca.ShowDialog();
        }

        // Para Carregar cores no botão
        //private void LoadTheme()
        //{
        //    foreach (Control btns in this.Controls)
        //    {
        //        if (btns.GetType() == typeof(Button))
        //        {
        //            Button btn = (Button)btns;
        //            btn.BackColor = ThemeColor.PrimaryColor;
        //            btn.ForeColor = Color.White;
        //            btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        //        }
        //    }
        //}
    }
}
