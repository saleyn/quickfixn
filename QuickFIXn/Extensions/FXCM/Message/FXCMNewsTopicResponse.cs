// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class FXCMNewsTopicResponse : Message
    {
            public const string MsgType = "U53";

            public FXCMNewsTopicResponse() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("U53"));
            }

            public FXCMNewsTopicResponse(
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
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.FXCMPageID, QuickFix.FXCM.Fields.Tags.Headline, 0};
            
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
                
                public QuickFix.FXCM.Fields.Headline Headline
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.Headline();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.Headline val) 
                { 
                    Headline = val;
                }
                
                public QuickFix.FXCM.Fields.Headline Get(QuickFix.FXCM.Fields.Headline val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.Headline val) 
                { 
                    return IsSetHeadline();
                }
                
                public bool IsSetHeadline() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.Headline);
                }
                
            
            }
    }
}
