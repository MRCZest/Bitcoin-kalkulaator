using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Bitcoin_kalkulaator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float testvalue = float.TryParse(bitcoinamountinput.Text, out float );


            if (bitcoinamountinput.Text.ToString() == "")
            {
                MessageBox.Show("Please insert a valid amount of currency"); 
            }
            //else if (testvalue.GetType() != typeof(float)) {
            //    MessageBox.Show("Please insert a number");
            //}
            else if (currencyselector.Text.ToString() == "EUR")
            {
                resultlabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
            else if (currencyselector.Text.ToString() == "USD")
            {
                resultlabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                    float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                    resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.USD.code}";
            }
            else if (currencyselector.Text.ToString() == "GBP")
            {
                resultlabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.GBP.code}";
            }
            else if (currencyselector.Text.ToString() == "EEK")
            {
                resultlabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                double eestikroon = 15.64;
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float * (float)eestikroon;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
            }
            else
            {
                MessageBox.Show("Please select a currency.");
            }
        }

        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }
    }
}
