using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webShow
{
    public class CreatWebEventArgs:EventArgs
    {
        public string statusText { get; set; }

        public string title { get; set; }
    }
}
