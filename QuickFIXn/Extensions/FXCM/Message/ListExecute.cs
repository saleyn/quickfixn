// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class ListExecute : Message
    {
            public const string MsgType = "L";

            public ListExecute() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("L"));
            }

            public ListExecute(
                    QuickFix.FXCM.Fields.ListID aListID,
                    QuickFix.FXCM.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.ListID = aListID;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.FXCM.Fields.ListID ListID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ListID val) 
            { 
                ListID = val;
            }
            
            public QuickFix.FXCM.Fields.ListID Get(QuickFix.FXCM.Fields.ListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ListID val) 
            { 
                return IsSetListID();
            }
            
            public bool IsSetListID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ListID);
            }
            
            public QuickFix.FXCM.Fields.ClientBidID ClientBidID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ClientBidID val) 
            { 
                ClientBidID = val;
            }
            
            public QuickFix.FXCM.Fields.ClientBidID Get(QuickFix.FXCM.Fields.ClientBidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ClientBidID val) 
            { 
                return IsSetClientBidID();
            }
            
            public bool IsSetClientBidID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ClientBidID);
            }
            
            public QuickFix.FXCM.Fields.BidID BidID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BidID val) 
            { 
                BidID = val;
            }
            
            public QuickFix.FXCM.Fields.BidID Get(QuickFix.FXCM.Fields.BidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BidID val) 
            { 
                return IsSetBidID();
            }
            
            public bool IsSetBidID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BidID);
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
