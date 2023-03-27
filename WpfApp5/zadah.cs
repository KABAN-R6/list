using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class zadah
    {
        public string Text { get; set; }
        public Status status { get; set; }
        
        public zadah(string name,Status st)
        {
            Text = name;
            status = st;
        }
    }
    public enum Status
    {
        Active,
        Completed
    }
}
