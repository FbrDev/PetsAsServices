using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace PetsAsServices
{
    public partial class frmBuscarRaca : Form
    {
        private string _name { get; set;}

        public frmBuscarRaca()
        {
            InitializeComponent();
        }

        private void frmBuscarRaca_Load(object sender, EventArgs e)
        {
            IncluiItems();
        }

        private async void IncluiItems()
        {
            var client = new RestClient($"https://api.thecatapi.com/v1/breeds");
            RestRequest request = new RestRequest("", Method.Get);
            var response = await client.ExecuteGetAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = response.Content;
                List<CatJsonToClass> myDeserializedObjList = (List<CatJsonToClass>)JsonConvert.DeserializeObject(content, typeof(List<CatJsonToClass>));

                foreach (var obj in myDeserializedObjList)
                {
                    cbRaca.Items.Add(obj.name);
                }
            }
            else
            {
                var error = response.ErrorMessage;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _name = cbRaca.SelectedItem.ToString();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var client = new RestClient($"https://api.thecatapi.com/v1/breeds/search?q={_name}");
            RestRequest request = new RestRequest("", Method.Get);
            var response = await client.ExecuteGetAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = response.Content;
                List<CatJsonToClass> myDeserializedObjList = (List<CatJsonToClass>)JsonConvert.DeserializeObject(content, typeof(List<CatJsonToClass>));

                foreach (var myDeserializedObj in myDeserializedObjList)
                {
                    lblResult1.Text = myDeserializedObj.temperament;
                    lblResult2.Text = myDeserializedObj.origin;
                    lblResult3.Text = myDeserializedObj.description;
                }
            }
            else
            {
                var error = response.ErrorMessage;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
