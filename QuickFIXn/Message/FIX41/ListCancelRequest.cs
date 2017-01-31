// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class ListCancelRequest : Message
    {
            public const string MsgType = "K";

            public ListCancelRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("K"));
            }

            public ListCancelRequest(
                    QuickFix.Fields.ListID aListID
                ) : this()
            {
                this.ListID = aListID;
            }

            public QuickFix.Fields.ListID ListID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListID val) 
            { 
                ListID = val;
            }
            
            public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListID val) 
            { 
                return IsSetListID();
            }
            
            public bool IsSetListID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ListID);
            }
            
            public QuickFix.Fields.WaveNo WaveNo
            { 
                get 
                {
                    var val = new QuickFix.Fields.WaveNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.WaveNo val) 
            { 
                WaveNo = val;
            }
            
            public QuickFix.Fields.WaveNo Get(QuickFix.Fields.WaveNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.WaveNo val) 
            { 
                return IsSetWaveNo();
            }
            
            public bool IsSetWaveNo() 
            { 
                return IsSetField(QuickFix.Fields.Tags.WaveNo);
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
            

    }
}
