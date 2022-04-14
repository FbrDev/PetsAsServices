using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsAsServices.APIServices
{
    public class CatModel
    {
        public string id { get; set; }

        public string name { get; set; }

        public string temperament { get; set; }

        public string origin { get; set; }

        public string description { get; set; }

        public string url { get; set; }

        public string reference_image_id { get; set; }
    }
}