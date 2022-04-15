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
        private Button currentButton;
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button) btnSender)
                {
                    currentButton = (Button) btnSender;
                    currentButton.BackColor = Color.Green;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
