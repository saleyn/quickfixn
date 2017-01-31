// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class ApplicationMessageReport : Message
    {
            public const string MsgType = "BY";

            public ApplicationMessageReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BY"));
            }

            public ApplicationMessageReport(
                    QuickFix.Fields.ApplReportID aApplReportID,
                    QuickFix.Fields.ApplReportType aApplReportType
                ) : this()
            {
                this.ApplReportID = aApplReportID;
                this.ApplReportType = aApplReportType;
            }

            public QuickFix.Fields.ApplReportID ApplReportID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplReportID val) 
            { 
                ApplReportID = val;
            }
            
            public QuickFix.Fields.ApplReportID Get(QuickFix.Fields.ApplReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplReportID val) 
            { 
                return IsSetApplReportID();
            }
            
            public bool IsSetApplReportID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplReportID);
            }
            
            public QuickFix.Fields.ApplReportType ApplReportType
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplReportType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplReportType val) 
            { 
                ApplReportType = val;
            }
            
            public QuickFix.Fields.ApplReportType Get(QuickFix.Fields.ApplReportType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplReportType val) 
            { 
                return IsSetApplReportType();
            }
            
            public bool IsSetApplReportType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplReportType);
            }
            
            public QuickFix.Fields.NoApplIDs NoApplIDs
            { 
                get 
                {
                    var val = new QuickFix.Fields.NoApplIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoApplIDs val) 
            { 
                NoApplIDs = val;
            }
            
            public QuickFix.Fields.NoApplIDs Get(QuickFix.Fields.NoApplIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoApplIDs val) 
            { 
                return IsSetNoApplIDs();
            }
            
            public bool IsSetNoApplIDs() 
            { 
                return IsSetField(QuickFix.Fields.Tags.NoApplIDs);
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
            
            public QuickFix.Fields.ApplReqID ApplReqID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplReqID val) 
            { 
                ApplReqID = val;
            }
            
            public QuickFix.Fields.ApplReqID Get(QuickFix.Fields.ApplReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplReqID val) 
            { 
                return IsSetApplReqID();
            }
            
            public bool IsSetApplReqID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplReqID);
            }
            
            public class NoApplIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RefApplID, QuickFix.Fields.Tags.ApplNewSeqNum, QuickFix.Fields.Tags.RefApplLastSeqNum, 0};
            
                public NoApplIDsGroup() 
                  :base( QuickFix.Fields.Tags.NoApplIDs, QuickFix.Fields.Tags.RefApplID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoApplIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RefApplID RefApplID
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RefApplID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefApplID val) 
                { 
                    RefApplID = val;
                }
                
                public QuickFix.Fields.RefApplID Get(QuickFix.Fields.RefApplID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefApplID val) 
                { 
                    return IsSetRefApplID();
                }
                
                public bool IsSetRefApplID() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RefApplID);
                }
                
                public QuickFix.Fields.ApplNewSeqNum ApplNewSeqNum
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ApplNewSeqNum();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ApplNewSeqNum val) 
                { 
                    ApplNewSeqNum = val;
                }
                
                public QuickFix.Fields.ApplNewSeqNum Get(QuickFix.Fields.ApplNewSeqNum val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ApplNewSeqNum val) 
                { 
                    return IsSetApplNewSeqNum();
                }
                
                public bool IsSetApplNewSeqNum() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ApplNewSeqNum);
                }
                
                public QuickFix.Fields.RefApplLastSeqNum RefApplLastSeqNum
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.RefApplLastSeqNum();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefApplLastSeqNum val) 
                { 
                    RefApplLastSeqNum = val;
                }
                
                public QuickFix.Fields.RefApplLastSeqNum Get(QuickFix.Fields.RefApplLastSeqNum val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefApplLastSeqNum val) 
                { 
                    return IsSetRefApplLastSeqNum();
                }
                
                public bool IsSetRefApplLastSeqNum() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.RefApplLastSeqNum);
                }
                
            
            }
    }
}
