// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class Heartbeat : Message
    {
            public const string MsgType = "0";

            public Heartbeat() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("0"));
            }


            public QuickFix.FXCM.Fields.TestReqID TestReqID
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TestReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TestReqID val) 
            { 
                TestReqID = val;
            }
            
            public QuickFix.FXCM.Fields.TestReqID Get(QuickFix.FXCM.Fields.TestReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TestReqID val) 
            { 
                return IsSetTestReqID();
            }
            
            public bool IsSetTestReqID() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TestReqID);
            }
            

    }
}
