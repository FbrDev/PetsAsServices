using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsAsServices
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarRaca abrirFormBuscarRaca = new frmBuscarRaca();
            abrirFormBuscarRaca.ShowDialog();
        }

        private void btnMenuFavoritos_Click(object sender, EventArgs e)
        {
            frmMeusFavoritos abrirFrmMeusFavoritos = new frmMeusFavoritos();
            abrirFrmMeusFavoritos.ShowDialog();
        }
    }
}
