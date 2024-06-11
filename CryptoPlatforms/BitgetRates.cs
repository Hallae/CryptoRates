using Bitget.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates.CryptoPlatforms
{
    public sealed class BitgetExchangeRates(IResultPresenter resultPresenter) : Exchange(resultPresenter)
    {
        private readonly BitgetRestClient client = new();
        public override string Name => "Bitget";

        protected override async Task<decimal> Update()
        {
            try
            {
                var restClient = new BitgetRestClient(); ;
                var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT");
             
                return tickerResult.Data?.ClosePrice ?? 0;


            }
            catch (Exception)
            {
                return 0;// Null Data from api
            }
        }
    }
}
