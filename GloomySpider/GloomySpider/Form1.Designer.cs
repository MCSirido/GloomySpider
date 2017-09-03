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
            this.listviewConditionSearchList = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnConditionLoad = new MetroFramework.Controls.MetroButton();
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
            this.bttnConditionSearchStart = new MetroFramework.Controls.MetroButton();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.listviewStockResult = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbAcc예수금 = new MetroFramework.Controls.MetroTextBox();
            this.tbAcc총평가금액 = new MetroFramework.Controls.MetroTextBox();
            this.tbAcc총수익률 = new MetroFramework.Controls.MetroTextBox();
            this.tbAcc총손익금 = new MetroFramework.Controls.MetroTextBox();
            this.listviewAccStock = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.btnPossibleCnt = new MetroFramework.Controls.MetroButton();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.panel1.SuspendLayout();
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
            // listviewConditionSearchList
            // 
            this.listviewConditionSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listviewConditionSearchList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewConditionSearchList.FullRowSelect = true;
            this.listviewConditionSearchList.GridLines = true;
            this.listviewConditionSearchList.Location = new System.Drawing.Point(386, 72);
            this.listviewConditionSearchList.MultiSelect = false;
            this.listviewConditionSearchList.Name = "listviewConditionSearchList";
            this.listviewConditionSearchList.OwnerDraw = true;
            this.listviewConditionSearchList.Size = new System.Drawing.Size(332, 257);
            this.listviewConditionSearchList.TabIndex = 5;
            this.listviewConditionSearchList.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listviewConditionSearchList.UseCompatibleStateImageBehavior = false;
            this.listviewConditionSearchList.UseSelectable = true;
            this.listviewConditionSearchList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "조건번호";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "조건명";
            this.columnHeader2.Width = 200;
            // 
            // bttnConditionLoad
            // 
            this.bttnConditionLoad.Location = new System.Drawing.Point(26, 104);
            this.bttnConditionLoad.Name = "bttnConditionLoad";
            this.bttnConditionLoad.Size = new System.Drawing.Size(154, 26);
            this.bttnConditionLoad.TabIndex = 6;
            this.bttnConditionLoad.Text = "조건 검색 Load";
            this.bttnConditionLoad.UseSelectable = true;
            this.bttnConditionLoad.Click += new System.EventHandler(this.bttnConditionLoad_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(253, 146);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(107, 70);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "매수";
            this.btnBuy.UseSelectable = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(253, 222);
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
            this.tbAccount.Location = new System.Drawing.Point(99, 146);
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
            this.metroLabel1.Location = new System.Drawing.Point(26, 149);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 20);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "주식계좌";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 179);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 20);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "종목코드";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 209);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 20);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "주문수량";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 269);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 20);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "주문가격";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 239);
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
            this.tbStockCode.Location = new System.Drawing.Point(99, 179);
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
            this.tbOrderQty.Location = new System.Drawing.Point(99, 209);
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
            this.tbOrderPrice.Location = new System.Drawing.Point(99, 268);
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
            this.metroRadioButton1.Location = new System.Drawing.Point(99, 242);
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
            this.metroRadioButton2.Checked = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(175, 242);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(63, 17);
            this.metroRadioButton2.TabIndex = 20;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "시장가";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // bttnConditionSearchStart
            // 
            this.bttnConditionSearchStart.Location = new System.Drawing.Point(186, 104);
            this.bttnConditionSearchStart.Name = "bttnConditionSearchStart";
            this.bttnConditionSearchStart.Size = new System.Drawing.Size(174, 26);
            this.bttnConditionSearchStart.TabIndex = 21;
            this.bttnConditionSearchStart.Text = "조건 검색 시작";
            this.bttnConditionSearchStart.UseSelectable = true;
            this.bttnConditionSearchStart.Click += new System.EventHandler(this.bttnConditionSearchStart_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(741, 72);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(463, 595);
            this.richTextBoxLog.TabIndex = 22;
            this.richTextBoxLog.Text = "";
            // 
            // listviewStockResult
            // 
            this.listviewStockResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listviewStockResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewStockResult.FullRowSelect = true;
            this.listviewStockResult.GridLines = true;
            this.listviewStockResult.Location = new System.Drawing.Point(386, 352);
            this.listviewStockResult.MultiSelect = false;
            this.listviewStockResult.Name = "listviewStockResult";
            this.listviewStockResult.OwnerDraw = true;
            this.listviewStockResult.Size = new System.Drawing.Size(332, 315);
            this.listviewStockResult.TabIndex = 23;
            this.listviewStockResult.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listviewStockResult.UseCompatibleStateImageBehavior = false;
            this.listviewStockResult.UseSelectable = true;
            this.listviewStockResult.View = System.Windows.Forms.View.Details;
            this.listviewStockResult.SelectedIndexChanged += new System.EventHandler(this.listviewStockResult_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "종목명";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "현재가";
            this.columnHeader4.Width = 100;
            // 
            // tbAcc예수금
            // 
            // 
            // 
            // 
            this.tbAcc예수금.CustomButton.Image = null;
            this.tbAcc예수금.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tbAcc예수금.CustomButton.Name = "";
            this.tbAcc예수금.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAcc예수금.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAcc예수금.CustomButton.TabIndex = 1;
            this.tbAcc예수금.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAcc예수금.CustomButton.UseSelectable = true;
            this.tbAcc예수금.CustomButton.Visible = false;
            this.tbAcc예수금.Lines = new string[0];
            this.tbAcc예수금.Location = new System.Drawing.Point(26, 352);
            this.tbAcc예수금.MaxLength = 32767;
            this.tbAcc예수금.Name = "tbAcc예수금";
            this.tbAcc예수금.PasswordChar = '\0';
            this.tbAcc예수금.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAcc예수금.SelectedText = "";
            this.tbAcc예수금.SelectionLength = 0;
            this.tbAcc예수금.SelectionStart = 0;
            this.tbAcc예수금.ShortcutsEnabled = true;
            this.tbAcc예수금.Size = new System.Drawing.Size(136, 23);
            this.tbAcc예수금.TabIndex = 24;
            this.tbAcc예수금.UseSelectable = true;
            this.tbAcc예수금.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAcc예수금.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAcc총평가금액
            // 
            // 
            // 
            // 
            this.tbAcc총평가금액.CustomButton.Image = null;
            this.tbAcc총평가금액.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tbAcc총평가금액.CustomButton.Name = "";
            this.tbAcc총평가금액.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAcc총평가금액.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAcc총평가금액.CustomButton.TabIndex = 1;
            this.tbAcc총평가금액.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAcc총평가금액.CustomButton.UseSelectable = true;
            this.tbAcc총평가금액.CustomButton.Visible = false;
            this.tbAcc총평가금액.Lines = new string[0];
            this.tbAcc총평가금액.Location = new System.Drawing.Point(168, 352);
            this.tbAcc총평가금액.MaxLength = 32767;
            this.tbAcc총평가금액.Name = "tbAcc총평가금액";
            this.tbAcc총평가금액.PasswordChar = '\0';
            this.tbAcc총평가금액.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAcc총평가금액.SelectedText = "";
            this.tbAcc총평가금액.SelectionLength = 0;
            this.tbAcc총평가금액.SelectionStart = 0;
            this.tbAcc총평가금액.ShortcutsEnabled = true;
            this.tbAcc총평가금액.Size = new System.Drawing.Size(136, 23);
            this.tbAcc총평가금액.TabIndex = 25;
            this.tbAcc총평가금액.UseSelectable = true;
            this.tbAcc총평가금액.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAcc총평가금액.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAcc총수익률
            // 
            // 
            // 
            // 
            this.tbAcc총수익률.CustomButton.Image = null;
            this.tbAcc총수익률.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tbAcc총수익률.CustomButton.Name = "";
            this.tbAcc총수익률.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAcc총수익률.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAcc총수익률.CustomButton.TabIndex = 1;
            this.tbAcc총수익률.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAcc총수익률.CustomButton.UseSelectable = true;
            this.tbAcc총수익률.CustomButton.Visible = false;
            this.tbAcc총수익률.Lines = new string[0];
            this.tbAcc총수익률.Location = new System.Drawing.Point(26, 381);
            this.tbAcc총수익률.MaxLength = 32767;
            this.tbAcc총수익률.Name = "tbAcc총수익률";
            this.tbAcc총수익률.PasswordChar = '\0';
            this.tbAcc총수익률.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAcc총수익률.SelectedText = "";
            this.tbAcc총수익률.SelectionLength = 0;
            this.tbAcc총수익률.SelectionStart = 0;
            this.tbAcc총수익률.ShortcutsEnabled = true;
            this.tbAcc총수익률.Size = new System.Drawing.Size(136, 23);
            this.tbAcc총수익률.TabIndex = 26;
            this.tbAcc총수익률.UseSelectable = true;
            this.tbAcc총수익률.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAcc총수익률.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAcc총손익금
            // 
            // 
            // 
            // 
            this.tbAcc총손익금.CustomButton.Image = null;
            this.tbAcc총손익금.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tbAcc총손익금.CustomButton.Name = "";
            this.tbAcc총손익금.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAcc총손익금.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAcc총손익금.CustomButton.TabIndex = 1;
            this.tbAcc총손익금.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAcc총손익금.CustomButton.UseSelectable = true;
            this.tbAcc총손익금.CustomButton.Visible = false;
            this.tbAcc총손익금.Lines = new string[0];
            this.tbAcc총손익금.Location = new System.Drawing.Point(167, 381);
            this.tbAcc총손익금.MaxLength = 32767;
            this.tbAcc총손익금.Name = "tbAcc총손익금";
            this.tbAcc총손익금.PasswordChar = '\0';
            this.tbAcc총손익금.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAcc총손익금.SelectedText = "";
            this.tbAcc총손익금.SelectionLength = 0;
            this.tbAcc총손익금.SelectionStart = 0;
            this.tbAcc총손익금.ShortcutsEnabled = true;
            this.tbAcc총손익금.Size = new System.Drawing.Size(136, 23);
            this.tbAcc총손익금.TabIndex = 27;
            this.tbAcc총손익금.UseSelectable = true;
            this.tbAcc총손익금.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAcc총손익금.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listviewAccStock
            // 
            this.listviewAccStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listviewAccStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewAccStock.FullRowSelect = true;
            this.listviewAccStock.GridLines = true;
            this.listviewAccStock.Location = new System.Drawing.Point(26, 410);
            this.listviewAccStock.MultiSelect = false;
            this.listviewAccStock.Name = "listviewAccStock";
            this.listviewAccStock.OwnerDraw = true;
            this.listviewAccStock.Size = new System.Drawing.Size(332, 257);
            this.listviewAccStock.TabIndex = 28;
            this.listviewAccStock.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listviewAccStock.UseCompatibleStateImageBehavior = false;
            this.listviewAccStock.UseSelectable = true;
            this.listviewAccStock.View = System.Windows.Forms.View.Details;
            this.listviewAccStock.SelectedIndexChanged += new System.EventHandler(this.listviewAccStock_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "종목명";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "현재가";
            this.columnHeader6.Width = 100;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(26, 300);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 20);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "신용구분";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroRadioButton3);
            this.panel1.Controls.Add(this.metroRadioButton4);
            this.panel1.Location = new System.Drawing.Point(95, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 28);
            this.panel1.TabIndex = 30;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(81, 6);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(50, 17);
            this.metroRadioButton3.TabIndex = 22;
            this.metroRadioButton3.Text = "신용";
            this.metroRadioButton3.UseSelectable = true;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Checked = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(5, 6);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(50, 17);
            this.metroRadioButton4.TabIndex = 21;
            this.metroRadioButton4.TabStop = true;
            this.metroRadioButton4.Text = "현금";
            this.metroRadioButton4.UseSelectable = true;
            // 
            // btnPossibleCnt
            // 
            this.btnPossibleCnt.Location = new System.Drawing.Point(253, 295);
            this.btnPossibleCnt.Name = "btnPossibleCnt";
            this.btnPossibleCnt.Size = new System.Drawing.Size(107, 30);
            this.btnPossibleCnt.TabIndex = 31;
            this.btnPossibleCnt.Text = "가능수량";
            this.btnPossibleCnt.UseSelectable = true;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "수익률";
            this.columnHeader7.Width = 100;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 680);
            this.Controls.Add(this.btnPossibleCnt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.listviewAccStock);
            this.Controls.Add(this.tbAcc총손익금);
            this.Controls.Add(this.tbAcc총수익률);
            this.Controls.Add(this.tbAcc총평가금액);
            this.Controls.Add(this.tbAcc예수금);
            this.Controls.Add(this.listviewStockResult);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.bttnConditionSearchStart);
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
            this.Controls.Add(this.bttnConditionLoad);
            this.Controls.Add(this.listviewConditionSearchList);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.axKHOpenAPI);
            this.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainFrom";
            this.Padding = new System.Windows.Forms.Padding(22, 69, 22, 23);
            this.Text = "Gloomy Spider";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private MetroFramework.Controls.MetroButton bttnStart;
        private MetroFramework.Controls.MetroListView listviewConditionSearchList;
        private MetroFramework.Controls.MetroButton bttnConditionLoad;
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
        private MetroFramework.Controls.MetroButton bttnConditionSearchStart;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroListView listviewStockResult;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroTextBox tbAcc예수금;
        private MetroFramework.Controls.MetroTextBox tbAcc총평가금액;
        private MetroFramework.Controls.MetroTextBox tbAcc총수익률;
        private MetroFramework.Controls.MetroTextBox tbAcc총손익금;
        private MetroFramework.Controls.MetroListView listviewAccStock;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroButton btnPossibleCnt;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

