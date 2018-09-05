namespace webShow
{
    partial class WebInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebInfo));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.web_show = new System.Windows.Forms.WebBrowser();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_back = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bet_web = new DevExpress.XtraEditors.ButtonEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bet_web.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.web_show);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1181, 605);
            this.panelControl1.TabIndex = 0;
            // 
            // web_show
            // 
            this.web_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_show.Location = new System.Drawing.Point(2, 79);
            this.web_show.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_show.Name = "web_show";
            this.web_show.Size = new System.Drawing.Size(1177, 524);
            this.web_show.TabIndex = 1;
            this.web_show.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.web_show_Navigated);
            this.web_show.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.web_show_Navigating);
            this.web_show.NewWindow += new System.ComponentModel.CancelEventHandler(this.web_show_NewWindow);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_refresh);
            this.groupControl1.Controls.Add(this.btn_next);
            this.groupControl1.Controls.Add(this.btn_back);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.bet_web);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1177, 77);
            this.groupControl1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Appearance.Options.UseFont = true;
            this.btn_refresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_refresh.Location = new System.Drawing.Point(89, 35);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 24);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.ToolTip = "刷新";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_next
            // 
            this.btn_next.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Appearance.Options.UseFont = true;
            this.btn_next.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_next.Location = new System.Drawing.Point(53, 35);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(30, 24);
            this.btn_next.TabIndex = 3;
            this.btn_next.ToolTip = "返回下一页";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Appearance.Options.UseFont = true;
            this.btn_back.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_back.Location = new System.Drawing.Point(17, 35);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 24);
            this.btn_back.TabIndex = 2;
            this.btn_back.ToolTip = "返回上一页";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(151, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "网址：";
            // 
            // bet_web
            // 
            this.bet_web.EditValue = "";
            this.bet_web.Location = new System.Drawing.Point(213, 36);
            this.bet_web.Name = "bet_web";
            this.bet_web.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinRight)});
            this.bet_web.Size = new System.Drawing.Size(632, 20);
            this.bet_web.TabIndex = 0;
            this.bet_web.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bet_web_ButtonClick);
            this.bet_web.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bet_web_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "上一页 - 副本.png");
            this.imageList1.Images.SetKeyName(1, "下一页-副本.png");
            this.imageList1.Images.SetKeyName(2, "刷新 - 副本.png");
            // 
            // WebInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "WebInfo";
            this.Size = new System.Drawing.Size(1181, 605);
            this.Load += new System.EventHandler(this.WebInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bet_web.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.WebBrowser web_show;
        private DevExpress.XtraEditors.SimpleButton btn_next;
        private DevExpress.XtraEditors.SimpleButton btn_back;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private System.Windows.Forms.ImageList imageList1;
        public DevExpress.XtraEditors.ButtonEdit bet_web;
    }
}
