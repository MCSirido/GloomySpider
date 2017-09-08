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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.bttnLogIn = new MetroFramework.Controls.MetroButton();
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.btnPossibleCnt = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btn계좌정보조회 = new MetroFramework.Controls.MetroButton();
            this.tbLoanDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewAccountStock = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewAccount = new MetroFramework.Controls.MetroGrid();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
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
            // bttnLogIn
            // 
            this.bttnLogIn.Location = new System.Drawing.Point(26, 72);
            this.bttnLogIn.Name = "bttnLogIn";
            this.bttnLogIn.Size = new System.Drawing.Size(83, 26);
            this.bttnLogIn.TabIndex = 1;
            this.bttnLogIn.Text = "Log In";
            this.bttnLogIn.UseSelectable = true;
            this.bttnLogIn.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // listviewConditionSearchList
            // 
            this.listviewConditionSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listviewConditionSearchList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewConditionSearchList.FullRowSelect = true;
            this.listviewConditionSearchList.GridLines = true;
            this.listviewConditionSearchList.Location = new System.Drawing.Point(462, 68);
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
            this.richTextBoxLog.Location = new System.Drawing.Point(961, 72);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(302, 253);
            this.richTextBoxLog.TabIndex = 22;
            this.richTextBoxLog.Text = "";
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
            this.btnPossibleCnt.Size = new System.Drawing.Size(107, 53);
            this.btnPossibleCnt.TabIndex = 31;
            this.btnPossibleCnt.Text = "가능수량";
            this.btnPossibleCnt.UseSelectable = true;
            this.btnPossibleCnt.Click += new System.EventHandler(this.btnPossibleCnt_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(26, 442);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(122, 20);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "갤러리 계좌 정보";
            // 
            // btn계좌정보조회
            // 
            this.btn계좌정보조회.Location = new System.Drawing.Point(186, 436);
            this.btn계좌정보조회.Name = "btn계좌정보조회";
            this.btn계좌정보조회.Size = new System.Drawing.Size(174, 26);
            this.btn계좌정보조회.TabIndex = 33;
            this.btn계좌정보조회.Text = "계좌 정보 조회";
            this.btn계좌정보조회.UseSelectable = true;
            this.btn계좌정보조회.Click += new System.EventHandler(this.btn계좌정보조회_Click);
            // 
            // tbLoanDate
            // 
            // 
            // 
            // 
            this.tbLoanDate.CustomButton.Image = null;
            this.tbLoanDate.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbLoanDate.CustomButton.Name = "";
            this.tbLoanDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLoanDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLoanDate.CustomButton.TabIndex = 1;
            this.tbLoanDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLoanDate.CustomButton.UseSelectable = true;
            this.tbLoanDate.CustomButton.Visible = false;
            this.tbLoanDate.Lines = new string[0];
            this.tbLoanDate.Location = new System.Drawing.Point(99, 327);
            this.tbLoanDate.MaxLength = 32767;
            this.tbLoanDate.Name = "tbLoanDate";
            this.tbLoanDate.PasswordChar = '\0';
            this.tbLoanDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLoanDate.SelectedText = "";
            this.tbLoanDate.SelectionLength = 0;
            this.tbLoanDate.SelectionStart = 0;
            this.tbLoanDate.ShortcutsEnabled = true;
            this.tbLoanDate.Size = new System.Drawing.Size(148, 23);
            this.tbLoanDate.TabIndex = 35;
            this.tbLoanDate.UseSelectable = true;
            this.tbLoanDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLoanDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(26, 328);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 20);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "대출일";
            // 
            // dataGridViewAccountStock
            // 
            this.dataGridViewAccountStock.AllowUserToResizeRows = false;
            this.dataGridViewAccountStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAccountStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAccountStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAccountStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccountStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccountStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccountStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccountStock.EnableHeadersVisualStyles = false;
            this.dataGridViewAccountStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewAccountStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAccountStock.Location = new System.Drawing.Point(26, 566);
            this.dataGridViewAccountStock.MultiSelect = false;
            this.dataGridViewAccountStock.Name = "dataGridViewAccountStock";
            this.dataGridViewAccountStock.ReadOnly = true;
            this.dataGridViewAccountStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccountStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAccountStock.RowHeadersVisible = false;
            this.dataGridViewAccountStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAccountStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAccountStock.RowTemplate.Height = 27;
            this.dataGridViewAccountStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccountStock.Size = new System.Drawing.Size(1237, 212);
            this.dataGridViewAccountStock.StandardTab = true;
            this.dataGridViewAccountStock.TabIndex = 36;
            this.dataGridViewAccountStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAccInfo_CellFormatting);
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AllowUserToResizeRows = false;
            this.dataGridViewAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAccount.EnableHeadersVisualStyles = false;
            this.dataGridViewAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAccount.Location = new System.Drawing.Point(26, 487);
            this.dataGridViewAccount.MultiSelect = false;
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.ReadOnly = true;
            this.dataGridViewAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAccount.RowHeadersVisible = false;
            this.dataGridViewAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewAccount.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAccount.RowTemplate.Height = 27;
            this.dataGridViewAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccount.Size = new System.Drawing.Size(1237, 73);
            this.dataGridViewAccount.StandardTab = true;
            this.dataGridViewAccount.TabIndex = 38;
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.Location = new System.Drawing.Point(249, 71);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(111, 27);
            this.cbAutoStart.TabIndex = 40;
            this.cbAutoStart.Text = "Auto Start";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            this.cbAutoStart.CheckedChanged += new System.EventHandler(this.cbAutoStart_CheckedChanged);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 790);
            this.Controls.Add(this.cbAutoStart);
            this.Controls.Add(this.dataGridViewAccount);
            this.Controls.Add(this.dataGridViewAccountStock);
            this.Controls.Add(this.tbLoanDate);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btn계좌정보조회);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnPossibleCnt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel6);
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
            this.Controls.Add(this.bttnLogIn);
            this.Controls.Add(this.axKHOpenAPI);
            this.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainFrom";
            this.Padding = new System.Windows.Forms.Padding(22, 69, 22, 23);
            this.Text = "Gloomy Spider";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton bttnLogIn;
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroButton btnPossibleCnt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btn계좌정보조회;
        private MetroFramework.Controls.MetroTextBox tbLoanDate;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid dataGridViewAccountStock;
        internal AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private MetroFramework.Controls.MetroGrid dataGridViewAccount;
        private System.Windows.Forms.CheckBox cbAutoStart;
    }
}

