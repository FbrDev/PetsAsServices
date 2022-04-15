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
            lbFavoritos.Items.AddRange(ItemObject);
        }
    }
}
