// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class BusinessMessageReject : Message
    {
            public const string MsgType = "j";

            public BusinessMessageReject() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("j"));
            }

            public BusinessMessageReject(
                    QuickFix.FXCM.Fields.RefMsgType aRefMsgType,
                    QuickFix.FXCM.Fields.BusinessRejectReason aBusinessRejectReason
                ) : this()
            {
                this.RefMsgType = aRefMsgType;
                this.BusinessRejectReason = aBusinessRejectReason;
            }

            public QuickFix.FXCM.Fields.RefSeqNum RefSeqNum
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RefSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RefSeqNum val) 
            { 
                RefSeqNum = val;
            }
            
            public QuickFix.FXCM.Fields.RefSeqNum Get(QuickFix.FXCM.Fields.RefSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RefSeqNum val) 
            { 
                return IsSetRefSeqNum();
            }
            
            public bool IsSetRefSeqNum() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RefSeqNum);
            }
            
            public QuickFix.FXCM.Fields.RefMsgType RefMsgType
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RefMsgType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RefMsgType val) 
            { 
                RefMsgType = val;
            }
            
            public QuickFix.FXCM.Fields.RefMsgType Get(QuickFix.FXCM.Fields.RefMsgType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RefMsgType val) 
            { 
                return IsSetRefMsgType();
            }
            
            public bool IsSetRefMsgType() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RefMsgType);
            }
            
            public QuickFix.FXCM.Fields.BusinessRejectRefID BusinessRejectRefID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BusinessRejectRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BusinessRejectRefID val) 
            { 
                BusinessRejectRefID = val;
            }
            
            public QuickFix.FXCM.Fields.BusinessRejectRefID Get(QuickFix.FXCM.Fields.BusinessRejectRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BusinessRejectRefID val) 
            { 
                return IsSetBusinessRejectRefID();
            }
            
            public bool IsSetBusinessRejectRefID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BusinessRejectRefID);
            }
            
            public QuickFix.FXCM.Fields.BusinessRejectReason BusinessRejectReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BusinessRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BusinessRejectReason val) 
            { 
                BusinessRejectReason = val;
            }
            
            public QuickFix.FXCM.Fields.BusinessRejectReason Get(QuickFix.FXCM.Fields.BusinessRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BusinessRejectReason val) 
            { 
                return IsSetBusinessRejectReason();
            }
            
            public bool IsSetBusinessRejectReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BusinessRejectReason);
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
