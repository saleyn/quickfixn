// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class SequenceReset : Message
    {
            public const string MsgType = "4";

            public SequenceReset() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("4"));
            }

            public SequenceReset(
                    QuickFix.FXCM.Fields.NewSeqNo aNewSeqNo
                ) : this()
            {
                this.NewSeqNo = aNewSeqNo;
            }

            public QuickFix.FXCM.Fields.GapFillFlag GapFillFlag
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.GapFillFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.GapFillFlag val) 
            { 
                GapFillFlag = val;
            }
            
            public QuickFix.FXCM.Fields.GapFillFlag Get(QuickFix.FXCM.Fields.GapFillFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.GapFillFlag val) 
            { 
                return IsSetGapFillFlag();
            }
            
            public bool IsSetGapFillFlag() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.GapFillFlag);
            }
            
            public QuickFix.FXCM.Fields.NewSeqNo NewSeqNo
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NewSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NewSeqNo val) 
            { 
                NewSeqNo = val;
            }
            
            public QuickFix.FXCM.Fields.NewSeqNo Get(QuickFix.FXCM.Fields.NewSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NewSeqNo val) 
            { 
                return IsSetNewSeqNo();
            }
            
            public bool IsSetNewSeqNo() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NewSeqNo);
            }
            

    }
}
