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
        long LogInResult;
        int conditionLoadState;
        public MainFrom()
        {
            InitializeComponent();

            axKHOpenAPI.OnEventConnect += API_OnEventConnect;
        }

        private void API_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (LogInResult == 0)
            {
                Logger(Log.일반, "로그인창 열기 성공");
            }
            else
            {
                Logger(Log.에러, "로그인창 열기 실패");
            }
            UpdateUserInformation();
        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI.GetConnectState() == 0)
            {
                LogInResult = axKHOpenAPI.CommConnect();
            }
            else
            {
                Logger(Log.일반, "연결중");
            }
        }

        // 로그를 출력합니다.
        public void Logger(Log type, string msg)
        {
            listviewLog.Items.Add(type.ToString() + " : " + msg);
        }

        private void UpdateUserInformation()
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "LOGIN ID : " + axKHOpenAPI.GetLoginInfo("USER_ID");
            string account = axKHOpenAPI.GetLoginInfo("ACCNO");
            string[] accounts = account.Split(';');
            richTextBox1.Text += "\n 보유한 계좌 : " + axKHOpenAPI.GetLoginInfo("ACCOUNT_CNT");
            foreach (string acc in accounts)
            {
                if (string.IsNullOrEmpty(acc))
                    continue;

                richTextBox1.Text += "\n Account : " + acc;
            }

            richTextBox1.Text += "\n 사용자명 : " + axKHOpenAPI.GetLoginInfo("USER_NAME");
        }

        private void bttnConditionSearch_Click(object sender, EventArgs e)
        {
            this.listviewConditionSearchList.Clear();

            if (conditionLoadState == 1)
            {
                string conditionSearchList;

                conditionSearchList = axKHOpenAPI.GetConditionNameList().Trim();

                Logger(Log.조회, conditionSearchList);

                // 분리된 문자 배열 저장
                string[] spconditionSearchListArr = conditionSearchList.Split(';');

                foreach (string condition in spconditionSearchListArr)
                {
                    if (string.IsNullOrEmpty(condition))
                        continue;

                    listviewConditionSearchList.Items.Add(condition);
                    /*
                    string[] spCon = spConList[i].Split('^');
                    int nIndex = Int32.Parse(spCon[0]);
                    string strConditionName = spCon[1];
                    cbo조건식.Items.Add(strConditionName);
                    */
                }
                Logger(Log.일반, "조건식 불러오기 완료");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            conditionLoadState = axKHOpenAPI.GetConditionLoad();

            if (conditionLoadState == 1)
            {
                Logger(Log.일반, "조건식 저장이 성공 되었습니다");

            }
            else
            {
                Logger(Log.에러, "조건식 저장이 실패 하였습니다");
            }
        }
    }
}
