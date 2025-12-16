using System.Net;
using Newtonsoft.Json;

namespace MyBTCCalculator
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (currencySelector.SelectedItem.ToString() != "USD" &&
                    currencySelector.SelectedItem.ToString() != "EUR" &&
                    currencySelector.SelectedItem.ToString() != "GBP" &&
                    currencySelector.SelectedItem.ToString() != "EEK" //||
                    //currencySelector.SelectedItem. == null
                    )
                {
                    MessageBox.Show("Error", "VALUUTA ON VALIMATA");
                }
                else if (currencySelector.SelectedItem.ToString() == "USD")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountInput.Text) * newRate.Data.BTCUSD.VALUE);
                    CalcResult.Text = result.ToString();
                }
                else if (currencySelector.SelectedItem.ToString() == "EUR")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountInput.Text) * newRate.Data.BTCEUR.VALUE);
                    CalcResult.Text = result.ToString();
                }
                else if (currencySelector.SelectedItem.ToString() == "GBP")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountInput.Text) * newRate.Data.BTCGBP.VALUE);
                    CalcResult.Text = result.ToString();
                }
                else if (currencySelector.SelectedItem.ToString() == "EEK")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountInput.Text) * newRate.Data.BTCEUR.VALUE * 15.6466);
                    CalcResult.Text = result.ToString();
                }

            }
            catch (Exception ex)
                {
                MessageBox.Show($"Tekkis viga, vea detailid: {ex.Message}");
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static BitcoinRates BitcoinRates()
        {
            string URL = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR,BTC-GBP&apply_mapping=true&api_key=ea098fc4354369facd575d4b2c22bb0d27f26e7ed821db004387f8777e335687";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates newbitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                newbitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return newbitcoin;
        }
    }
}
