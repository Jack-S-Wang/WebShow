using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webShow.sharClass;

namespace webShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.xtraTabControl1.CustomHeaderButtons[1].Image = this.imageList1.Images[0];
                if (this.WindowState == FormWindowState.Normal)
                    this.xtraTabControl1.CustomHeaderButtons[2].Image = this.imageList1.Images[1];
                else
                    this.xtraTabControl1.CustomHeaderButtons[2].Image = this.imageList1.Images[2];
                this.xtraTabControl1.CustomHeaderButtons[3].Image = this.imageList1.Images[3];
                this.xtraTabControl1.CustomHeaderButtons[0].Image = this.imageList1.Images[4];
                this.webInfo1.GetTitle += WebInfo1_GetTitle;
                this.webInfo1.CreatNewWeb += WebInfo1_CreatNewWeb;
                SeverLink server = new SeverLink();
                server.ConnectSocket();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WebInfo1_CreatNewWeb(object arg1, CreatWebEventArgs arg2)
        {
            try
            {
                XtraTabPage page = new XtraTabPage();
                PanelControl panel = new PanelControl();
                panel.Dock = DockStyle.Fill;
                WebInfo webf = new WebInfo();
                webf.Dock = DockStyle.Fill;
                webf.GetTitle += WebInfo1_GetTitle;
                webf.CreatNewWeb += WebInfo1_CreatNewWeb;
                webf.bet_web.Text = arg2.statusText;
                webf.lurl = arg2.statusText;
                panel.Controls.Add(webf);
                page.Controls.Add(panel);
                this.xtraTabControl1.TabPages.Add(page);
                this.xtraTabControl1.SelectedTabPage = this.xtraTabControl1.TabPages[this.xtraTabControl1.TabPages.Count - 1];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WebInfo1_GetTitle(object arg1, CreatWebEventArgs arg2)
        {
            if (arg2.title != "")
            {
                this.xtraTabControl1.SelectedTabPage.Text = arg2.title;
            }
        }


        private void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            try
            {
                if (e.Button == this.xtraTabControl1.CustomHeaderButtons[2])
                {
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        this.WindowState = FormWindowState.Maximized;
                        this.xtraTabControl1.CustomHeaderButtons[2].Image = this.imageList1.Images[2];
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Normal;
                        this.xtraTabControl1.CustomHeaderButtons[2].Image = this.imageList1.Images[1];
                    }
                }
                else if (e.Button == this.xtraTabControl1.CustomHeaderButtons[1])
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                else if (e.Button == this.xtraTabControl1.CustomHeaderButtons[3])
                {
                    this.Close();
                }
                else if (e.Button == this.xtraTabControl1.CustomHeaderButtons[0])
                {
                    XtraTabPage page = new XtraTabPage();
                    PanelControl panel = new PanelControl();
                    panel.Dock = DockStyle.Fill;
                    WebInfo webf = new WebInfo();
                    webf.Dock = DockStyle.Fill;
                    webf.GetTitle += WebInfo1_GetTitle;
                    webf.CreatNewWeb += WebInfo1_CreatNewWeb;
                    webf.lurl = "";
                    panel.Controls.Add(webf);
                    page.Controls.Add(panel);
                    page.Text = "新标签页";
                    this.xtraTabControl1.TabPages.Add(page);
                    this.xtraTabControl1.SelectedTabPage = this.xtraTabControl1.TabPages[this.xtraTabControl1.TabPages.Count - 1];
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs a = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
                XtraTabPage page = (XtraTabPage)a.Page;
                page.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Point sp = new Point();
        private void xtraTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
        }

        private void xtraTabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X - sp.X;
            int y = e.Y - sp.Y;
            var p = this.Location;
            this.Location = new Point(p.X + x, p.Y + y);
        }
        
    }
}
