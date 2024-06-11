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
        private readonly KucoinRestClient _client = new();
        public override string Name => "Kucoin";
        public KucoinExchangeRates(IResultPresenter resultPresenter) : base(resultPresenter)
        {
        }
        protected override async Task<decimal> Update()
        {
            try
            {
                var usdFuturesTradeHistoryData = await _client.FuturesApi.ExchangeData.GetTickerAsync("BTCUSDT");
                return usdFuturesTradeHistoryData.Data?.Price ?? 0;
               
              
            
            }
            catch (Exception)
            {

                return 0; // Null Data from api
            }
        }
    }
}
