using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetsAsServices.APIServices;

namespace PetsAsServices
{
    public partial class frmMeusFavoritos : Form
    {
        private APIServices.CatAsService apiCatAsService;
        public frmMeusFavoritos()
        {
            InitializeComponent();
            apiCatAsService = new APIServices.CatAsService();
            
        }
        private void frmMeusFavoritos_Load(object sender, EventArgs e)
        {
            if (lb1.SelectedItem == null)
                btnExcluirFavorito.Enabled = false;
            carregaCatFavoritos();
        }

        public void carregaCatFavoritos()
        {
            var result = apiCatAsService.GetFavorites();
            Object[] ItemObject = new Object[result.Count];
            for (int i = 0; i < result.Count; i++)
            {
                ItemObject[i] = result[i].sub_id;
            }
            lb1.Items.AddRange(ItemObject);
        }

        private void btnExcluirFavorito_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                btnExcluirFavorito.Enabled = true;
                try
                {
                    var itemSelecionado = lb1.SelectedItem.ToString();
                    var cat = apiCatAsService.GetFavorites().Find(model => model.sub_id == itemSelecionado);
                    var result = apiCatAsService.DeleteFavorites(cat.id);
                    if (result)
                    {
                        MessageBox.Show("Raça Favorita Excluida com Sucesso");
                        lb1.Items.Clear();
                        carregaCatFavoritos();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir a Raça favorita");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao recuperar favorito" + ex);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma raça para excluir!");
            }
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
                btnExcluirFavorito.Enabled = true;
        }
    }
}
