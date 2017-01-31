// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ApplicationMessageRequestAck : Message
    {
            public const string MsgType = "BX";

            public ApplicationMessageRequestAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BX"));
            }

            public ApplicationMessageRequestAck(
                    QuickFix.Fields.ApplResponseID aApplResponseID
                ) : this()
            {
                this.ApplResponseID = aApplResponseID;
            }

            public QuickFix.Fields.ApplResponseID ApplResponseID
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResponseID val) 
            { 
                ApplResponseID = val;
            }
            
            public QuickFix.Fields.ApplResponseID Get(QuickFix.Fields.ApplResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResponseID val) 
            { 
                return IsSetApplResponseID();
            }
            
            public bool IsSetApplResponseID() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplResponseID);
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
            
            public QuickFix.Fields.ApplReqType ApplReqType
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplReqType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplReqType val) 
            { 
                ApplReqType = val;
            }
            
            public QuickFix.Fields.ApplReqType Get(QuickFix.Fields.ApplReqType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplReqType val) 
            { 
                return IsSetApplReqType();
            }
            
            public bool IsSetApplReqType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplReqType);
            }
            
            public QuickFix.Fields.ApplResponseType ApplResponseType
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplResponseType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResponseType val) 
            { 
                ApplResponseType = val;
            }
            
            public QuickFix.Fields.ApplResponseType Get(QuickFix.Fields.ApplResponseType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResponseType val) 
            { 
                return IsSetApplResponseType();
            }
            
            public bool IsSetApplResponseType() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplResponseType);
            }
            
            public QuickFix.Fields.ApplTotalMessageCount ApplTotalMessageCount
            { 
                get 
                {
                    var val = new QuickFix.Fields.ApplTotalMessageCount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplTotalMessageCount val) 
            { 
                ApplTotalMessageCount = val;
            }
            
            public QuickFix.Fields.ApplTotalMessageCount Get(QuickFix.Fields.ApplTotalMessageCount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplTotalMessageCount val) 
            { 
                return IsSetApplTotalMessageCount();
            }
            
            public bool IsSetApplTotalMessageCount() 
            { 
                return IsSetField(QuickFix.Fields.Tags.ApplTotalMessageCount);
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
            
            public class NoApplIDsGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.Fields.Tags.RefApplID, QuickFix.Fields.Tags.ApplBegSeqNum, QuickFix.Fields.Tags.ApplEndSeqNum, QuickFix.Fields.Tags.RefApplLastSeqNum, QuickFix.Fields.Tags.ApplResponseError, 0};
            
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
                
                public QuickFix.Fields.ApplBegSeqNum ApplBegSeqNum
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ApplBegSeqNum();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    ApplBegSeqNum = val;
                }
                
                public QuickFix.Fields.ApplBegSeqNum Get(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    return IsSetApplBegSeqNum();
                }
                
                public bool IsSetApplBegSeqNum() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ApplBegSeqNum);
                }
                
                public QuickFix.Fields.ApplEndSeqNum ApplEndSeqNum
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ApplEndSeqNum();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    ApplEndSeqNum = val;
                }
                
                public QuickFix.Fields.ApplEndSeqNum Get(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    return IsSetApplEndSeqNum();
                }
                
                public bool IsSetApplEndSeqNum() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ApplEndSeqNum);
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
                
                public QuickFix.Fields.ApplResponseError ApplResponseError
                { 
                    get 
                    {
                        var val = new QuickFix.Fields.ApplResponseError();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ApplResponseError val) 
                { 
                    ApplResponseError = val;
                }
                
                public QuickFix.Fields.ApplResponseError Get(QuickFix.Fields.ApplResponseError val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ApplResponseError val) 
                { 
                    return IsSetApplResponseError();
                }
                
                public bool IsSetApplResponseError() 
                { 
                    return IsSetField(QuickFix.Fields.Tags.ApplResponseError);
                }
                
            
            }
    }
}
