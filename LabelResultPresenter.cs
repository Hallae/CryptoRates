using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates
{
    internal sealed class LabelResultPresenter : IResultPresenter
    {
        private readonly Label _label;

        public LabelResultPresenter(Label label)
        {
            _label = label;
        }

        public void Update(string str)
        {
            _label.Text = str;
        }
    }
}
