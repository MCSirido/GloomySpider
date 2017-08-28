using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace GloomySpider
{
    public partial class MainFrom : MetroFramework.Forms.MetroForm
    {
        public MainFrom()
        {
            InitializeComponent();

            axKHOpenAPI1.OnEventConnect += API_OnEventConnect;
        }

        private void API_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            UpdateUserInformation();
        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            long Result;
            Result = axKHOpenAPI1.CommConnect();
            if (Result != 0)
                MessageBox.Show("Login창 열림 Fail");
        }

        private void UpdateUserInformation()
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "LOGIN ID : " + axKHOpenAPI1.GetLoginInfo("USER_ID");
            string account = axKHOpenAPI1.GetLoginInfo("ACCNO");
            string[] accounts = account.Split(';');
            richTextBox1.Text += "\n 보유한 계좌 : " + axKHOpenAPI1.GetLoginInfo("ACCOUNT_CNT");
            foreach (string acc in accounts)
            {
                richTextBox1.Text += "\n Account : " + acc;
            }

            richTextBox1.Text += "\n 사용자명 : " + axKHOpenAPI1.GetLoginInfo("USER_NAME");
            richTextBox1.Text += "\n 키보드보안 해지여부 0:정상, 1:해지 : " + axKHOpenAPI1.GetLoginInfo("KEY_BSECGB");
            richTextBox1.Text += "\n 방화벽 설정 여부. 0:미설정, 1:설정, 2:해지 : " + axKHOpenAPI1.GetLoginInfo("FIREW_SECGB");
        }



    }
}
