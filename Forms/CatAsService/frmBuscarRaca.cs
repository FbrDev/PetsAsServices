using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using PetsAsServices.APIServices;
using RestSharp;

namespace PetsAsServices
{
    public partial class frmBuscarRaca : Form
    {
        private APIServices.CatAsService ApiCatAsService;

        public frmBuscarRaca()
        {
            InitializeComponent();
            ApiCatAsService = new APIServices.CatAsService();
        }

        private void frmBuscarRaca_Load(object sender, EventArgs e)
        {
            IncluiItems();
        }

        private void IncluiItems()
        {
            foreach (var obj in ApiCatAsService.GetCaracteristicas())
            {
                cbRaca.Items.Add(obj.name);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbRaca.SelectedIndex > 0)
            {
                string idRaca = cbRaca.Text;
                CarregaResultadoTela(ApiCatAsService.GetCaracteristicasPorID(idRaca));
            }
            else
            {
                MessageBox.Show("Selecione uma raça para Buscar");
                LimpaResultados();
            }
        }

        private void LimpaResultados()
        {
            lblTemperamento.Text = "Resultado";
            lblOrigem.Text = "Resultado";
            lblDescricao.Text = "Resultado";
            pictureBoxGatinho.Image = null;

        }

        private void CarregaResultadoTela(CatModel resultado)
        {
            lblDescricao.Text = resultado.description;
            lblOrigem.Text = resultado.origin;
            lblTemperamento.Text = resultado.temperament;
            pictureBoxGatinho.ImageLocation = ApiCatAsService.GetImagePorId(resultado.reference_image_id);
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            if (cbRaca.SelectedIndex > 0)
            {
                string idRaca = cbRaca.Text;
                FavoritarRaca(ApiCatAsService.GetCaracteristicasPorID(idRaca));
            }
            else
            {
                MessageBox.Show("Selecione uma raça para Favoritar");
            }
        }
        private void FavoritarRaca(CatModel resultado)
        {
            ApiCatAsService.FavoritarRacaPost(resultado.reference_image_id, resultado.name);
            MessageBox.Show($"A raça {resultado.name} foi favoritada com sucesso");
        }
    }
}
