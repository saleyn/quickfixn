// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class FXCMRequestReject : Message
    {
            public const string MsgType = "U52";

            public FXCMRequestReject() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("U52"));
            }

            public FXCMRequestReject(
                    QuickFix.FXCM.Fields.TestReqID aTestReqID,
                    QuickFix.FXCM.Fields.FXCMRequestRejectReason aFXCMRequestRejectReason
                ) : this()
            {
                this.TestReqID = aTestReqID;
                this.FXCMRequestRejectReason = aFXCMRequestRejectReason;
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
