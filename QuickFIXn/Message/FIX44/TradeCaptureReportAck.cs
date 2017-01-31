// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class TradeCaptureReportAck : Message
    {
            public const string MsgType = "AR";

            public TradeCaptureReportAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AR"));
            }

            public TradeCaptureReportAck(
                    QuickFix.Fields.TradeReportID aTradeReportID,
                    QuickFix.Fields.ExecType aExecType,
                    QuickFix.Fields.Symbol aSymbol
                ) : this()
            {
                this.TradeReportID = aTradeReportID;
                this.ExecType = aExecType;
                this.Symbol = aSymbol;
            }

            public QuickFix.Fields.TradeReportID TradeReportID
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportID val) 
            { 
                TradeReportID = val;
            }
            
            public QuickFix.Fields.TradeReportID Get(QuickFix.Fields.TradeReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportID val) 
            { 
                return IsSetTradeReportID();
            }
            
            public bool IsSetTradeReportID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeReportID);
            }
            
            public QuickFix.Fields.TradeReportTransType TradeReportTransType
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeReportTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportTransType val) 
            { 
                TradeReportTransType = val;
            }
            
            public QuickFix.Fields.TradeReportTransType Get(QuickFix.Fields.TradeReportTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportTransType val) 
            { 
                return IsSetTradeReportTransType();
            }
            
            public bool IsSetTradeReportTransType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeReportTransType);
            }
            
            public QuickFix.Fields.TradeReportType TradeReportType
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeReportType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportType val) 
            { 
                TradeReportType = val;
            }
            
            public QuickFix.Fields.TradeReportType Get(QuickFix.Fields.TradeReportType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportType val) 
            { 
                return IsSetTradeReportType();
            }
            
            public bool IsSetTradeReportType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeReportType);
            }
            
            public QuickFix.Fields.TrdType TrdType
            { 
                get 
                {
                    var val = new QuickFix.Fields.TrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TrdType val) 
            { 
                TrdType = val;
            }
            
            public QuickFix.Fields.TrdType Get(QuickFix.Fields.TrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TrdType val) 
            { 
                return IsSetTrdType();
            }
            
            public bool IsSetTrdType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TrdType);
            }
            
            public QuickFix.Fields.TrdSubType TrdSubType
            { 
                get 
                {
                    var val = new QuickFix.Fields.TrdSubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TrdSubType val) 
            { 
                TrdSubType = val;
            }
            
            public QuickFix.Fields.TrdSubType Get(QuickFix.Fields.TrdSubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TrdSubType val) 
            { 
                return IsSetTrdSubType();
            }
            
            public bool IsSetTrdSubType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TrdSubType);
            }
            
            public QuickFix.Fields.SecondaryTrdType SecondaryTrdType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecondaryTrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryTrdType val) 
            { 
                SecondaryTrdType = val;
            }
            
            public QuickFix.Fields.SecondaryTrdType Get(QuickFix.Fields.SecondaryTrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryTrdType val) 
            { 
                return IsSetSecondaryTrdType();
            }
            
            public bool IsSetSecondaryTrdType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecondaryTrdType);
            }
            
            public QuickFix.Fields.TransferReason TransferReason
            { 
                get 
                {
                    var val = new QuickFix.Fields.TransferReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransferReason val) 
            { 
                TransferReason = val;
            }
            
            public QuickFix.Fields.TransferReason Get(QuickFix.Fields.TransferReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransferReason val) 
            { 
                return IsSetTransferReason();
            }
            
            public bool IsSetTransferReason() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TransferReason);
            }
            
            public QuickFix.Fields.ExecType ExecType
            { 
                get 
                {
                    var val = new QuickFix.Fields.ExecType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecType val) 
            { 
                ExecType = val;
            }
            
            public QuickFix.Fields.ExecType Get(QuickFix.Fields.ExecType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecType val) 
            { 
                return IsSetExecType();
            }
            
            public bool IsSetExecType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ExecType);
            }
            
            public QuickFix.Fields.TradeReportRefID TradeReportRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeReportRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportRefID val) 
            { 
                TradeReportRefID = val;
            }
            
            public QuickFix.Fields.TradeReportRefID Get(QuickFix.Fields.TradeReportRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportRefID val) 
            { 
                return IsSetTradeReportRefID();
            }
            
            public bool IsSetTradeReportRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeReportRefID);
            }
            
            public QuickFix.Fields.SecondaryTradeReportRefID SecondaryTradeReportRefID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecondaryTradeReportRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryTradeReportRefID val) 
            { 
                SecondaryTradeReportRefID = val;
            }
            
            public QuickFix.Fields.SecondaryTradeReportRefID Get(QuickFix.Fields.SecondaryTradeReportRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryTradeReportRefID val) 
            { 
                return IsSetSecondaryTradeReportRefID();
            }
            
            public bool IsSetSecondaryTradeReportRefID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecondaryTradeReportRefID);
            }
            
            public QuickFix.Fields.TrdRptStatus TrdRptStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.TrdRptStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TrdRptStatus val) 
            { 
                TrdRptStatus = val;
            }
            
            public QuickFix.Fields.TrdRptStatus Get(QuickFix.Fields.TrdRptStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TrdRptStatus val) 
            { 
                return IsSetTrdRptStatus();
            }
            
            public bool IsSetTrdRptStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TrdRptStatus);
            }
            
            public QuickFix.Fields.TradeReportRejectReason TradeReportRejectReason
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeReportRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportRejectReason val) 
            { 
                TradeReportRejectReason = val;
            }
            
            public QuickFix.Fields.TradeReportRejectReason Get(QuickFix.Fields.TradeReportRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportRejectReason val) 
            { 
                return IsSetTradeReportRejectReason();
            }
            
            public bool IsSetTradeReportRejectReason() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeReportRejectReason);
            }
            
            public QuickFix.Fields.SecondaryTradeReportID SecondaryTradeReportID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecondaryTradeReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryTradeReportID val) 
            { 
                SecondaryTradeReportID = val;
            }
            
            public QuickFix.Fields.SecondaryTradeReportID Get(QuickFix.Fields.SecondaryTradeReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryTradeReportID val) 
            { 
                return IsSetSecondaryTradeReportID();
            }
            
            public bool IsSetSecondaryTradeReportID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecondaryTradeReportID);
            }
            
            public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                SubscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return IsSetSubscriptionRequestType();
            }
            
            public bool IsSetSubscriptionRequestType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SubscriptionRequestType);
            }
            
            public QuickFix.Fields.TradeLinkID TradeLinkID
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradeLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeLinkID val) 
            { 
                TradeLinkID = val;
            }
            
            public QuickFix.Fields.TradeLinkID Get(QuickFix.Fields.TradeLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeLinkID val) 
            { 
                return IsSetTradeLinkID();
            }
            
            public bool IsSetTradeLinkID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradeLinkID);
            }
            
            public QuickFix.Fields.TrdMatchID TrdMatchID
            { 
                get 
                {
                    var val = new QuickFix.Fields.TrdMatchID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TrdMatchID val) 
            { 
                TrdMatchID = val;
            }
            
            public QuickFix.Fields.TrdMatchID Get(QuickFix.Fields.TrdMatchID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TrdMatchID val) 
            { 
                return IsSetTrdMatchID();
            }
            
            public bool IsSetTrdMatchID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TrdMatchID);
            }
            
            public QuickFix.Fields.ExecID ExecID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecID val) 
            { 
                ExecID = val;
            }
            
            public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecID val) 
            { 
                return IsSetExecID();
            }
            
            public bool IsSetExecID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ExecID);
            }
            
            public QuickFix.Fields.SecondaryExecID SecondaryExecID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecondaryExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryExecID val) 
            { 
                SecondaryExecID = val;
            }
            
            public QuickFix.Fields.SecondaryExecID Get(QuickFix.Fields.SecondaryExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryExecID val) 
            { 
                return IsSetSecondaryExecID();
            }
            
            public bool IsSetSecondaryExecID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecondaryExecID);
            }
            
            public QuickFix.Fields.Symbol Symbol
            { 
                get 
                {
                    var val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                Symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Symbol);
            }
            
            public QuickFix.Fields.SymbolSfx SymbolSfx
            { 
                get 
                {
                    var val = new QuickFix.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SymbolSfx val) 
            { 
                SymbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SymbolSfx);
            }
            
            public QuickFix.Fields.SecurityID SecurityID
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            { 
                SecurityID = val;
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityID);
            }
            
            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                SecurityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityIDSource);
            }
            
            public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                NoSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoSecurityAltID);
            }
            
            public QuickFix.Fields.Product Product
            { 
                get 
                {
                    var val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Product val) 
            { 
                Product = val;
            }
            
            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Product);
            }
            
            public QuickFix.Fields.CFICode CFICode
            { 
                get 
                {
                    var val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CFICode val) 
            { 
                CFICode = val;
            }
            
            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CFICode);
            }
            
            public QuickFix.Fields.SecurityType SecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                SecurityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityType);
            }
            
            public QuickFix.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySubType val) 
            { 
                SecuritySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecuritySubType);
            }
            
            public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                MaturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaturityMonthYear);
            }
            
            public QuickFix.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                MaturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.MaturityDate);
            }
            
            public QuickFix.Fields.PutOrCall PutOrCall
            { 
                get 
                {
                    var val = new QuickFix.Fields.PutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PutOrCall val) 
            { 
                PutOrCall = val;
            }
            
            public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PutOrCall val) 
            { 
                return IsSetPutOrCall();
            }
            
            public bool IsSetPutOrCall() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PutOrCall);
            }
            
            public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                CouponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CouponPaymentDate);
            }
            
            public QuickFix.Fields.IssueDate IssueDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IssueDate val) 
            { 
                IssueDate = val;
            }
            
            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.IssueDate);
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                RepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepoCollateralSecurityType);
            }
            
            public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                RepurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepurchaseTerm);
            }
            
            public QuickFix.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseRate val) 
            { 
                RepurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RepurchaseRate);
            }
            
            public QuickFix.Fields.Factor Factor
            { 
                get 
                {
                    var val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Factor val) 
            { 
                Factor = val;
            }
            
            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Factor);
            }
            
            public QuickFix.Fields.CreditRating CreditRating
            { 
                get 
                {
                    var val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CreditRating val) 
            { 
                CreditRating = val;
            }
            
            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CreditRating);
            }
            
            public QuickFix.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    var val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrRegistry val) 
            { 
                InstrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(QuickFix.Fields.Tags.InstrRegistry);
            }
            
            public QuickFix.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CountryOfIssue val) 
            { 
                CountryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CountryOfIssue);
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StateOrProvinceOfIssue);
            }
            
            public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    var val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                LocaleOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(QuickFix.Fields.Tags.LocaleOfIssue);
            }
            
            public QuickFix.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RedemptionDate val) 
            { 
                RedemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RedemptionDate);
            }
            
            public QuickFix.Fields.StrikePrice StrikePrice
            { 
                get 
                {
                    var val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePrice val) 
            { 
                StrikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StrikePrice);
            }
            
            public QuickFix.Fields.StrikeCurrency StrikeCurrency
            { 
                get 
                {
                    var val = new QuickFix.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeCurrency val) 
            { 
                StrikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StrikeCurrency);
            }
            
            public QuickFix.Fields.OptAttribute OptAttribute
            { 
                get 
                {
                    var val = new QuickFix.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptAttribute val) 
            { 
                OptAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OptAttribute);
            }
            
            public QuickFix.Fields.ContractMultiplier ContractMultiplier
            { 
                get 
                {
                    var val = new QuickFix.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractMultiplier val) 
            { 
                ContractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ContractMultiplier);
            }
            
            public QuickFix.Fields.CouponRate CouponRate
            { 
                get 
                {
                    var val = new QuickFix.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponRate val) 
            { 
                CouponRate = val;
            }
            
            public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CouponRate);
            }
            
            public QuickFix.Fields.SecurityExchange SecurityExchange
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityExchange val) 
            { 
                SecurityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityExchange);
            }
            
            public QuickFix.Fields.Issuer Issuer
            { 
                get 
                {
                    var val = new QuickFix.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Issuer val) 
            { 
                Issuer = val;
            }
            
            public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Issuer);
            }
            
            public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                EncodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedIssuerLen);
            }
            
            public QuickFix.Fields.EncodedIssuer EncodedIssuer
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuer val) 
            { 
                EncodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedIssuer);
            }
            
            public QuickFix.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityDesc val) 
            { 
                SecurityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SecurityDesc);
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                EncodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedSecurityDescLen);
            }
            
            public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                EncodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedSecurityDesc);
            }
            
            public QuickFix.Fields.Pool Pool
            { 
                get 
                {
                    var val = new QuickFix.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Pool val) 
            { 
                Pool = val;
            }
            
            public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Pool);
            }
            
            public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
            { 
                get 
                {
                    var val = new QuickFix.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                ContractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ContractSettlMonth);
            }
            
            public QuickFix.Fields.CPProgram CPProgram
            { 
                get 
                {
                    var val = new QuickFix.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPProgram val) 
            { 
                CPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CPProgram);
            }
            
            public QuickFix.Fields.CPRegType CPRegType
            { 
                get 
                {
                    var val = new QuickFix.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPRegType val) 
            { 
                CPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CPRegType);
            }
            
            public QuickFix.Fields.NoEvents NoEvents
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoEvents val) 
            { 
                NoEvents = val;
            }
            
            public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoEvents);
            }
            
            public QuickFix.Fields.DatedDate DatedDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DatedDate val) 
            { 
                DatedDate = val;
            }
            
            public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.DatedDate);
            }
            
            public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
            { 
                get 
                {
                    var val = new QuickFix.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                InterestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(QuickFix.Fields.Tags.InterestAccrualDate);
            }
            
            public QuickFix.Fields.TransactTime TransactTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                TransactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TransactTime);
            }
            
            public QuickFix.Fields.NoTrdRegTimestamps NoTrdRegTimestamps
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoTrdRegTimestamps();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                NoTrdRegTimestamps = val;
            }
            
            public QuickFix.Fields.NoTrdRegTimestamps Get(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                return IsSetNoTrdRegTimestamps();
            }
            
            public bool IsSetNoTrdRegTimestamps() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoTrdRegTimestamps);
            }
            
            public QuickFix.Fields.ResponseTransportType ResponseTransportType
            { 
                get 
                {
                    var val = new QuickFix.Fields.ResponseTransportType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ResponseTransportType val) 
            { 
                ResponseTransportType = val;
            }
            
            public QuickFix.Fields.ResponseTransportType Get(QuickFix.Fields.ResponseTransportType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ResponseTransportType val) 
            { 
                return IsSetResponseTransportType();
            }
            
            public bool IsSetResponseTransportType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ResponseTransportType);
            }
            
            public QuickFix.Fields.ResponseDestination ResponseDestination
            { 
                get 
                {
                    var val = new QuickFix.Fields.ResponseDestination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ResponseDestination val) 
            { 
                ResponseDestination = val;
            }
            
            public QuickFix.Fields.ResponseDestination Get(QuickFix.Fields.ResponseDestination val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ResponseDestination val) 
            { 
                return IsSetResponseDestination();
            }
            
            public bool IsSetResponseDestination() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ResponseDestination);
            }
            
            public QuickFix.Fields.Text Text
            { 
                get 
                {
                    var val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                Text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Text);
            }
            
            public QuickFix.Fields.EncodedTextLen EncodedTextLen
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedTextLen val) 
            { 
                EncodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedTextLen);
            }
            
            public QuickFix.Fields.EncodedText EncodedText
            { 
                get 
                {
                    var val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedText val) 
            { 
                EncodedText = val;
            }
            
            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(QuickFix.Fields.Tags.EncodedText);
            }
            
            public QuickFix.Fields.NoLegs NoLegs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoLegs val) 
            { 
                NoLegs = val;
            }
            
            public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoLegs);
            }
            
            public QuickFix.Fields.ClearingFeeIndicator ClearingFeeIndicator
            { 
                get 
                {
                    var val = new QuickFix.Fields.ClearingFeeIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                ClearingFeeIndicator = val;
            }
            
            public QuickFix.Fields.ClearingFeeIndicator Get(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                return IsSetClearingFeeIndicator();
            }
            
            public bool IsSetClearingFeeIndicator() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ClearingFeeIndicator);
            }
            
            public QuickFix.Fields.OrderCapacity OrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderCapacity val) 
            { 
                OrderCapacity = val;
            }
            
            public QuickFix.Fields.OrderCapacity Get(QuickFix.Fields.OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrderCapacity);
            }
            
            public QuickFix.Fields.OrderRestrictions OrderRestrictions
            { 
                get 
                {
                    var val = new QuickFix.Fields.OrderRestrictions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderRestrictions val) 
            { 
                OrderRestrictions = val;
            }
            
            public QuickFix.Fields.OrderRestrictions Get(QuickFix.Fields.OrderRestrictions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderRestrictions val) 
            { 
                return IsSetOrderRestrictions();
            }
            
            public bool IsSetOrderRestrictions() 
            { 
                return IsSetField(QuickFix.Fields.Tags.OrderRestrictions);
            }
            
            public QuickFix.Fields.CustOrderCapacity CustOrderCapacity
            { 
                get 
                {
                    var val = new QuickFix.Fields.CustOrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CustOrderCapacity val) 
            { 
                CustOrderCapacity = val;
            }
            
            public QuickFix.Fields.CustOrderCapacity Get(QuickFix.Fields.CustOrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CustOrderCapacity val) 
            { 
                return IsSetCustOrderCapacity();
            }
            
            public bool IsSetCustOrderCapacity() 
            { 
                return IsSetField(QuickFix.Fields.Tags.CustOrderCapacity);
            }
            
            public QuickFix.Fields.Account Account
            { 
                get 
                {
                    var val = new QuickFix.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Account val) 
            { 
                Account = val;
            }
            
            public QuickFix.Fields.Account Get(QuickFix.Fields.Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.Account);
            }
            
            public QuickFix.Fields.AcctIDSource AcctIDSource
            { 
                get 
                {
                    var val = new QuickFix.Fields.AcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AcctIDSource val) 
            { 
                AcctIDSource = val;
            }
            
            public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AcctIDSource val) 
            { 
                return IsSetAcctIDSource();
            }
            
            public bool IsSetAcctIDSource() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AcctIDSource);
            }
            
            public QuickFix.Fields.AccountType AccountType
            { 
                get 
                {
                    var val = new QuickFix.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccountType val) 
            { 
                AccountType = val;
            }
            
            public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.AccountType);
            }
            
            public QuickFix.Fields.PositionEffect PositionEffect
            { 
                get 
                {
                    var val = new QuickFix.Fields.PositionEffect();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionEffect val) 
            { 
                PositionEffect = val;
            }
            
            public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionEffect val) 
            { 
                return IsSetPositionEffect();
            }
            
            public bool IsSetPositionEffect() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PositionEffect);
            }
            
            public QuickFix.Fields.PreallocMethod PreallocMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.PreallocMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PreallocMethod val) 
            { 
                PreallocMethod = val;
            }
            
            public QuickFix.Fields.PreallocMethod Get(QuickFix.Fields.PreallocMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PreallocMethod val) 
            { 
                return IsSetPreallocMethod();
            }
            
            public bool IsSetPreallocMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.PreallocMethod);
            }
            
            public QuickFix.Fields.NoAllocs NoAllocs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoAllocs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoAllocs val) 
            { 
                NoAllocs = val;
            }
            
            public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoAllocs val) 
            { 
                return IsSetNoAllocs();
            }
            
            public bool IsSetNoAllocs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoAllocs);
            }
            
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.SecurityAltID, QuickFix.Fields.Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( QuickFix.Fields.Tags.NoSecurityAltID, QuickFix.Fields.Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltID val) 
                { 
                    SecurityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityAltID);
                }
                
                public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    SecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.SecurityAltIDSource);
                }
                
            
            }
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.EventType, QuickFix.Fields.Tags.EventDate, QuickFix.Fields.Tags.EventPx, QuickFix.Fields.Tags.EventText, 0};
            
                public NoEventsGroup() 
                  :base( QuickFix.Fields.Tags.NoEvents, QuickFix.Fields.Tags.EventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.EventType EventType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventType val) 
                { 
                    EventType = val;
                }
                
                public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventType);
                }
                
                public QuickFix.Fields.EventDate EventDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventDate val) 
                { 
                    EventDate = val;
                }
                
                public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventDate);
                }
                
                public QuickFix.Fields.EventPx EventPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventPx val) 
                { 
                    EventPx = val;
                }
                
                public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventPx);
                }
                
                public QuickFix.Fields.EventText EventText
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventText val) 
                { 
                    EventText = val;
                }
                
                public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EventText);
                }
                
            
            }
            public class NoTrdRegTimestampsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.TrdRegTimestamp, QuickFix.Fields.Tags.TrdRegTimestampType, QuickFix.Fields.Tags.TrdRegTimestampOrigin, 0};
            
                public NoTrdRegTimestampsGroup() 
                  :base( QuickFix.Fields.Tags.NoTrdRegTimestamps, QuickFix.Fields.Tags.TrdRegTimestamp, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTrdRegTimestampsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.TrdRegTimestamp TrdRegTimestamp
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TrdRegTimestamp();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    TrdRegTimestamp = val;
                }
                
                public QuickFix.Fields.TrdRegTimestamp Get(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    return IsSetTrdRegTimestamp();
                }
                
                public bool IsSetTrdRegTimestamp() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TrdRegTimestamp);
                }
                
                public QuickFix.Fields.TrdRegTimestampType TrdRegTimestampType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TrdRegTimestampType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    TrdRegTimestampType = val;
                }
                
                public QuickFix.Fields.TrdRegTimestampType Get(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    return IsSetTrdRegTimestampType();
                }
                
                public bool IsSetTrdRegTimestampType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TrdRegTimestampType);
                }
                
                public QuickFix.Fields.TrdRegTimestampOrigin TrdRegTimestampOrigin
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TrdRegTimestampOrigin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    TrdRegTimestampOrigin = val;
                }
                
                public QuickFix.Fields.TrdRegTimestampOrigin Get(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    return IsSetTrdRegTimestampOrigin();
                }
                
                public bool IsSetTrdRegTimestampOrigin() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TrdRegTimestampOrigin);
                }
                
            
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.LegSymbol, QuickFix.Fields.Tags.LegSymbolSfx, QuickFix.Fields.Tags.LegSecurityID, QuickFix.Fields.Tags.LegSecurityIDSource, QuickFix.Fields.Tags.NoLegSecurityAltID, QuickFix.Fields.Tags.LegProduct, QuickFix.Fields.Tags.LegCFICode, QuickFix.Fields.Tags.LegSecurityType, QuickFix.Fields.Tags.LegSecuritySubType, QuickFix.Fields.Tags.LegMaturityMonthYear, QuickFix.Fields.Tags.LegMaturityDate, QuickFix.Fields.Tags.LegCouponPaymentDate, QuickFix.Fields.Tags.LegIssueDate, QuickFix.Fields.Tags.LegRepoCollateralSecurityType, QuickFix.Fields.Tags.LegRepurchaseTerm, QuickFix.Fields.Tags.LegRepurchaseRate, QuickFix.Fields.Tags.LegFactor, QuickFix.Fields.Tags.LegCreditRating, QuickFix.Fields.Tags.LegInstrRegistry, QuickFix.Fields.Tags.LegCountryOfIssue, QuickFix.Fields.Tags.LegStateOrProvinceOfIssue, QuickFix.Fields.Tags.LegLocaleOfIssue, QuickFix.Fields.Tags.LegRedemptionDate, QuickFix.Fields.Tags.LegStrikePrice, QuickFix.Fields.Tags.LegStrikeCurrency, QuickFix.Fields.Tags.LegOptAttribute, QuickFix.Fields.Tags.LegContractMultiplier, QuickFix.Fields.Tags.LegCouponRate, QuickFix.Fields.Tags.LegSecurityExchange, QuickFix.Fields.Tags.LegIssuer, QuickFix.Fields.Tags.EncodedLegIssuerLen, QuickFix.Fields.Tags.EncodedLegIssuer, QuickFix.Fields.Tags.LegSecurityDesc, QuickFix.Fields.Tags.EncodedLegSecurityDescLen, QuickFix.Fields.Tags.EncodedLegSecurityDesc, QuickFix.Fields.Tags.LegRatioQty, QuickFix.Fields.Tags.LegSide, QuickFix.Fields.Tags.LegCurrency, QuickFix.Fields.Tags.LegPool, QuickFix.Fields.Tags.LegDatedDate, QuickFix.Fields.Tags.LegContractSettlMonth, QuickFix.Fields.Tags.LegInterestAccrualDate, QuickFix.Fields.Tags.LegQty, QuickFix.Fields.Tags.LegSwapType, QuickFix.Fields.Tags.NoLegStipulations, QuickFix.Fields.Tags.LegPositionEffect, QuickFix.Fields.Tags.LegCoveredOrUncovered, QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.LegRefID, QuickFix.Fields.Tags.LegPrice, QuickFix.Fields.Tags.LegSettlType, QuickFix.Fields.Tags.LegSettlDate, QuickFix.Fields.Tags.LegLastPx, 0};
            
                public NoLegsGroup() 
                  :base( QuickFix.Fields.Tags.NoLegs, QuickFix.Fields.Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbol val) 
                { 
                    LegSymbol = val;
                }
                
                public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSymbol);
                }
                
                public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    LegSymbolSfx = val;
                }
                
                public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    return IsSetLegSymbolSfx();
                }
                
                public bool IsSetLegSymbolSfx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSymbolSfx);
                }
                
                public QuickFix.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityID val) 
                { 
                    LegSecurityID = val;
                }
                
                public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityID);
                }
                
                public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    LegSecurityIDSource = val;
                }
                
                public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityIDSource);
                }
                
                public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    NoLegSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoLegSecurityAltID);
                }
                
                public QuickFix.Fields.LegProduct LegProduct
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegProduct val) 
                { 
                    LegProduct = val;
                }
                
                public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegProduct);
                }
                
                public QuickFix.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCFICode val) 
                { 
                    LegCFICode = val;
                }
                
                public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCFICode);
                }
                
                public QuickFix.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityType val) 
                { 
                    LegSecurityType = val;
                }
                
                public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityType);
                }
                
                public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    LegSecuritySubType = val;
                }
                
                public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecuritySubType);
                }
                
                public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    LegMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegMaturityMonthYear);
                }
                
                public QuickFix.Fields.LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityDate val) 
                { 
                    LegMaturityDate = val;
                }
                
                public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegMaturityDate);
                }
                
                public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    LegCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    return IsSetLegCouponPaymentDate();
                }
                
                public bool IsSetLegCouponPaymentDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCouponPaymentDate);
                }
                
                public QuickFix.Fields.LegIssueDate LegIssueDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssueDate val) 
                { 
                    LegIssueDate = val;
                }
                
                public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssueDate val) 
                { 
                    return IsSetLegIssueDate();
                }
                
                public bool IsSetLegIssueDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegIssueDate);
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    LegRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return IsSetLegRepoCollateralSecurityType();
                }
                
                public bool IsSetLegRepoCollateralSecurityType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRepoCollateralSecurityType);
                }
                
                public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    LegRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    return IsSetLegRepurchaseTerm();
                }
                
                public bool IsSetLegRepurchaseTerm() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRepurchaseTerm);
                }
                
                public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    LegRepurchaseRate = val;
                }
                
                public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    return IsSetLegRepurchaseRate();
                }
                
                public bool IsSetLegRepurchaseRate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRepurchaseRate);
                }
                
                public QuickFix.Fields.LegFactor LegFactor
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegFactor val) 
                { 
                    LegFactor = val;
                }
                
                public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegFactor val) 
                { 
                    return IsSetLegFactor();
                }
                
                public bool IsSetLegFactor() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegFactor);
                }
                
                public QuickFix.Fields.LegCreditRating LegCreditRating
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCreditRating val) 
                { 
                    LegCreditRating = val;
                }
                
                public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCreditRating val) 
                { 
                    return IsSetLegCreditRating();
                }
                
                public bool IsSetLegCreditRating() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCreditRating);
                }
                
                public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    LegInstrRegistry = val;
                }
                
                public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    return IsSetLegInstrRegistry();
                }
                
                public bool IsSetLegInstrRegistry() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegInstrRegistry);
                }
                
                public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    LegCountryOfIssue = val;
                }
                
                public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    return IsSetLegCountryOfIssue();
                }
                
                public bool IsSetLegCountryOfIssue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCountryOfIssue);
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    LegStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return IsSetLegStateOrProvinceOfIssue();
                }
                
                public bool IsSetLegStateOrProvinceOfIssue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegStateOrProvinceOfIssue);
                }
                
                public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    LegLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    return IsSetLegLocaleOfIssue();
                }
                
                public bool IsSetLegLocaleOfIssue() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegLocaleOfIssue);
                }
                
                public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    LegRedemptionDate = val;
                }
                
                public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    return IsSetLegRedemptionDate();
                }
                
                public bool IsSetLegRedemptionDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRedemptionDate);
                }
                
                public QuickFix.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikePrice val) 
                { 
                    LegStrikePrice = val;
                }
                
                public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegStrikePrice);
                }
                
                public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    LegStrikeCurrency = val;
                }
                
                public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    return IsSetLegStrikeCurrency();
                }
                
                public bool IsSetLegStrikeCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegStrikeCurrency);
                }
                
                public QuickFix.Fields.LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOptAttribute val) 
                { 
                    LegOptAttribute = val;
                }
                
                public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegOptAttribute);
                }
                
                public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    LegContractMultiplier = val;
                }
                
                public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    return IsSetLegContractMultiplier();
                }
                
                public bool IsSetLegContractMultiplier() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegContractMultiplier);
                }
                
                public QuickFix.Fields.LegCouponRate LegCouponRate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponRate val) 
                { 
                    LegCouponRate = val;
                }
                
                public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponRate val) 
                { 
                    return IsSetLegCouponRate();
                }
                
                public bool IsSetLegCouponRate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCouponRate);
                }
                
                public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    LegSecurityExchange = val;
                }
                
                public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityExchange);
                }
                
                public QuickFix.Fields.LegIssuer LegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssuer val) 
                { 
                    LegIssuer = val;
                }
                
                public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssuer val) 
                { 
                    return IsSetLegIssuer();
                }
                
                public bool IsSetLegIssuer() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegIssuer);
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    EncodedLegIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    return IsSetEncodedLegIssuerLen();
                }
                
                public bool IsSetEncodedLegIssuerLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegIssuerLen);
                }
                
                public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    EncodedLegIssuer = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    return IsSetEncodedLegIssuer();
                }
                
                public bool IsSetEncodedLegIssuer() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegIssuer);
                }
                
                public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    LegSecurityDesc = val;
                }
                
                public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSecurityDesc);
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    EncodedLegSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return IsSetEncodedLegSecurityDescLen();
                }
                
                public bool IsSetEncodedLegSecurityDescLen() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegSecurityDescLen);
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    EncodedLegSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    return IsSetEncodedLegSecurityDesc();
                }
                
                public bool IsSetEncodedLegSecurityDesc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.EncodedLegSecurityDesc);
                }
                
                public QuickFix.Fields.LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioQty val) 
                { 
                    LegRatioQty = val;
                }
                
                public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRatioQty);
                }
                
                public QuickFix.Fields.LegSide LegSide
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSide val) 
                { 
                    LegSide = val;
                }
                
                public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSide);
                }
                
                public QuickFix.Fields.LegCurrency LegCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCurrency val) 
                { 
                    LegCurrency = val;
                }
                
                public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCurrency);
                }
                
                public QuickFix.Fields.LegPool LegPool
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPool val) 
                { 
                    LegPool = val;
                }
                
                public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPool val) 
                { 
                    return IsSetLegPool();
                }
                
                public bool IsSetLegPool() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegPool);
                }
                
                public QuickFix.Fields.LegDatedDate LegDatedDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegDatedDate val) 
                { 
                    LegDatedDate = val;
                }
                
                public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegDatedDate val) 
                { 
                    return IsSetLegDatedDate();
                }
                
                public bool IsSetLegDatedDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegDatedDate);
                }
                
                public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    LegContractSettlMonth = val;
                }
                
                public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    return IsSetLegContractSettlMonth();
                }
                
                public bool IsSetLegContractSettlMonth() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegContractSettlMonth);
                }
                
                public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    LegInterestAccrualDate = val;
                }
                
                public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    return IsSetLegInterestAccrualDate();
                }
                
                public bool IsSetLegInterestAccrualDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegInterestAccrualDate);
                }
                
                public QuickFix.Fields.LegQty LegQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegQty val) 
                { 
                    LegQty = val;
                }
                
                public QuickFix.Fields.LegQty Get(QuickFix.Fields.LegQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegQty val) 
                { 
                    return IsSetLegQty();
                }
                
                public bool IsSetLegQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegQty);
                }
                
                public QuickFix.Fields.LegSwapType LegSwapType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSwapType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSwapType val) 
                { 
                    LegSwapType = val;
                }
                
                public QuickFix.Fields.LegSwapType Get(QuickFix.Fields.LegSwapType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSwapType val) 
                { 
                    return IsSetLegSwapType();
                }
                
                public bool IsSetLegSwapType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSwapType);
                }
                
                public QuickFix.Fields.NoLegStipulations NoLegStipulations
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoLegStipulations();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegStipulations val) 
                { 
                    NoLegStipulations = val;
                }
                
                public QuickFix.Fields.NoLegStipulations Get(QuickFix.Fields.NoLegStipulations val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegStipulations val) 
                { 
                    return IsSetNoLegStipulations();
                }
                
                public bool IsSetNoLegStipulations() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoLegStipulations);
                }
                
                public QuickFix.Fields.LegPositionEffect LegPositionEffect
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegPositionEffect();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPositionEffect val) 
                { 
                    LegPositionEffect = val;
                }
                
                public QuickFix.Fields.LegPositionEffect Get(QuickFix.Fields.LegPositionEffect val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPositionEffect val) 
                { 
                    return IsSetLegPositionEffect();
                }
                
                public bool IsSetLegPositionEffect() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegPositionEffect);
                }
                
                public QuickFix.Fields.LegCoveredOrUncovered LegCoveredOrUncovered
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegCoveredOrUncovered();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    LegCoveredOrUncovered = val;
                }
                
                public QuickFix.Fields.LegCoveredOrUncovered Get(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    return IsSetLegCoveredOrUncovered();
                }
                
                public bool IsSetLegCoveredOrUncovered() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegCoveredOrUncovered);
                }
                
                public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    NoNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoNestedPartyIDs);
                }
                
                public QuickFix.Fields.LegRefID LegRefID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRefID val) 
                { 
                    LegRefID = val;
                }
                
                public QuickFix.Fields.LegRefID Get(QuickFix.Fields.LegRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRefID val) 
                { 
                    return IsSetLegRefID();
                }
                
                public bool IsSetLegRefID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegRefID);
                }
                
                public QuickFix.Fields.LegPrice LegPrice
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPrice val) 
                { 
                    LegPrice = val;
                }
                
                public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPrice val) 
                { 
                    return IsSetLegPrice();
                }
                
                public bool IsSetLegPrice() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegPrice);
                }
                
                public QuickFix.Fields.LegSettlType LegSettlType
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSettlType val) 
                { 
                    LegSettlType = val;
                }
                
                public QuickFix.Fields.LegSettlType Get(QuickFix.Fields.LegSettlType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSettlType val) 
                { 
                    return IsSetLegSettlType();
                }
                
                public bool IsSetLegSettlType() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSettlType);
                }
                
                public QuickFix.Fields.LegSettlDate LegSettlDate
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegSettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSettlDate val) 
                { 
                    LegSettlDate = val;
                }
                
                public QuickFix.Fields.LegSettlDate Get(QuickFix.Fields.LegSettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSettlDate val) 
                { 
                    return IsSetLegSettlDate();
                }
                
                public bool IsSetLegSettlDate() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegSettlDate);
                }
                
                public QuickFix.Fields.LegLastPx LegLastPx
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.LegLastPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLastPx val) 
                { 
                    LegLastPx = val;
                }
                
                public QuickFix.Fields.LegLastPx Get(QuickFix.Fields.LegLastPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLastPx val) 
                { 
                    return IsSetLegLastPx();
                }
                
                public bool IsSetLegLastPx() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.LegLastPx);
                }
                
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.LegSecurityAltID, QuickFix.Fields.Tags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( QuickFix.Fields.Tags.NoLegSecurityAltID, QuickFix.Fields.Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        LegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityAltID);
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        LegSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegSecurityAltIDSource);
                    }
                    
                
                }
                public class NoLegStipulationsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.LegStipulationType, QuickFix.Fields.Tags.LegStipulationValue, 0};
                
                    public NoLegStipulationsGroup() 
                      :base( QuickFix.Fields.Tags.NoLegStipulations, QuickFix.Fields.Tags.LegStipulationType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegStipulationsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegStipulationType LegStipulationType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegStipulationType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStipulationType val) 
                    { 
                        LegStipulationType = val;
                    }
                    
                    public QuickFix.Fields.LegStipulationType Get(QuickFix.Fields.LegStipulationType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStipulationType val) 
                    { 
                        return IsSetLegStipulationType();
                    }
                    
                    public bool IsSetLegStipulationType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegStipulationType);
                    }
                    
                    public QuickFix.Fields.LegStipulationValue LegStipulationValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.LegStipulationValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        LegStipulationValue = val;
                    }
                    
                    public QuickFix.Fields.LegStipulationValue Get(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        return IsSetLegStipulationValue();
                    }
                    
                    public bool IsSetLegStipulationValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.LegStipulationValue);
                    }
                    
                
                }
                public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartyID, QuickFix.Fields.Tags.NestedPartyIDSource, QuickFix.Fields.Tags.NestedPartyRole, QuickFix.Fields.Tags.NoNestedPartySubIDs, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoNestedPartyIDs, QuickFix.Fields.Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        NestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyID);
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyIDSource);
                    }
                    
                    public QuickFix.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        NestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NestedPartyRole);
                    }
                    
                    public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoNestedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        NoNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        return IsSetNoNestedPartySubIDs();
                    }
                    
                    public bool IsSetNoNestedPartySubIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoNestedPartySubIDs);
                    }
                    
                                    public class NoNestedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.NestedPartySubID, QuickFix.Fields.Tags.NestedPartySubIDType, 0};
                    
                        public NoNestedPartySubIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoNestedPartySubIDs, QuickFix.Fields.Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.NestedPartySubID NestedPartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NestedPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            NestedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            return IsSetNestedPartySubID();
                        }
                        
                        public bool IsSetNestedPartySubID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NestedPartySubID);
                        }
                        
                        public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.NestedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            NestedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            return IsSetNestedPartySubIDType();
                        }
                        
                        public bool IsSetNestedPartySubIDType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.NestedPartySubIDType);
                        }
                        
                    
                    }
                }
            }
            public class NoAllocsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.AllocAccount, QuickFix.Fields.Tags.AllocAcctIDSource, QuickFix.Fields.Tags.AllocSettlCurrency, QuickFix.Fields.Tags.IndividualAllocID, QuickFix.Fields.Tags.NoNested2PartyIDs, QuickFix.Fields.Tags.AllocQty, 0};
            
                public NoAllocsGroup() 
                  :base( QuickFix.Fields.Tags.NoAllocs, QuickFix.Fields.Tags.AllocAccount, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoAllocsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.AllocAccount AllocAccount
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocAccount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocAccount val) 
                { 
                    AllocAccount = val;
                }
                
                public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocAccount val) 
                { 
                    return IsSetAllocAccount();
                }
                
                public bool IsSetAllocAccount() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocAccount);
                }
                
                public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocAcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocAcctIDSource val) 
                { 
                    AllocAcctIDSource = val;
                }
                
                public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) 
                { 
                    return IsSetAllocAcctIDSource();
                }
                
                public bool IsSetAllocAcctIDSource() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocAcctIDSource);
                }
                
                public QuickFix.Fields.AllocSettlCurrency AllocSettlCurrency
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocSettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocSettlCurrency val) 
                { 
                    AllocSettlCurrency = val;
                }
                
                public QuickFix.Fields.AllocSettlCurrency Get(QuickFix.Fields.AllocSettlCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocSettlCurrency val) 
                { 
                    return IsSetAllocSettlCurrency();
                }
                
                public bool IsSetAllocSettlCurrency() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocSettlCurrency);
                }
                
                public QuickFix.Fields.IndividualAllocID IndividualAllocID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.IndividualAllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IndividualAllocID val) 
                { 
                    IndividualAllocID = val;
                }
                
                public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IndividualAllocID val) 
                { 
                    return IsSetIndividualAllocID();
                }
                
                public bool IsSetIndividualAllocID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.IndividualAllocID);
                }
                
                public QuickFix.Fields.NoNested2PartyIDs NoNested2PartyIDs
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoNested2PartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    NoNested2PartyIDs = val;
                }
                
                public QuickFix.Fields.NoNested2PartyIDs Get(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNested2PartyIDs val) 
                { 
                    return IsSetNoNested2PartyIDs();
                }
                
                public bool IsSetNoNested2PartyIDs() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoNested2PartyIDs);
                }
                
                public QuickFix.Fields.AllocQty AllocQty
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.AllocQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocQty val) 
                { 
                    AllocQty = val;
                }
                
                public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocQty val) 
                { 
                    return IsSetAllocQty();
                }
                
                public bool IsSetAllocQty() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.AllocQty);
                }
                
                            public class NoNested2PartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.Nested2PartyID, QuickFix.Fields.Tags.Nested2PartyIDSource, QuickFix.Fields.Tags.Nested2PartyRole, QuickFix.Fields.Tags.NoNested2PartySubIDs, 0};
                
                    public NoNested2PartyIDsGroup() 
                      :base( QuickFix.Fields.Tags.NoNested2PartyIDs, QuickFix.Fields.Tags.Nested2PartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNested2PartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.Nested2PartyID Nested2PartyID
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.Nested2PartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        Nested2PartyID = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyID Get(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested2PartyID val) 
                    { 
                        return IsSetNested2PartyID();
                    }
                    
                    public bool IsSetNested2PartyID() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.Nested2PartyID);
                    }
                    
                    public QuickFix.Fields.Nested2PartyIDSource Nested2PartyIDSource
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.Nested2PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        Nested2PartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyIDSource Get(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested2PartyIDSource val) 
                    { 
                        return IsSetNested2PartyIDSource();
                    }
                    
                    public bool IsSetNested2PartyIDSource() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.Nested2PartyIDSource);
                    }
                    
                    public QuickFix.Fields.Nested2PartyRole Nested2PartyRole
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.Nested2PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        Nested2PartyRole = val;
                    }
                    
                    public QuickFix.Fields.Nested2PartyRole Get(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested2PartyRole val) 
                    { 
                        return IsSetNested2PartyRole();
                    }
                    
                    public bool IsSetNested2PartyRole() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.Nested2PartyRole);
                    }
                    
                    public QuickFix.Fields.NoNested2PartySubIDs NoNested2PartySubIDs
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.NoNested2PartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        NoNested2PartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested2PartySubIDs Get(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNested2PartySubIDs val) 
                    { 
                        return IsSetNoNested2PartySubIDs();
                    }
                    
                    public bool IsSetNoNested2PartySubIDs() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.NoNested2PartySubIDs);
                    }
                    
                                    public class NoNested2PartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {QuickFix.Fields.Tags.Nested2PartySubID, QuickFix.Fields.Tags.Nested2PartySubIDType, 0};
                    
                        public NoNested2PartySubIDsGroup() 
                          :base( QuickFix.Fields.Tags.NoNested2PartySubIDs, QuickFix.Fields.Tags.Nested2PartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNested2PartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.Nested2PartySubID Nested2PartySubID
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.Nested2PartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            Nested2PartySubID = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartySubID Get(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartySubID val) 
                        { 
                            return IsSetNested2PartySubID();
                        }
                        
                        public bool IsSetNested2PartySubID() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.Nested2PartySubID);
                        }
                        
                        public QuickFix.Fields.Nested2PartySubIDType Nested2PartySubIDType
                        { 
                            get 
                            {
                                var val = new QuickFix.Fields.Nested2PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            Nested2PartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartySubIDType Get(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartySubIDType val) 
                        { 
                            return IsSetNested2PartySubIDType();
                        }
                        
                        public bool IsSetNested2PartySubIDType() 
                        { 
                            return IsSetField(QuickFix.Fields.Tags.Nested2PartySubIDType);
                        }
                        
                    
                    }
                }
            }
    }
}
