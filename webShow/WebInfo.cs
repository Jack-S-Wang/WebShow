using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;

namespace webShow
{
    public partial class WebInfo : UserControl
    {
        public WebInfo()
        {
            InitializeComponent();
        }
        [Description("跳转网页事件"), Browsable(false)]
        public event Action<object, CreatWebEventArgs> GetTitle;
        [Description("跳转新网页事件"), Browsable(false)]
        public event Action<object, CreatWebEventArgs> CreatNewWeb;
        [Description("网址"), Browsable(false)]
        public string lurl { get; set; }
        private void WebInfo_Load(object sender, EventArgs e)
        {
            if (lurl == "" || lurl==null)
            {
                lurl = "Http://www.baidu.com/";
            }
            this.web_show.Navigate(lurl);
            this.web_show.AllowNavigation = true;
            this.btn_back.Image = this.imageList1.Images[0];
            this.btn_next.Image = this.imageList1.Images[1];
            this.btn_refresh.Image = this.imageList1.Images[2];

        }

        private void bet_web_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.bet_web.Text != "")
            {
                var url = this.bet_web.Text;
                this.web_show.Navigate(url);
            }
        }

        private void web_show_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            CreatWebEventArgs ea = new CreatWebEventArgs();
            ea.title= this.web_show.Document.Title;
            GetTitle?.Invoke(sender, ea);
        }

        private void bet_web_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (this.bet_web.Text != "")
                {
                    var url = this.bet_web.Text;
                    this.web_show.Navigate(url);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (this.web_show.CanGoBack)
            {
                this.web_show.GoBack();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (this.web_show.CanGoForward)
            {
                this.web_show.GoForward();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (this.bet_web.Text != "")
            {
                var url = this.bet_web.Text;
                this.web_show.Navigate(url);
            }
        }

        private void web_show_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            CreatWebEventArgs ea = new CreatWebEventArgs();
            ea.statusText = web_show.StatusText;
            CreatNewWeb?.Invoke(sender, ea);
        }

        private void web_show_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            var url = e.Url.ToString();
            try
            {
                WebRequest quest = WebRequest.Create(url);
                this.bet_web.Text = url;
            }
            catch
            {
                return;
            }

        }
    }
}
