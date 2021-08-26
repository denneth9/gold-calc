using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using money_calc;
using RestSharp;


namespace Gold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.MaxDate = DateTime.Today.AddDays(-1);
        }

        private void historic_CheckedChanged(object sender, EventArgs e)
        {
            goldprice = 0;
            if (historic.Checked)
            {
                monthCalendar1.Enabled = true;
                Size = new Size(248, 327);
            }
            else
            {
                monthCalendar1.Enabled = false;
                Size = new Size(248, 158);
            }
        }

        private void silver_CheckedChanged(object sender, EventArgs e)
        {
            goldprice = 0;
            if (silver.Checked)
            {
                goldlabel.Text = "Grams of Silver";
            }
            else
            {
                goldlabel.Text = "Grams of Gold";
            }
        }

        public string golddate = "0";
        public double goldprice;
        private void button1_Click(object sender, EventArgs e)
        {

            if (historic.Checked && changed)
            {
                changed = false;
                //MessageBox.Show(monthCalendar1.SelectionRange.Start.ToShortDateString());
                string datestring = monthCalendar1.SelectionRange.Start.ToShortDateString();
                string[] datestringsplit = datestring.Split("/");
                Array.Reverse(datestringsplit);
                datestring = String.Join("", datestringsplit);
                //MessageBox.Show(datestring);
                golddate = datestring;
            }

            if (goldprice == 0) //only get current price if something changed or you have not gotten it before
            {
                goldprice = GetGoldPrice();
            }

            pricelabel.Text = "Price per g: " + goldprice;

            try
            {
                if (pricetograms.Checked && price.Text != String.Empty)
                {
                    grams.Text = pricetogold(float.Parse(price.Text)).ToString();
                }
                else if (gramstoprice.Checked && grams.Text != String.Empty)
                {
                    price.Text = goldtoprice(float.Parse(grams.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter input");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong parsing inputs");
            }

        }
        public class goldresp
        {
            public double price { get; set; }

            /* example json
             * "timestamp":1629971640
               "metal":"XAU"
               "currency":"USD"
               "exchange":"FOREXCOM"
               "symbol":"FOREXCOM:XAUUSD"
               "prev_close_price":1791.23
               "open_price":1791.23
               "low_price":1783.43
               "high_price":1792.07
               "open_time":1629936000
               "price":1785.67
               "ch":-5.56
               "chp":-0.31
               "ask":1785.97
               "bid":1785.3
             */
        }

        public double GetGoldPrice()
        {
            try
            {
                string metal = "XAU";
                if (silver.Checked)
                {
                    metal = "XAG";
                }
                var client = new RestClient("https://www.goldapi.io/api/" + metal + "/EUR");

                if (historic.Checked)
                {

                    client = new RestClient("https://www.goldapi.io/api/" + metal + "/EUR/" + golddate);
                }
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-access-token", "goldapi-4c88kgtsksspmo0g-io");
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                //MessageBox.Show(response.ErrorMessage);
                if (response.Content == string.Empty)
                {
                    MessageBox.Show("something went wrong getting gold price");
                }
                else if (response.ErrorMessage == "No data available for this pair")
                {
                    MessageBox.Show("No data available for selected date");
                }
                else
                {
                    var content = response.Content; // raw content as string
                    //MessageBox.Show(content);
                    goldresp resp = JsonSerializer.Deserialize<goldresp>(content);
                    double goldpricegram = resp.price / 28.3495; //convert from ounce to gram
                    return goldpricegram;
                }

                return 0;
            }
            catch
            {
                MessageBox.Show("Something went wrong getting the price");
                return 0;
            }
        }

        public double pricetogold(float price)
        {
            double goldtotal = price / goldprice;
            return goldtotal;
        }

        public double goldtoprice(float grams)
        {
            double goldcost = goldprice * grams;
            return goldcost;
        }

        public bool changed = true;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            changed = true;
        }

        private void info_Click(object sender, EventArgs e)
        {
            var formPopup = new formPopup();
            formPopup.Show(this); // if you need non-modal window
        }
    }
}
