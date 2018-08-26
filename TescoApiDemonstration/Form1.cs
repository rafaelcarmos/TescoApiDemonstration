using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TescoApiDemonstration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async void MakeRequest(string query, decimal offset, decimal limit)
        {
            var client = new HttpClient();

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "56ac439a92694577a2779f3d0ee0cd85");

            var uri = string.Format("https://dev.tescolabs.com/grocery/products/?query={0}&offset={1}&limit={2}", query, offset.ToString("N0"), limit.ToString("N0"));

            var response = await client.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("A problem occured: \n" + response.ToString());
                this.Invoke((MethodInvoker)delegate { btnGo.Enabled = true; });
                return;
            }

            string body = await response.Content.ReadAsStringAsync();

            var result = JObject.Parse(body);

            // get JSON result objects into a list
            IList<JToken> results = result["uk"]["ghs"]["products"]["results"].Children().ToList();

            // serialize JSON results into .NET objects
            IList<Product> products = new List<Product>();
            foreach (JToken r in results)
            {
                // JToken.ToObject is a helper method that uses JsonSerializer internally
                Product product = r.ToObject<Product>();

                string desc = "";

                if (product.LstDescription != null)
                    foreach (var str in product.LstDescription)
                        desc += " " + str;

                product.Description = desc;

                products.Add(product);
            }

            this.Invoke((MethodInvoker)delegate
            {
                txtQuery.Text = uri;
                btnGo.Enabled = true;
                bdsItems.DataSource = products;
            });

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            MakeRequest(txtSearch.Text, numOffset.Value, numLimit.Value);
        }

        private Stream DownloadData(string url)
        {
            WebRequest req = WebRequest.Create(url);
            WebResponse response = req.GetResponse();
            Stream stream = response.GetResponseStream();
            return stream;
        }



        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var product = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (product == null) return;

            var image = Image.FromStream(DownloadData(product.ImageURL));
            pictureBox.Image = image;
            lblName.Text = product.Name;
            lblPrice.Text = product.Price.ToString("C2") + " - Unit: " + product.ContentsQuantity;
            txtDescription.Text = product.Description;
            lblDepartment.Text = product.Department;
            lblSuperDepartment.Text = product.SuperDepartment;
        }
    }
}
