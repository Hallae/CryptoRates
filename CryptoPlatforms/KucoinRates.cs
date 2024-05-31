using Kucoin.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates.CryptoPlatforms
{
    public sealed class KucoinExchangeRates : Exchange
    {
        private readonly KucoinRestClient client = new();
        public override string Name => "Kucoin";
        public KucoinExchangeRates(IResultPresenter resultPresenter) : base(resultPresenter)
        {
        }
        protected override async Task<decimal> Update()
        {
            try
            {

                var restClient = new KucoinRestClient();
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT");
                var lastPrice = tickerResult.Data.LastPrice;
                return tickerResult.Data?.LastPrice ?? 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
