using Binance.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates.CryptoPlatforms
{
    public sealed class BinanceExchangeRates : Exchange
    {
        private readonly BinanceRestClient client = new();
        public override string Name => "Binance";
        public BinanceExchangeRates(IResultPresenter resultPresenter) : base(resultPresenter)
        {
        }



        protected override async Task<decimal> Update()
        {
            try
            {
                var restClient = new BinanceRestClient();
                var ticker = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT");
                return ticker.Data.LastPrice;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
