namespace GloomySpider
{
    partial class MainFrom
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.bttnStart = new MetroFramework.Controls.MetroButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listviewLog = new MetroFramework.Controls.MetroListView();
            this.bttnConditionSearch = new MetroFramework.Controls.MetroButton();
            this.listviewConditionSearchList = new MetroFramework.Controls.MetroListView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnBuy = new MetroFramework.Controls.MetroButton();
            this.btnSell = new MetroFramework.Controls.MetroButton();
            this.tbAccount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbStockCode = new MetroFramework.Controls.MetroTextBox();
            this.tbOrderQty = new MetroFramework.Controls.MetroTextBox();
            this.tbOrderPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI
            // 
            this.axKHOpenAPI.Enabled = true;
            this.axKHOpenAPI.Location = new System.Drawing.Point(9, 628);
            this.axKHOpenAPI.Name = "axKHOpenAPI";
            this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
            this.axKHOpenAPI.Size = new System.Drawing.Size(75, 28);
            this.axKHOpenAPI.TabIndex = 0;
            this.axKHOpenAPI.Visible = false;
            // 
            // bttnStart
            // 
            this.bttnStart.Location = new System.Drawing.Point(26, 72);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(83, 26);
            this.bttnStart.TabIndex = 1;
            this.bttnStart.Text = "Log In";
            this.bttnStart.UseSelectable = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 102);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // listviewLog
            // 
            this.listviewLog.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewLog.ForeColor = System.Drawing.Color.Black;
            this.listviewLog.FullRowSelect = true;
            this.listviewLog.GridLines = true;
            this.listviewLog.Location = new System.Drawing.Point(699, 72);
            this.listviewLog.MultiSelect = false;
            this.listviewLog.Name = "listviewLog";
            this.listviewLog.OwnerDraw = true;
            this.listviewLog.Size = new System.Drawing.Size(513, 572);
            this.listviewLog.TabIndex = 3;
            this.listviewLog.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listviewLog.UseCompatibleStateImageBehavior = false;
            this.listviewLog.UseSelectable = true;
            this.listviewLog.View = System.Windows.Forms.View.List;
            // 
            // bttnConditionSearch
            // 
            this.bttnConditionSearch.Location = new System.Drawing.Point(156, 241);
            this.bttnConditionSearch.Name = "bttnConditionSearch";
            this.bttnConditionSearch.Size = new System.Drawing.Size(83, 26);
            this.bttnConditionSearch.TabIndex = 4;
            this.bttnConditionSearch.Text = "조건 검색";
            this.bttnConditionSearch.UseSelectable = true;
            this.bttnConditionSearch.Click += new System.EventHandler(this.bttnConditionSearch_Click);
            // 
            // listviewConditionSearchList
            // 
            this.listviewConditionSearchList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewConditionSearchList.FullRowSelect = true;
            this.listviewConditionSearchList.GridLines = true;
            this.listviewConditionSearchList.Location = new System.Drawing.Point(27, 290);
            this.listviewConditionSearchList.MultiSelect = false;
            this.listviewConditionSearchList.Name = "listviewConditionSearchList";
            this.listviewConditionSearchList.OwnerDraw = true;
            this.listviewConditionSearchList.Size = new System.Drawing.Size(221, 111);
            this.listviewConditionSearchList.TabIndex = 5;
            this.listviewConditionSearchList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listviewConditionSearchList.UseCompatibleStateImageBehavior = false;
            this.listviewConditionSearchList.UseSelectable = true;
            this.listviewConditionSearchList.View = System.Windows.Forms.View.List;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(27, 241);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 26);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "조건 검색 Load";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(254, 423);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(107, 70);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "매수";
            this.btnBuy.UseSelectable = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(254, 499);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(107, 67);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "매도";
            this.btnSell.UseSelectable = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // tbAccount
            // 
            // 
            // 
            // 
            this.tbAccount.CustomButton.Image = null;
            this.tbAccount.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbAccount.CustomButton.Name = "";
            this.tbAccount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAccount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAccount.CustomButton.TabIndex = 1;
            this.tbAccount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAccount.CustomButton.UseSelectable = true;
            this.tbAccount.CustomButton.Visible = false;
            this.tbAccount.Lines = new string[0];
            this.tbAccount.Location = new System.Drawing.Point(100, 423);
            this.tbAccount.MaxLength = 32767;
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.PasswordChar = '\0';
            this.tbAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAccount.SelectedText = "";
            this.tbAccount.SelectionLength = 0;
            this.tbAccount.SelectionStart = 0;
            this.tbAccount.ShortcutsEnabled = true;
            this.tbAccount.Size = new System.Drawing.Size(148, 23);
            this.tbAccount.TabIndex = 9;
            this.tbAccount.UseSelectable = true;
            this.tbAccount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAccount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 426);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 20);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "주식계좌";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 456);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 20);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "종목코드";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 486);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 20);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "주문수량";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 546);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 20);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "주문가격";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 516);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 20);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "주문유형";
            // 
            // tbStockCode
            // 
            // 
            // 
            // 
            this.tbStockCode.CustomButton.Image = null;
            this.tbStockCode.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbStockCode.CustomButton.Name = "";
            this.tbStockCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbStockCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStockCode.CustomButton.TabIndex = 1;
            this.tbStockCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStockCode.CustomButton.UseSelectable = true;
            this.tbStockCode.CustomButton.Visible = false;
            this.tbStockCode.Lines = new string[] {
        "039490"};
            this.tbStockCode.Location = new System.Drawing.Point(100, 456);
            this.tbStockCode.MaxLength = 32767;
            this.tbStockCode.Name = "tbStockCode";
            this.tbStockCode.PasswordChar = '\0';
            this.tbStockCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStockCode.SelectedText = "";
            this.tbStockCode.SelectionLength = 0;
            this.tbStockCode.SelectionStart = 0;
            this.tbStockCode.ShortcutsEnabled = true;
            this.tbStockCode.Size = new System.Drawing.Size(148, 23);
            this.tbStockCode.TabIndex = 15;
            this.tbStockCode.Text = "039490";
            this.tbStockCode.UseSelectable = true;
            this.tbStockCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStockCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbOrderQty
            // 
            // 
            // 
            // 
            this.tbOrderQty.CustomButton.Image = null;
            this.tbOrderQty.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbOrderQty.CustomButton.Name = "";
            this.tbOrderQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbOrderQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbOrderQty.CustomButton.TabIndex = 1;
            this.tbOrderQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbOrderQty.CustomButton.UseSelectable = true;
            this.tbOrderQty.CustomButton.Visible = false;
            this.tbOrderQty.Lines = new string[0];
            this.tbOrderQty.Location = new System.Drawing.Point(100, 486);
            this.tbOrderQty.MaxLength = 32767;
            this.tbOrderQty.Name = "tbOrderQty";
            this.tbOrderQty.PasswordChar = '\0';
            this.tbOrderQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbOrderQty.SelectedText = "";
            this.tbOrderQty.SelectionLength = 0;
            this.tbOrderQty.SelectionStart = 0;
            this.tbOrderQty.ShortcutsEnabled = true;
            this.tbOrderQty.Size = new System.Drawing.Size(148, 23);
            this.tbOrderQty.TabIndex = 16;
            this.tbOrderQty.UseSelectable = true;
            this.tbOrderQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbOrderQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbOrderPrice
            // 
            // 
            // 
            // 
            this.tbOrderPrice.CustomButton.Image = null;
            this.tbOrderPrice.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbOrderPrice.CustomButton.Name = "";
            this.tbOrderPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbOrderPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbOrderPrice.CustomButton.TabIndex = 1;
            this.tbOrderPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbOrderPrice.CustomButton.UseSelectable = true;
            this.tbOrderPrice.CustomButton.Visible = false;
            this.tbOrderPrice.Lines = new string[0];
            this.tbOrderPrice.Location = new System.Drawing.Point(100, 545);
            this.tbOrderPrice.MaxLength = 32767;
            this.tbOrderPrice.Name = "tbOrderPrice";
            this.tbOrderPrice.PasswordChar = '\0';
            this.tbOrderPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbOrderPrice.SelectedText = "";
            this.tbOrderPrice.SelectionLength = 0;
            this.tbOrderPrice.SelectionStart = 0;
            this.tbOrderPrice.ShortcutsEnabled = true;
            this.tbOrderPrice.Size = new System.Drawing.Size(148, 23);
            this.tbOrderPrice.TabIndex = 18;
            this.tbOrderPrice.UseSelectable = true;
            this.tbOrderPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbOrderPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(100, 519);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(63, 17);
            this.metroRadioButton1.TabIndex = 19;
            this.metroRadioButton1.Text = "지정가";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(176, 519);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(63, 17);
            this.metroRadioButton2.TabIndex = 20;
            this.metroRadioButton2.Text = "시장가";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 661);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.tbOrderPrice);
            this.Controls.Add(this.tbOrderQty);
            this.Controls.Add(this.tbStockCode);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listviewConditionSearchList);
            this.Controls.Add(this.bttnConditionSearch);
            this.Controls.Add(this.listviewLog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.axKHOpenAPI);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainFrom";
            this.Padding = new System.Windows.Forms.Padding(22, 69, 22, 23);
            this.Text = "Gloomy Spider";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private MetroFramework.Controls.MetroButton bttnStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroListView listviewLog;
        private MetroFramework.Controls.MetroButton bttnConditionSearch;
        private MetroFramework.Controls.MetroListView listviewConditionSearchList;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnBuy;
        private MetroFramework.Controls.MetroButton btnSell;
        private MetroFramework.Controls.MetroTextBox tbAccount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbStockCode;
        private MetroFramework.Controls.MetroTextBox tbOrderQty;
        private MetroFramework.Controls.MetroTextBox tbOrderPrice;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
    }
}

