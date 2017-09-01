using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxKHOpenAPILib;
using MetroFramework;


namespace GloomySpider
{
    public partial class MainFrom : MetroFramework.Forms.MetroForm
    {
        long LogInResult;
        int conditionLoadState;
        private int _scrNum = 5000;
        public MainFrom()
        {
            InitializeComponent();

            axKHOpenAPI.OnEventConnect += API_OnEventConnect;
            axKHOpenAPI.OnReceiveConditionVer += API_OnReceiveConditionVer;
            axKHOpenAPI.OnReceiveTrCondition += API_OnReceiveTrCondition;
            axKHOpenAPI.OnReceiveTrData += API_OnReceiveTrData;
            axKHOpenAPI.OnReceiveRealCondition += API_OnReceiveRealCondition;
            axKHOpenAPI.OnReceiveRealData += API_OnReceiveRealData;
            axKHOpenAPI.OnReceiveConditionVer += API_OnReceiveConditionVer;
        }

        private void API_OnReceiveRealData(object sender, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            throw new NotImplementedException();
        }

        private void API_OnReceiveRealCondition(object sender, _DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {
            //BSTR strCode,   // 종목코드
            //BSTR strType,   //  이벤트 종류, "I":종목편입, "D", 종목이탈
            //BSTR strConditionName,    // 조건식 이름 
            //BSTR strConditionIndex    // 조건명 인덱스

            string type = e.strType.Equals("I") ? "종목편입" : "종목이탈";
            Logger(Log.일반, type + ";" + e.sTrCode);
        }

        private void API_OnReceiveTrData(object sender, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

        }

        private void API_OnReceiveTrCondition(object sender, _DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            string codeList = e.strCodeList.Trim();
            Logger(Log.일반, codeList);

            if(e.nNext==2)
            {
                axKHOpenAPI.SendCondition(e.sScrNo, e.strConditionName, e.nIndex, 2);
                Logger(Log.일반, codeList);
            }
        }

        private void API_OnReceiveConditionVer(object sender, _DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            this.listviewConditionSearchList.Clear();
            string conditionSearchList;

            conditionSearchList = axKHOpenAPI.GetConditionNameList().Trim();

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
                if (string.IsNullOrEmpty(tbAccount.Text)){
                    tbAccount.Text = acc;
                }
            }

            richTextBox1.Text += "\n 사용자명 : " + axKHOpenAPI.GetLoginInfo("USER_NAME");
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (this.listviewConditionSearchList.SelectedItems.Count == 0)
                return;


            foreach(ListViewItem lvItem in this.listviewConditionSearchList.Items)
            {
                string[] conditionInfo1 = lvItem.Text.Split(';');
                int conditionIndex1 = Int32.Parse(conditionInfo1[0]);
                string conditionName1 = conditionInfo1[1];

                axKHOpenAPI.SendConditionStop(GetScreenNum(), conditionName1, conditionIndex1);
            }

            string[] conditionInfo = this.listviewConditionSearchList.SelectedItems[0].Text.Split(';');
            int conditionIndex = Int32.Parse(conditionInfo[0]);
            string conditionName = conditionInfo[1];
            int result = axKHOpenAPI.SendCondition(GetScreenNum(), conditionName, conditionIndex, 1);

            if(result>0)
                Logger(Log.일반, "조건 검색 결과 불러오기 완료");
            else
                Logger(Log.에러, "조건 검색 결과 불러오기 실패");
        }



        private string GetScreenNum()
        {
            if (_scrNum < 9000)
                this._scrNum++;
            else
                this._scrNum = 5000;
            return this._scrNum.ToString();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string orderGb = "00";
            int orderPrice = 0;
            if (metroRadioButton2.Checked)
            {
                orderGb = "03";
            }
            else
            {
                orderGb = "00";
                orderPrice = int.Parse(tbOrderPrice.Text);
            }
            sendOrderGS(1, tbStockCode.Text, int.Parse(tbOrderQty.Text), orderPrice, orderGb);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string orderGb = "00";
            int orderPrice = 0;
            if (metroRadioButton2.Checked)
            {
                orderGb = "03";
            }
            else
            {
                orderGb = "00";
                orderPrice = int.Parse(tbOrderPrice.Text);
            }
            sendOrderGS(2, tbStockCode.Text, int.Parse(tbOrderQty.Text), orderPrice, orderGb);
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked)
            {
                tbOrderPrice.Enabled = false;
            }
            else
            {
                tbOrderPrice.Enabled = true;
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked)
            {
                tbOrderPrice.Enabled = false;
            }
            else
            {
                tbOrderPrice.Enabled = true;
            }
        }

        /*  Parameter 설명
            거래유형 orderType :  1:신규매수, 2:신규매도 3:매수취소, 4:매도취소, 5:매수정정, 6:매도정정
            종목코드 stockCode
            주문수량 orderQty
            주문가격 orderPrice
            거래구분 orderGb
              - 00 : 지정가
              - 03 : 시장가
            원주문번호 orgOrderNo : 일반적으론 주문정정이나 취소가 아닐때는 안넣어도 됨
        */

        private void sendOrderGS(int orderType, string stockCode, int orderQty, int orderPrice, string orderGb, string orgOrderNo = "")
        {
            int lRet;
            string orderTypeStr = "";

            switch (orderType)
            {
                case 1:
                    orderTypeStr = "신규매수";
                    break;
                case 2:
                    orderTypeStr = "신규매도";
                    break;
                case 3:
                    orderTypeStr = "매수취소";
                    break;
                case 4:
                    orderTypeStr = "매도취소";
                    break;
                case 5:
                    orderTypeStr = "매수정정";
                    break;
                case 6:
                    orderTypeStr = "매도정정";
                    break;
                default:
                    break;
            }

            lRet = axKHOpenAPI.SendOrder("주식주문",
                                        GetScrNum(),
                                        tbAccount.Text.Trim(),
                                        orderType,      // 매매구분
                                        stockCode,   // 종목코드
                                        orderQty,      // 주문수량
                                        orderPrice,      // 주문가격 
                                        orderGb,    // 거래구분 (시장가)
                                        orgOrderNo);    // 원주문 번호

            if (lRet == 0)
            {
                Logger(Log.일반, orderTypeStr + " 주문이 전송 되었습니다");
            }
            else
            {
                Logger(Log.에러, orderTypeStr + " 주문이 전송 실패 하였습니다. [에러] : " + lRet);
            }
        }
    }
}
