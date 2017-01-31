// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class TradingSessionList : Message
    {
            public const string MsgType = "BJ";

            public TradingSessionList() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BJ"));
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
            
            public QuickFix.Fields.NoTradingSessions NoTradingSessions
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoTradingSessions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTradingSessions val) 
            { 
                NoTradingSessions = val;
            }
            
            public QuickFix.Fields.NoTradingSessions Get(QuickFix.Fields.NoTradingSessions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTradingSessions val) 
            { 
                return IsSetNoTradingSessions();
            }
            
            public bool IsSetNoTradingSessions() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoTradingSessions);
            }
            
            public QuickFix.Fields.ApplID ApplID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                ApplID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplID);
            }
            
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                ApplSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplSeqNum);
            }
            
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                ApplLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplLastSeqNum);
            }
            
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                ApplResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplResendFlag);
            }
            
            public class NoTradingSessionsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.TradingSessionID, QuickFix.Fields.Tags.TradingSessionSubID, QuickFix.Fields.Tags.SecurityExchange, QuickFix.Fields.Tags.TradSesMethod, QuickFix.Fields.Tags.TradSesMode, QuickFix.Fields.Tags.UnsolicitedIndicator, QuickFix.Fields.Tags.TradSesStatus, QuickFix.Fields.Tags.TradSesStatusRejReason, QuickFix.Fields.Tags.TradSesStartTime, QuickFix.Fields.Tags.TradSesOpenTime, QuickFix.Fields.Tags.TradSesPreCloseTime, QuickFix.Fields.Tags.TradSesCloseTime, QuickFix.Fields.Tags.TradSesEndTime, QuickFix.Fields.Tags.TotalVolumeTraded, QuickFix.Fields.Tags.Text, QuickFix.Fields.Tags.EncodedTextLen, QuickFix.Fields.Tags.EncodedText, QuickFix.Fields.Tags.MarketID, QuickFix.Fields.Tags.MarketSegmentID, QuickFix.Fields.Tags.TradingSessionDesc, QuickFix.Fields.Tags.NoOrdTypeRules, QuickFix.Fields.Tags.NoTimeInForceRules, QuickFix.Fields.Tags.NoExecInstRules, QuickFix.Fields.Tags.NoMatchRules, QuickFix.Fields.Tags.NoMDFeedTypes, QuickFix.Fields.Tags.TransactTime, QuickFix.Fields.Tags.TradSesUpdateAction, 0};
            
                public NoTradingSessionsGroup() 
                  :base( QuickFix.Fields.Tags.NoTradingSessions, QuickFix.Fields.Tags.TradingSessionID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTradingSessionsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradingSessionSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    TradingSessionSubID = val;
                }
                
                public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    return IsSetTradingSessionSubID();
                }
                
                public bool IsSetTradingSessionSubID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradingSessionSubID);
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
                
                public QuickFix.Fields.TradSesStatusRejReason TradSesStatusRejReason
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradSesStatusRejReason();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    TradSesStatusRejReason = val;
                }
                
                public QuickFix.Fields.TradSesStatusRejReason Get(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesStatusRejReason val) 
                { 
                    return IsSetTradSesStatusRejReason();
                }
                
                public bool IsSetTradSesStatusRejReason() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradSesStatusRejReason);
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
                
                public QuickFix.Fields.MarketID MarketID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MarketID val) 
                { 
                    MarketID = val;
                }
                
                public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MarketID val) 
                { 
                    return IsSetMarketID();
                }
                
                public bool IsSetMarketID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MarketID);
                }
                
                public QuickFix.Fields.MarketSegmentID MarketSegmentID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.MarketSegmentID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MarketSegmentID val) 
                { 
                    MarketSegmentID = val;
                }
                
                public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MarketSegmentID val) 
                { 
                    return IsSetMarketSegmentID();
                }
                
                public bool IsSetMarketSegmentID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.MarketSegmentID);
                }
                
                public QuickFix.Fields.TradingSessionDesc TradingSessionDesc
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradingSessionDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    TradingSessionDesc = val;
                }
                
                public QuickFix.Fields.TradingSessionDesc Get(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionDesc val) 
                { 
                    return IsSetTradingSessionDesc();
                }
                
                public bool IsSetTradingSessionDesc() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradingSessionDesc);
                }
                
                public QuickFix.Fields.NoOrdTypeRules NoOrdTypeRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoOrdTypeRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    NoOrdTypeRules = val;
                }
                
                public QuickFix.Fields.NoOrdTypeRules Get(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoOrdTypeRules val) 
                { 
                    return IsSetNoOrdTypeRules();
                }
                
                public bool IsSetNoOrdTypeRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoOrdTypeRules);
                }
                
                public QuickFix.Fields.NoTimeInForceRules NoTimeInForceRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoTimeInForceRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    NoTimeInForceRules = val;
                }
                
                public QuickFix.Fields.NoTimeInForceRules Get(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTimeInForceRules val) 
                { 
                    return IsSetNoTimeInForceRules();
                }
                
                public bool IsSetNoTimeInForceRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoTimeInForceRules);
                }
                
                public QuickFix.Fields.NoExecInstRules NoExecInstRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoExecInstRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoExecInstRules val) 
                { 
                    NoExecInstRules = val;
                }
                
                public QuickFix.Fields.NoExecInstRules Get(QuickFix.Fields.NoExecInstRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoExecInstRules val) 
                { 
                    return IsSetNoExecInstRules();
                }
                
                public bool IsSetNoExecInstRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoExecInstRules);
                }
                
                public QuickFix.Fields.NoMatchRules NoMatchRules
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoMatchRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoMatchRules val) 
                { 
                    NoMatchRules = val;
                }
                
                public QuickFix.Fields.NoMatchRules Get(QuickFix.Fields.NoMatchRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoMatchRules val) 
                { 
                    return IsSetNoMatchRules();
                }
                
                public bool IsSetNoMatchRules() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoMatchRules);
                }
                
                public QuickFix.Fields.NoMDFeedTypes NoMDFeedTypes
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.NoMDFeedTypes();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    NoMDFeedTypes = val;
                }
                
                public QuickFix.Fields.NoMDFeedTypes Get(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoMDFeedTypes val) 
                { 
                    return IsSetNoMDFeedTypes();
                }
                
                public bool IsSetNoMDFeedTypes() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.NoMDFeedTypes);
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
                
                public QuickFix.Fields.TradSesUpdateAction TradSesUpdateAction
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.TradSesUpdateAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradSesUpdateAction val) 
                { 
                    TradSesUpdateAction = val;
                }
                
                public QuickFix.Fields.TradSesUpdateAction Get(QuickFix.Fields.TradSesUpdateAction val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradSesUpdateAction val) 
                { 
                    return IsSetTradSesUpdateAction();
                }
                
                public bool IsSetTradSesUpdateAction() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.TradSesUpdateAction);
                }
                
                            public class NoOrdTypeRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.OrdType, 0};
                
                    public NoOrdTypeRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoOrdTypeRules, QuickFix.Fields.Tags.OrdType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoOrdTypeRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.OrdType OrdType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.OrdType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OrdType val) 
                    { 
                        OrdType = val;
                    }
                    
                    public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OrdType val) 
                    { 
                        return IsSetOrdType();
                    }
                    
                    public bool IsSetOrdType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.OrdType);
                    }
                    
                
                }
                public class NoTimeInForceRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.TimeInForce, 0};
                
                    public NoTimeInForceRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoTimeInForceRules, QuickFix.Fields.Tags.TimeInForce, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTimeInForceRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.TimeInForce TimeInForce
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.TimeInForce();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TimeInForce val) 
                    { 
                        TimeInForce = val;
                    }
                    
                    public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TimeInForce val) 
                    { 
                        return IsSetTimeInForce();
                    }
                    
                    public bool IsSetTimeInForce() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.TimeInForce);
                    }
                    
                
                }
                public class NoExecInstRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.ExecInstValue, 0};
                
                    public NoExecInstRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoExecInstRules, QuickFix.Fields.Tags.ExecInstValue, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoExecInstRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.ExecInstValue ExecInstValue
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.ExecInstValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ExecInstValue val) 
                    { 
                        ExecInstValue = val;
                    }
                    
                    public QuickFix.Fields.ExecInstValue Get(QuickFix.Fields.ExecInstValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ExecInstValue val) 
                    { 
                        return IsSetExecInstValue();
                    }
                    
                    public bool IsSetExecInstValue() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.ExecInstValue);
                    }
                    
                
                }
                public class NoMatchRulesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.MatchAlgorithm, QuickFix.Fields.Tags.MatchType, 0};
                
                    public NoMatchRulesGroup() 
                      :base( QuickFix.Fields.Tags.NoMatchRules, QuickFix.Fields.Tags.MatchAlgorithm, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoMatchRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.MatchAlgorithm MatchAlgorithm
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MatchAlgorithm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        MatchAlgorithm = val;
                    }
                    
                    public QuickFix.Fields.MatchAlgorithm Get(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MatchAlgorithm val) 
                    { 
                        return IsSetMatchAlgorithm();
                    }
                    
                    public bool IsSetMatchAlgorithm() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MatchAlgorithm);
                    }
                    
                    public QuickFix.Fields.MatchType MatchType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MatchType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MatchType val) 
                    { 
                        MatchType = val;
                    }
                    
                    public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MatchType val) 
                    { 
                        return IsSetMatchType();
                    }
                    
                    public bool IsSetMatchType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MatchType);
                    }
                    
                
                }
                public class NoMDFeedTypesGroup : Group
                {
                    public static int[] fieldOrder = {QuickFix.Fields.Tags.MDFeedType, QuickFix.Fields.Tags.MarketDepth, QuickFix.Fields.Tags.MDBookType, 0};
                
                    public NoMDFeedTypesGroup() 
                      :base( QuickFix.Fields.Tags.NoMDFeedTypes, QuickFix.Fields.Tags.MDFeedType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoMDFeedTypesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.MDFeedType MDFeedType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MDFeedType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MDFeedType val) 
                    { 
                        MDFeedType = val;
                    }
                    
                    public QuickFix.Fields.MDFeedType Get(QuickFix.Fields.MDFeedType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MDFeedType val) 
                    { 
                        return IsSetMDFeedType();
                    }
                    
                    public bool IsSetMDFeedType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MDFeedType);
                    }
                    
                    public QuickFix.Fields.MarketDepth MarketDepth
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MarketDepth();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MarketDepth val) 
                    { 
                        MarketDepth = val;
                    }
                    
                    public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MarketDepth val) 
                    { 
                        return IsSetMarketDepth();
                    }
                    
                    public bool IsSetMarketDepth() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MarketDepth);
                    }
                    
                    public QuickFix.Fields.MDBookType MDBookType
                    { 
                        get 
                        {
                            var val = new QuickFix.Fields.MDBookType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MDBookType val) 
                    { 
                        MDBookType = val;
                    }
                    
                    public QuickFix.Fields.MDBookType Get(QuickFix.Fields.MDBookType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MDBookType val) 
                    { 
                        return IsSetMDBookType();
                    }
                    
                    public bool IsSetMDBookType() 
                    { 
                        return IsSetField(QuickFix.Fields.Tags.MDBookType);
                    }
                    
                
                }
            }
    }
}
