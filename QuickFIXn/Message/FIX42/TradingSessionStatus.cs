// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class TradingSessionStatus : Message
    {
            public const string MsgType = "h";

            public TradingSessionStatus() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("h"));
            }

            public TradingSessionStatus(
                    QuickFix.Fields.TradingSessionID aTradingSessionID,
                    QuickFix.Fields.TradSesStatus aTradSesStatus
                ) : this()
            {
                this.TradingSessionID = aTradingSessionID;
                this.TradSesStatus = aTradSesStatus;
            }

            public QuickFix.Fields.TradSesReqID TradSesReqID
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesReqID val) 
            { 
                TradSesReqID = val;
            }
            
            public QuickFix.Fields.TradSesReqID Get(QuickFix.Fields.TradSesReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesReqID val) 
            { 
                return IsSetTradSesReqID();
            }
            
            public bool IsSetTradSesReqID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesReqID);
            }
            
            public QuickFix.Fields.TradingSessionID TradingSessionID
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingSessionID val) 
            { 
                TradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return IsSetTradingSessionID();
            }
            
            public bool IsSetTradingSessionID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradingSessionID);
            }
            
            public QuickFix.Fields.TradSesMethod TradSesMethod
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesMethod val) 
            { 
                TradSesMethod = val;
            }
            
            public QuickFix.Fields.TradSesMethod Get(QuickFix.Fields.TradSesMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesMethod val) 
            { 
                return IsSetTradSesMethod();
            }
            
            public bool IsSetTradSesMethod() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesMethod);
            }
            
            public QuickFix.Fields.TradSesMode TradSesMode
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesMode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesMode val) 
            { 
                TradSesMode = val;
            }
            
            public QuickFix.Fields.TradSesMode Get(QuickFix.Fields.TradSesMode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesMode val) 
            { 
                return IsSetTradSesMode();
            }
            
            public bool IsSetTradSesMode() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesMode);
            }
            
            public QuickFix.Fields.UnsolicitedIndicator UnsolicitedIndicator
            { 
                get 
                {
                    var val = new QuickFix.Fields.UnsolicitedIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                UnsolicitedIndicator = val;
            }
            
            public QuickFix.Fields.UnsolicitedIndicator Get(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                return IsSetUnsolicitedIndicator();
            }
            
            public bool IsSetUnsolicitedIndicator() 
            { 
                return IsSetField(QuickFix.Fields.Tags.UnsolicitedIndicator);
            }
            
            public QuickFix.Fields.TradSesStatus TradSesStatus
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesStatus val) 
            { 
                TradSesStatus = val;
            }
            
            public QuickFix.Fields.TradSesStatus Get(QuickFix.Fields.TradSesStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesStatus val) 
            { 
                return IsSetTradSesStatus();
            }
            
            public bool IsSetTradSesStatus() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesStatus);
            }
            
            public QuickFix.Fields.TradSesStartTime TradSesStartTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesStartTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesStartTime val) 
            { 
                TradSesStartTime = val;
            }
            
            public QuickFix.Fields.TradSesStartTime Get(QuickFix.Fields.TradSesStartTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesStartTime val) 
            { 
                return IsSetTradSesStartTime();
            }
            
            public bool IsSetTradSesStartTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesStartTime);
            }
            
            public QuickFix.Fields.TradSesOpenTime TradSesOpenTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesOpenTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesOpenTime val) 
            { 
                TradSesOpenTime = val;
            }
            
            public QuickFix.Fields.TradSesOpenTime Get(QuickFix.Fields.TradSesOpenTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesOpenTime val) 
            { 
                return IsSetTradSesOpenTime();
            }
            
            public bool IsSetTradSesOpenTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesOpenTime);
            }
            
            public QuickFix.Fields.TradSesPreCloseTime TradSesPreCloseTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesPreCloseTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesPreCloseTime val) 
            { 
                TradSesPreCloseTime = val;
            }
            
            public QuickFix.Fields.TradSesPreCloseTime Get(QuickFix.Fields.TradSesPreCloseTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesPreCloseTime val) 
            { 
                return IsSetTradSesPreCloseTime();
            }
            
            public bool IsSetTradSesPreCloseTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesPreCloseTime);
            }
            
            public QuickFix.Fields.TradSesCloseTime TradSesCloseTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesCloseTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesCloseTime val) 
            { 
                TradSesCloseTime = val;
            }
            
            public QuickFix.Fields.TradSesCloseTime Get(QuickFix.Fields.TradSesCloseTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesCloseTime val) 
            { 
                return IsSetTradSesCloseTime();
            }
            
            public bool IsSetTradSesCloseTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesCloseTime);
            }
            
            public QuickFix.Fields.TradSesEndTime TradSesEndTime
            { 
                get 
                {
                    var val = new QuickFix.Fields.TradSesEndTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradSesEndTime val) 
            { 
                TradSesEndTime = val;
            }
            
            public QuickFix.Fields.TradSesEndTime Get(QuickFix.Fields.TradSesEndTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradSesEndTime val) 
            { 
                return IsSetTradSesEndTime();
            }
            
            public bool IsSetTradSesEndTime() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TradSesEndTime);
            }
            
            public QuickFix.Fields.TotalVolumeTraded TotalVolumeTraded
            { 
                get 
                {
                    var val = new QuickFix.Fields.TotalVolumeTraded();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                TotalVolumeTraded = val;
            }
            
            public QuickFix.Fields.TotalVolumeTraded Get(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                return IsSetTotalVolumeTraded();
            }
            
            public bool IsSetTotalVolumeTraded() 
            { 
                return IsSetField(QuickFix.Fields.Tags.TotalVolumeTraded);
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
            

    }
}
