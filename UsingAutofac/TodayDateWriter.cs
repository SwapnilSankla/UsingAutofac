using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAutofac
{
    class TodayDateWriter : IDateWriter
    {
        private IOutput _output;

        public TodayDateWriter(IOutput output)
        {
            _output = output;
        }

        public void WriteDate()
        {
            _output.Write(DateTime.Now.Date.ToString());
        }
    }
}
