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
        private long LogInResult;
        private int conditionLoadState;
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
            axKHOpenAPI.OnReceiveMsg += API_OnReceiveMsg;
        }

        private void API_OnReceiveMsg(object sender, _DKHOpenAPIEvents_OnReceiveMsgEvent e)
        {
            if (e.sRQName.Equals("주식주문"))
            {
                Logger(Log.에러, e.sMsg);
            }
        }

        #region 키움 API 이벤트
        private void API_OnReceiveConditionVer(object sender, _DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            this.listviewConditionSearchList.Items.Clear();
            string conditionSearchList;

            conditionSearchList = axKHOpenAPI.GetConditionNameList().Trim();

            // 분리된 문자 배열 저장
            string[] spconditionSearchListArr = conditionSearchList.Split(';');

            foreach (string condition in spconditionSearchListArr)
            {
                if (string.IsNullOrEmpty(condition))
                    continue;

                string[] conditionaArr = condition.Split('^');

                ListViewItem lv = new ListViewItem(conditionaArr[0]);
                lv.SubItems.Add(conditionaArr[1]);
                listviewConditionSearchList.Items.Add(lv);
            }
            Logger(Log.일반, "조건식 불러오기 완료");
        }

        private void API_OnReceiveRealData(object sender, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {

        }

        private void API_OnReceiveRealCondition(object sender, _DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {
            //BSTR strCode,   // 종목코드
            //BSTR strType,   //  이벤트 종류, "I":종목편입, "D", 종목이탈
            //BSTR strConditionName,    // 조건식 이름 
            //BSTR strConditionIndex    // 조건명 인덱스

            string type = e.strType.Equals("I") ? "종목편입" : "종목이탈";
            Logger(Log.일반, e.strConditionName + ";" + type + ";" + e.sTrCode);
        }

        private void API_OnReceiveTrData(object sender, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName.Equals("조건검색결과"))
            {
                this.listviewStockResult.Items.Clear();
                int count = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < count; i++)
                {

                    string stockName = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    string stockCurrentPrice = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim();
                    ListViewItem lv = new ListViewItem(stockName);
                    lv.SubItems.Add(stockCurrentPrice);
                    lv.Tag = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();

                    this.listviewStockResult.Items.Add(lv);
                }
            }
            else if (e.sRQName.Equals("계좌평가현황요청"))
            {
                this.listviewAccStock.Items.Clear();

                this.tbAcc예수금.Text = Int32.Parse(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "예수금").Trim()).ToString();
                this.tbAcc총평가금액.Text = Int32.Parse(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "예탁자산평가액").Trim()).ToString();
                this.tbAcc총수익률.Text = double.Parse(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "누적손익율").Trim()).ToString("0.000");
                this.tbAcc총손익금.Text = Int32.Parse(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "누적투자손익").Trim()).ToString();

                int count = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < count; i++)
                {
                    string stockName = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    string stockCode = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    string stockCurrentPrice = Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim()).ToString();
                    string stockCurrentMargin =axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "손익율").Trim();
                    string stockLoanDate = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "대출일").Trim();

                    ListViewItem lv = new ListViewItem(stockName);
                    lv.SubItems.Add(stockCurrentPrice);
                    lv.SubItems.Add(stockCurrentMargin);
                    lv.SubItems.Add(stockLoanDate);
                    lv.Tag = stockCode;

                    this.listviewAccStock.Items.Add(lv);
                }
                    Logger(Log.조회, "계좌정보 조회 성공");
            }
            else if (e.sRQName.Equals("증거금율별주문가능수량조회요청"))
            {
                this.tbOrderQty.Text = Int32.Parse(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "증거금100주문가능수량").Trim()).ToString();

                Logger(Log.조회, "증거금율별주문가능수량조회요청 성공");
            }
            else if (e.sRQName.Equals("신용보증금율별주문가능수량조회요청"))
            {
                this.tbOrderQty.Text = Int32.Parse(this.axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "보증금40주문가능수량").Trim()).ToString();

                Logger(Log.조회, "신용보증금율별주문가능수량조회요청 성공");
            }
        }

        private void API_OnReceiveTrCondition(object sender, _DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            string codeList = e.strCodeList.Trim();
            if (codeList.Length > 0)
                codeList = codeList.Remove(codeList.Length - 1);

            if (string.IsNullOrEmpty(codeList))
            {
                Logger(Log.일반, "해당 조건 검색 종목 없음");
                return;
            }

            int count = codeList.Trim().Split(';').Length;

            if (e.nNext == 2)
            {
                axKHOpenAPI.SendCondition(e.sScrNo, e.strConditionName, e.nIndex, 2);
                //Logger(Log.일반, codeList);
            }

            axKHOpenAPI.CommKwRqData(codeList, 0, count, 0, "조건검색결과", GetScreenNum());
        }

        private void API_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (LogInResult == 0)
            {
                Logger(Log.일반, "로그인창 열기 성공");
                UpdateUserInformation();
                GetAccountInfo();
            }
            else
            {
                Logger(Log.에러, "로그인창 열기 실패");
            }
            
        }
        #endregion

        #region UI 이벤트
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

        private void bttnConditionLoad_Click(object sender, EventArgs e)
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
            sendOrderGS(2, tbStockCode.Text, int.Parse(tbOrderQty.Text), orderPrice, orderGb, metroRadioButton3.Checked);
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

        private void bttnConditionSearchStart_Click(object sender, EventArgs e)
        {
            if (this.listviewConditionSearchList.SelectedItems.Count == 0)
                return;

            int conditionIndex = Int32.Parse(this.listviewConditionSearchList.SelectedItems[0].SubItems[0].Text);
            string conditionName = this.listviewConditionSearchList.SelectedItems[0].SubItems[1].Text;
            int result = axKHOpenAPI.SendCondition(GetScreenNum(), conditionName, conditionIndex, 1);

            if (result > 0)
                Logger(Log.일반, "조건 검색 결과 불러오기 완료");
            else
                Logger(Log.에러, "조건 검색 결과 불러오기 실패");


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

            sendOrderGS(1, tbStockCode.Text, int.Parse(tbOrderQty.Text), orderPrice, orderGb, metroRadioButton3.Checked);
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DisconnectAllRealData();
            axKHOpenAPI.CommTerminate();
            Logger(Log.일반, "로그아웃");
        }
        #endregion

        #region 사용자 함수

        private void GetAccountInfo()
        {
            this.axKHOpenAPI.SetInputValue("계좌번호", this.tbAccount.Text);
            this.axKHOpenAPI.SetInputValue("비밀번호", "");
            this.axKHOpenAPI.SetInputValue("상장폐지조회구분", "0");
            this.axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");    

            int result = this.axKHOpenAPI.CommRqData("계좌평가현황요청", "OPW00004", 0, "6001");
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

        private void sendOrderGS(int orderType, string stockCode, int orderQty, int orderPrice, string orderGb, bool creditYn, string orgOrderNo = "")
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

            if (creditYn)
            {
                orderTypeStr = "신용" + orderTypeStr;

                lRet = axKHOpenAPI.SendOrderCredit("주식주문",
                            GetScreenNum(),
                            tbAccount.Text.Trim(),
                            orderType,      // 매매구분
                            stockCode,   // 종목코드
                            orderQty,      // 주문수량
                            orderPrice,      // 주문가격 
                            orderGb,    // 거래구분 (시장가)
                            creditYn?"03":"33",
                            creditYn?"":"",
                            orgOrderNo);    // 원주문 번호
            }
            else
            {
                lRet = axKHOpenAPI.SendOrder("주식주문",
                            GetScreenNum(),
                            tbAccount.Text.Trim(),
                            orderType,      // 매매구분
                            stockCode,   // 종목코드
                            orderQty,      // 주문수량
                            orderPrice,      // 주문가격 
                            orderGb,    // 거래구분 (시장가)
                            orgOrderNo);    // 원주문 번호
            }

            if (lRet == 0)
            {
                Logger(Log.일반, orderTypeStr + " 주문이 전송 되었습니다");
            }
            else
            {
                Logger(Log.에러, orderTypeStr + " 주문이 전송 실패 하였습니다. [에러] : " + lRet);
            }
        }

        private string GetScreenNum()
        {
            if (_scrNum < 9000)
                this._scrNum++;
            else
                this._scrNum = 5000;
            return this._scrNum.ToString();
        }

        private void UpdateUserInformation()
        {
            string account = axKHOpenAPI.GetLoginInfo("ACCNO");
            string[] accounts = account.Split(';');

            foreach (string acc in accounts)
            {
                if (string.IsNullOrEmpty(acc))
                    continue;

                if (string.IsNullOrEmpty(tbAccount.Text))
                {
                    tbAccount.Text = acc;
                }
            }
        }

        // 로그를 출력합니다.
        public void Logger(Log type, string msg)
        {
            this.richTextBoxLog.AppendText(type.ToString() + " : " + msg+"\n");
        }

        // 실시간 연결 종료
        private void DisconnectAllRealData()
        {
            for (int i = _scrNum; i > 5000; i--)
            {
                axKHOpenAPI.DisconnectRealData(i.ToString());
            }

            _scrNum = 5000;
        }
        #endregion

        private void listviewStockResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listviewStockResult.SelectedItems.Count>0)
            {
                if (listviewAccStock.FocusedItem != null)
                {
                    int index = listviewAccStock.FocusedItem.Index;
                    listviewAccStock.Items.RemoveAt(index);
                }

                string stockCode = (string)this.listviewStockResult.SelectedItems[0].Tag;
                string currentPirce = Int32.Parse(this.listviewStockResult.SelectedItems[0].SubItems[1].Text).ToString();

                this.tbStockCode.Text = stockCode;
                this.tbOrderPrice.Text = currentPirce;
            }
        }

        private void listviewAccStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listviewAccStock.SelectedItems.Count > 0)
            {
                if (listviewStockResult.FocusedItem != null)
                {
                    int index = listviewStockResult.FocusedItem.Index;
                    listviewStockResult.Items.RemoveAt(index);
                }

                string stockCode = (string)this.listviewAccStock.SelectedItems[0].Tag;
                string currentPirce = Int32.Parse(this.listviewAccStock.SelectedItems[0].SubItems[1].Text).ToString();

                this.tbStockCode.Text = stockCode;
                this.tbOrderPrice.Text = currentPirce;
            }
        }
        private void btnPossibleCnt_Click(object sender, EventArgs e)
        {
            this.axKHOpenAPI.SetInputValue("계좌번호", this.tbAccount.Text);
            this.axKHOpenAPI.SetInputValue("비밀번호", "");
            this.axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");
            this.axKHOpenAPI.SetInputValue("종목번호",this.tbStockCode.Text);
            this.axKHOpenAPI.SetInputValue("매수가격", this.tbOrderPrice.Text);


            if (metroRadioButton4.Checked)
            {
                this.axKHOpenAPI.CommRqData("증거금율별주문가능수량조회요청", "opw00011", 0, "0399");
            }

            if (metroRadioButton3.Checked)
            {
                this.axKHOpenAPI.CommRqData("신용보증금율별주문가능수량조회요청", "opw00012", 0, "0399");
            }
        }

        private void btn계좌정보조회_Click(object sender, EventArgs e)
        {
            GetAccountInfo();
        }
    }
}
