using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_RestConsumer
{
    public partial class Form1 : Form
    {
        bool sslEnabled = true;
        string URL = "http://localhost:8532/";
        string SslURL = "https://localhost:8533/";
        string urlParameters = "ep/pi";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestConsumer_Click(object sender, EventArgs e)
        {
            if (!sslEnabled)
            {
                CallSimpleRest();
            }

            else if (sslEnabled)
            {
                CallSslRest();
            }
        }

        private void CallSimpleRest()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("securityToken", "125");


            client.BaseAddress = new Uri(URL);

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                MessageBox.Show("StatusCode: " + response.StatusCode.ToString() + " - ReasonPhrase: " + response.ReasonPhrase);
            }
            client.Dispose();
        }

        private void CallSslRest()
        {
            //bypass Ssl Certificate Check, Dangerous CODE
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;


            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("securityToken", "125");


            client.BaseAddress = new Uri(SslURL);

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                MessageBox.Show("StatusCode: " + response.StatusCode.ToString() + " - ReasonPhrase: " + response.ReasonPhrase);
            }
            client.Dispose();
        }
    }
}
