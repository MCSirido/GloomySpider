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
            this.richTextBox1.Size = new System.Drawing.Size(332, 189);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // listviewLog
            // 
            this.listviewLog.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            this.bttnConditionSearch.Location = new System.Drawing.Point(29, 346);
            this.bttnConditionSearch.Name = "bttnConditionSearch";
            this.bttnConditionSearch.Size = new System.Drawing.Size(83, 26);
            this.bttnConditionSearch.TabIndex = 4;
            this.bttnConditionSearch.Text = "조건 검색";
            this.bttnConditionSearch.UseSelectable = true;
            this.bttnConditionSearch.Click += new System.EventHandler(this.bttnConditionSearch_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 661);
            this.Controls.Add(this.bttnConditionSearch);
            this.Controls.Add(this.listviewLog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.axKHOpenAPI);
            this.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainFrom";
            this.Padding = new System.Windows.Forms.Padding(22, 69, 22, 23);
            this.Text = "Gloomy Spider";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private MetroFramework.Controls.MetroButton bttnStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroListView listviewLog;
        private MetroFramework.Controls.MetroButton bttnConditionSearch;
    }
}

