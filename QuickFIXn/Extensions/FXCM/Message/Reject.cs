// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class Reject : Message
    {
            public const string MsgType = "3";

            public Reject() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("3"));
            }

            public Reject(
                    QuickFix.FXCM.Fields.RefSeqNum aRefSeqNum
                ) : this()
            {
                this.RefSeqNum = aRefSeqNum;
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
            
            public QuickFix.FXCM.Fields.RefTagID RefTagID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RefTagID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RefTagID val) 
            { 
                RefTagID = val;
            }
            
            public QuickFix.FXCM.Fields.RefTagID Get(QuickFix.FXCM.Fields.RefTagID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RefTagID val) 
            { 
                return IsSetRefTagID();
            }
            
            public bool IsSetRefTagID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RefTagID);
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
            
            public QuickFix.FXCM.Fields.SessionRejectReason SessionRejectReason
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.SessionRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.SessionRejectReason val) 
            { 
                SessionRejectReason = val;
            }
            
            public QuickFix.FXCM.Fields.SessionRejectReason Get(QuickFix.FXCM.Fields.SessionRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.SessionRejectReason val) 
            { 
                return IsSetSessionRejectReason();
            }
            
            public bool IsSetSessionRejectReason() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.SessionRejectReason);
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
            

    }
}
