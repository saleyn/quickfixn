// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class FXCMNewsTopicRequest : Message
    {
            public const string MsgType = "U51";

            public FXCMNewsTopicRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("U51"));
            }

            public FXCMNewsTopicRequest(
                    QuickFix.FXCM.Fields.TestReqID aTestReqID,
                    QuickFix.FXCM.Fields.TradingSessionID aTradingSessionID,
                    QuickFix.FXCM.Fields.TradingSessionSubID aTradingSessionSubID
                ) : this()
            {
                this.TestReqID = aTestReqID;
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
            

    }
}
