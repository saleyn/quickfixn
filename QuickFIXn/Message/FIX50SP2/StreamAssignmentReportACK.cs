// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class StreamAssignmentReportACK : Message
    {
            public const string MsgType = "CE";

            public StreamAssignmentReportACK() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CE"));
            }

            public StreamAssignmentReportACK(
                    QuickFix.Fields.StreamAsgnAckType aStreamAsgnAckType,
                    QuickFix.Fields.StreamAsgnRptID aStreamAsgnRptID
                ) : this()
            {
                this.StreamAsgnAckType = aStreamAsgnAckType;
                this.StreamAsgnRptID = aStreamAsgnRptID;
            }

            public QuickFix.Fields.StreamAsgnAckType StreamAsgnAckType
            { 
                get 
                {
                    var val = new QuickFix.Fields.StreamAsgnAckType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StreamAsgnAckType val) 
            { 
                StreamAsgnAckType = val;
            }
            
            public QuickFix.Fields.StreamAsgnAckType Get(QuickFix.Fields.StreamAsgnAckType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StreamAsgnAckType val) 
            { 
                return IsSetStreamAsgnAckType();
            }
            
            public bool IsSetStreamAsgnAckType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StreamAsgnAckType);
            }
            
            public QuickFix.Fields.StreamAsgnRptID StreamAsgnRptID
            { 
                get 
                {
                    var val = new QuickFix.Fields.StreamAsgnRptID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StreamAsgnRptID val) 
            { 
                StreamAsgnRptID = val;
            }
            
            public QuickFix.Fields.StreamAsgnRptID Get(QuickFix.Fields.StreamAsgnRptID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StreamAsgnRptID val) 
            { 
                return IsSetStreamAsgnRptID();
            }
            
            public bool IsSetStreamAsgnRptID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StreamAsgnRptID);
            }
            
            public QuickFix.Fields.StreamAsgnRejReason StreamAsgnRejReason
            { 
                get 
                {
                    var val = new QuickFix.Fields.StreamAsgnRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StreamAsgnRejReason val) 
            { 
                StreamAsgnRejReason = val;
            }
            
            public QuickFix.Fields.StreamAsgnRejReason Get(QuickFix.Fields.StreamAsgnRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StreamAsgnRejReason val) 
            { 
                return IsSetStreamAsgnRejReason();
            }
            
            public bool IsSetStreamAsgnRejReason() 
            { 
                return IsSetField(QuickFix.Fields.Tags.StreamAsgnRejReason);
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
