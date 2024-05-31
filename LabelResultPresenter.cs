using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates
{
    internal sealed class LabelResult(Label label) : IResultPresenter
    {
        private readonly Label _label = label;

        public void Update(string str)
        {
            _label.Text = str;
        }
    }
}
