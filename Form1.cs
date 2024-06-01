using Binance.Net;
using Bybit.Net;
using CryptoRates.CryptoPlatforms;
using Kucoin.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoRates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var binance = new BinanceExchangeRates(new LabelResultPresenter(BinanceLabel));
            var bybit = new BybitExchangeRates(new LabelResultPresenter(BybitLabel));
            var kucoin = new KucoinExchangeRates(new LabelResultPresenter(KucoinLabel));
            var bitget = new BitgetExchangeRates(new LabelResultPresenter(BitgetLabel));
            binance.Start();
            bybit.Start();
            kucoin.Start();
            bitget.Start();
        }

        private void BinanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void BybitLabel_Click(object sender, EventArgs e)
        {

        }

         private void KucoinLabel_Click(object sender, EventArgs e)
        {

        }

         private void BitgetLabel_Click(object sender, EventArgs e)
         {

         }
     
    }
}
