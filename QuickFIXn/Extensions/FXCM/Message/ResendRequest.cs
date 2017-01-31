// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class ResendRequest : Message
    {
            public const string MsgType = "2";

            public ResendRequest() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("2"));
            }

            public ResendRequest(
                    QuickFix.FXCM.Fields.BeginSeqNo aBeginSeqNo,
                    QuickFix.FXCM.Fields.EndSeqNo aEndSeqNo
                ) : this()
            {
                this.BeginSeqNo = aBeginSeqNo;
                this.EndSeqNo = aEndSeqNo;
            }

            public QuickFix.FXCM.Fields.BeginSeqNo BeginSeqNo
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.BeginSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.BeginSeqNo val) 
            { 
                BeginSeqNo = val;
            }
            
            public QuickFix.FXCM.Fields.BeginSeqNo Get(QuickFix.FXCM.Fields.BeginSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.BeginSeqNo val) 
            { 
                return IsSetBeginSeqNo();
            }
            
            public bool IsSetBeginSeqNo() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.BeginSeqNo);
            }
            
            public QuickFix.FXCM.Fields.EndSeqNo EndSeqNo
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EndSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EndSeqNo val) 
            { 
                EndSeqNo = val;
            }
            
            public QuickFix.FXCM.Fields.EndSeqNo Get(QuickFix.FXCM.Fields.EndSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EndSeqNo val) 
            { 
                return IsSetEndSeqNo();
            }
            
            public bool IsSetEndSeqNo() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EndSeqNo);
            }
            

    }
}
