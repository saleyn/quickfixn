// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class OrderCancelReject : Message
    {
            public const string MsgType = "9";

            public OrderCancelReject() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("9"));
            }

            public OrderCancelReject(
                    QuickFix.FXCM.Fields.OrderID aOrderID,
                    QuickFix.FXCM.Fields.ClOrdID aClOrdID,
                    QuickFix.FXCM.Fields.OrigClOrdID aOrigClOrdID,
                    QuickFix.FXCM.Fields.OrdStatus aOrdStatus,
                    QuickFix.FXCM.Fields.CxlRejResponseTo aCxlRejResponseTo
                ) : this()
            {
                this.OrderID = aOrderID;
                this.ClOrdID = aClOrdID;
                this.OrigClOrdID = aOrigClOrdID;
                this.OrdStatus = aOrdStatus;
                this.CxlRejResponseTo = aCxlRejResponseTo;
            }

            public QuickFix.FXCM.Fields.OrderID OrderID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrderID val) 
            { 
                OrderID = val;
            }
            
            public QuickFix.FXCM.Fields.OrderID Get(QuickFix.FXCM.Fields.OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrderID);
            }
            
            public QuickFix.FXCM.Fields.SecondaryOrderID SecondaryOrderID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecondaryOrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecondaryOrderID val) 
            { 
                SecondaryOrderID = val;
            }
            
            public QuickFix.FXCM.Fields.SecondaryOrderID Get(QuickFix.FXCM.Fields.SecondaryOrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecondaryOrderID val) 
            { 
                return IsSetSecondaryOrderID();
            }
            
            public bool IsSetSecondaryOrderID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryOrderID);
            }
            
            public QuickFix.FXCM.Fields.SecondaryClOrdID SecondaryClOrdID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SecondaryClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
            { 
                SecondaryClOrdID = val;
            }
            
            public QuickFix.FXCM.Fields.SecondaryClOrdID Get(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SecondaryClOrdID val) 
            { 
                return IsSetSecondaryClOrdID();
            }
            
            public bool IsSetSecondaryClOrdID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SecondaryClOrdID);
            }
            
            public QuickFix.FXCM.Fields.ClOrdID ClOrdID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClOrdID val) 
            { 
                ClOrdID = val;
            }
            
            public QuickFix.FXCM.Fields.ClOrdID Get(QuickFix.FXCM.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClOrdID);
            }
            
            public QuickFix.FXCM.Fields.ClOrdLinkID ClOrdLinkID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClOrdLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClOrdLinkID val) 
            { 
                ClOrdLinkID = val;
            }
            
            public QuickFix.FXCM.Fields.ClOrdLinkID Get(QuickFix.FXCM.Fields.ClOrdLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClOrdLinkID val) 
            { 
                return IsSetClOrdLinkID();
            }
            
            public bool IsSetClOrdLinkID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClOrdLinkID);
            }
            
            public QuickFix.FXCM.Fields.OrigClOrdID OrigClOrdID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrigClOrdID val) 
            { 
                OrigClOrdID = val;
            }
            
            public QuickFix.FXCM.Fields.OrigClOrdID Get(QuickFix.FXCM.Fields.OrigClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrigClOrdID val) 
            { 
                return IsSetOrigClOrdID();
            }
            
            public bool IsSetOrigClOrdID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrigClOrdID);
            }
            
            public QuickFix.FXCM.Fields.OrdStatus OrdStatus
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrdStatus val) 
            { 
                OrdStatus = val;
            }
            
            public QuickFix.FXCM.Fields.OrdStatus Get(QuickFix.FXCM.Fields.OrdStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrdStatus val) 
            { 
                return IsSetOrdStatus();
            }
            
            public bool IsSetOrdStatus() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrdStatus);
            }
            
            public QuickFix.FXCM.Fields.WorkingIndicator WorkingIndicator
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.WorkingIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.WorkingIndicator val) 
            { 
                WorkingIndicator = val;
            }
            
            public QuickFix.FXCM.Fields.WorkingIndicator Get(QuickFix.FXCM.Fields.WorkingIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.WorkingIndicator val) 
            { 
                return IsSetWorkingIndicator();
            }
            
            public bool IsSetWorkingIndicator() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.WorkingIndicator);
            }
            
            public QuickFix.FXCM.Fields.OrigOrdModTime OrigOrdModTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.OrigOrdModTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.OrigOrdModTime val) 
            { 
                OrigOrdModTime = val;
            }
            
            public QuickFix.FXCM.Fields.OrigOrdModTime Get(QuickFix.FXCM.Fields.OrigOrdModTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.OrigOrdModTime val) 
            { 
                return IsSetOrigOrdModTime();
            }
            
            public bool IsSetOrigOrdModTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.OrigOrdModTime);
            }
            
            public QuickFix.FXCM.Fields.ListID ListID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ListID val) 
            { 
                ListID = val;
            }
            
            public QuickFix.FXCM.Fields.ListID Get(QuickFix.FXCM.Fields.ListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ListID val) 
            { 
                return IsSetListID();
            }
            
            public bool IsSetListID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ListID);
            }
            
            public QuickFix.FXCM.Fields.Account Account
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Account val) 
            { 
                Account = val;
            }
            
            public QuickFix.FXCM.Fields.Account Get(QuickFix.FXCM.Fields.Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Account);
            }
            
            public QuickFix.FXCM.Fields.AcctIDSource AcctIDSource
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AcctIDSource val) 
            { 
                AcctIDSource = val;
            }
            
            public QuickFix.FXCM.Fields.AcctIDSource Get(QuickFix.FXCM.Fields.AcctIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AcctIDSource val) 
            { 
                return IsSetAcctIDSource();
            }
            
            public bool IsSetAcctIDSource() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AcctIDSource);
            }
            
            public QuickFix.FXCM.Fields.AccountType AccountType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.AccountType val) 
            { 
                AccountType = val;
            }
            
            public QuickFix.FXCM.Fields.AccountType Get(QuickFix.FXCM.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.AccountType);
            }
            
            public QuickFix.FXCM.Fields.TradeOriginationDate TradeOriginationDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradeOriginationDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradeOriginationDate val) 
            { 
                TradeOriginationDate = val;
            }
            
            public QuickFix.FXCM.Fields.TradeOriginationDate Get(QuickFix.FXCM.Fields.TradeOriginationDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradeOriginationDate val) 
            { 
                return IsSetTradeOriginationDate();
            }
            
            public bool IsSetTradeOriginationDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradeOriginationDate);
            }
            
            public QuickFix.FXCM.Fields.TradeDate TradeDate
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                TradeDate = val;
            }
            
            public QuickFix.FXCM.Fields.TradeDate Get(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradeDate);
            }
            
            public QuickFix.FXCM.Fields.TransactTime TransactTime
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                TransactTime = val;
            }
            
            public QuickFix.FXCM.Fields.TransactTime Get(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TransactTime);
            }
            
            public QuickFix.FXCM.Fields.CxlRejResponseTo CxlRejResponseTo
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CxlRejResponseTo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CxlRejResponseTo val) 
            { 
                CxlRejResponseTo = val;
            }
            
            public QuickFix.FXCM.Fields.CxlRejResponseTo Get(QuickFix.FXCM.Fields.CxlRejResponseTo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CxlRejResponseTo val) 
            { 
                return IsSetCxlRejResponseTo();
            }
            
            public bool IsSetCxlRejResponseTo() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CxlRejResponseTo);
            }
            
            public QuickFix.FXCM.Fields.CxlRejReason CxlRejReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.CxlRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.CxlRejReason val) 
            { 
                CxlRejReason = val;
            }
            
            public QuickFix.FXCM.Fields.CxlRejReason Get(QuickFix.FXCM.Fields.CxlRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.CxlRejReason val) 
            { 
                return IsSetCxlRejReason();
            }
            
            public bool IsSetCxlRejReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.CxlRejReason);
            }
            
            public QuickFix.FXCM.Fields.Text Text
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Text val) 
            { 
                Text = val;
            }
            
            public QuickFix.FXCM.Fields.Text Get(QuickFix.FXCM.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Text);
            }
            
            public QuickFix.FXCM.Fields.EncodedTextLen EncodedTextLen
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                EncodedTextLen = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedTextLen Get(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedTextLen);
            }
            
            public QuickFix.FXCM.Fields.EncodedText EncodedText
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                EncodedText = val;
            }
            
            public QuickFix.FXCM.Fields.EncodedText Get(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncodedText);
            }
            
            public QuickFix.FXCM.Fields.TradingSessionID TradingSessionID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradingSessionID val) 
            { 
                TradingSessionID = val;
            }
            
            public QuickFix.FXCM.Fields.TradingSessionID Get(QuickFix.FXCM.Fields.TradingSessionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradingSessionID val) 
            { 
                return IsSetTradingSessionID();
            }
            
            public bool IsSetTradingSessionID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradingSessionID);
            }
            
            public QuickFix.FXCM.Fields.TradingSessionSubID TradingSessionSubID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradingSessionSubID val) 
            { 
                TradingSessionSubID = val;
            }
            
            public QuickFix.FXCM.Fields.TradingSessionSubID Get(QuickFix.FXCM.Fields.TradingSessionSubID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradingSessionSubID val) 
            { 
                return IsSetTradingSessionSubID();
            }
            
            public bool IsSetTradingSessionSubID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradingSessionSubID);
            }
            
            public QuickFix.FXCM.Fields.FXCMRequestRejectReason FXCMRequestRejectReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMRequestRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMRequestRejectReason val) 
            { 
                FXCMRequestRejectReason = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMRequestRejectReason Get(QuickFix.FXCM.Fields.FXCMRequestRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMRequestRejectReason val) 
            { 
                return IsSetFXCMRequestRejectReason();
            }
            
            public bool IsSetFXCMRequestRejectReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMRequestRejectReason);
            }
            
            public QuickFix.FXCM.Fields.FXCMErrorDetails FXCMErrorDetails
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMErrorDetails();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMErrorDetails val) 
            { 
                FXCMErrorDetails = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMErrorDetails Get(QuickFix.FXCM.Fields.FXCMErrorDetails val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMErrorDetails val) 
            { 
                return IsSetFXCMErrorDetails();
            }
            
            public bool IsSetFXCMErrorDetails() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMErrorDetails);
            }
            

    }
}
