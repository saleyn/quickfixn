// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class FXCMNewsRequest : Message
    {
            public const string MsgType = "U50";

            public FXCMNewsRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("U50"));
            }

            public FXCMNewsRequest(
                    QuickFix.FXCM.Fields.TestReqID aTestReqID,
                    QuickFix.FXCM.Fields.SubscriptionRequestType aSubscriptionRequestType,
                    QuickFix.FXCM.Fields.TradingSessionID aTradingSessionID,
                    QuickFix.FXCM.Fields.TradingSessionSubID aTradingSessionSubID
                ) : this()
            {
                this.TestReqID = aTestReqID;
                this.SubscriptionRequestType = aSubscriptionRequestType;
                this.TradingSessionID = aTradingSessionID;
                this.TradingSessionSubID = aTradingSessionSubID;
            }

            public QuickFix.FXCM.Fields.TestReqID TestReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TestReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TestReqID val) 
            { 
                TestReqID = val;
            }
            
            public QuickFix.FXCM.Fields.TestReqID Get(QuickFix.FXCM.Fields.TestReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TestReqID val) 
            { 
                return IsSetTestReqID();
            }
            
            public bool IsSetTestReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TestReqID);
            }
            
            public QuickFix.FXCM.Fields.SubscriptionRequestType SubscriptionRequestType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SubscriptionRequestType val) 
            { 
                SubscriptionRequestType = val;
            }
            
            public QuickFix.FXCM.Fields.SubscriptionRequestType Get(QuickFix.FXCM.Fields.SubscriptionRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SubscriptionRequestType val) 
            { 
                return IsSetSubscriptionRequestType();
            }
            
            public bool IsSetSubscriptionRequestType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SubscriptionRequestType);
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
            
            public QuickFix.FXCM.Fields.FXCMPageIDNo FXCMPageIDNo
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.FXCMPageIDNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.FXCMPageIDNo val) 
            { 
                FXCMPageIDNo = val;
            }
            
            public QuickFix.FXCM.Fields.FXCMPageIDNo Get(QuickFix.FXCM.Fields.FXCMPageIDNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.FXCMPageIDNo val) 
            { 
                return IsSetFXCMPageIDNo();
            }
            
            public bool IsSetFXCMPageIDNo() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMPageIDNo);
            }
            
            public class FXCMPageIDNoGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.FXCMPageID, QuickFix.FXCM.Fields.Tags.FXCMPageviewID, QuickFix.FXCM.Fields.Tags.FXCMPageviewLifetime, QuickFix.FXCM.Fields.Tags.TransactTime, QuickFix.FXCM.Fields.Tags.FXCMNoSnapshot, 0};
            
                public FXCMPageIDNoGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.FXCMPageIDNo, QuickFix.FXCM.Fields.Tags.FXCMPageID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new FXCMPageIDNoGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.FXCM.Fields.FXCMPageID FXCMPageID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FXCMPageID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FXCMPageID val) 
                { 
                    FXCMPageID = val;
                }
                
                public QuickFix.FXCM.Fields.FXCMPageID Get(QuickFix.FXCM.Fields.FXCMPageID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FXCMPageID val) 
                { 
                    return IsSetFXCMPageID();
                }
                
                public bool IsSetFXCMPageID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMPageID);
                }
                
                public QuickFix.FXCM.Fields.FXCMPageviewID FXCMPageviewID
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FXCMPageviewID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FXCMPageviewID val) 
                { 
                    FXCMPageviewID = val;
                }
                
                public QuickFix.FXCM.Fields.FXCMPageviewID Get(QuickFix.FXCM.Fields.FXCMPageviewID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FXCMPageviewID val) 
                { 
                    return IsSetFXCMPageviewID();
                }
                
                public bool IsSetFXCMPageviewID() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMPageviewID);
                }
                
                public QuickFix.FXCM.Fields.FXCMPageviewLifetime FXCMPageviewLifetime
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FXCMPageviewLifetime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FXCMPageviewLifetime val) 
                { 
                    FXCMPageviewLifetime = val;
                }
                
                public QuickFix.FXCM.Fields.FXCMPageviewLifetime Get(QuickFix.FXCM.Fields.FXCMPageviewLifetime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FXCMPageviewLifetime val) 
                { 
                    return IsSetFXCMPageviewLifetime();
                }
                
                public bool IsSetFXCMPageviewLifetime() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMPageviewLifetime);
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
                
                public QuickFix.FXCM.Fields.FXCMNoSnapshot FXCMNoSnapshot
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.FXCMNoSnapshot();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.FXCMNoSnapshot val) 
                { 
                    FXCMNoSnapshot = val;
                }
                
                public QuickFix.FXCM.Fields.FXCMNoSnapshot Get(QuickFix.FXCM.Fields.FXCMNoSnapshot val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.FXCMNoSnapshot val) 
                { 
                    return IsSetFXCMNoSnapshot();
                }
                
                public bool IsSetFXCMNoSnapshot() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.FXCMNoSnapshot);
                }
                
            
            }
    }
}
