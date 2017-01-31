// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class Reject : Message
    {
            public const string MsgType = "3";

            public Reject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("3"));
            }

            public Reject(
                    QuickFix.Fields.RefSeqNum aRefSeqNum
                ) : this()
            {
                this.RefSeqNum = aRefSeqNum;
            }

            public QuickFix.Fields.RefSeqNum RefSeqNum
            { 
                get 
                {
                    var val = new QuickFix.Fields.RefSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefSeqNum val) 
            { 
                RefSeqNum = val;
            }
            
            public QuickFix.Fields.RefSeqNum Get(QuickFix.Fields.RefSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefSeqNum val) 
            { 
                return IsSetRefSeqNum();
            }
            
            public bool IsSetRefSeqNum() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RefSeqNum);
            }
            
            public QuickFix.Fields.RefTagID RefTagID
            { 
                get 
                {
                    var val = new QuickFix.Fields.RefTagID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefTagID val) 
            { 
                RefTagID = val;
            }
            
            public QuickFix.Fields.RefTagID Get(QuickFix.Fields.RefTagID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefTagID val) 
            { 
                return IsSetRefTagID();
            }
            
            public bool IsSetRefTagID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RefTagID);
            }
            
            public QuickFix.Fields.RefMsgType RefMsgType
            { 
                get 
                {
                    var val = new QuickFix.Fields.RefMsgType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefMsgType val) 
            { 
                RefMsgType = val;
            }
            
            public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefMsgType val) 
            { 
                return IsSetRefMsgType();
            }
            
            public bool IsSetRefMsgType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.RefMsgType);
            }
            
            public QuickFix.Fields.SessionRejectReason SessionRejectReason
            { 
                get 
                {
                    var val = new QuickFix.Fields.SessionRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SessionRejectReason val) 
            { 
                SessionRejectReason = val;
            }
            
            public QuickFix.Fields.SessionRejectReason Get(QuickFix.Fields.SessionRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SessionRejectReason val) 
            { 
                return IsSetSessionRejectReason();
            }
            
            public bool IsSetSessionRejectReason() 
            { 
                return IsSetField(QuickFix.Fields.Tags.SessionRejectReason);
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
