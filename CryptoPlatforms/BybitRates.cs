﻿using Bybit.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates.CryptoPlatforms
{
    public sealed class BybitExchangeRates(IResultPresenter resultPresenter) : Exchange(resultPresenter)
    {
        private readonly BybitRestClient _client = new();

        public override string Name => "Bybit";

        protected override async Task<decimal> Update()
        {
            try
            {
                var restClient = new BybitRestClient();
                var tickerResult = await restClient.V5Api.ExchangeData.GetSpotTickersAsync("BTCUSDT");
                return tickerResult.Data.List.First().LastPrice;
            }
            catch (Exception)
            {
                return 0;// Null Data from api
            }
        }
    }
}
