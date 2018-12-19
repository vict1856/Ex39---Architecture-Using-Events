using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter01
{
    public class CustomArgs : EventArgs
    {
		public string MessageBefore { get; set; }
        public string MessageAfter { get; set; }

        public CustomArgs(string before, string after)
        {
            MessageBefore = before;
            MessageAfter = after;
        }
    }
}
