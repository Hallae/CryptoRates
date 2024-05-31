using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates
{
    public abstract class Exchange
    {
        private bool _isOnGoing;
        private readonly IResultPresenter _result;


        public abstract string Name { get; }
        protected abstract Task<decimal> Update();

        public Exchange(IResultPresenter result)
        {
            _result = result;
        }
        public async Task Start()
        {
            await StartInternal();
        }

        private async Task StartInternal()
        {
            _isOnGoing = true;
            while (_isOnGoing)
            {
                var result = await Update();
                _result.Update($"{Name}: {result}");
                await Task.Delay(5000);
            }
        }

        public void Stop()
        {
            _isOnGoing = false;
        }
    }
}
