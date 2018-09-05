using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace webShow.sharClass
{
    public class SeverLink
    {
        public void ConnectSocket()
        {
            var web = new WebSocketServer("ws://192.168.136.1:8080");
            web.AddWebSocketService<Laputa>("/Connect");
            web.Start();
        }
        public class Laputa : WebSocketBehavior
        {
            private static List<WebSocket> CONNECT_POOL = new List<WebSocket>();//用户连接池
            protected override void OnOpen()
            {
                base.OnOpen();
                WebSocket socket = Context.WebSocket;
                CONNECT_POOL.Add(socket);
            }
            protected override void OnMessage(MessageEventArgs e)
            {
                base.OnMessage(e);
                try
                {
                    JObject jb = JObject.Parse(e.Data);
                    if ((string)jb["messageType"] == "request")
                    {
                        if ((string)jb["messageName"] == "cn.dascom.cloudprint.pt.ImageRequest")
                        {
                            string fileName = (string)jb["fileName"];
                            PdfToImage pi = new PdfToImage();
                            byte[] data = pi.getBitmap(fileName);
                            string imageInfo = Convert.ToBase64String(data);
                            RequestInfo.ImageResponse ir = new RequestInfo.ImageResponse()
                            {
                                imageInfo = imageInfo
                            };
                            var json = JsonConvert.SerializeObject(ir);
                            Send(json);
                        }
                        else if((string)jb["messageName"] == "cn.dascom.cloudprint.pt.NegotiateRequest")
                        {

                        }
                    }
                    else
                    {

                    }
                }catch(Exception ex)
                {
                    throw new Exception("服务连接有问题！"+ex.Message);
                }
            }
            protected override void OnError(ErrorEventArgs e)
            {
                base.OnError(e);
                WebSocket socket = Context.WebSocket;
                if (CONNECT_POOL.Contains(socket))
                {
                    CONNECT_POOL.Remove(socket);
                }
            }
            protected override void OnClose(CloseEventArgs e)
            {
                base.OnClose(e);
                WebSocket socket = Context.WebSocket;
                if (CONNECT_POOL.Contains(socket))
                {
                    CONNECT_POOL.Remove(socket);
                }
            }
        }
    }
}
