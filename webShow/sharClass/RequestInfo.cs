using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webShow.sharClass
{
    public class RequestInfo
    {
        public class ImageResponse
        {
            private string messageName = "cn.dascom.cloudprint.pt.ImageResponse";
            private string messageType = "response";
            private List<string> functions = new List<string>() { "PDFConvert[1,0]" };
            public string imageInfo { get; set; }
        }
    }
}
