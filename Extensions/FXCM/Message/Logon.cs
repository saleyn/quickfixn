// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix.FXCM
{
    public class Logon : Message
    {
            public const string MsgType = "A";

            public Logon() : base()
            {
                this.Header.SetField(new QuickFix.FXCM.Fields.MsgType("A"));
            }

            public Logon(
                    QuickFix.FXCM.Fields.EncryptMethod aEncryptMethod,
                    QuickFix.FXCM.Fields.HeartBtInt aHeartBtInt
                ) : this()
            {
                this.EncryptMethod = aEncryptMethod;
                this.HeartBtInt = aHeartBtInt;
            }

            public QuickFix.FXCM.Fields.EncryptMethod EncryptMethod
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.EncryptMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.EncryptMethod val) 
            { 
                EncryptMethod = val;
            }
            
            public QuickFix.FXCM.Fields.EncryptMethod Get(QuickFix.FXCM.Fields.EncryptMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.EncryptMethod val) 
            { 
                return IsSetEncryptMethod();
            }
            
            public bool IsSetEncryptMethod() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.EncryptMethod);
            }
            
            public QuickFix.FXCM.Fields.HeartBtInt HeartBtInt
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.HeartBtInt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.HeartBtInt val) 
            { 
                HeartBtInt = val;
            }
            
            public QuickFix.FXCM.Fields.HeartBtInt Get(QuickFix.FXCM.Fields.HeartBtInt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.HeartBtInt val) 
            { 
                return IsSetHeartBtInt();
            }
            
            public bool IsSetHeartBtInt() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.HeartBtInt);
            }
            
            public QuickFix.FXCM.Fields.RawDataLength RawDataLength
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RawDataLength();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RawDataLength val) 
            { 
                RawDataLength = val;
            }
            
            public QuickFix.FXCM.Fields.RawDataLength Get(QuickFix.FXCM.Fields.RawDataLength val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RawDataLength val) 
            { 
                return IsSetRawDataLength();
            }
            
            public bool IsSetRawDataLength() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RawDataLength);
            }
            
            public QuickFix.FXCM.Fields.RawData RawData
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.RawData val) 
            { 
                RawData = val;
            }
            
            public QuickFix.FXCM.Fields.RawData Get(QuickFix.FXCM.Fields.RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.RawData);
            }
            
            public QuickFix.FXCM.Fields.ResetSeqNumFlag ResetSeqNumFlag
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.ResetSeqNumFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.ResetSeqNumFlag val) 
            { 
                ResetSeqNumFlag = val;
            }
            
            public QuickFix.FXCM.Fields.ResetSeqNumFlag Get(QuickFix.FXCM.Fields.ResetSeqNumFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.ResetSeqNumFlag val) 
            { 
                return IsSetResetSeqNumFlag();
            }
            
            public bool IsSetResetSeqNumFlag() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.ResetSeqNumFlag);
            }
            
            public QuickFix.FXCM.Fields.NextExpectedMsgSeqNum NextExpectedMsgSeqNum
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NextExpectedMsgSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NextExpectedMsgSeqNum val) 
            { 
                NextExpectedMsgSeqNum = val;
            }
            
            public QuickFix.FXCM.Fields.NextExpectedMsgSeqNum Get(QuickFix.FXCM.Fields.NextExpectedMsgSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NextExpectedMsgSeqNum val) 
            { 
                return IsSetNextExpectedMsgSeqNum();
            }
            
            public bool IsSetNextExpectedMsgSeqNum() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NextExpectedMsgSeqNum);
            }
            
            public QuickFix.FXCM.Fields.MaxMessageSize MaxMessageSize
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.MaxMessageSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.MaxMessageSize val) 
            { 
                MaxMessageSize = val;
            }
            
            public QuickFix.FXCM.Fields.MaxMessageSize Get(QuickFix.FXCM.Fields.MaxMessageSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.MaxMessageSize val) 
            { 
                return IsSetMaxMessageSize();
            }
            
            public bool IsSetMaxMessageSize() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.MaxMessageSize);
            }
            
            public QuickFix.FXCM.Fields.NoMsgTypes NoMsgTypes
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.NoMsgTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.NoMsgTypes val) 
            { 
                NoMsgTypes = val;
            }
            
            public QuickFix.FXCM.Fields.NoMsgTypes Get(QuickFix.FXCM.Fields.NoMsgTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.NoMsgTypes val) 
            { 
                return IsSetNoMsgTypes();
            }
            
            public bool IsSetNoMsgTypes() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.NoMsgTypes);
            }
            
            public QuickFix.FXCM.Fields.TestMessageIndicator TestMessageIndicator
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.TestMessageIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.TestMessageIndicator val) 
            { 
                TestMessageIndicator = val;
            }
            
            public QuickFix.FXCM.Fields.TestMessageIndicator Get(QuickFix.FXCM.Fields.TestMessageIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.TestMessageIndicator val) 
            { 
                return IsSetTestMessageIndicator();
            }
            
            public bool IsSetTestMessageIndicator() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.TestMessageIndicator);
            }
            
            public QuickFix.FXCM.Fields.Username Username
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Username();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Username val) 
            { 
                Username = val;
            }
            
            public QuickFix.FXCM.Fields.Username Get(QuickFix.FXCM.Fields.Username val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Username val) 
            { 
                return IsSetUsername();
            }
            
            public bool IsSetUsername() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Username);
            }
            
            public QuickFix.FXCM.Fields.Password Password
            { 
                get 
                {
                    var val = new QuickFix.FXCM.Fields.Password();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.FXCM.Fields.Password val) 
            { 
                Password = val;
            }
            
            public QuickFix.FXCM.Fields.Password Get(QuickFix.FXCM.Fields.Password val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.FXCM.Fields.Password val) 
            { 
                return IsSetPassword();
            }
            
            public bool IsSetPassword() 
            { 
                return IsSetField(QuickFix.FXCM.Fields.Tags.Password);
            }
            
            public class NoMsgTypesGroup : Group
            {
                public static int[] fieldOrder = {QuickFix.FXCM.Fields.Tags.RefMsgType, QuickFix.FXCM.Fields.Tags.MsgDirection, 0};
            
                public NoMsgTypesGroup() 
                  :base( QuickFix.FXCM.Fields.Tags.NoMsgTypes, QuickFix.FXCM.Fields.Tags.RefMsgType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMsgTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                
                public QuickFix.FXCM.Fields.MsgDirection MsgDirection
                { 
                    get 
                    {
                        var val = new QuickFix.FXCM.Fields.MsgDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.FXCM.Fields.MsgDirection val) 
                { 
                    MsgDirection = val;
                }
                
                public QuickFix.FXCM.Fields.MsgDirection Get(QuickFix.FXCM.Fields.MsgDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.FXCM.Fields.MsgDirection val) 
                { 
                    return IsSetMsgDirection();
                }
                
                public bool IsSetMsgDirection() 
                { 
                    return IsSetField(QuickFix.FXCM.Fields.Tags.MsgDirection);
                }
                
            
            }
    }
}
