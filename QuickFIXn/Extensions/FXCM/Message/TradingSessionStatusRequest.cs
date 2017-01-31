// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class TradingSessionStatusRequest : Message
    {
            public const string MsgType = "g";

            public TradingSessionStatusRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("g"));
            }

            public TradingSessionStatusRequest(
                    QuickFix.FXCM.Fields.TradSesReqID aTradSesReqID,
                    QuickFix.FXCM.Fields.SubscriptionRequestType aSubscriptionRequestType
                ) : this()
            {
                this.TradSesReqID = aTradSesReqID;
                this.SubscriptionRequestType = aSubscriptionRequestType;
            }

            public QuickFix.FXCM.Fields.TradSesReqID TradSesReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradSesReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradSesReqID val) 
            { 
                TradSesReqID = val;
            }
            
            public QuickFix.FXCM.Fields.TradSesReqID Get(QuickFix.FXCM.Fields.TradSesReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradSesReqID val) 
            { 
                return IsSetTradSesReqID();
            }
            
            public bool IsSetTradSesReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradSesReqID);
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
            
            public QuickFix.FXCM.Fields.TradSesMethod TradSesMethod
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradSesMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradSesMethod val) 
            { 
                TradSesMethod = val;
            }
            
            public QuickFix.FXCM.Fields.TradSesMethod Get(QuickFix.FXCM.Fields.TradSesMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradSesMethod val) 
            { 
                return IsSetTradSesMethod();
            }
            
            public bool IsSetTradSesMethod() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradSesMethod);
            }
            
            public QuickFix.FXCM.Fields.TradSesMode TradSesMode
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TradSesMode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TradSesMode val) 
            { 
                TradSesMode = val;
            }
            
            public QuickFix.FXCM.Fields.TradSesMode Get(QuickFix.FXCM.Fields.TradSesMode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TradSesMode val) 
            { 
                return IsSetTradSesMode();
            }
            
            public bool IsSetTradSesMode() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TradSesMode);
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
            

    }
}
